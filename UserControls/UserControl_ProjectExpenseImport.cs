using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TimeLog.DataImporter.Handlers;
using TimeLog.DataImporter.TimeLogApi;
using TimeLog.DataImporter.TimeLogApi.Model;

namespace TimeLog.DataImporter.UserControls
{
    public partial class UserControl_ProjectExpenseImport : UserControl
    {
        #region Variable declarations

        private DataTable _projectExpenseTable;
        private DataTable _fileContent;
        private Button _senderButton;
        private int _errorRowCount;
        private bool _isMappingFieldValueToIDCorrect;
        private bool _isFirstTimeInvalidMapping;

        private static readonly Dictionary<int, string> MandatoryFields = new Dictionary<int, string>
        {
            {0, "Project No"},
            {1, "Purchase Date"},
            {2, "Payment Method"},
            {3, "Expense Type"},
            {4, "Amount inc. VAT"},
            {5, "Sales Price Amount"},
            {6, "Is Billable"},
            {7, "Expense No"},
            {8, "VAT Amount"},
            {9, "Expense Currency ISO"},
            {10, "Contract Name"},
            {11, "Exchange Rate"}
        };

        //all column header variables
        private const string ProjectNo = "Project No";   
        private const string PurchaseDate = "Purchase Date";  //let them choose default
        private const string PaymentMethod = "Payment Method";
        private const string ExpenseType = "Expense Type";
        private const string AmountIncludingVAT = "Amount inc. VAT";
        private const string SalesPriceAmount = "Sales Price Amount";
        private const string IsBillable = "Is Billable";
        private const string ExpenseNo = "Expense No";
        private const string VATAmount = "VAT Amount";  
        private const string ExpenseCurrencyISO = "Expense Currency ISO";
        private const string ContractName = "Contract Name";
        private const string ExchangeRate = "Exchange Rate";
        private const string ExternalID = "External ID";
        private const string Comment = "Comment";
        private const string SupplierNo = "Supplier No";
        private const string SupplierInvoiceNo = "Supplier Invoice No";
        private const string ProfitRatio = "Profit Ratio";

        //default value lists
        private static readonly List<string> IsBillableList = new List<string> { "true", "false" };

        //default value lists from API 
        private static readonly List<KeyValuePair<int, string>> ProjectNoList = new List<KeyValuePair<int, string>>();
        private static readonly List<KeyValuePair<int, string>> PaymentMethodList = new List<KeyValuePair<int, string>>();
        private static readonly List<KeyValuePair<int, string>> ExpenseTypeList = new List<KeyValuePair<int, string>>();
        private static readonly List<KeyValuePair<int, string>> ExpenseCurrencyISOList = new List<KeyValuePair<int, string>>();
        private static readonly List<KeyValuePair<int, string>> ContractNameList = new List<KeyValuePair<int, string>>();
        private static readonly List<KeyValuePair<int, string>> SupplierNoList = new List<KeyValuePair<int, string>>();

        //expanding panels' current states, expand panels, expand buttons
        private BaseHandler.ExpandState[] _expandStates;
        private Panel[] _expandPanels;
        private Button[] _expandButtons;

        //set the number of pixels expanded per timer Tick
        private const int ExpansionPerTick = 7;

        #endregion

        public UserControl_ProjectExpenseImport()
        {
            InitializeComponent();
            ProjectExpenseHandler.Instance.InitializeDelimiterComboBox(comboBox_delimiter);
            InitializeExpandCollapsePanels();
            AddRowNumberToDataTable();
            InitializeAllDefaultValues();
            _projectExpenseTable = ProjectExpenseHandler.Instance.InitializeDomainDataTable(MandatoryFields);
            dataGridView_projectExpense.DataSource = _projectExpenseTable;
            button_import.Enabled = false;
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
          
        }

        #region Initialization methods

        private void InitializeExpandCollapsePanels()
        {
            _expandStates = new[]
            {
                BaseHandler.ExpandState.Expanded
            };
            _expandPanels = new[]
            {
                panel_NonMandatoryFields
            };
            _expandButtons = new[]
            {
                button_expandNonMandatory
            };

            for (int i = 0; i < _expandButtons.Length; i++)
            {
                _expandButtons[i].Tag = i;
                _expandButtons[i].BackgroundImage = Properties.Resources.upload;
            }
        }

        private void InitializeAllDefaultValues()
        {
            GetAllProjectFromApi();
            GetAllPaymentMethodFromApi();
            GetAllExpenseTypeFromApi();
            GetAllExpenseCurrencyISOFromApi();
            GetAllSupplierFromApi();
        }

        #endregion

        #region Functionalities implementations

        private void button_select_project_file_Click(object sender, EventArgs e)
        {
            ProjectExpenseHandler.Instance.FileColumnHeaders = new List<string>();
            _fileContent = new DataTable();
            _fileContent = ProjectExpenseHandler.Instance.GetFileContent(comboBox_delimiter.SelectedItem.ToString());

            if (_fileContent != null)
            {
                textBox_projectExpenseImportMessages.Text = string.Empty;
                ClearAndResetAllCheckBoxes();
                ClearAndResetAllComboBoxes();
                Invoke((MethodInvoker)(() => button_import.Enabled = false));

                if (dataGridView_projectExpense.RowCount > 1)
                {
                    dataGridView_projectExpense.DataSource = null;
                    _projectExpenseTable = ProjectExpenseHandler.Instance.InitializeDomainDataTable(MandatoryFields);
                    dataGridView_projectExpense.DataSource = _projectExpenseTable;
                }

                foreach (DataRow _fileContentRow in _fileContent.Rows)
                {
                    _projectExpenseTable.Rows.Add();
                }

                AddFileColumnHeaderToComboBox(ProjectExpenseHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());
            }
            else
            {
                button_clear_Click(sender, e);
            }
        }

        private void button_validate_Click(object sender, EventArgs e)
        {
            textBox_projectExpenseImportMessages.Text = string.Empty;
            _senderButton = (Button) sender;
            WorkerFetcher.RunWorkerAsync();
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            WorkerFetcher.CancelAsync();
        }

        private void button_import_Click(object sender, EventArgs e)
        {
            textBox_projectExpenseImportMessages.Text = string.Empty;
            _senderButton = (Button) sender;
            WorkerFetcher.RunWorkerAsync();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            ProjectExpenseHandler.Instance.FileColumnHeaders = new List<string>();
            textBox_projectExpenseImportMessages.Text = string.Empty;
            ClearAndResetAllCheckBoxes();
            ClearAndResetAllComboBoxes();
            Invoke((MethodInvoker)(() => button_import.Enabled = false));

            dataGridView_projectExpense.DataSource = null;
            _projectExpenseTable = ProjectExpenseHandler.Instance.InitializeDomainDataTable(MandatoryFields);
            dataGridView_projectExpense.DataSource = _projectExpenseTable;
        }

        private void textBox_projectExpenseImportMessages_MouseClick(object sender, MouseEventArgs e)
        {
            ProjectExpenseHandler.Instance.HighlightDataTableRowByTextBoxClick(e, dataGridView_projectExpense, textBox_projectExpenseImportMessages);
        }

        private void button_expand_Click(object sender, EventArgs e)
        {
            ProjectExpenseHandler.Instance.ExpandCollapseFieldByButtonClick(sender, _expandStates, _expandButtons, tmrExpand);
        }

        private void tmrExpand_Tick(object sender, EventArgs e)
        {
            ProjectExpenseHandler.Instance.ProcessExpandCollapseFieldForPanel(_expandPanels, _expandStates, ExpansionPerTick, tmrExpand);
        }

        private void WorkerFetcherDoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (dataGridView_projectExpense != null && dataGridView_projectExpense.RowCount > 1)
            {
                _errorRowCount = 0;

                //while validating, deactivate other buttons
                Invoke((MethodInvoker)(() => button_validate.Enabled = false));
                Invoke((MethodInvoker)(() => button_import.Enabled = false));
                Invoke((MethodInvoker)(() => button_clear.Enabled = false));
                Invoke((MethodInvoker)(() => button_projectExpenseSelectFile.Enabled = false));

                try
                {
                    foreach (DataGridViewRow _row in dataGridView_projectExpense.Rows)
                    {
                        if (WorkerFetcher.CancellationPending)
                        {
                            break;
                        }

                        _isMappingFieldValueToIDCorrect = true;
                        _isFirstTimeInvalidMapping = true;

                        if (_row.DataBoundItem != null)
                        {
                            ProjectExpenseCreateModel _newProjectExpense = new ProjectExpenseCreateModel
                            {
                                ProjectID = (int) MapFieldValueToID(ProjectNo, _row, false),
                                Comment = ProjectExpenseHandler.Instance.CheckAndGetString(dataGridView_projectExpense, Comment, _row),
                                PurchaseDate = ProjectExpenseHandler.Instance.CheckAndGetDate(dataGridView_projectExpense, PurchaseDate, _row),
                                PaymentMethodID = (int) MapFieldValueToID(PaymentMethod, _row, false),
                                ExpenseTypeID = (int) MapFieldValueToID(ExpenseType, _row, false),
                                AmountIncludingVatExpenseCurrency = ProjectExpenseHandler.Instance.CheckAndGetDouble(dataGridView_projectExpense, AmountIncludingVAT, _row),
                                SalesPriceAmountProjectCurrency = ProjectExpenseHandler.Instance.CheckAndGetDouble(dataGridView_projectExpense, SalesPriceAmount, _row),
                                IsBillable = ProjectExpenseHandler.Instance.CheckAndGetBoolean(dataGridView_projectExpense, IsBillable, _row),
                                ExpenseNo = ProjectExpenseHandler.Instance.CheckAndGetString(dataGridView_projectExpense, ExpenseNo, _row),
                                VatAmountExpenseCurrency = ProjectExpenseHandler.Instance.CheckAndGetDouble(dataGridView_projectExpense, VATAmount, _row),
                                ExpenseCurrencyISO = ProjectExpenseHandler.Instance.CheckAndGetString(dataGridView_projectExpense, ExpenseCurrencyISO, _row),
                                ExternalID = ProjectExpenseHandler.Instance.CheckAndGetString(dataGridView_projectExpense, ExternalID, _row),
                                ProjectSubContractID = (int) MapFieldValueToID(ContractName, _row, false),
                                ProjectExpenseExchangeRate = ProjectExpenseHandler.Instance.CheckAndGetDouble(dataGridView_projectExpense, ExchangeRate, _row),
                                SupplierID = MapFieldValueToID(SupplierNo, _row, true),
                                SupplierInvoiceNo = ProjectExpenseHandler.Instance.CheckAndGetString(dataGridView_projectExpense, SupplierInvoiceNo, _row),
                                ProfitRatio = ProjectExpenseHandler.Instance.CheckAndGetDouble(dataGridView_projectExpense, ProfitRatio, _row)
                            };

                            if (_isMappingFieldValueToIDCorrect)
                            {
                                if (_senderButton.Name == button_validate.Name)
                                {
                                    var _defaultApiResponse = ProjectExpenseHandler.Instance.ValidateProjectExpense(_newProjectExpense,
                                        AuthenticationHandler.Instance.Token, out var _businessRulesApiResponse);

                                    _errorRowCount = ApiHelper.Instance.HandleApiResponse(_defaultApiResponse, _row, _businessRulesApiResponse,
                                        textBox_projectExpenseImportMessages, _errorRowCount, WorkerFetcher, this);
                                }
                                else
                                {
                                    var _defaultApiResponse = ProjectExpenseHandler.Instance.ImportProjectExpense(_newProjectExpense,
                                        AuthenticationHandler.Instance.Token, out var _businessRulesApiResponse);

                                    _errorRowCount = ApiHelper.Instance.HandleApiResponse(_defaultApiResponse, _row, _businessRulesApiResponse,
                                        textBox_projectExpenseImportMessages, _errorRowCount, WorkerFetcher, this);
                                }
                            }
                        }
                    }

                    ProjectExpenseHandler.Instance.DisplayErrorRowCountAndSuccessMessage(_errorRowCount, button_import, button_validate, _senderButton, textBox_projectExpenseImportMessages, this);
                }
                catch (FormatException _ex)
                {
                    MessageBox.Show(_ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception _ex)
                {
                    MessageBox.Show(_ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                //reactivate buttons after work is done
                Invoke((MethodInvoker)(() => button_validate.Enabled = true));
                Invoke((MethodInvoker)(() => button_clear.Enabled = true));
                Invoke((MethodInvoker)(() => button_projectExpenseSelectFile.Enabled = true));
            }
        }

        #endregion

        #region Helper methods

        private void AddFileColumnHeaderToComboBox(object[] fileColumnHeaderArray)
        {
            comboBox_projectNo.Items.AddRange(fileColumnHeaderArray);
            comboBox_purchaseDate.Items.AddRange(fileColumnHeaderArray);
            comboBox_paymentMethod.Items.AddRange(fileColumnHeaderArray);
            comboBox_expenseType.Items.AddRange(fileColumnHeaderArray);
            comboBox_amountIncludingVAT.Items.AddRange(fileColumnHeaderArray);
            comboBox_salesPriceAmount.Items.AddRange(fileColumnHeaderArray);
            comboBox_isBillable.Items.AddRange(fileColumnHeaderArray);
            comboBox_expenseNo.Items.AddRange(fileColumnHeaderArray);
            comboBox_VATAmount.Items.AddRange(fileColumnHeaderArray);
            comboBox_expenseCurrencyISO.Items.AddRange(fileColumnHeaderArray);
            comboBox_contractName.Items.AddRange(fileColumnHeaderArray);
            comboBox_externalID.Items.AddRange(fileColumnHeaderArray);
            comboBox_exchangeRate.Items.AddRange(fileColumnHeaderArray);
            comboBox_comment.Items.AddRange(fileColumnHeaderArray);
            comboBox_supplierNo.Items.AddRange(fileColumnHeaderArray);
            comboBox_supplierInvoiceNo.Items.AddRange(fileColumnHeaderArray);
            comboBox_profitRatio.Items.AddRange(fileColumnHeaderArray);
        }

        private int? MapFieldValueToID(string columnName, DataGridViewRow row, bool isNullableField)
        {
            if (dataGridView_projectExpense.Columns[columnName] != null)
            {
                var _fieldValue = ProjectExpenseHandler.Instance.CheckAndGetString(dataGridView_projectExpense, columnName, row);
                int _result = -1;

                if (columnName == ProjectNo)
                {
                    _result = ProjectExpenseHandler.Instance.GetIDFromFieldValue(ProjectNoList, _fieldValue);
                    if (_result != -1)
                    {
                        GetAllContractFromApi(_result);
                    }
                }
                else if (columnName == PaymentMethod)
                {
                    _result = ProjectExpenseHandler.Instance.GetIDFromFieldValue(PaymentMethodList, _fieldValue);
                }
                else if (columnName == ExpenseType)
                {
                    _result = ProjectExpenseHandler.Instance.GetIDFromFieldValue(ExpenseTypeList, _fieldValue);
                }
                else if (columnName == ContractName)
                {
                    _result = ProjectExpenseHandler.Instance.GetIDFromFieldValue(ContractNameList, _fieldValue);
                }
                else if (columnName == SupplierNo)
                {
                    _result = ProjectExpenseHandler.Instance.GetIDFromFieldValue(SupplierNoList, _fieldValue);
                }

                if (_result != -1)
                {
                    return _result;
                }

                if (isNullableField)
                {
                    return null;
                }

                //if can't match, display error message
                _errorRowCount = ProjectExpenseHandler.Instance.HandleInvalidFieldValueToIDMapping(columnName, row, _fieldValue, textBox_projectExpenseImportMessages, 
                    WorkerFetcher, this, _isFirstTimeInvalidMapping, _errorRowCount);
                _isMappingFieldValueToIDCorrect = false;
                _isFirstTimeInvalidMapping = false;
            }

            
            return 0;
        }

        private void ClearAndResetAllComboBoxes()
        {
            comboBox_projectNo.ResetText();
            comboBox_projectNo.Items.Clear();
            comboBox_purchaseDate.ResetText();
            comboBox_purchaseDate.Items.Clear();
            comboBox_paymentMethod.ResetText();
            comboBox_paymentMethod.Items.Clear();
            comboBox_expenseType.ResetText();
            comboBox_expenseType.Items.Clear();
            comboBox_amountIncludingVAT.ResetText();
            comboBox_amountIncludingVAT.Items.Clear();
            comboBox_salesPriceAmount.ResetText();
            comboBox_salesPriceAmount.Items.Clear();
            comboBox_isBillable.ResetText();
            comboBox_isBillable.Items.Clear();
            comboBox_expenseNo.ResetText();
            comboBox_expenseNo.Items.Clear();
            comboBox_VATAmount.ResetText();
            comboBox_VATAmount.Items.Clear();
            comboBox_expenseCurrencyISO.ResetText();
            comboBox_expenseCurrencyISO.Items.Clear();
            comboBox_contractName.ResetText();
            comboBox_contractName.Items.Clear();
            comboBox_externalID.ResetText();
            comboBox_externalID.Items.Clear();
            comboBox_exchangeRate.ResetText();
            comboBox_exchangeRate.Items.Clear();
            comboBox_comment.ResetText();
            comboBox_comment.Items.Clear();
            comboBox_supplierNo.ResetText();
            comboBox_supplierNo.Items.Clear();
            comboBox_supplierInvoiceNo.ResetText();
            comboBox_supplierInvoiceNo.Items.Clear();
            comboBox_profitRatio.ResetText();
            comboBox_profitRatio.Items.Clear();
        }

        private void ClearAndResetAllCheckBoxes()
        {
            checkBox_defaultPaymentMethod.Checked = false;
            checkBox_defaultExpenseType.Checked = false;
            checkBox_defaultExpenseCurrencyISO.Checked = false;
            checkBox_defaultIsBillable.Checked = false;
        }

        #endregion

        #region Get default values from API

        private void GetAllProjectFromApi()
        {
            var _apiResponse = ProjectExpenseHandler.Instance.GetAllProject(AuthenticationHandler.Instance.Token);

            if (_apiResponse != null)
            {
                foreach (var _project in _apiResponse)
                {
                    ProjectNoList.Add(new KeyValuePair<int, string>(_project.ProjectID, _project.No));
                }
            }
        }

        private void GetAllPaymentMethodFromApi()
        {
            var _apiResponse = ProjectExpenseHandler.Instance.GetAllPaymentMethod(AuthenticationHandler.Instance.Token);

            if (_apiResponse != null)
            {
                foreach (var _paymentMethod in _apiResponse)
                {
                    PaymentMethodList.Add(new KeyValuePair<int, string>(_paymentMethod.PaymentMethodID, _paymentMethod.Name));
                }
            }
        }

        private void GetAllExpenseTypeFromApi()
        {
            var _apiResponse = ProjectExpenseHandler.Instance.GetAllExpenseType(AuthenticationHandler.Instance.Token);

            if (_apiResponse != null)
            {
                foreach (var _expenseType in _apiResponse)
                {
                    ExpenseTypeList.Add(new KeyValuePair<int, string>(_expenseType.ExpenseTypeID, _expenseType.ExpenseTypeName));
                }
            }
        }

        private void GetAllExpenseCurrencyISOFromApi()
        {
            var _apiResponse = ProjectExpenseHandler.Instance.GetAllCurrency(AuthenticationHandler.Instance.Token);

            if (_apiResponse != null)
            {
                foreach (var _currency in _apiResponse)
                {
                    ExpenseCurrencyISOList.Add(new KeyValuePair<int, string>(_currency.CurrencyID, _currency.CurrencyABB));
                }
            }
        }

        private void GetAllContractFromApi(int projectID)
        {
            var _apiResponse = ProjectExpenseHandler.Instance.GetAllContract(AuthenticationHandler.Instance.Token, projectID);

            if (_apiResponse != null)
            {
                foreach (var _contract in _apiResponse)
                { 
                    ContractNameList.Add(new KeyValuePair<int, string>(_contract.ContractID, _contract.ContractName));
                }
            }
        }

        private void GetAllSupplierFromApi()
        {
            var _apiResponse = ProjectExpenseHandler.Instance.GetAllCustomer(AuthenticationHandler.Instance.Token);

            if (_apiResponse != null)
            {
                foreach (var _supplier in _apiResponse)
                {
                    SupplierNoList.Add(new KeyValuePair<int, string>(_supplier.CustomerID, _supplier.No));
                }
            }
        }

        #endregion

        #region Combobox implementations

        private void comboBox_projectNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProjectExpenseHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_projectExpense, _projectExpenseTable,
                comboBox_projectNo, ProjectNo);
        }

        private void comboBox_purchaseDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProjectExpenseHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_projectExpense, _projectExpenseTable,
                comboBox_purchaseDate, PurchaseDate);
        }

        private void comboBox_paymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProjectExpenseHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_projectExpense, _projectExpenseTable,
                comboBox_paymentMethod, PaymentMethod, checkBox_defaultPaymentMethod);
        }

        private void comboBox_expenseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProjectExpenseHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_projectExpense, _projectExpenseTable,
                comboBox_expenseType, ExpenseType, checkBox_defaultExpenseType);
        }

        private void comboBox_amountIncludingVAT_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProjectExpenseHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_projectExpense, _projectExpenseTable,
                comboBox_amountIncludingVAT, AmountIncludingVAT);
        }

        private void comboBox_salesPriceAmount_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProjectExpenseHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_projectExpense, _projectExpenseTable,
                comboBox_salesPriceAmount, SalesPriceAmount);
        }

        private void comboBox_expenseNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProjectExpenseHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_projectExpense, _projectExpenseTable,
                comboBox_expenseNo, ExpenseNo);
        }

        private void comboBox_VATAmount_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProjectExpenseHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_projectExpense, _projectExpenseTable,
                comboBox_VATAmount, VATAmount);
        }

        private void comboBox_expenseCurrencyISO_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProjectExpenseHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_projectExpense, _projectExpenseTable,
                comboBox_expenseCurrencyISO, ExpenseCurrencyISO, checkBox_defaultExpenseCurrencyISO);
        }

        private void comboBox_contractName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProjectExpenseHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_projectExpense, _projectExpenseTable,
                comboBox_contractName, ContractName);
        }

        private void comboBox_exchangeRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProjectExpenseHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_projectExpense, _projectExpenseTable,
                comboBox_exchangeRate, ExchangeRate);
        }

        private void comboBox_isBillable_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProjectExpenseHandler.Instance.MapMandatoryNonKeyValuePairSelectedColumnToTable(_fileContent, dataGridView_projectExpense, _projectExpenseTable,
                comboBox_isBillable, IsBillable, checkBox_defaultIsBillable);
        }

        private void comboBox_externalID_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProjectExpenseHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_projectExpense, _projectExpenseTable,
                comboBox_externalID, ExternalID);
        }

        private void comboBox_comment_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProjectExpenseHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_projectExpense, _projectExpenseTable,
                comboBox_comment, Comment);
        }

        private void comboBox_supplierNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProjectExpenseHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_projectExpense, _projectExpenseTable,
                comboBox_supplierNo, SupplierNo);
        }

        private void comboBox_supplierInvoiceNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProjectExpenseHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_projectExpense, _projectExpenseTable,
                comboBox_supplierInvoiceNo, SupplierInvoiceNo);
        }

        private void comboBox_profitRatio_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProjectExpenseHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_projectExpense, _projectExpenseTable,
                comboBox_profitRatio, ProfitRatio);
        }

        #endregion

        #region Checkbox implementations

        private void checkBox_defaultExpenseType_CheckedChanged(object sender, EventArgs e)
        {
            ProjectExpenseHandler.Instance.MapValuesToComboBoxByCheckboxStatus(dataGridView_projectExpense, _projectExpenseTable, comboBox_expenseType,
                ExpenseType, checkBox_defaultExpenseType, ExpenseTypeList, ProjectExpenseHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());
        }

        private void checkBox_defaultPaymentMethod_CheckedChanged(object sender, EventArgs e)
        {
            ProjectExpenseHandler.Instance.MapValuesToComboBoxByCheckboxStatus(dataGridView_projectExpense, _projectExpenseTable, comboBox_paymentMethod,
                PaymentMethod, checkBox_defaultPaymentMethod, PaymentMethodList, ProjectExpenseHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());
        }

        private void checkBox_defaultExpenseCurrencyISO_CheckedChanged(object sender, EventArgs e)
        {
            ProjectExpenseHandler.Instance.MapValuesToComboBoxByCheckboxStatus(dataGridView_projectExpense, _projectExpenseTable, comboBox_expenseCurrencyISO,
               ExpenseCurrencyISO, checkBox_defaultExpenseCurrencyISO, ExpenseCurrencyISOList, ProjectExpenseHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());
        }

        private void checkBox_defaultIsBillable_CheckedChanged(object sender, EventArgs e)
        {
            ProjectExpenseHandler.Instance.MapNonKeyValuePairToComboBoxByCheckboxStatus(dataGridView_projectExpense, _projectExpenseTable, comboBox_isBillable,
                IsBillable, checkBox_defaultIsBillable, IsBillableList, ProjectExpenseHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());
        }

        #endregion
    }
}