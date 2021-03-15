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
    public partial class UserControl_ContractImport : UserControl
    {
        #region Variable declarations

        private DataTable _contractTable;
        private DataTable _fileContent;
        private Button _senderButton;
        private int _errorRowCount;
        private bool _isMappingFieldValueToIDCorrect;
        private bool _isFirstTimeInvalidMapping;

        private static readonly Dictionary<int, string> MandatoryFields = new Dictionary<int, string>
        {
            {0, "Project Name"},
            {1, "Project No"},
            {2, "Contract Status"},
            {3, "Contract Owner Initials"},
            {3, "Contract Model"},
        };

        //all column header variables
        private readonly string _contractName = "Contract Name";
        private readonly string _projectNo = "Project No";
        private readonly string _contractStatus = "Contract Status";
        private readonly string _contractOwnerInitials = "Contract Owner Initials";
        private readonly string _contractModel = "Contract Model";
        private readonly string _budgetExpensesAmount = "Budget Expenses Amount";
        private readonly string _budgetTravelAmount = "Budget Travel Amount";
        private readonly string _budgetWorkAmount = "Budget Work Amount";
        private readonly string _budgetWorkHour = "Budget Work Hour";
        private readonly string _completionNotification = "Completion Notification";
        private readonly string _completionNotificationPercentage = "Completion Notification %";
        private readonly string _isMileageBillable = "Is Mileage Billable";
        private readonly string _isDefaultExpenses = "Is Default Expenses";
        private readonly string _budgetOverrunNotification = "Budget Overrun Notification";
        private readonly string _targetHourlyRate = "Target Hourly Rate";
        private readonly string _paymentPlanAmount = "Payment Plan Amount";
        private readonly string _revenueExprAmount = "Revenue Expr Amount";
        private readonly string _revenueTravelAmount = "Revenue Travel Amount";
        private readonly string _isExpensesLinked = "Is Expenses Linked";
        private readonly string _isTravelLinked = "Is Travel Linked";


        //default value lists from API 
        private static readonly List<KeyValuePair<int, string>> ContractModels = new List<KeyValuePair<int, string>>();


        private static readonly List<KeyValuePair<int, string>> ContractStatusList =
            new List<KeyValuePair<int, string>>()
            {
                new KeyValuePair<int, string>(1, "Quotation"),
                new KeyValuePair<int, string>(2, "Active"),
                new KeyValuePair<int, string>(3, "Completed"),
                new KeyValuePair<int, string>(4, "Cancelled")
            };

        private static readonly List<string> HasCompletionNotificationList = new List<string> {"true", "false"};
        private static readonly List<string> IsMileageBillable = new List<string> {"true", "false"};
        private static readonly List<string> IsDefaultExpenses = new List<string> {"true", "false"};
        private static readonly List<string> HasBudgetOverrunNotification = new List<string> {"true", "false"};
        private static readonly List<string> IsExpensesLinked = new List<string> {"true", "false"};
        private static readonly List<string> IsTravelLinked = new List<string> {"true", "false"};

        private static List<string> CompletionNotificationPercentageList = new List<string>();


        //expanding panels' current states, expand panels, expand buttons
        private BaseHandler.ExpandState[] _expandStates;
        private Panel[] _expandPanels;
        private Button[] _expandButtons;

        //set the number of pixels expanded per timer Tick
        private const int ExpansionPerTick = 7;

        #endregion

        public UserControl_ContractImport()
        {
            InitializeComponent();
            ContractHandler.Instance.InitializeDelimiterComboBox(comboBox_delimiter);
            InitializeExpandCollapsePanels();
            AddRowNumberToDataTable();
            InitializeAllDefaultValues();
            _contractTable = ContractHandler.Instance.InitializeDomainDataTable(MandatoryFields);
            dataGridView_contract.DataSource = _contractTable;
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

            for (int i = 0; i <= 100; i++)
            {
                CompletionNotificationPercentageList.Add(i.ToString());
            }

            GetAllContractModelsFromApi();
        }

        #endregion

        #region Functionalities implementations

        private void button_select_contract_file_Click(object sender, EventArgs e)
        {
            ContractHandler.Instance.FileColumnHeaders = new List<string>();
            _fileContent = new DataTable();
            _fileContent = ContractHandler.Instance.GetFileContent(comboBox_delimiter.SelectedItem.ToString());

            if (_fileContent != null)
            {
                textBox_contractImportMessages.Text = string.Empty;
                ClearAndResetAllCheckBoxes();
                ClearAndResetAllComboBoxes();
                Invoke((MethodInvoker) (() => button_import.Enabled = false));

                if (dataGridView_contract.RowCount > 1)
                {
                    dataGridView_contract.DataSource = null;
                    _contractTable = ContractHandler.Instance.InitializeDomainDataTable(MandatoryFields);
                    dataGridView_contract.DataSource = _contractTable;
                }

                foreach (DataRow _fileContentRow in _fileContent.Rows)
                {
                    _contractTable.Rows.Add();
                }

                AddFileColumnHeaderToComboBox(ContractHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());
            }
            else
            {
                button_clear_Click(sender, e);
            }
        }

        private void button_validate_Click(object sender, EventArgs e)
        {
            textBox_contractImportMessages.Text = string.Empty;
            _senderButton = (Button) sender;
            WorkerFetcher.RunWorkerAsync();
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            WorkerFetcher.CancelAsync();
        }

        private void button_import_Click(object sender, EventArgs e)
        {
            textBox_contractImportMessages.Text = string.Empty;
            _senderButton = (Button) sender;
            WorkerFetcher.RunWorkerAsync();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            ContractHandler.Instance.FileColumnHeaders = new List<string>();
            textBox_contractImportMessages.Text = string.Empty;
            ClearAndResetAllCheckBoxes();
            ClearAndResetAllComboBoxes();
            Invoke((MethodInvoker) (() => button_import.Enabled = false));

            dataGridView_contract.DataSource = null;
            _contractTable = ContractHandler.Instance.InitializeDomainDataTable(MandatoryFields);
            dataGridView_contract.DataSource = _contractTable;
        }

        private void textBox_projectImportMessages_MouseClick(object sender, MouseEventArgs e)
        {
            ContractHandler.Instance.HighlightDataTableRowByTextBoxClick(e, dataGridView_contract,
                textBox_contractImportMessages);
        }

        private void button_expand_Click(object sender, EventArgs e)
        {
            ContractHandler.Instance.ExpandCollapseFieldByButtonClick(sender, _expandStates, _expandButtons, tmrExpand);
        }

        private void tmrExpand_Tick(object sender, EventArgs e)
        {
            ContractHandler.Instance.ProcessExpandCollapseFieldForPanel(_expandPanels, _expandStates, ExpansionPerTick,
                tmrExpand);
        }

        private void WorkerFetcherDoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (dataGridView_contract != null && dataGridView_contract.RowCount > 1)
            {
                _errorRowCount = 0;

                //while validating, deactivate other buttons
                Invoke((MethodInvoker) (() => button_validate.Enabled = false));
                Invoke((MethodInvoker) (() => button_import.Enabled = false));
                Invoke((MethodInvoker) (() => button_clear.Enabled = false));
                Invoke((MethodInvoker) (() => button_contractSelectFile.Enabled = false));

                try
                {
                    foreach (DataGridViewRow _row in dataGridView_contract.Rows)
                    {
                        if (WorkerFetcher.CancellationPending)
                        {
                            break;
                        }

                        _isMappingFieldValueToIDCorrect = true;
                        _isFirstTimeInvalidMapping = true;

                        if (_row.DataBoundItem != null)
                        {
                            //ContractCreateModel _newProject = new ProjectCreateModel
                            //{
                            //    Name = ContractHandler.Instance.CheckAndGetString(dataGridView_contract, _projectName,
                            //        _row),
                            //    CustomerID = (int) MapFieldValueToID(_customerNo, _row, false),
                            //    ProjectTemplateID = (int) MapFieldValueToID(_projectTemplate, _row, false),
                            //    ProjectManagerID = (int) MapFieldValueToID(_projectManager, _row, false),
                            //    CurrencyID = (int) MapFieldValueToID(_currencyISO, _row, false),
                            //    LegalEntityID = (int) MapFieldValueToID(_legalEntity, _row, false),
                            //    ProjectNo = ProjectHandler.Instance.CheckAndGetString(dataGridView_contract, _projectNo,
                            //        _row),
                            //    Description =
                            //        ProjectHandler.Instance.CheckAndGetString(dataGridView_contract, _description,
                            //            _row),
                            //    ProjectStartDate =
                            //        ProjectHandler.Instance.CheckAndGetDate(dataGridView_contract, _projectStartDate,
                            //            _row),
                            //    ProjectEndDate =
                            //        ProjectHandler.Instance.CheckAndGetDate(dataGridView_contract, _projectEndDate,
                            //            _row),
                            //    ProjectTypeID = (int) MapFieldValueToID(_projectType, _row, false),
                            //    ProjectCategoryID = (int) MapFieldValueToID(_projectCategory, _row, false)
                            //};

                            //if (_isMappingFieldValueToIDCorrect)
                            //{
                            //    if (_senderButton.Name == button_validate.Name)
                            //    {
                            //        var _defaultApiResponse = ContractHandler.Instance.ValidateProject(_newProject,
                            //            AuthenticationHandler.Instance.Token, out var _businessRulesApiResponse);

                            //        _errorRowCount = ApiHelper.Instance.HandleApiResponse(_defaultApiResponse, _row,
                            //            _businessRulesApiResponse,
                            //            textBox_contractImportMessages, _errorRowCount, WorkerFetcher, this);
                            //    }
                            //    else
                            //    {

                            //        var _defaultApiResponse = ContractHandler.Instance.ImportContract(_newProject,
                            //            AuthenticationHandler.Instance.Token, out var _businessRulesApiResponse);

                            //        _errorRowCount = ApiHelper.Instance.HandleApiResponse(_defaultApiResponse, _row,
                            //            _businessRulesApiResponse,
                            //            textBox_contractImportMessages, _errorRowCount, WorkerFetcher, this);
                            //    }
                            //}
                        }
                    }

                    ContractHandler.Instance.DisplayErrorRowCountAndSuccessMessage(_errorRowCount, button_import,
                        button_validate, _senderButton, textBox_contractImportMessages, this);
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
                Invoke((MethodInvoker) (() => button_validate.Enabled = true));
                Invoke((MethodInvoker) (() => button_clear.Enabled = true));
                Invoke((MethodInvoker) (() => button_contractSelectFile.Enabled = true));
            }
        }

        #endregion

        #region Helper methods

        private void AddFileColumnHeaderToComboBox(object[] fileColumnHeaderArray)
        {
            comboBox_contractName.Items.AddRange(fileColumnHeaderArray);
            comboBox_contractOwnerInitials.Items.AddRange(fileColumnHeaderArray);
            comboBox_contractStatus.Items.AddRange(fileColumnHeaderArray);
            comboBox_projectNo.Items.AddRange(fileColumnHeaderArray);
            comboBox_contractBudgetTravelAmount.Items.AddRange(fileColumnHeaderArray);
            comboBox_contractBudgetWorkAmount.Items.AddRange(fileColumnHeaderArray);
            comboBox_contractBudgetWorkHour.Items.AddRange(fileColumnHeaderArray);
            comboBox_contractHasCompletionNotification.Items.AddRange(fileColumnHeaderArray);
        }

        private int? MapFieldValueToID(string columnName, DataGridViewRow row, bool isNullableField)
        {
            if (dataGridView_contract.Columns[columnName] != null)
            {
                var _fieldValue = ContractHandler.Instance.CheckAndGetString(dataGridView_contract, columnName, row);
                int _result = -1;

                if (columnName == _contractStatus)
                {
                    _result = ContractHandler.Instance.GetIDFromFieldValue(ContractStatusList, _fieldValue);
                }
                

                if (_result != -1)
                {
                    return _result;
                }

                //if can't match, display error message
                _errorRowCount = ContractHandler.Instance.HandleInvalidFieldValueToIDMapping(columnName, row,
                    _fieldValue, textBox_contractImportMessages,
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
            comboBox_contractName.ResetText();
            comboBox_contractName.Items.Clear();
            comboBox_projectNo.ResetText();
            comboBox_projectNo.Items.Clear();
            comboBox_contractStatus.ResetText();
            comboBox_contractStatus.Items.Clear();
            comboBox_contractOwnerInitials.ResetText();
            comboBox_contractOwnerInitials.Items.Clear();
            
            comboBox_contractBudgetExpensesAmount.ResetText();
            comboBox_contractBudgetExpensesAmount.Items.Clear();
            comboBox_contractBudgetTravelAmount.ResetText();
            comboBox_contractBudgetTravelAmount.Items.Clear();
            comboBox_contractBudgetWorkAmount.ResetText();
            comboBox_contractBudgetWorkAmount.Items.Clear();
            comboBox_contractBudgetWorkHour.ResetText();
            comboBox_contractBudgetWorkHour.Items.Clear();
            comboBox_contractHasCompletionNotification.ResetText();
            comboBox_contractHasCompletionNotification.Items.Clear();

            comboBox_contractCompletionNotificationPercentage.ResetText();
            comboBox_contractCompletionNotificationPercentage.Items.Clear();
            comboBox_contractIsMileageBillable.ResetText();
            comboBox_contractIsMileageBillable.Items.Clear();
            comboBox_contractIsDefaultExpenses.ResetText();
            comboBox_contractIsDefaultExpenses.Items.Clear();

            comboBox_contractHasBudgetOverrunNotification.ResetText();
            comboBox_contractHasBudgetOverrunNotification.Items.Clear();
            comboBox_contractTargetHourlyRate.ResetText();
            comboBox_contractTargetHourlyRate.Items.Clear();
            comboBox_contractPaymentPlanAmount.ResetText();
            comboBox_contractPaymentPlanAmount.Items.Clear();
            comboBox_contractRevenueExprAmount.ResetText();
            comboBox_contractRevenueExprAmount.Items.Clear();
            comboBox_contractRevenueTravelAmount.ResetText();
            comboBox_contractRevenueTravelAmount.Items.Clear();
            comboBox_contractIsExpensesLinked.ResetText();
            comboBox_contractIsExpensesLinked.Items.Clear();
            comboBox_contractIsTravelLinked.ResetText();
            comboBox_contractIsTravelLinked.Items.Clear();
        }

        private void ClearAndResetAllCheckBoxes()
        {
            checkBox_defaultContractStatus.Checked = false;
            checkBox_defaultContractHasCompletionNotification.Checked = false;
        }

        #endregion


        #region Get default values from API

        private void GetAllContractModelsFromApi()
        {
            var _apiResponse = ContractHandler.Instance.GetAllContractModels(AuthenticationHandler.Instance.Token);

            if (_apiResponse != null)
            {
                foreach (var _contractModel in _apiResponse)
                {
                    ContractModels.Add(new KeyValuePair<int, string>(_contractModel.ContractModelID, _contractModel.Name));
                }
            }
        }

        #endregion


        #region Combobox implementations

        private void comboBox_contractName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContractHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_contract,
                _contractTable, comboBox_contractName, _contractName);
        }

        private void comboBox_projectNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContractHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_contract,
                _contractTable, comboBox_projectNo, _projectNo);
        }

        private void comboBox_contractStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContractHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_contract,
                _contractTable, comboBox_contractStatus, _contractStatus, checkBox_defaultContractStatus);
        }

        private void comboBox_contractOwnerInitials_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContractHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_contract,
                _contractTable, comboBox_contractOwnerInitials, _contractOwnerInitials);
        }

        private void comboBox_ContractModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContractHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_contract,
                _contractTable, comboBox_ContractModel, _contractModel,
                checkBox_defaultContractModel);
        }

        private void comboBox_contractBudgetExpensesAmount_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContractHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_contract,
                _contractTable, comboBox_contractBudgetExpensesAmount, _budgetExpensesAmount);
        }

        private void comboBox_contractBudgetTravelAmount_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContractHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_contract,
                _contractTable, comboBox_contractBudgetTravelAmount, _budgetTravelAmount);
        }

        private void comboBox_contractBudgetWorkAmount_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContractHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_contract,
                _contractTable, comboBox_contractBudgetWorkAmount, _budgetWorkAmount);
        }

        private void comboBox_contractBudgetWorkHour_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContractHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_contract,
                _contractTable, comboBox_contractBudgetWorkHour, _budgetWorkHour);
        }

        private void comboBox_contractHasCompletionNotification_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContractHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_contract,
                _contractTable, comboBox_contractHasCompletionNotification, _completionNotification,
                checkBox_defaultContractHasCompletionNotification);
        }


        private void comboBox_contractCompletionNotificationPercentage_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContractHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_contract,
                _contractTable, comboBox_contractCompletionNotificationPercentage, _completionNotificationPercentage,
                checkBox_defaultContractCompletionNotificationPercentage);
        }

        private void comboBox_contractIsMileageBillable_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContractHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_contract,
                _contractTable, comboBox_contractIsMileageBillable, _isMileageBillable,
                checkBox_defaultContractIsMileageBillable);
        }

        private void comboBox_contractIsDefaultExpenses_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContractHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_contract,
                _contractTable, comboBox_contractIsDefaultExpenses, _isDefaultExpenses,
                checkBox_defaultContractIsDefaultExpenses);
        }

        private void comboBox_contractHasBudgetOverrunNotification_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContractHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_contract,
                _contractTable, comboBox_contractHasBudgetOverrunNotification, _budgetOverrunNotification,
                checkBox_defaultContractHasBudgetOverrunNotification);
        }

        private void comboBox_contractTargetHourlyRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContractHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_contract,
                _contractTable, comboBox_contractTargetHourlyRate, _targetHourlyRate);
        }

        private void comboBox_contractPaymentPlanAmount_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContractHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_contract,
                _contractTable, comboBox_contractPaymentPlanAmount, _paymentPlanAmount);
        }

        private void comboBox_contractRevenueExprAmount_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContractHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_contract,
                _contractTable, comboBox_contractRevenueExprAmount, _revenueExprAmount);
        }

        private void comboBox_contractRevenueTravelAmount_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContractHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_contract,
                _contractTable, comboBox_contractRevenueTravelAmount, _revenueTravelAmount);
        }

        private void comboBox_contractIsExpensesLinked_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContractHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_contract,
                _contractTable, comboBox_contractIsExpensesLinked, _isExpensesLinked,
                checkBox_defaultContractIsExpensesLinked);
        }

        private void comboBox_contractIsTravelLinked_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContractHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_contract,
                _contractTable, comboBox_contractIsTravelLinked, _isTravelLinked,
                checkBox_defaultContractIsTravelLinked);
        }
        

        #endregion


        #region Checkbox implementations

        private void checkBox_defaultContractStatus_CheckedChanged(object sender, EventArgs e)
        {
            ContractHandler.Instance.MapValuesToComboBoxByCheckboxStatus(dataGridView_contract, _contractTable,
                comboBox_contractStatus,
                _contractStatus, checkBox_defaultContractStatus, ContractStatusList,
                ContractHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());
        }

        private void checkBox_defaultContractModel_CheckedChanged(object sender, EventArgs e)
        {
            ContractHandler.Instance.MapValuesToComboBoxByCheckboxStatus(dataGridView_contract, _contractTable,
                comboBox_ContractModel,
                _contractModel, checkBox_defaultContractModel, ContractModels,
                ContractHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());
        }

        private void checkBox_defaultContractHasCompletionNotification_CheckedChanged(object sender, EventArgs e)
        {
            ContractHandler.Instance.MapNonKeyValuePairToComboBoxByCheckboxStatus(dataGridView_contract, _contractTable,
                comboBox_contractHasCompletionNotification,
                _completionNotification, checkBox_defaultContractHasCompletionNotification,
                HasCompletionNotificationList, ContractHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());
        }

        private void checkBox_defaultContractCompletionNotificationPercentage_CheckedChanged(object sender, EventArgs e)
        {
            ContractHandler.Instance.MapNonKeyValuePairToComboBoxByCheckboxStatus(dataGridView_contract, _contractTable,
                comboBox_contractCompletionNotificationPercentage,
                _completionNotificationPercentage, checkBox_defaultContractCompletionNotificationPercentage,
                CompletionNotificationPercentageList,
                ContractHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());
        }

        private void checkBox_defaultContractIsMileageBillable_CheckedChanged(object sender, EventArgs e)
        {
            ContractHandler.Instance.MapNonKeyValuePairToComboBoxByCheckboxStatus(dataGridView_contract, _contractTable,
                comboBox_contractIsMileageBillable,
                _isMileageBillable, checkBox_defaultContractIsMileageBillable, IsMileageBillable,
                ContractHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());
        }

        private void checkBox_defaultContractIsDefaultExpenses_CheckedChanged(object sender, EventArgs e)
        {
            ContractHandler.Instance.MapNonKeyValuePairToComboBoxByCheckboxStatus(dataGridView_contract, _contractTable,
                comboBox_contractIsDefaultExpenses,
                _isDefaultExpenses, checkBox_defaultContractIsDefaultExpenses, IsDefaultExpenses,
                ContractHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());
        }

        private void checkBox_defaultContractHasBudgetOverrunNotification_CheckedChanged(object sender, EventArgs e)
        {
            ContractHandler.Instance.MapNonKeyValuePairToComboBoxByCheckboxStatus(dataGridView_contract, _contractTable,
                comboBox_contractHasBudgetOverrunNotification,
                _budgetOverrunNotification, checkBox_defaultContractHasBudgetOverrunNotification,
                HasBudgetOverrunNotification, ContractHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());
        }

        private void checkBox_defaultContractIsExpensesLinked_CheckedChanged(object sender, EventArgs e)
        {
            ContractHandler.Instance.MapNonKeyValuePairToComboBoxByCheckboxStatus(dataGridView_contract, _contractTable,
                comboBox_contractIsExpensesLinked,
                _isExpensesLinked, checkBox_defaultContractIsExpensesLinked, IsExpensesLinked,
                ContractHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());
        }

        private void checkBox_defaultContractIsTravelLinked_CheckedChanged(object sender, EventArgs e)
        {
            ContractHandler.Instance.MapNonKeyValuePairToComboBoxByCheckboxStatus(dataGridView_contract, _contractTable,
                comboBox_contractIsTravelLinked,
                _isTravelLinked, checkBox_defaultContractIsTravelLinked, IsTravelLinked,
                ContractHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());
        }


        #endregion

        
    }
}