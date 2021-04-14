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
            {0, "Contract Name"},
            {1, "Project No"},
            {2, "Contract Status Name"},
            {3, "Contract Owner Initials"},
            {4, "Contract Model"},
        };

        //all column header variables
        private readonly string _contractName = "Contract Name";
        private readonly string _projectNo = "Project No";
        private readonly string _contractStatus = "Contract Status Name";
        private readonly string _contractOwnerInitials = "Contract Owner Initials";
        private readonly string _contractModel = "Contract Model";
        private readonly string _budgetExpensesAmount = "Budget Expenses Amount";
        private readonly string _budgetTravelAmount = "Budget Travel Amount";
        private readonly string _budgetWorkAmount = "Budget Work Amount";
        private readonly string _budgetWorkHour = "Budget Work Hours";
        private readonly string _completionNotification = "Has Completion Notification";
        private readonly string _completionNotificationPercentage = "Completion Notification %";
        private readonly string _isMileageBillable = "Is Mileage Billable";
        private readonly string _isDefaultExpenses = "Is Default Expenses";
        private readonly string _budgetOverrunNotification = "Has Budget Overrun Notification";
        private readonly string _isFixedHourlyRate = "Is Fixed Hourly Rate";
        private readonly string _hourlyRateName = "Hourly Rate Name";
        private readonly string _targetHourlyRate = "Target Hourly Rate";
        private readonly string _paymentPlanAmount = "Payment Plan Amount";
        private readonly string _revenueExpensesAmount = "Revenue Expenses Amount";
        private readonly string _revenueTravelAmount = "Revenue Travel Amount";
        private readonly string _isExpensesLinked = "Is Expenses Linked";
        private readonly string _isTravelLinked = "Is Travel Linked";



        //default value lists from API 
        private static readonly List<KeyValuePair<int, string>> ContractModelList = new List<KeyValuePair<int, string>>();
        private static readonly List<KeyValuePair<int, string>> ProjectList = new List<KeyValuePair<int, string>>();
        private static readonly List<KeyValuePair<int, string>> ContractOwnerList = new List<KeyValuePair<int, string>>();

        private static readonly List<KeyValuePair<int, string>> ContractStatusList =
            new List<KeyValuePair<int, string>>()
            {
                new KeyValuePair<int, string>(1, "Quotation"),
                new KeyValuePair<int, string>(2, "Active"),
                new KeyValuePair<int, string>(3, "Completed"),
                new KeyValuePair<int, string>(4, "Cancelled")
            };

        private static readonly List<string> HasCompletionNotificationList = new List<string> {"true", "false"};
        private static readonly List<string> IsMileageBillableList = new List<string> {"true", "false"};
        private static readonly List<string> IsDefaultExpensesList = new List<string> {"true", "false"};
        private static readonly List<string> HasBudgetOverrunNotificationList = new List<string> {"true", "false"};
        private static readonly List<string> IsExpensesLinkedList = new List<string> {"true", "false"};
        private static readonly List<string> IsTravelLinkedList = new List<string> {"true", "false"};
        private static readonly List<string> IsFixedHourlyRateList = new List<string> {"true", "false"};

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
            GetAllProjectsFromApi();
            GetAllContractOwnersFromApi();


            
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
                }

                _contractTable = _fileContent.Copy();
                dataGridView_contract.DataSource = _contractTable;


                AddFileColumnHeaderToComboBox(ContractHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());


                ContractHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_contractName, _contractName);
                ContractHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_projectNo, _projectNo);
                ContractHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_contractStatus, _contractStatus);
                ContractHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_contractOwnerInitials, _contractOwnerInitials);
                ContractHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_ContractModel, _contractModel);
                ContractHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_contractBudgetExpensesAmount, _budgetExpensesAmount);
                ContractHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_contractBudgetTravelAmount, _budgetTravelAmount);
                ContractHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_contractBudgetWorkAmount, _budgetWorkAmount);
                ContractHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_contractBudgetWorkHour, _budgetWorkHour);
                ContractHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_contractHasCompletionNotification, _completionNotification);
                ContractHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_contractCompletionNotificationPercentage, _completionNotificationPercentage);
                ContractHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_contractIsMileageBillable, _isMileageBillable);
                ContractHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_contractIsDefaultExpenses, _isDefaultExpenses);
                ContractHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_contractHasBudgetOverrunNotification, _budgetOverrunNotification);
                ContractHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_contractTargetHourlyRate, _targetHourlyRate);
                ContractHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_contractPaymentPlanAmount, _paymentPlanAmount);
                ContractHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_contractRevenueExpensesAmount, _revenueExpensesAmount);
                ContractHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_contractRevenueTravelAmount, _revenueTravelAmount);
                ContractHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_contractIsExpensesLinked, _isExpensesLinked);
                ContractHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_contractIsTravelLinked, _isTravelLinked);
                ContractHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_contractHourlyRateName, _hourlyRateName);
                ContractHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_contractIsFixedHourlyRate, _isFixedHourlyRate);

                this.comboBox_contractIsFixedHourlyRate.SelectedIndexChanged += new System.EventHandler(this.comboBox_contractIsFixedHourlyRate_SelectedIndexChanged);
                this.comboBox_contractHourlyRateName.SelectedIndexChanged += new System.EventHandler(this.comboBox_contractHourlyRateName_SelectedIndexChanged);
                this.comboBox_contractIsTravelLinked.SelectedIndexChanged += new System.EventHandler(this.comboBox_contractIsTravelLinked_SelectedIndexChanged);
                this.comboBox_contractIsExpensesLinked.SelectedIndexChanged += new System.EventHandler(this.comboBox_contractIsExpensesLinked_SelectedIndexChanged);
                this.comboBox_contractRevenueTravelAmount.SelectedIndexChanged += new System.EventHandler(this.comboBox_contractRevenueTravelAmount_SelectedIndexChanged);
                this.comboBox_contractRevenueExpensesAmount.SelectedIndexChanged += new System.EventHandler(this.comboBox_contractRevenueExpensesAmount_SelectedIndexChanged);
                this.comboBox_contractPaymentPlanAmount.SelectedIndexChanged += new System.EventHandler(this.comboBox_contractPaymentPlanAmount_SelectedIndexChanged);
                this.comboBox_contractTargetHourlyRate.SelectedIndexChanged += new System.EventHandler(this.comboBox_contractTargetHourlyRate_SelectedIndexChanged);
                this.comboBox_contractHasBudgetOverrunNotification.SelectedIndexChanged += new System.EventHandler(this.comboBox_contractHasBudgetOverrunNotification_SelectedIndexChanged);
                this.comboBox_contractIsDefaultExpenses.SelectedIndexChanged += new System.EventHandler(this.comboBox_contractIsDefaultExpenses_SelectedIndexChanged);
                this.comboBox_contractIsMileageBillable.SelectedIndexChanged += new System.EventHandler(this.comboBox_contractIsMileageBillable_SelectedIndexChanged);
                this.comboBox_contractCompletionNotificationPercentage.SelectedIndexChanged += new System.EventHandler(this.comboBox_contractCompletionNotificationPercentage_SelectedIndexChanged);
                this.comboBox_contractBudgetExpensesAmount.SelectedIndexChanged += new System.EventHandler(this.comboBox_contractBudgetExpensesAmount_SelectedIndexChanged);
                this.comboBox_contractBudgetTravelAmount.SelectedIndexChanged += new System.EventHandler(this.comboBox_contractBudgetTravelAmount_SelectedIndexChanged);
                this.comboBox_contractHasCompletionNotification.SelectedIndexChanged += new System.EventHandler(this.comboBox_contractHasCompletionNotification_SelectedIndexChanged);
                this.comboBox_contractBudgetWorkAmount.SelectedIndexChanged += new System.EventHandler(this.comboBox_contractBudgetWorkAmount_SelectedIndexChanged);
                this.comboBox_contractBudgetWorkHour.SelectedIndexChanged += new System.EventHandler(this.comboBox_contractBudgetWorkHour_SelectedIndexChanged);
                this.comboBox_ContractModel.SelectedIndexChanged += new System.EventHandler(this.comboBox_ContractModel_SelectedIndexChanged);
                this.comboBox_projectNo.SelectedIndexChanged += new System.EventHandler(this.comboBox_projectNo_SelectedIndexChanged);
                this.comboBox_contractOwnerInitials.SelectedIndexChanged += new System.EventHandler(this.comboBox_contractOwnerInitials_SelectedIndexChanged);
                this.comboBox_contractStatus.SelectedIndexChanged += new System.EventHandler(this.comboBox_contractStatus_SelectedIndexChanged);
                this.comboBox_contractName.SelectedIndexChanged += new System.EventHandler(this.comboBox_contractName_SelectedIndexChanged);

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

            InitializeAllDefaultValues();
        }

        private void textBox_projectImportMessages_MouseClick(object sender, MouseEventArgs e)
        {
            ContractHandler.Instance.HighlightDataTableRowByTextBoxClick(e, dataGridView_contract, textBox_contractImportMessages);
        }

        private void button_expand_Click(object sender, EventArgs e)
        {
            ContractHandler.Instance.ExpandCollapseFieldByButtonClick(sender, _expandStates, _expandButtons, tmrExpand);
        }

        private void tmrExpand_Tick(object sender, EventArgs e)
        {
            ContractHandler.Instance.ProcessExpandCollapseFieldForPanel(_expandPanels, _expandStates, ExpansionPerTick, tmrExpand);
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

                Invoke((MethodInvoker)(() => textBox_contractImportMessages.AppendText("Start time: " + DateTime.Now)));

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
                            ProjectSubContractCreateModelBase _newBaseContract = new ProjectSubContractCreateModelBase
                            {
                                ProjectID = (int)MapFieldValueToID(_projectNo, _row, false),
                                ContractName = ContractHandler.Instance.CheckAndGetString(dataGridView_contract, _contractName, _row),
                                IsMileageBillable = ContractHandler.Instance.CheckAndGetBoolean(dataGridView_contract, _isMileageBillable, _row),
                                IsDefaultExpenses = ContractHandler.Instance.CheckAndGetBoolean(dataGridView_contract, _isDefaultExpenses, _row),
                                ContractOwnerUserID = (int)MapFieldValueToID(_contractOwnerInitials, _row, false),
                                BudgetWorkHour = ContractHandler.Instance.CheckAndGetDouble(dataGridView_contract, _budgetWorkHour, _row ),
                                BudgetWorkAmount = ContractHandler.Instance.CheckAndGetDouble(dataGridView_contract, _budgetWorkAmount, _row),
                                ContractStatus = (ProjectSubContractStatus)MapFieldValueToID(_contractStatus, _row, false),
                                ContractModelType = (ContractModelType)MapFieldValueToID(_contractModel, _row, false),
                            };

                            switch (_newBaseContract.ContractModelType)
                            {
                                case ContractModelType.TimeMaterialBasic:
                                    TimeMaterialBasicContractCreateModel _timeMaterialBasicContractCreateModel= new TimeMaterialBasicContractCreateModel(_newBaseContract);
                                    
                                    // Specifics for TimeMaterialBasic contract model
                                    _timeMaterialBasicContractCreateModel.HasCompletionNotification = ContractHandler.Instance.CheckAndGetBoolean(dataGridView_contract, _completionNotification, _row);
                                    _timeMaterialBasicContractCreateModel.CompletionNotificationPercentage = ContractHandler.Instance.CheckAndGetDouble(dataGridView_contract, _completionNotificationPercentage, _row);
                                    _timeMaterialBasicContractCreateModel.HasBudgetOverrunNotification = ContractHandler.Instance.CheckAndGetBoolean(dataGridView_contract, _budgetOverrunNotification, _row);
                                    _timeMaterialBasicContractCreateModel.BudgetTravelAmount = ContractHandler.Instance.CheckAndGetDouble(dataGridView_contract, _budgetTravelAmount, _row);
                                    _timeMaterialBasicContractCreateModel.BudgetExpensesAmount = ContractHandler.Instance.CheckAndGetDouble(dataGridView_contract, _budgetExpensesAmount, _row);

                                    if (_isMappingFieldValueToIDCorrect)
                                    {
                                        if (_senderButton.Name == button_validate.Name)
                                        {
                                            var _defaultApiResponse = ContractHandler.Instance.ValidateTimeMaterialBasicContract(_timeMaterialBasicContractCreateModel, AuthenticationHandler.Instance.Token, out var _businessRulesApiResponse);
                                            _errorRowCount = ApiHelper.Instance.HandleApiResponse(_defaultApiResponse, _row, _businessRulesApiResponse, textBox_contractImportMessages, _errorRowCount, WorkerFetcher, this);
                                        }
                                        else
                                        {
                                            var _defaultApiResponse = ContractHandler.Instance.ImportTimeMaterialBasicContract(_timeMaterialBasicContractCreateModel, AuthenticationHandler.Instance.Token, out var _businessRulesApiResponse);
                                            _errorRowCount = ApiHelper.Instance.HandleApiResponse(_defaultApiResponse, _row, _businessRulesApiResponse, textBox_contractImportMessages, _errorRowCount, WorkerFetcher, this);
                                        }
                                    }

                                    break;

                                case ContractModelType.FixedPriceBasic:
                                    FixedPriceBasicContractCreateModel _fixedPriceBasicContractCreateModel = new FixedPriceBasicContractCreateModel(_newBaseContract);

                                    // Specifics for FixedPriceBasic contract model
                                    _fixedPriceBasicContractCreateModel.IsExpensesLinked = ContractHandler.Instance.CheckAndGetBoolean(dataGridView_contract, _isExpensesLinked, _row);
                                    _fixedPriceBasicContractCreateModel.IsTravelLinked = ContractHandler.Instance.CheckAndGetBoolean(dataGridView_contract, _isTravelLinked, _row);
                                    _fixedPriceBasicContractCreateModel.PaymentPlanAmount = ContractHandler.Instance.CheckAndGetDouble(dataGridView_contract, _paymentPlanAmount, _row);
                                    _fixedPriceBasicContractCreateModel.RevenueExpensesAmount = ContractHandler.Instance.CheckAndGetDouble(dataGridView_contract, _revenueExpensesAmount, _row);
                                    _fixedPriceBasicContractCreateModel.RevenueTravelAmount = ContractHandler.Instance.CheckAndGetDouble(dataGridView_contract, _revenueTravelAmount, _row);
                                    _fixedPriceBasicContractCreateModel.HasCompletionNotification = ContractHandler.Instance.CheckAndGetBoolean(dataGridView_contract, _completionNotification, _row);
                                    _fixedPriceBasicContractCreateModel.CompletionNotificationPercentage = ContractHandler.Instance.CheckAndGetDouble(dataGridView_contract, _completionNotificationPercentage, _row);
                                    _fixedPriceBasicContractCreateModel.BudgetTravelAmount = ContractHandler.Instance.CheckAndGetDouble(dataGridView_contract, _budgetTravelAmount, _row);
                                    _fixedPriceBasicContractCreateModel.BudgetExpensesAmount = ContractHandler.Instance.CheckAndGetDouble(dataGridView_contract, _budgetExpensesAmount, _row);
                                    _fixedPriceBasicContractCreateModel.TargetHourlyRate = ContractHandler.Instance.CheckAndGetDouble(dataGridView_contract, _targetHourlyRate, _row);

                                    if (_isMappingFieldValueToIDCorrect)
                                    {
                                        if (_senderButton.Name == button_validate.Name)
                                        {
                                            var _defaultApiResponse = ContractHandler.Instance.ValidateFixedPriceBasicContract(_fixedPriceBasicContractCreateModel, AuthenticationHandler.Instance.Token, out var _businessRulesApiResponse);
                                            _errorRowCount = ApiHelper.Instance.HandleApiResponse(_defaultApiResponse, _row, _businessRulesApiResponse, textBox_contractImportMessages, _errorRowCount, WorkerFetcher, this);
                                        }
                                        else
                                        {
                                            var _defaultApiResponse = ContractHandler.Instance.ImportFixedPriceBasicContract(_fixedPriceBasicContractCreateModel, AuthenticationHandler.Instance.Token, out var _businessRulesApiResponse);
                                            _errorRowCount = ApiHelper.Instance.HandleApiResponse(_defaultApiResponse, _row, _businessRulesApiResponse, textBox_contractImportMessages, _errorRowCount, WorkerFetcher, this);
                                        }
                                    }

                                    break;


                                case ContractModelType.TimeMaterialAccountEndBalancing:
                                    TimeMaterialAccountEndBalancingContractCreateModel _timeMaterialAccountEndBalancingContractCreateModel = new TimeMaterialAccountEndBalancingContractCreateModel(_newBaseContract);

                                    // Specifics for TimeMaterialAccountEndBalancing contract model
                                    _timeMaterialAccountEndBalancingContractCreateModel.HasCompletionNotification = ContractHandler.Instance.CheckAndGetBoolean(dataGridView_contract, _completionNotification, _row);
                                    _timeMaterialAccountEndBalancingContractCreateModel.CompletionNotificationPercentage = ContractHandler.Instance.CheckAndGetDouble(dataGridView_contract, _completionNotificationPercentage, _row);
                                    _timeMaterialAccountEndBalancingContractCreateModel.HasBudgetOverrunNotification = ContractHandler.Instance.CheckAndGetBoolean(dataGridView_contract, _budgetOverrunNotification, _row);
                                    _timeMaterialAccountEndBalancingContractCreateModel.BudgetTravelAmount = ContractHandler.Instance.CheckAndGetDouble(dataGridView_contract, _budgetTravelAmount, _row);
                                    _timeMaterialAccountEndBalancingContractCreateModel.BudgetExpensesAmount = ContractHandler.Instance.CheckAndGetDouble(dataGridView_contract, _budgetExpensesAmount, _row);

                                    if (_isMappingFieldValueToIDCorrect)
                                    {
                                        if (_senderButton.Name == button_validate.Name)
                                        {
                                            var _defaultApiResponse = ContractHandler.Instance.ValidateTimeMaterialAccountEndBalancingContract(_timeMaterialAccountEndBalancingContractCreateModel, AuthenticationHandler.Instance.Token, out var _businessRulesApiResponse);
                                            _errorRowCount = ApiHelper.Instance.HandleApiResponse(_defaultApiResponse, _row, _businessRulesApiResponse, textBox_contractImportMessages, _errorRowCount, WorkerFetcher, this);
                                        }
                                        else
                                        {
                                            var _defaultApiResponse = ContractHandler.Instance.ImportTimeMaterialAccountEndBalancingContract(_timeMaterialAccountEndBalancingContractCreateModel, AuthenticationHandler.Instance.Token, out var _businessRulesApiResponse);
                                            _errorRowCount = ApiHelper.Instance.HandleApiResponse(_defaultApiResponse, _row, _businessRulesApiResponse, textBox_contractImportMessages, _errorRowCount, WorkerFetcher, this);
                                        }
                                    }
                                    break;

                                case ContractModelType.PrepaidServices:
                                    PrepaidServicesContractCreateModel _prepaidServicesContractCreateModel = new PrepaidServicesContractCreateModel(_newBaseContract);

                                    // Specifics for PrepaidServices contract model
                                    _prepaidServicesContractCreateModel.HasCompletionNotification = ContractHandler.Instance.CheckAndGetBoolean(dataGridView_contract, _completionNotification, _row);
                                    _prepaidServicesContractCreateModel.CompletionNotificationPercentage = ContractHandler.Instance.CheckAndGetDouble(dataGridView_contract, _completionNotificationPercentage, _row);
                                    _prepaidServicesContractCreateModel.IsFixedHourlyRate = ContractHandler.Instance.CheckAndGetBoolean(dataGridView_contract, _isFixedHourlyRate, _row);
                                    _prepaidServicesContractCreateModel.HourlyRatePrice = ContractHandler.Instance.CheckAndGetDouble(dataGridView_contract, _targetHourlyRate, _row);
                                    _prepaidServicesContractCreateModel.HourlyRateName = ContractHandler.Instance.CheckAndGetString(dataGridView_contract, _hourlyRateName, _row);


                                    if (_isMappingFieldValueToIDCorrect)
                                    {
                                        if (_senderButton.Name == button_validate.Name)
                                        {
                                            var _defaultApiResponse = ContractHandler.Instance.ValidatePrepaidServicesContract(_prepaidServicesContractCreateModel, AuthenticationHandler.Instance.Token, out var _businessRulesApiResponse);
                                            _errorRowCount = ApiHelper.Instance.HandleApiResponse(_defaultApiResponse, _row, _businessRulesApiResponse, textBox_contractImportMessages, _errorRowCount, WorkerFetcher, this);
                                        }
                                        else
                                        {
                                            var _defaultApiResponse = ContractHandler.Instance.ImportPrepaidServicesContract(_prepaidServicesContractCreateModel, AuthenticationHandler.Instance.Token, out var _businessRulesApiResponse);
                                            _errorRowCount = ApiHelper.Instance.HandleApiResponse(_defaultApiResponse, _row, _businessRulesApiResponse, textBox_contractImportMessages, _errorRowCount, WorkerFetcher, this);
                                        }
                                    }
                                    break;


                                case ContractModelType.TaskDrivenRevenue:
                                    TaskDrivenRevenueContractCreateModel _taskDrivenRevenueContractCreateModel = new TaskDrivenRevenueContractCreateModel(_newBaseContract);

                                    // Specifics for TaskDrivenRevenue contract model
                                    _taskDrivenRevenueContractCreateModel.IsExpensesLinked = ContractHandler.Instance.CheckAndGetBoolean(dataGridView_contract, _isExpensesLinked, _row);
                                    _taskDrivenRevenueContractCreateModel.IsTravelLinked = ContractHandler.Instance.CheckAndGetBoolean(dataGridView_contract, _isTravelLinked, _row);
                                    _taskDrivenRevenueContractCreateModel.PaymentPlanAmount = ContractHandler.Instance.CheckAndGetDouble(dataGridView_contract, _paymentPlanAmount, _row);
                                    _taskDrivenRevenueContractCreateModel.RevenueExpensesAmount = ContractHandler.Instance.CheckAndGetDouble(dataGridView_contract, _revenueExpensesAmount, _row);
                                    _taskDrivenRevenueContractCreateModel.RevenueTravelAmount = ContractHandler.Instance.CheckAndGetDouble(dataGridView_contract, _revenueTravelAmount, _row);
                                    _taskDrivenRevenueContractCreateModel.HasCompletionNotification = ContractHandler.Instance.CheckAndGetBoolean(dataGridView_contract, _completionNotification, _row);
                                    _taskDrivenRevenueContractCreateModel.CompletionNotificationPercentage = ContractHandler.Instance.CheckAndGetDouble(dataGridView_contract, _completionNotificationPercentage, _row);
                                    _taskDrivenRevenueContractCreateModel.BudgetTravelAmount = ContractHandler.Instance.CheckAndGetDouble(dataGridView_contract, _budgetTravelAmount, _row);
                                    _taskDrivenRevenueContractCreateModel.BudgetExpensesAmount = ContractHandler.Instance.CheckAndGetDouble(dataGridView_contract, _budgetExpensesAmount, _row);
                                    _taskDrivenRevenueContractCreateModel.TargetHourlyRate = ContractHandler.Instance.CheckAndGetDouble(dataGridView_contract, _targetHourlyRate, _row);

                                    if (_isMappingFieldValueToIDCorrect)
                                    {
                                        if (_senderButton.Name == button_validate.Name)
                                        {
                                            var _defaultApiResponse = ContractHandler.Instance.ValidateTaskDrivenRevenueContract(_taskDrivenRevenueContractCreateModel, AuthenticationHandler.Instance.Token, out var _businessRulesApiResponse);
                                            _errorRowCount = ApiHelper.Instance.HandleApiResponse(_defaultApiResponse, _row, _businessRulesApiResponse, textBox_contractImportMessages, _errorRowCount, WorkerFetcher, this);
                                        }
                                        else
                                        {
                                            var _defaultApiResponse = ContractHandler.Instance.ImportTaskDrivenRevenueContract(_taskDrivenRevenueContractCreateModel, AuthenticationHandler.Instance.Token, out var _businessRulesApiResponse);
                                            _errorRowCount = ApiHelper.Instance.HandleApiResponse(_defaultApiResponse, _row, _businessRulesApiResponse, textBox_contractImportMessages, _errorRowCount, WorkerFetcher, this);
                                        }
                                    } 
                                    break;
                            }
                        }
                    }

                    ContractHandler.Instance.DisplayErrorRowCountAndSuccessMessage(_errorRowCount, button_import, button_validate, _senderButton, textBox_contractImportMessages, this);
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
            comboBox_ContractModel.Items.AddRange(fileColumnHeaderArray);
            comboBox_contractStatus.Items.AddRange(fileColumnHeaderArray);
            comboBox_projectNo.Items.AddRange(fileColumnHeaderArray);
            comboBox_contractBudgetExpensesAmount.Items.AddRange(fileColumnHeaderArray);
            comboBox_contractBudgetTravelAmount.Items.AddRange(fileColumnHeaderArray);
            comboBox_contractBudgetWorkAmount.Items.AddRange(fileColumnHeaderArray);
            comboBox_contractBudgetWorkHour.Items.AddRange(fileColumnHeaderArray);
            comboBox_contractHasCompletionNotification.Items.AddRange(fileColumnHeaderArray);
            comboBox_contractCompletionNotificationPercentage.Items.AddRange(fileColumnHeaderArray);
            comboBox_contractIsMileageBillable.Items.AddRange(fileColumnHeaderArray);
            comboBox_contractIsDefaultExpenses.Items.AddRange(fileColumnHeaderArray);
            comboBox_contractHasBudgetOverrunNotification.Items.AddRange(fileColumnHeaderArray);
            comboBox_contractIsFixedHourlyRate.Items.AddRange(fileColumnHeaderArray);
            comboBox_contractHourlyRateName.Items.AddRange(fileColumnHeaderArray);
            comboBox_contractTargetHourlyRate.Items.AddRange(fileColumnHeaderArray);
            comboBox_contractPaymentPlanAmount.Items.AddRange(fileColumnHeaderArray);
            comboBox_contractRevenueExpensesAmount.Items.AddRange(fileColumnHeaderArray);
            comboBox_contractRevenueTravelAmount.Items.AddRange(fileColumnHeaderArray);
            comboBox_contractIsExpensesLinked.Items.AddRange(fileColumnHeaderArray);
            comboBox_contractIsTravelLinked.Items.AddRange(fileColumnHeaderArray);
        }

        private int? MapFieldValueToID(string columnName, DataGridViewRow row, bool isNullableField)
        {
            if (dataGridView_contract.Columns[columnName] != null)
            {
                var _fieldValue = ContractHandler.Instance.CheckAndGetString(dataGridView_contract, columnName, row);
                int _result = -1;

                if (columnName == _projectNo)
                {
                    _result = ContractHandler.Instance.GetIDFromFieldValue(ProjectList, _fieldValue);
                }
                else if (columnName == _contractStatus)
                {
                    _result = ContractHandler.Instance.GetIDFromFieldValue(ContractStatusList, _fieldValue);
                }
                else if (columnName == _contractOwnerInitials)
                {
                    _result = ContractHandler.Instance.GetIDFromFieldValue(ContractOwnerList, _fieldValue);
                }
                else if (columnName == _contractModel)
                {
                    _result = ContractHandler.Instance.GetIDFromFieldValue(ContractModelList, _fieldValue);
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
                _errorRowCount = ContractHandler.Instance.HandleInvalidFieldValueToIDMapping(columnName, row,
                    _fieldValue, textBox_contractImportMessages,
                    WorkerFetcher, this, _isFirstTimeInvalidMapping, _errorRowCount);
                _isMappingFieldValueToIDCorrect = false;
                _isFirstTimeInvalidMapping = false;
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
            comboBox_ContractModel.ResetText();
            comboBox_ContractModel.Items.Clear();

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
            comboBox_contractIsFixedHourlyRate.ResetText();
            comboBox_contractIsFixedHourlyRate.Items.Clear();
            comboBox_contractHourlyRateName.ResetText();
            comboBox_contractHourlyRateName.Items.Clear();
            comboBox_contractTargetHourlyRate.ResetText();
            comboBox_contractTargetHourlyRate.Items.Clear();
            comboBox_contractPaymentPlanAmount.ResetText();
            comboBox_contractPaymentPlanAmount.Items.Clear();
            comboBox_contractRevenueExpensesAmount.ResetText();
            comboBox_contractRevenueExpensesAmount.Items.Clear();
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
            checkBox_defaultContractModel.Checked = false;
            checkBox_defaultContractHasCompletionNotification.Checked = false;
            checkBox_defaultContractCompletionNotificationPercentage.Checked = false;
            checkBox_defaultContractIsMileageBillable.Checked = false;
            checkBox_defaultContractIsDefaultExpenses.Checked = false;
            checkBox_defaultContractIsFixedHourlyRate.Checked = false;
            checkBox_defaultContractIsExpensesLinked.Checked = false;
            checkBox_defaultContractIsTravelLinked.Checked = false;
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
                    ContractModelList.Add(new KeyValuePair<int, string>(_contractModel.ContractModelID, _contractModel.Name));
                }
            }
        }

        private void GetAllProjectsFromApi()
        {
            var _apiResponse = ContractHandler.Instance.GetAllProject(AuthenticationHandler.Instance.Token);

            if (_apiResponse != null)
            {
                foreach (var _project in _apiResponse)
                {
                    ProjectList.Add(new KeyValuePair<int, string>(_project.ProjectID, _project.No));
                }
            }
        }

        private void GetAllContractOwnersFromApi()
        {
            var _apiResponse = ContractHandler.Instance.GetAllEmployee(AuthenticationHandler.Instance.Token);

            if (_apiResponse != null)
            {
                foreach (var _employee in _apiResponse)
                {
                    ContractOwnerList.Add(new KeyValuePair<int, string>(_employee.UserID, _employee.Initials));
                }
            }
        }

        #endregion


        #region Combobox implementations

        private void comboBox_contractName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContractHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_contract, _contractTable, comboBox_contractName, _contractName);
        }

        private void comboBox_projectNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContractHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_contract, _contractTable, comboBox_projectNo, _projectNo);
        }

        private void comboBox_contractStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContractHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_contract, _contractTable, comboBox_contractStatus, _contractStatus, checkBox_defaultContractStatus);
        }

        private void comboBox_contractOwnerInitials_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContractHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_contract, _contractTable, comboBox_contractOwnerInitials, _contractOwnerInitials);
        }

        private void comboBox_ContractModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContractHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_contract, _contractTable, comboBox_ContractModel, _contractModel,
                checkBox_defaultContractModel);
        }

        private void comboBox_contractBudgetExpensesAmount_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContractHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_contract, _contractTable, comboBox_contractBudgetExpensesAmount, _budgetExpensesAmount);
        }

        private void comboBox_contractBudgetTravelAmount_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContractHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_contract, _contractTable, comboBox_contractBudgetTravelAmount, _budgetTravelAmount);
        }

        private void comboBox_contractBudgetWorkAmount_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContractHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_contract, _contractTable, comboBox_contractBudgetWorkAmount, _budgetWorkAmount);
        }

        private void comboBox_contractBudgetWorkHour_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContractHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_contract, _contractTable, comboBox_contractBudgetWorkHour, _budgetWorkHour);
        }

        private void comboBox_contractHasCompletionNotification_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContractHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_contract, _contractTable, comboBox_contractHasCompletionNotification, _completionNotification, checkBox_defaultContractHasCompletionNotification);
        }


        private void comboBox_contractCompletionNotificationPercentage_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContractHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_contract, _contractTable, comboBox_contractCompletionNotificationPercentage, _completionNotificationPercentage, checkBox_defaultContractCompletionNotificationPercentage);
        }

        private void comboBox_contractIsMileageBillable_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContractHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_contract, _contractTable, comboBox_contractIsMileageBillable, _isMileageBillable, checkBox_defaultContractIsMileageBillable);
        }

        private void comboBox_contractIsDefaultExpenses_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContractHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_contract, _contractTable, comboBox_contractIsDefaultExpenses, _isDefaultExpenses, checkBox_defaultContractIsDefaultExpenses);
        }

        private void comboBox_contractHasBudgetOverrunNotification_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContractHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_contract, _contractTable, comboBox_contractHasBudgetOverrunNotification, _budgetOverrunNotification, checkBox_defaultContractHasBudgetOverrunNotification);
        }

        private void comboBox_contractTargetHourlyRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContractHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_contract, _contractTable, comboBox_contractTargetHourlyRate, _targetHourlyRate);
        }

        private void comboBox_contractPaymentPlanAmount_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContractHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_contract, _contractTable, comboBox_contractPaymentPlanAmount, _paymentPlanAmount);
        }

        private void comboBox_contractRevenueExpensesAmount_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContractHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_contract, _contractTable, comboBox_contractRevenueExpensesAmount, _revenueExpensesAmount);
        }

        private void comboBox_contractRevenueTravelAmount_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContractHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_contract, _contractTable, comboBox_contractRevenueTravelAmount, _revenueTravelAmount);
        }

        private void comboBox_contractIsExpensesLinked_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContractHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_contract, _contractTable, comboBox_contractIsExpensesLinked, _isExpensesLinked, checkBox_defaultContractIsExpensesLinked);
        }

        private void comboBox_contractIsTravelLinked_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContractHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_contract, _contractTable, comboBox_contractIsTravelLinked, _isTravelLinked, checkBox_defaultContractIsTravelLinked);
        }

        private void comboBox_contractHourlyRateName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContractHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_contract, _contractTable, comboBox_contractHourlyRateName, _hourlyRateName);
        }

        private void comboBox_contractIsFixedHourlyRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContractHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_contract, _contractTable, comboBox_contractIsFixedHourlyRate, _isFixedHourlyRate, checkBox_defaultContractIsFixedHourlyRate);
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
                _contractModel, checkBox_defaultContractModel, ContractModelList,
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
                _isMileageBillable, checkBox_defaultContractIsMileageBillable, IsMileageBillableList,
                ContractHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());
        }

        private void checkBox_defaultContractIsDefaultExpenses_CheckedChanged(object sender, EventArgs e)
        {
            ContractHandler.Instance.MapNonKeyValuePairToComboBoxByCheckboxStatus(dataGridView_contract, _contractTable,
                comboBox_contractIsDefaultExpenses,
                _isDefaultExpenses, checkBox_defaultContractIsDefaultExpenses, IsDefaultExpensesList,
                ContractHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());
        }

        private void checkBox_defaultContractHasBudgetOverrunNotification_CheckedChanged(object sender, EventArgs e)
        {
            ContractHandler.Instance.MapNonKeyValuePairToComboBoxByCheckboxStatus(dataGridView_contract, _contractTable,
                comboBox_contractHasBudgetOverrunNotification,
                _budgetOverrunNotification, checkBox_defaultContractHasBudgetOverrunNotification,
                HasBudgetOverrunNotificationList, ContractHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());
        }

        private void checkBox_defaultContractIsExpensesLinked_CheckedChanged(object sender, EventArgs e)
        {
            ContractHandler.Instance.MapNonKeyValuePairToComboBoxByCheckboxStatus(dataGridView_contract, _contractTable,
                comboBox_contractIsExpensesLinked,
                _isExpensesLinked, checkBox_defaultContractIsExpensesLinked, IsExpensesLinkedList,
                ContractHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());
        }

        private void checkBox_defaultContractIsTravelLinked_CheckedChanged(object sender, EventArgs e)
        {
            ContractHandler.Instance.MapNonKeyValuePairToComboBoxByCheckboxStatus(dataGridView_contract, _contractTable,
                comboBox_contractIsTravelLinked,
                _isTravelLinked, checkBox_defaultContractIsTravelLinked, IsTravelLinkedList,
                ContractHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());
        }

        private void checkBox_defaultContractIsFixedHourlyRate_CheckedChanged(object sender, EventArgs e)
        {
            ContractHandler.Instance.MapNonKeyValuePairToComboBoxByCheckboxStatus(dataGridView_contract, _contractTable,
                comboBox_contractIsFixedHourlyRate,
                _isFixedHourlyRate, checkBox_defaultContractIsFixedHourlyRate, IsFixedHourlyRateList,
                ContractHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());
        }


        #endregion

       
    }
}