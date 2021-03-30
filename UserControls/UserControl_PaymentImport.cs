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
    public partial class UserControl_PaymentImport : UserControl
    {
        #region Variable declarations

        private DataTable _paymentTable;
        private DataTable _fileContent;
        private Button _senderButton;
        private int _errorRowCount;
        private bool _isMappingFieldValueToIDCorrect;
        private bool _isFirstTimeInvalidMapping;

        private static readonly Dictionary<int, string> MandatoryFields = new Dictionary<int, string>
        {
            {0, "Payment Name"},
            {1, "Project No"},
            {2, "Contract Name"},
            {3, "Invoice Date"},
            {4, "Amount"},
            {5, "Quantity"},
            {6, "Unit Type"},

        };

        //all column header variables
        private readonly string _paymentName = "Payment Name";
        private readonly string _projectNo = "Project No";
        private readonly string _contractName = "Contract Name";
        private readonly string _invoiceDate = "Invoice Date";
        private readonly string _amount = "Amount";
        private readonly string _quantity = "Quantity";
        private readonly string _unitType = "Unit type";
        private readonly string _taskNo = "Task No";
        private readonly string _productNo = "Product No";
        private readonly string _discountPercentage = "Discount Percentage";
        private readonly string _comment = "Comment";
        private readonly string _isReadyForInvoicing = "Is Ready For Invoicing";
        private readonly string _isFixedPricePayment = "Is Fixed Price Payment";
       

        //default value lists from API 
        private static readonly List<KeyValuePair<int, string>> _projectList = new List<KeyValuePair<int, string>>();
        private static readonly List<KeyValuePair<int, string>> _unitTypeList = new List<KeyValuePair<int, string>>();

        //expanding panels' current states, expand panels, expand buttons
        private BaseHandler.ExpandState[] _expandStates;
        private Panel[] _expandPanels;
        private Button[] _expandButtons;

        //set the number of pixels expanded per timer Tick
        private const int ExpansionPerTick = 7;

        #endregion

        public UserControl_PaymentImport()
        {
            InitializeComponent();
            PaymentHandler.Instance.InitializeDelimiterComboBox(comboBox_delimiter);
            InitializeExpandCollapsePanels();
            AddRowNumberToDataTable();
            InitializeAllDefaultValues();
            _paymentTable = PaymentHandler.Instance.InitializeDomainDataTable(MandatoryFields);
            dataGridView_payment.DataSource = _paymentTable;
            button_import.Enabled = false;
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
            GetAllUnitTypeFromApi();
            GetAllProjectFromApi();
        }

        #endregion

        #region Functionalities implementations

        private void button_select_payment_file_Click(object sender, EventArgs e)
        {
            PaymentHandler.Instance.FileColumnHeaders = new List<string>();
            _fileContent = new DataTable();
            _fileContent = PaymentHandler.Instance.GetFileContent(comboBox_delimiter.SelectedItem.ToString());

            if (_fileContent != null)
            {
                textBox_paymentImportMessages.Text = string.Empty;
                ClearAndResetAllCheckBoxes();
                ClearAndResetAllComboBoxes();
                Invoke((MethodInvoker)(() => button_import.Enabled = false));

                if (dataGridView_payment.RowCount > 1)
                {
                    dataGridView_payment.DataSource = null;
                    _paymentTable = PaymentHandler.Instance.InitializeDomainDataTable(MandatoryFields);
                    dataGridView_payment.DataSource = _paymentTable;
                }

                foreach (DataRow _fileContentRow in _fileContent.Rows)
                {
                    _paymentTable.Rows.Add();
                }

                AddFileColumnHeaderToComboBox(PaymentHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());

                ContractHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_paymentName,_paymentName );
                ContractHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_paymentProjectNo,_projectNo);
                ContractHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_paymentContractName,_contractName);
                ContractHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_paymentInvoiceDate,_invoiceDate);
                ContractHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_paymentAmount,_amount);
                ContractHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_paymentQuantity,_quantity);
                ContractHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_paymentUnitType,_unitType);
                ContractHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_paymentTaskNo,_taskNo);
                ContractHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_paymentProductNo,_productNo);
                ContractHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_paymentDiscountPercentage,_discountPercentage);
                ContractHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_paymentComment,_comment);
                ContractHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_paymentIsReadyForInvoicing,_isReadyForInvoicing);
                ContractHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_paymentIsFixedPricePayment,_isFixedPricePayment);

            }
            else
            {
                button_clear_Click(sender, e);
            }
        }

        private void button_validate_Click(object sender, EventArgs e)
        {
            textBox_paymentImportMessages.Text = string.Empty;
            _senderButton = (Button) sender;
            WorkerFetcher.RunWorkerAsync();
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            WorkerFetcher.CancelAsync();
        }

        private void button_import_Click(object sender, EventArgs e)
        {
            textBox_paymentImportMessages.Text = string.Empty;
            _senderButton = (Button) sender;
            WorkerFetcher.RunWorkerAsync();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            PaymentHandler.Instance.FileColumnHeaders = new List<string>();
            textBox_paymentImportMessages.Text = string.Empty;
            ClearAndResetAllCheckBoxes();
            ClearAndResetAllComboBoxes();
            Invoke((MethodInvoker)(() => button_import.Enabled = false));

            dataGridView_payment.DataSource = null;
            _paymentTable = PaymentHandler.Instance.InitializeDomainDataTable(MandatoryFields);
            dataGridView_payment.DataSource = _paymentTable;
        }

        private void textBox_paymentImportMessages_MouseClick(object sender, MouseEventArgs e)
        {
            PaymentHandler.Instance.HighlightDataTableRowByTextBoxClick(e, dataGridView_payment, textBox_paymentImportMessages);
        }

        private void button_expand_Click(object sender, EventArgs e)
        {
            PaymentHandler.Instance.ExpandCollapseFieldByButtonClick(sender, _expandStates, _expandButtons, tmrExpand);
        }

        private void tmrExpand_Tick(object sender, EventArgs e)
        {
            PaymentHandler.Instance.ProcessExpandCollapseFieldForPanel(_expandPanels, _expandStates, ExpansionPerTick, tmrExpand);
        }

        private void WorkerFetcherDoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (dataGridView_payment != null && dataGridView_payment.RowCount > 1)
            {
                _errorRowCount = 0;

                //while validating, deactivate other buttons
                Invoke((MethodInvoker)(() => button_validate.Enabled = false));
                Invoke((MethodInvoker)(() => button_import.Enabled = false));
                Invoke((MethodInvoker)(() => button_clear.Enabled = false));
                Invoke((MethodInvoker)(() => button_paymentSelectFile.Enabled = false));

                try
                {
                    foreach (DataGridViewRow _row in dataGridView_payment.Rows)
                    {
                        if (WorkerFetcher.CancellationPending)
                        {
                            break;
                        }

                        _isMappingFieldValueToIDCorrect = true;
                        _isFirstTimeInvalidMapping = true;

                        if (_row.DataBoundItem != null)
                        {
                            PaymentCreateModel _newPayment = new PaymentCreateModel
                            {
                                Name = PaymentHandler.Instance.CheckAndGetString(dataGridView_payment, _paymentName, _row),
                                ProjectID = (int) MapFieldValueToID(_projectNo, _row, false),
                                ProjectSubContractID = (int) MapFieldValueToID(_contractName, _row, false),
                                TaskID = (int) MapFieldValueToID(_taskNo, _row, false),
                                InvoiceDate = PaymentHandler.Instance.CheckAndGetDate(dataGridView_payment,_invoiceDate,_row),
                                Amount = PaymentHandler.Instance.CheckAndGetDouble(dataGridView_payment,_amount,_row),
                                Quantity = PaymentHandler.Instance.CheckAndGetDouble(dataGridView_payment, _quantity, _row),
                                UnitTypeID = (int)MapFieldValueToID(_unitType,_row,false),
                                ProductNumber = PaymentHandler.Instance.CheckAndGetString(dataGridView_payment,_productNo,_row),
                                DiscountPercentage = PaymentHandler.Instance.CheckAndGetDouble(dataGridView_payment, _discountPercentage, _row),
                                Comment = PaymentHandler.Instance.CheckAndGetString(dataGridView_payment,_comment,_row),
                                IsReadyForInvoicing = PaymentHandler.Instance.CheckAndGetBoolean(dataGridView_payment,_isReadyForInvoicing,_row),
                                IsFixedPricePayment = PaymentHandler.Instance.CheckAndGetBoolean(dataGridView_payment,_isFixedPricePayment,_row)

                            };

                            if (_isMappingFieldValueToIDCorrect)
                            {
                                if (_senderButton.Name == button_validate.Name)
                                {
                                    var _defaultApiResponse = PaymentHandler.Instance.ValidatePayment(_newPayment,
                                        AuthenticationHandler.Instance.Token, out var _businessRulesApiResponse);

                                    _errorRowCount = ApiHelper.Instance.HandleApiResponse(_defaultApiResponse, _row, _businessRulesApiResponse,
                                        textBox_paymentImportMessages, _errorRowCount, WorkerFetcher, this);
                                }
                                else
                                {
                                    var _defaultApiResponse = PaymentHandler.Instance.ImportPayment(_newPayment,
                                        AuthenticationHandler.Instance.Token, out var _businessRulesApiResponse);

                                    _errorRowCount = ApiHelper.Instance.HandleApiResponse(_defaultApiResponse, _row, _businessRulesApiResponse,
                                        textBox_paymentImportMessages, _errorRowCount, WorkerFetcher, this);
                                }
                            }
                        }
                    }

                    PaymentHandler.Instance.DisplayErrorRowCountAndSuccessMessage(_errorRowCount, button_import, button_validate, _senderButton, textBox_paymentImportMessages, this);
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
                Invoke((MethodInvoker)(() => button_paymentSelectFile.Enabled = true));
            }
        }

        #endregion

        #region Helper methods

        private void AddFileColumnHeaderToComboBox(object[] fileColumnHeaderArray)
        {
            comboBox_paymentName.Items.AddRange(fileColumnHeaderArray);
            comboBox_paymentProjectNo.Items.AddRange(fileColumnHeaderArray);
            comboBox_paymentContractName.Items.AddRange(fileColumnHeaderArray);
            comboBox_paymentInvoiceDate.Items.AddRange(fileColumnHeaderArray);
            comboBox_paymentAmount.Items.AddRange(fileColumnHeaderArray);
            comboBox_paymentQuantity.Items.AddRange(fileColumnHeaderArray);
            comboBox_paymentUnitType.Items.AddRange(fileColumnHeaderArray);
            comboBox_paymentTaskNo.Items.AddRange(fileColumnHeaderArray);
            comboBox_paymentProductNo.Items.AddRange(fileColumnHeaderArray);
            comboBox_paymentDiscountPercentage.Items.AddRange(fileColumnHeaderArray);
            comboBox_paymentComment.Items.AddRange(fileColumnHeaderArray);
            comboBox_paymentIsReadyForInvoicing.Items.AddRange(fileColumnHeaderArray);
            comboBox_paymentIsFixedPricePayment.Items.AddRange(fileColumnHeaderArray);
        }

        private int? MapFieldValueToID(string columnName, DataGridViewRow row, bool isNullableField)
        {
            if (dataGridView_payment.Columns[columnName] != null)
            {
                var _fieldValue = PaymentHandler.Instance.CheckAndGetString(dataGridView_payment, columnName, row);
                int _result = -1;

                if (columnName == _projectNo)
                {
                    _result = PaymentHandler.Instance.GetIDFromFieldValue(_projectList, _fieldValue);
                }
                else if (columnName == _contractName)
                {
                    var _projectID = PaymentHandler.Instance.GetIDFromFieldValue(_projectList, PaymentHandler.Instance.CheckAndGetString(dataGridView_payment, _projectNo, row));
                    var _projectContracts = PaymentHandler.Instance.GetAllContract(AuthenticationHandler.Instance.Token, _projectID);

                    try
                    {
                        _result = _projectContracts.FirstOrDefault(x => x.ContractName.ToLower().Trim().Equals(_fieldValue.ToLower().Trim())).ContractID;
                    }
                    catch (Exception _)
                    {
                        _result = -1;
                    }
                }
                else if (columnName == _taskNo)
                {
                    if (!string.IsNullOrWhiteSpace(_fieldValue))
                    {
                        var _projectID = PaymentHandler.Instance.GetIDFromFieldValue(_projectList, PaymentHandler.Instance.CheckAndGetString(dataGridView_payment, _projectNo, row));
                        var _tasks = PaymentHandler.Instance.GetAllTask(AuthenticationHandler.Instance.Token, _projectID);

                        try
                        {
                            _result = _tasks.FirstOrDefault(x => x.No.ToLower().Trim().Equals(_fieldValue.ToLower().Trim())).TaskID;
                        }
                        catch (Exception _)
                        {
                            _result = -1;
                        }
                    }
                    else
                    {
                        _result = 0;
                    }

                }
                else if (columnName == _unitType)
                {
                    _result = PaymentHandler.Instance.GetIDFromFieldValue(_unitTypeList, _fieldValue);
                }
                

                if (_result != -1)
                {
                    return _result;
                }

                //if can't match, display error message
                _errorRowCount = PaymentHandler.Instance.HandleInvalidFieldValueToIDMapping(columnName, row, _fieldValue, textBox_paymentImportMessages,
                    WorkerFetcher, this, _isFirstTimeInvalidMapping, _errorRowCount);
                _isMappingFieldValueToIDCorrect = false;
                _isFirstTimeInvalidMapping = false;
            }

            if (isNullableField)
            {
                return null;
            }

            return 0;
        }

        private void ClearAndResetAllComboBoxes()
        {
            comboBox_paymentName.ResetText();
            comboBox_paymentName.Items.Clear();
            comboBox_paymentProjectNo.ResetText();
            comboBox_paymentProjectNo.Items.Clear();
            comboBox_paymentContractName.ResetText();
            comboBox_paymentContractName.Items.Clear();
            comboBox_paymentInvoiceDate.ResetText();
            comboBox_paymentInvoiceDate.Items.Clear();
            comboBox_paymentAmount.ResetText();
            comboBox_paymentAmount.Items.Clear();
            comboBox_paymentQuantity.ResetText();
            comboBox_paymentQuantity.Items.Clear();
            comboBox_paymentUnitType.ResetText();
            comboBox_paymentUnitType.Items.Clear();
            comboBox_paymentTaskNo.ResetText();
            comboBox_paymentTaskNo.Items.Clear();
            comboBox_paymentProductNo.ResetText();
            comboBox_paymentProductNo.Items.Clear();
            comboBox_paymentDiscountPercentage.ResetText();
            comboBox_paymentDiscountPercentage.Items.Clear();
            comboBox_paymentComment.ResetText();
            comboBox_paymentComment.Items.Clear();
            comboBox_paymentIsReadyForInvoicing.ResetText();
            comboBox_paymentIsReadyForInvoicing.Items.Clear();
            comboBox_paymentIsFixedPricePayment.ResetText();
            comboBox_paymentIsFixedPricePayment.Items.Clear();
        }

        private void ClearAndResetAllCheckBoxes()
        {

            checkBox_defaultPaymentUnitType.Checked = false;
        }

        #endregion

        #region Get default values from API

        private void GetAllUnitTypeFromApi()
        {
            var _apiResponse = PaymentHandler.Instance.GetAllUnitType(AuthenticationHandler.Instance.Token);

            if (_apiResponse != null)
            {
                foreach (var _unitType in _apiResponse)
                {
                    _unitTypeList.Add(new KeyValuePair<int, string>(_unitType.UnitTypeID, _unitType.Name));
                }
            }
        }

        private void GetAllProjectFromApi()
        {
            var _apiResponse = PaymentHandler.Instance.GetAllProject(AuthenticationHandler.Instance.Token);

            if (_apiResponse != null)
            {
                foreach (var _project in _apiResponse)
                {
                    _projectList.Add(new KeyValuePair<int, string>(_project.ProjectID, _project.No));
                }
            }
        }

        



        #endregion

        #region Combobox implementations
        private void comboBox_paymentName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContractHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_payment, _paymentTable, comboBox_paymentName, _paymentName);

        }

        private void comboBox_paymentProjectNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContractHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_payment, _paymentTable, comboBox_paymentProjectNo, _projectNo);

        }

        private void comboBox_paymentContractName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContractHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_payment, _paymentTable, comboBox_paymentContractName, _contractName);

        }

        private void comboBox_paymentInvoiceDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContractHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_payment, _paymentTable, comboBox_paymentInvoiceDate, _invoiceDate);

        }

        private void comboBox_paymentAmount_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContractHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_payment, _paymentTable, comboBox_paymentAmount, _amount);

        }

        private void comboBox_paymentQuantity_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContractHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_payment, _paymentTable, comboBox_paymentQuantity, _quantity);

        }

        private void comboBox_paymentUnitType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContractHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_payment, _paymentTable, comboBox_paymentUnitType, _unitType);

        }

        private void comboBox_paymentTaskNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContractHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_payment, _paymentTable, comboBox_paymentTaskNo,_taskNo);

        }

        private void comboBox_paymentProductNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContractHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_payment, _paymentTable, comboBox_paymentProductNo,_productNo);

        }

        private void comboBox_paymentDiscountPercentage_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContractHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_payment, _paymentTable, comboBox_paymentDiscountPercentage,_discountPercentage);

        }

        private void comboBox_paymentComment_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContractHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_payment, _paymentTable, comboBox_paymentComment,_comment);

        }

        private void comboBox_paymentIsReadyForInvoicing_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContractHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_payment, _paymentTable, comboBox_paymentIsReadyForInvoicing,_isReadyForInvoicing);

        }

        private void comboBox_paymentIsFixedPricePayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContractHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_payment, _paymentTable, comboBox_paymentIsFixedPricePayment,_isFixedPricePayment);

        }

        #endregion

        #region Checkbox implementations



        private void checkBox_defaultPaymentUnitType_CheckedChanged(object sender, EventArgs e)
        {
            PaymentHandler.Instance.MapValuesToComboBoxByCheckboxStatus(dataGridView_payment, _paymentTable, comboBox_paymentUnitType,
                _unitType, checkBox_defaultPaymentUnitType, _unitTypeList, PaymentHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());
        }




        #endregion

      
    }
}