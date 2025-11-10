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
    public partial class UserControl_TaskImport : UserControl
    {
        #region Variable declarations

        private DataTable _taskTable;
        private DataTable _fileContent;
        private Button _senderButton;
        private int _errorRowCount;
        private bool _isMappingFieldValueToIDCorrect;
        private bool _isFirstTimeInvalidMapping;

        private static readonly Dictionary<int, string> MandatoryFields = new Dictionary<int, string>
        {
            {0, "Task Name"},
            {1, "Start Date"},
            {2, "End Date"},
            {3, "Contract Name"},
            {4, "Task Type"},
            {5, "Project No"}
        };

        //all column header variables
        private const string TaskNo = "Task No";
        private const string TaskName = "Task Name";
        private const string Description = "Description";
        private const string StartDate = "Start Date";
        private const string EndDate = "End Date";
        private const string AdditionalTextIsRequired = "Additional Text Is Required";
        private const string BudgetHours = "Budget Hours";
        private const string BudgetAmount = "Budget Amount";
        private const string ContractName = "Contract Name";  
        private const string IsReadyForInvoicing = "Is Ready For Invoicing";
        private const string TaskType = "Task Type";
        private const string ContractHourlyRate = "Hourly Rate Name";  
        private const string ProjectNo = "Project No"; 
        private const string ParentTaskNo = "Parent Task No";
        private const string IsBillable = "Is Billable";
        private const string PaymentRecognitionModel = "Payment Recognition Model";  
        private const string PaymentAmount = "Payment Amount";
        private const string TaskHourlyRate = "Task Hourly Rate";
        private const string PaymentProductNo = "Payment Product No";
        private const string PaymentName = "Payment Name";
        private const string PaymentInvoiceDate = "Payment Invoice Date";  

        //default value lists
        private static readonly List<string> IsBillableList = new List<string> { "true", "false" };
        private static readonly List<string> AdditionalTextIsRequiredList = new List<string> { "true", "false" };
        private static readonly List<string> IsReadyForInvoicingList = new List<string> { "true", "false" };

        //default value lists from API 
        private static readonly List<KeyValuePair<int, string>> TaskTypeList = new List<KeyValuePair<int, string>>();
        private static readonly List<KeyValuePair<int, string>> ContractHourlyRateList = new List<KeyValuePair<int, string>>();
        private static readonly List<KeyValuePair<int, string>> PaymentRecognitionModelList = new List<KeyValuePair<int, string>>();
        private static readonly List<KeyValuePair<int, string>> ContractNameList = new List<KeyValuePair<int, string>>();
        private static readonly List<KeyValuePair<int, string>> ProjectNoList = new List<KeyValuePair<int, string>>();
        private static readonly List<KeyValuePair<int, string>> ParentTaskNoList = new List<KeyValuePair<int, string>>(); 

        //expanding panels' current states, expand panels, expand buttons
        private BaseHandler.ExpandState[] _expandStates;
        private Panel[] _expandPanels;
        private Button[] _expandButtons;

        //set the number of pixels expanded per timer Tick
        private const int ExpansionPerTick = 7;

        #endregion

        public UserControl_TaskImport()
        {
            InitializeComponent();
            TaskHandler.Instance.InitializeDelimiterComboBox(comboBox_delimiter);
            InitializeExpandCollapsePanels();
            AddRowNumberToDataTable();
            InitializeAllDefaultValues();
            _taskTable = TaskHandler.Instance.InitializeDomainDataTable(MandatoryFields);
            dataGridView_task.DataSource = _taskTable;
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
            GetAllTaskTypeFromApi();
            GetAllPaymentRecognitionModel();
        }

        #endregion

        #region Functionalities implementations

        private void button_select_task_file_Click(object sender, EventArgs e)
        {
            TaskHandler.Instance.FileColumnHeaders = new List<string>();
            _fileContent = new DataTable();
            _fileContent = TaskHandler.Instance.GetFileContent(comboBox_delimiter.SelectedItem.ToString());

            if (_fileContent != null)
            {
                textBox_taskImportMessages.Text = string.Empty;
                ClearAndResetAllCheckBoxes();
                ClearAndResetAllComboBoxes();
                Invoke((MethodInvoker)(() => button_import.Enabled = false));

                if (dataGridView_task.RowCount > 1)
                {
                    dataGridView_task.DataSource = null;
                    _taskTable = TaskHandler.Instance.InitializeDomainDataTable(MandatoryFields);
                }

                _taskTable = _fileContent.Copy();
                dataGridView_task.DataSource = _taskTable;

                AddFileColumnHeaderToComboBox(TaskHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());

                TaskHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_taskName, TaskName);
                TaskHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_startDate, StartDate);
                TaskHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_endDate, EndDate);
                TaskHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_isReadyForInvoicing, IsReadyForInvoicing );
                TaskHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_taskType, TaskType );
                TaskHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_projectNo, ProjectNo);
                TaskHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_parentTaskNo, ParentTaskNo);
                TaskHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_isBillable, IsBillable );
                TaskHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_paymentRecognitionModel, PaymentRecognitionModel);
                TaskHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_contractName, ContractName);
                TaskHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_paymentAmount, PaymentAmount);
                TaskHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_hourlyRate, ContractHourlyRate);
                TaskHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_taskNo, TaskNo);
                TaskHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_description, Description);
                TaskHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_additionalTextIsRequired, AdditionalTextIsRequired);
                TaskHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_budgetHours, BudgetHours);
                TaskHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_budgetAmount, BudgetAmount);
                TaskHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_taskHourlyRate, TaskHourlyRate);
                TaskHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_paymentProductNo, PaymentProductNo);
                TaskHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_paymentName, PaymentName);
                TaskHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_paymentInvoiceDate, PaymentInvoiceDate);

                this.comboBox_paymentInvoiceDate.SelectedIndexChanged += new System.EventHandler(this.comboBox_paymentInvoiceDate_SelectedIndexChanged);
                this.comboBox_paymentName.SelectedIndexChanged += new System.EventHandler(this.comboBox_paymentName_SelectedIndexChanged);
                this.comboBox_paymentProductNo.SelectedIndexChanged += new System.EventHandler(this.comboBox_paymentProductNo_SelectedIndexChanged);
                this.comboBox_taskHourlyRate.SelectedIndexChanged += new System.EventHandler(this.comboBox_taskHourlyRate_SelectedIndexChanged);
                this.comboBox_budgetAmount.SelectedIndexChanged += new System.EventHandler(this.comboBox_budgetAmount_SelectedIndexChanged);
                this.comboBox_paymentRecognitionModel.SelectedIndexChanged += new System.EventHandler(this.comboBox_paymentRecognitionModel_SelectedIndexChanged);
                this.comboBox_paymentAmount.SelectedIndexChanged += new System.EventHandler(this.comboBox_paymentAmount_SelectedIndexChanged);
                this.comboBox_isBillable.SelectedIndexChanged += new System.EventHandler(this.comboBox_isBillable_SelectedIndexChanged);
                this.comboBox_parentTaskNo.SelectedIndexChanged += new System.EventHandler(this.comboBox_parentTaskNo_SelectedIndexChanged);
                this.comboBox_taskNo.SelectedIndexChanged += new System.EventHandler(this.comboBox_taskNo_SelectedIndexChanged);
                this.comboBox_budgetHours.SelectedIndexChanged += new System.EventHandler(this.comboBox_budgetHours_SelectedIndexChanged);
                this.comboBox_description.SelectedIndexChanged += new System.EventHandler(this.comboBox_description_SelectedIndexChanged);
                this.comboBox_isReadyForInvoicing.SelectedIndexChanged += new System.EventHandler(this.comboBox_isReadyForInvoicing_SelectedIndexChanged);
                this.comboBox_additionalTextIsRequired.SelectedIndexChanged += new System.EventHandler(this.comboBox_additionalTextIsRequired_SelectedIndexChanged);
                this.comboBox_hourlyRate.SelectedIndexChanged += new System.EventHandler(this.comboBox_hourlyRate_SelectedIndexChanged);
                this.comboBox_contractName.SelectedIndexChanged += new System.EventHandler(this.comboBox_contractName_SelectedIndexChanged);
                this.comboBox_projectNo.SelectedIndexChanged += new System.EventHandler(this.comboBox_projectNo_SelectedIndexChanged);
                this.comboBox_taskType.SelectedIndexChanged += new System.EventHandler(this.comboBox_taskType_SelectedIndexChanged);
                this.comboBox_endDate.SelectedIndexChanged += new System.EventHandler(this.comboBox_endDate_SelectedIndexChanged);
                this.comboBox_startDate.SelectedIndexChanged += new System.EventHandler(this.comboBox_startDate_SelectedIndexChanged);
                this.comboBox_taskName.SelectedIndexChanged += new System.EventHandler(this.comboBox_taskName_SelectedIndexChanged);

            }
            else
            {
                button_clear_Click(sender, e);
            }
        }

        private void button_validate_Click(object sender, EventArgs e)
        {
            textBox_taskImportMessages.Text = string.Empty;
            _senderButton = (Button) sender;
            WorkerFetcher.RunWorkerAsync();
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            WorkerFetcher.CancelAsync();
        }

        private void button_import_Click(object sender, EventArgs e)
        {
            textBox_taskImportMessages.Text = string.Empty;
            _senderButton = (Button) sender;
            WorkerFetcher.RunWorkerAsync();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            TaskHandler.Instance.FileColumnHeaders = new List<string>();
            textBox_taskImportMessages.Text = string.Empty;
            ClearAndResetAllCheckBoxes();
            ClearAndResetAllComboBoxes();
            InitializeAllDefaultValues();
            Invoke((MethodInvoker)(() => button_import.Enabled = false));

            dataGridView_task.DataSource = null;
            _taskTable = TaskHandler.Instance.InitializeDomainDataTable(MandatoryFields);
            dataGridView_task.DataSource = _taskTable;
        }

        private void textBox_taskImportMessages_MouseClick(object sender, MouseEventArgs e)
        {
            TaskHandler.Instance.HighlightDataTableRowByTextBoxClick(e, dataGridView_task, textBox_taskImportMessages);
        }

        private void button_expand_Click(object sender, EventArgs e)
        {
            TaskHandler.Instance.ExpandCollapseFieldByButtonClick(sender, _expandStates, _expandButtons, tmrExpand);
        }

        private void tmrExpand_Tick(object sender, EventArgs e)
        {
            TaskHandler.Instance.ProcessExpandCollapseFieldForPanel(_expandPanels, _expandStates, ExpansionPerTick, tmrExpand);
        }

        private void WorkerFetcherDoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (dataGridView_task != null && dataGridView_task.RowCount > 1)
            {
                _errorRowCount = 0;

                //while validating, deactivate other buttons
                Invoke((MethodInvoker)(() => button_validate.Enabled = false));
                Invoke((MethodInvoker)(() => button_import.Enabled = false));
                Invoke((MethodInvoker)(() => button_clear.Enabled = false));
                Invoke((MethodInvoker)(() => button_taskSelectFile.Enabled = false));

                Invoke((MethodInvoker)(() => textBox_taskImportMessages.AppendText("Start time: " + DateTime.Now)));

                try
                {
                    foreach (DataGridViewRow _row in dataGridView_task.Rows)
                    {
                        if (WorkerFetcher.CancellationPending)
                        {
                            break;
                        }

                        _isMappingFieldValueToIDCorrect = true;
                        _isFirstTimeInvalidMapping = true;

                        if (_row.DataBoundItem != null)
                        {
                            TaskCreateModel _newTask = new TaskCreateModel
                            {
                                ProjectID = (int)MapFieldValueToID(ProjectNo, _row, false),
                                TaskNo = TaskHandler.Instance.CheckAndGetString(dataGridView_task, TaskNo, _row),
                                TaskName = TaskHandler.Instance.CheckAndGetString(dataGridView_task, TaskName, _row),
                                Description = TaskHandler.Instance.CheckAndGetString(dataGridView_task, Description, _row),
                                StartDate = TaskHandler.Instance.CheckAndGetDate(dataGridView_task, StartDate, _row),
                                EndDate = TaskHandler.Instance.CheckAndGetDate(dataGridView_task, EndDate, _row),
                                AdditionalTextIsRequired = TaskHandler.Instance.CheckAndGetBoolean(dataGridView_task, AdditionalTextIsRequired, _row),
                                BudgetHours = TaskHandler.Instance.CheckAndGetDouble(dataGridView_task, BudgetHours, _row),
                                BudgetAmount = TaskHandler.Instance.CheckAndGetDouble(dataGridView_task, BudgetAmount, _row),
                                ProjectSubContractID = (int) MapFieldValueToID(ContractName, _row, false),
                                IsReadyForInvoicing = TaskHandler.Instance.CheckAndGetBoolean(dataGridView_task, IsReadyForInvoicing, _row),
                                TaskTypeID = MapFieldValueToID(TaskType, _row, true),
                                HourlyRateID = MapFieldValueToID(ContractHourlyRate, _row, false),
                                ParentTaskID = MapFieldValueToID(ParentTaskNo, _row, true),
                                IsBillable = TaskHandler.Instance.CheckAndGetBoolean(dataGridView_task, IsBillable, _row),
                                PaymentRecognitionModel = (PaymentRecognitionModelTypes)(int) MapFieldValueToID(PaymentRecognitionModel, _row, false),
                                PaymentAmount = TaskHandler.Instance.CheckAndGetDouble(dataGridView_task, PaymentAmount, _row),
                                TaskHourlyRate = TaskHandler.Instance.CheckAndGetDouble(dataGridView_task, TaskHourlyRate, _row),
                                PaymentProductNo = TaskHandler.Instance.CheckAndGetString(dataGridView_task, PaymentProductNo, _row),
                                PaymentName = TaskHandler.Instance.CheckAndGetString(dataGridView_task, PaymentName, _row),
                                PaymentInvoiceDate = TaskHandler.Instance.CheckAndGetNullableDate(dataGridView_task, PaymentInvoiceDate, _row)
                            };

                            if (_isMappingFieldValueToIDCorrect)
                            {
                                if (_senderButton.Name == button_validate.Name)
                                {
                                    var _defaultApiResponse = TaskHandler.Instance.ValidateTask(_newTask,
                                        AuthenticationHandler.Instance.Token, out var _businessRulesApiResponse);

                                    _errorRowCount += ApiHelper.Instance.HandleApiResponse(_defaultApiResponse, _row, _businessRulesApiResponse,
                                        textBox_taskImportMessages, WorkerFetcher, this);
                                }
                                else
                                {
                                    var _defaultApiResponse = TaskHandler.Instance.ImportTask(_newTask,
                                        AuthenticationHandler.Instance.Token, out var _businessRulesApiResponse);

                                    _errorRowCount += ApiHelper.Instance.HandleApiResponse(_defaultApiResponse, _row, _businessRulesApiResponse,
                                        textBox_taskImportMessages, WorkerFetcher, this);
                                }
                            }
                        }
                    }

                    TaskHandler.Instance.DisplayErrorRowCountAndSuccessMessage(_errorRowCount, button_import, button_validate, _senderButton, textBox_taskImportMessages, this);
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
                Invoke((MethodInvoker)(() => button_taskSelectFile.Enabled = true));
            }
        }

        #endregion

        #region Helper methods

        private void GetAllPaymentRecognitionModel()
        {
            //get all from enum  //pls further test
            foreach (var _model in Enum.GetNames(typeof(PaymentRecognitionModelTypes)))
            {
                PaymentRecognitionModelList.Add(new KeyValuePair<int, string>((int)(PaymentRecognitionModelTypes)Enum.Parse(typeof(PaymentRecognitionModelTypes), _model), _model));
            }
        }

        private void AddFileColumnHeaderToComboBox(object[] fileColumnHeaderArray)
        {
            comboBox_taskName.Items.AddRange(fileColumnHeaderArray);
            comboBox_taskNo.Items.AddRange(fileColumnHeaderArray);
            comboBox_description.Items.AddRange(fileColumnHeaderArray);
            comboBox_startDate.Items.AddRange(fileColumnHeaderArray);
            comboBox_endDate.Items.AddRange(fileColumnHeaderArray);
            comboBox_additionalTextIsRequired.Items.AddRange(fileColumnHeaderArray);
            comboBox_budgetHours.Items.AddRange(fileColumnHeaderArray);
            comboBox_budgetAmount.Items.AddRange(fileColumnHeaderArray);
            comboBox_contractName.Items.AddRange(fileColumnHeaderArray);
            comboBox_isReadyForInvoicing.Items.AddRange(fileColumnHeaderArray);
            comboBox_taskType.Items.AddRange(fileColumnHeaderArray);
            comboBox_hourlyRate.Items.AddRange(fileColumnHeaderArray);
            comboBox_projectNo.Items.AddRange(fileColumnHeaderArray);
            comboBox_parentTaskNo.Items.AddRange(fileColumnHeaderArray);
            comboBox_isBillable.Items.AddRange(fileColumnHeaderArray);
            comboBox_paymentRecognitionModel.Items.AddRange(fileColumnHeaderArray);
            comboBox_paymentAmount.Items.AddRange(fileColumnHeaderArray);
            comboBox_taskHourlyRate.Items.AddRange(fileColumnHeaderArray);
            comboBox_paymentProductNo.Items.AddRange(fileColumnHeaderArray);
            comboBox_paymentName.Items.AddRange(fileColumnHeaderArray);
            comboBox_paymentInvoiceDate.Items.AddRange(fileColumnHeaderArray);
        }

        private int? MapFieldValueToID(string columnName, DataGridViewRow row, bool isNullableField)
        {
            if (dataGridView_task.Columns[columnName] != null)
            {
                var _fieldValue = TaskHandler.Instance.CheckAndGetString(dataGridView_task, columnName, row);
                int _result = -1;

                if (columnName == ProjectNo)
                {
                    _result = TaskHandler.Instance.GetIDFromFieldValue(ProjectNoList, _fieldValue);
                    if (_result != -1)
                    {
                        GetAllContractFromApi(_result);
                        GetAllTaskFromApi(_result);
                    }
                }
                else if (columnName == TaskType)
                {
                    _result = TaskHandler.Instance.GetIDFromFieldValue(TaskTypeList, _fieldValue);
                }
                else if (columnName == ContractHourlyRate)
                {
                    if (string.IsNullOrWhiteSpace(_fieldValue))
                    {
                        //If no hourly rate is entered use the default hourly rate (0)
                        _result = 0;
                    }
                    else
                    {
                        _result = TaskHandler.Instance.GetIDFromFieldValue(ContractHourlyRateList, _fieldValue);
                    }
                }
                else if (columnName == ContractName)
                {
                    _result = TaskHandler.Instance.GetIDFromFieldValue(ContractNameList, _fieldValue);
                    if (_result != -1)
                    {
                        GetAllContractHourlyRateFromApi(_result);
                    }
                }
                else if (columnName == PaymentRecognitionModel)
                {
                    if (!string.IsNullOrWhiteSpace(_fieldValue))
                    {
                        _result = TaskHandler.Instance.GetIDFromFieldValue(PaymentRecognitionModelList, _fieldValue);
                    }
                    else
                    {
                        _result = 0;
                    }
                }
                else if (columnName == ParentTaskNo)
                {
                    if (!string.IsNullOrWhiteSpace(_fieldValue))
                    {
                        _result = TaskHandler.Instance.GetIDFromFieldValue(ParentTaskNoList, _fieldValue);
                    }
                    else
                    {
                        return null;
                    }
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
                _errorRowCount = TaskHandler.Instance.HandleInvalidFieldValueToIDMapping(columnName, row, _fieldValue, textBox_taskImportMessages, 
                    WorkerFetcher, this, _isFirstTimeInvalidMapping, _errorRowCount);
                _isMappingFieldValueToIDCorrect = false;
                _isFirstTimeInvalidMapping = false;
            }

           
            return 0;
        }

        private void ClearAndResetAllComboBoxes()
        {
            comboBox_taskName.ResetText();
            comboBox_taskName.Items.Clear();
            comboBox_taskNo.ResetText();
            comboBox_taskNo.Items.Clear();
            comboBox_description.ResetText();
            comboBox_description.Items.Clear();
            comboBox_startDate.ResetText();
            comboBox_startDate.Items.Clear();
            comboBox_endDate.ResetText();
            comboBox_endDate.Items.Clear();
            comboBox_additionalTextIsRequired.ResetText();
            comboBox_additionalTextIsRequired.Items.Clear();
            comboBox_budgetHours.ResetText();
            comboBox_budgetHours.Items.Clear();
            comboBox_budgetAmount.ResetText();
            comboBox_budgetAmount.Items.Clear();
            comboBox_contractName.ResetText();
            comboBox_contractName.Items.Clear();
            comboBox_isReadyForInvoicing.ResetText();
            comboBox_isReadyForInvoicing.Items.Clear();
            comboBox_taskType.ResetText();
            comboBox_taskType.Items.Clear();
            comboBox_hourlyRate.ResetText();
            comboBox_hourlyRate.Items.Clear();
            comboBox_projectNo.ResetText();
            comboBox_projectNo.Items.Clear();
            comboBox_parentTaskNo.ResetText();
            comboBox_parentTaskNo.Items.Clear();
            comboBox_isBillable.ResetText();
            comboBox_isBillable.Items.Clear();
            comboBox_paymentRecognitionModel.ResetText();
            comboBox_paymentRecognitionModel.Items.Clear();
            comboBox_paymentAmount.ResetText();
            comboBox_paymentAmount.Items.Clear();
            comboBox_taskHourlyRate.ResetText();
            comboBox_taskHourlyRate.Items.Clear();
            comboBox_paymentProductNo.ResetText();
            comboBox_paymentProductNo.Items.Clear();
            comboBox_paymentName.ResetText();
            comboBox_paymentName.Items.Clear();
            comboBox_paymentInvoiceDate.ResetText();
            comboBox_paymentInvoiceDate.Items.Clear();
        }

        private void ClearAndResetAllCheckBoxes()
        {
            checkBox_defaultTaskType.Checked = false;
            checkBox_defaultAdditionalTextIsRequired.Checked = false;
            checkBox_defaultIsReadyForInvoicing.Checked = false;
            checkBox_defaultPaymentRecognitionModel.Checked = false;
            checkBox_defaultIsBillable.Checked = false;
        }

        #endregion

        #region Get default values from API

        private void GetAllTaskTypeFromApi()
        {
            TaskTypeList.Clear();
            var _apiResponse = TaskHandler.Instance.GetAllTaskType(AuthenticationHandler.Instance.Token);

            if (_apiResponse != null)
            {
                foreach (var _taskType in _apiResponse)
                {
                    TaskTypeList.Add(new KeyValuePair<int, string>(_taskType.TaskTypeID, _taskType.Name));
                }
            }
        }

       
        private void GetAllProjectFromApi()
        {
            ProjectNoList.Clear();
            var _apiResponse = TaskHandler.Instance.GetAllProject(AuthenticationHandler.Instance.Token);

            if (_apiResponse != null)
            {
                foreach (var _project in _apiResponse)
                {
                    ProjectNoList.Add(new KeyValuePair<int, string>(_project.ProjectID, _project.No));
                }
            }
        }

        private void GetAllContractFromApi(int projectID)
        {
            ContractNameList.Clear();
            var _apiResponse = TaskHandler.Instance.GetAllContract(AuthenticationHandler.Instance.Token, projectID);

            if (_apiResponse != null)
            {
                foreach (var _contract in _apiResponse)
                { 
                    ContractNameList.Add(new KeyValuePair<int, string>(_contract.ContractID, _contract.ContractName));
                }
            }
        }

        private void GetAllTaskFromApi(int projectID)
        {
            var _apiResponse = TaskHandler.Instance.GetAllTask(AuthenticationHandler.Instance.Token, projectID);

            if (_apiResponse != null)
            {
                foreach (var _task in _apiResponse)
                {
                    ParentTaskNoList.Add(new KeyValuePair<int, string>(_task.TaskID, _task.No));
                }
            }
        }

        private void GetAllContractHourlyRateFromApi(int contractID)
        {
            ContractHourlyRateList.Clear();
            var _apiResponse = TaskHandler.Instance.GetAllContractHourlyRates(AuthenticationHandler.Instance.Token, contractID);

            if (_apiResponse != null)
            {
                foreach (var _contractHourlyRate in _apiResponse)
                {
                    ContractHourlyRateList.Add(new KeyValuePair<int, string>(_contractHourlyRate.ContractHourlyRateID, _contractHourlyRate.Name));
                }
            }
        }


        #endregion

        #region Combobox implementations

        private void comboBox_taskName_SelectedIndexChanged(object sender, EventArgs e)
        {
            TaskHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_task, _taskTable, comboBox_taskName, TaskName);
        }

        private void comboBox_startDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            TaskHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_task, _taskTable, comboBox_startDate, StartDate);
        }

        private void comboBox_endDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            TaskHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_task, _taskTable, comboBox_endDate, EndDate);
        }

        private void comboBox_isReadyForInvoicing_SelectedIndexChanged(object sender, EventArgs e)
        {
            TaskHandler.Instance.MapNonMandatoryNonKeyValuePairSelectedColumnToTable(_fileContent, dataGridView_task, _taskTable, comboBox_isReadyForInvoicing, IsReadyForInvoicing, checkBox_defaultIsReadyForInvoicing);
        }

        private void comboBox_taskType_SelectedIndexChanged(object sender, EventArgs e)
        {
            TaskHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_task, _taskTable, comboBox_taskType, TaskType, checkBox_defaultTaskType);
        }

        private void comboBox_projectNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            TaskHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_task, _taskTable, comboBox_projectNo, ProjectNo);
        }

        private void comboBox_parentTaskNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            TaskHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_task, _taskTable, comboBox_parentTaskNo, ParentTaskNo);
        }

        private void comboBox_isBillable_SelectedIndexChanged(object sender, EventArgs e)
        {
            TaskHandler.Instance.MapNonMandatoryNonKeyValuePairSelectedColumnToTable(_fileContent, dataGridView_task, _taskTable, comboBox_isBillable, IsBillable, checkBox_defaultIsBillable);
        }

        private void comboBox_paymentRecognitionModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            TaskHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_task, _taskTable, comboBox_paymentRecognitionModel, PaymentRecognitionModel, checkBox_defaultPaymentRecognitionModel);
        }

        private void comboBox_contractName_SelectedIndexChanged(object sender, EventArgs e)
        {
            TaskHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_task, _taskTable, comboBox_contractName, ContractName);
        }

        private void comboBox_paymentAmount_SelectedIndexChanged(object sender, EventArgs e)
        {
            TaskHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_task, _taskTable, comboBox_paymentAmount, PaymentAmount);
        }

        private void comboBox_hourlyRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            TaskHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_task, _taskTable, comboBox_hourlyRate, ContractHourlyRate);
        }

        private void comboBox_taskNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            TaskHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_task, _taskTable, comboBox_taskNo, TaskNo);
        }

        private void comboBox_description_SelectedIndexChanged(object sender, EventArgs e)
        {
            TaskHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_task, _taskTable, comboBox_description, Description);
        }

        private void comboBox_additionalTextIsRequired_SelectedIndexChanged(object sender, EventArgs e)
        {
            TaskHandler.Instance.MapNonMandatoryNonKeyValuePairSelectedColumnToTable(_fileContent, dataGridView_task, _taskTable, comboBox_additionalTextIsRequired, AdditionalTextIsRequired, checkBox_defaultAdditionalTextIsRequired);
        }

        private void comboBox_budgetHours_SelectedIndexChanged(object sender, EventArgs e)
        {
            TaskHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_task, _taskTable, comboBox_budgetHours, BudgetHours);
        }

        private void comboBox_budgetAmount_SelectedIndexChanged(object sender, EventArgs e)
        {
            TaskHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_task, _taskTable, comboBox_budgetAmount, BudgetAmount);
        }

        private void comboBox_taskHourlyRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            TaskHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_task, _taskTable, comboBox_taskHourlyRate, TaskHourlyRate);
        }

        private void comboBox_paymentProductNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            TaskHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_task, _taskTable, comboBox_paymentProductNo, PaymentProductNo);
        }

        private void comboBox_paymentName_SelectedIndexChanged(object sender, EventArgs e)
        {
            TaskHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_task, _taskTable, comboBox_paymentName, PaymentName);
        }

        private void comboBox_paymentInvoiceDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            TaskHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_task, _taskTable, comboBox_paymentInvoiceDate, PaymentInvoiceDate);
        }

        #endregion

        #region Checkbox implementations

        private void checkBox_defaultIsReadyForInvoicing_CheckedChanged(object sender, EventArgs e)
        {
            TaskHandler.Instance.MapNonKeyValuePairToComboBoxByCheckboxStatus(dataGridView_task, _taskTable, comboBox_isReadyForInvoicing,
                IsReadyForInvoicing, checkBox_defaultIsReadyForInvoicing, IsReadyForInvoicingList, TaskHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());
        }

        private void checkBox_defaultAdditionalTextIsRequired_CheckedChanged(object sender, EventArgs e)
        {
            TaskHandler.Instance.MapNonKeyValuePairToComboBoxByCheckboxStatus(dataGridView_task, _taskTable, comboBox_additionalTextIsRequired,
                AdditionalTextIsRequired, checkBox_defaultAdditionalTextIsRequired, AdditionalTextIsRequiredList, TaskHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());
        }

        private void checkBox_defaultPaymentRecognitionModel_CheckedChanged(object sender, EventArgs e)
        {
            TaskHandler.Instance.MapValuesToComboBoxByCheckboxStatus(dataGridView_task, _taskTable, comboBox_paymentRecognitionModel,
               PaymentRecognitionModel, checkBox_defaultPaymentRecognitionModel, PaymentRecognitionModelList, TaskHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());
        }

        private void checkBox_defaultIsBillable_CheckedChanged(object sender, EventArgs e)
        {
            TaskHandler.Instance.MapNonKeyValuePairToComboBoxByCheckboxStatus(dataGridView_task, _taskTable, comboBox_isBillable,
                IsBillable, checkBox_defaultIsBillable, IsBillableList, TaskHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());
        }

        private void checkBox_defaultTaskType_CheckedChanged(object sender, EventArgs e)
        {
            TaskHandler.Instance.MapValuesToComboBoxByCheckboxStatus(dataGridView_task, _taskTable, comboBox_taskType,
                TaskType, checkBox_defaultTaskType, TaskTypeList, TaskHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());
        }


        #endregion

    }
}