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
    public partial class UserControl_TimeregistrationImport : UserControl
    {
        #region Variable declarations

        private DataTable _timeregistrationTable;
        private DataTable _fileContent;
        private Button _senderButton;
        private int _errorRowCount;
        private bool _isMappingFieldValueToIDCorrect;
        private bool _isFirstTimeInvalidMapping;

        private static readonly Dictionary<int, string> MandatoryFields = new Dictionary<int, string>
        {
            {0, "Task Name"},
            {1, "Project No"},
            {2, "Contract Name"},
            {3, "User Initials"},
            {4, "Date"},
            {5, "Hours"},
            {6, "Group Type"},
            {7, "Is Billable"},
            {8, "Billable Hours"},
            {9, "Hourly Rate"},
            {10, "Hourly Rate Name"},
            {11, "Cost Price"},
            {12, "Cost Price Name"},

        };

        //all column header variables
        private readonly string _taskName = "Task Name";
        private readonly string _projectNo = "Project No";
        private readonly string _contractName = "Contract Name";
        private readonly string _userInitials = "User Initials";
        private readonly string _date = "Date";
        private readonly string _hours = "Hours";
        private readonly string _groupType = "Group Type";
        private readonly string _isBillable = "Is Billable";
        private readonly string _billableHours = "Billable Hours";
        private readonly string _hourlyRate = "Hourly Rate";
        private readonly string _hourlyRateName = "Hourly Rate Name";
        private readonly string _costPrice = "Cost Price";
        private readonly string _costPriceName = "Cost Price Name";
        private readonly string _comment = "Comment";
        private readonly string _additionalComment = "Additional Comment";
        private readonly string _monthlyPeriod = "Monthly Period";
        
        

        //default value lists from API 
        private static readonly List<KeyValuePair<int, string>> _taskList = new List<KeyValuePair<int, string>>();
        private static readonly List<KeyValuePair<int, string>> _projectList = new List<KeyValuePair<int, string>>();
        private static readonly List<KeyValuePair<int, string>> _contractList = new List<KeyValuePair<int, string>>();
        private static readonly List<KeyValuePair<int, string>> _userList = new List<KeyValuePair<int, string>>();
        private static readonly List<KeyValuePair<int, string>> _groupTypeList = new List<KeyValuePair<int, string>>();

        //expanding panels' current states, expand panels, expand buttons
        private BaseHandler.ExpandState[] _expandStates;
        private Panel[] _expandPanels;
        private Button[] _expandButtons;

        //set the number of pixels expanded per timer Tick
        private const int ExpansionPerTick = 7;

        #endregion

        public UserControl_TimeregistrationImport()
        {
            InitializeComponent();
            TimeregistrationHandler.Instance.InitializeDelimiterComboBox(comboBox_delimiter);
            InitializeExpandCollapsePanels();
            AddRowNumberToDataTable();
            InitializeAllDefaultValues();
            _timeregistrationTable = TimeregistrationHandler.Instance.InitializeDomainDataTable(MandatoryFields);
            dataGridView_timeregistration.DataSource = _timeregistrationTable;
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

        }

        #endregion

        #region Functionalities implementations

        private void button_select_timeregistration_file_Click(object sender, EventArgs e)
        {
            TimeregistrationHandler.Instance.FileColumnHeaders = new List<string>();
            _fileContent = new DataTable();
            _fileContent = TimeregistrationHandler.Instance.GetFileContent(comboBox_delimiter.SelectedItem.ToString());

            if (_fileContent != null)
            {
                textBox_timeregistrationImportMessages.Text = string.Empty;
                ClearAndResetAllComboBoxes();
                Invoke((MethodInvoker)(() => button_import.Enabled = false));

                if (dataGridView_timeregistration.RowCount > 1)
                {
                    dataGridView_timeregistration.DataSource = null;
                    _timeregistrationTable = TimeregistrationHandler.Instance.InitializeDomainDataTable(MandatoryFields);
                    dataGridView_timeregistration.DataSource = _timeregistrationTable;
                }

                foreach (DataRow _fileContentRow in _fileContent.Rows)
                {
                    _timeregistrationTable.Rows.Add();
                }

                AddFileColumnHeaderToComboBox(TimeregistrationHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());

                TimeregistrationHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_timeregistrationTaskName, _taskName);
                TimeregistrationHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_timeregistrationProjectNo, _projectNo);
                TimeregistrationHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_timeregistrationContractName, _contractName);
                TimeregistrationHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_timeregistrationUserInitials, _userInitials);
                TimeregistrationHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_timeregistrationDate, _date);
                TimeregistrationHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_timeregistrationHours, _hours);
                TimeregistrationHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_timeregistrationGroupType, _groupType);
                TimeregistrationHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_timeregistrationIsBillable, _isBillable);
                TimeregistrationHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_timeregistrationBillableHours, _billableHours);
                TimeregistrationHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_timeregistrationHourlyRate, _hourlyRate);
                TimeregistrationHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_timeregistrationHourlyRateName, _hourlyRateName);
                TimeregistrationHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_timeregistrationCostPrice, _costPrice);
                TimeregistrationHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_timeregistrationCostPriceName, _costPriceName);
                TimeregistrationHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_timeregistrationComment, _comment);
                TimeregistrationHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_timeregistrationAdditionalComment, _additionalComment);
                TimeregistrationHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_timeregistrationMonthlyPeriod, _monthlyPeriod);
                
                
            
            }
            else
            {
                button_clear_Click(sender, e);
            }
        }

        private void button_validate_Click(object sender, EventArgs e)
        {
            textBox_timeregistrationImportMessages.Text = string.Empty;
            _senderButton = (Button) sender;
            WorkerFetcher.RunWorkerAsync();
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            WorkerFetcher.CancelAsync();
        }

        private void button_import_Click(object sender, EventArgs e)
        {
            textBox_timeregistrationImportMessages.Text = string.Empty;
            _senderButton = (Button) sender;
            WorkerFetcher.RunWorkerAsync();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            TimeregistrationHandler.Instance.FileColumnHeaders = new List<string>();
            textBox_timeregistrationImportMessages.Text = string.Empty;
            ClearAndResetAllComboBoxes();
            Invoke((MethodInvoker)(() => button_import.Enabled = false));

            dataGridView_timeregistration.DataSource = null;
            _timeregistrationTable = TimeregistrationHandler.Instance.InitializeDomainDataTable(MandatoryFields);
            dataGridView_timeregistration.DataSource = _timeregistrationTable;
        }

        private void textBox_timeregistrationImportMessages_MouseClick(object sender, MouseEventArgs e)
        {
            TimeregistrationHandler.Instance.HighlightDataTableRowByTextBoxClick(e, dataGridView_timeregistration, textBox_timeregistrationImportMessages);
        }

        private void button_expand_Click(object sender, EventArgs e)
        {
            TimeregistrationHandler.Instance.ExpandCollapseFieldByButtonClick(sender, _expandStates, _expandButtons, tmrExpand);
        }

        private void tmrExpand_Tick(object sender, EventArgs e)
        {
            TimeregistrationHandler.Instance.ProcessExpandCollapseFieldForPanel(_expandPanels, _expandStates, ExpansionPerTick, tmrExpand);
        }

        private void WorkerFetcherDoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (dataGridView_timeregistration != null && dataGridView_timeregistration.RowCount > 1)
            {
                _errorRowCount = 0;

                //while validating, deactivate other buttons
                Invoke((MethodInvoker)(() => button_validate.Enabled = false));
                Invoke((MethodInvoker)(() => button_import.Enabled = false));
                Invoke((MethodInvoker)(() => button_clear.Enabled = false));
                Invoke((MethodInvoker)(() => button_timeregistrationSelectFile.Enabled = false));

                try
                {
                    foreach (DataGridViewRow _row in dataGridView_timeregistration.Rows)
                    {
                        if (WorkerFetcher.CancellationPending)
                        {
                            break;
                        }

                        _isMappingFieldValueToIDCorrect = true;
                        _isFirstTimeInvalidMapping = true;

                        if (_row.DataBoundItem != null)
                        {
                            TimeregistrationCreateModel _newTimeregistration = new TimeregistrationCreateModel
                            {
                                TaskID = (int)MapFieldValueToID(_taskName, _row, false),
                                ProjectID = (int)MapFieldValueToID(_projectNo, _row, false),
                                ContractID = (int)MapFieldValueToID(_contractName, _row, false),
                                UserID = (int)MapFieldValueToID(_userInitials, _row, false),
                                Date = TimeregistrationHandler.Instance.CheckAndGetDate(dataGridView_timeregistration,_date, _row),
                                Hours = TimeregistrationHandler.Instance.CheckAndGetDouble(dataGridView_timeregistration, _hours, _row),
                                GroupType = TimeregistrationHandler.Instance.CheckAndGetString(dataGridView_timeregistration, _groupType, _row),
                                Billable = TimeregistrationHandler.Instance.CheckAndGetBoolean(dataGridView_timeregistration, _isBillable, _row),
                                BillableHours = TimeregistrationHandler.Instance.CheckAndGetDouble(dataGridView_timeregistration, _billableHours, _row),
                                HourlyRate = TimeregistrationHandler.Instance.CheckAndGetDouble(dataGridView_timeregistration, _hourlyRate, _row),
                                HourlyRateName = TimeregistrationHandler.Instance.CheckAndGetString(dataGridView_timeregistration, _hourlyRateName, _row),
                                CostPrice = TimeregistrationHandler.Instance.CheckAndGetDouble(dataGridView_timeregistration, _costPrice, _row),
                                CostPriceName = TimeregistrationHandler.Instance.CheckAndGetString(dataGridView_timeregistration, _costPriceName, _row),
                                Comment = TimeregistrationHandler.Instance.CheckAndGetString(dataGridView_timeregistration, _comment, _row),
                                AdditionalComment = TimeregistrationHandler.Instance.CheckAndGetString(dataGridView_timeregistration, _additionalComment, _row),
                                MonthlyPeriod = TimeregistrationHandler.Instance.CheckAndGetString(dataGridView_timeregistration, _monthlyPeriod, _row),

                            };

                            if (_isMappingFieldValueToIDCorrect)
                            {
                                if (_senderButton.Name == button_validate.Name)
                                {
                                    var _defaultApiResponse = TimeregistrationHandler.Instance.ValidateTimeregistration(_newTimeregistration,
                                        AuthenticationHandler.Instance.Token, out var _businessRulesApiResponse);

                                    _errorRowCount = ApiHelper.Instance.HandleApiResponse(_defaultApiResponse, _row, _businessRulesApiResponse,
                                        textBox_timeregistrationImportMessages, _errorRowCount, WorkerFetcher, this);
                                }
                                else
                                {
                                    var _defaultApiResponse = TimeregistrationHandler.Instance.ImportTimeregistration(_newTimeregistration,
                                        AuthenticationHandler.Instance.Token, out var _businessRulesApiResponse);

                                    _errorRowCount = ApiHelper.Instance.HandleApiResponse(_defaultApiResponse, _row, _businessRulesApiResponse,
                                        textBox_timeregistrationImportMessages, _errorRowCount, WorkerFetcher, this);
                                }
                            }
                        }
                    }

                    TimeregistrationHandler.Instance.DisplayErrorRowCountAndSuccessMessage(_errorRowCount, button_import, button_validate, _senderButton, textBox_timeregistrationImportMessages, this);
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
                Invoke((MethodInvoker)(() => button_timeregistrationSelectFile.Enabled = true));
            }
        }

        #endregion

        #region Helper methods

        private void AddFileColumnHeaderToComboBox(object[] fileColumnHeaderArray)
        {
            comboBox_timeregistrationTaskName.Items.AddRange(fileColumnHeaderArray);
            comboBox_timeregistrationProjectNo.Items.AddRange(fileColumnHeaderArray);
            comboBox_timeregistrationContractName.Items.AddRange(fileColumnHeaderArray);
            comboBox_timeregistrationUserInitials.Items.AddRange(fileColumnHeaderArray);
            comboBox_timeregistrationDate.Items.AddRange(fileColumnHeaderArray);
            comboBox_timeregistrationHours.Items.AddRange(fileColumnHeaderArray);
            comboBox_timeregistrationGroupType.Items.AddRange(fileColumnHeaderArray);
            comboBox_timeregistrationIsBillable.Items.AddRange(fileColumnHeaderArray);
            comboBox_timeregistrationBillableHours.Items.AddRange(fileColumnHeaderArray);
            comboBox_timeregistrationHourlyRate.Items.AddRange(fileColumnHeaderArray);
            comboBox_timeregistrationHourlyRateName.Items.AddRange(fileColumnHeaderArray);
            comboBox_timeregistrationCostPrice.Items.AddRange(fileColumnHeaderArray);
            comboBox_timeregistrationCostPriceName.Items.AddRange(fileColumnHeaderArray);
            comboBox_timeregistrationComment.Items.AddRange(fileColumnHeaderArray);
            comboBox_timeregistrationAdditionalComment.Items.AddRange(fileColumnHeaderArray);
            comboBox_timeregistrationMonthlyPeriod.Items.AddRange(fileColumnHeaderArray);
            
        }

        private int? MapFieldValueToID(string columnName, DataGridViewRow row, bool isNullableField)
        {
            if (dataGridView_timeregistration.Columns[columnName] != null)
            {
                var _fieldValue = TimeregistrationHandler.Instance.CheckAndGetString(dataGridView_timeregistration, columnName, row);
                int _result = -1;

                if (columnName == _taskName)
                {
                    if (!string.IsNullOrWhiteSpace(_fieldValue))
                    {
                        var _projectID = PaymentHandler.Instance.GetIDFromFieldValue(_projectList, PaymentHandler.Instance.CheckAndGetString(dataGridView_timeregistration, _projectNo, row));
                        var _tasks = PaymentHandler.Instance.GetAllTask(AuthenticationHandler.Instance.Token, _projectID);

                        try
                        {
                            _result = _tasks.FirstOrDefault(x => x.Name.ToLower().Trim().Equals(_fieldValue.ToLower().Trim())).TaskID;
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
                else if (columnName == _projectNo)
                {
                    _result = TimeregistrationHandler.Instance.GetIDFromFieldValue(_projectList, _fieldValue);
                }
                else if (columnName == _contractName)
                {
                    var _projectID = PaymentHandler.Instance.GetIDFromFieldValue(_projectList, PaymentHandler.Instance.CheckAndGetString(dataGridView_timeregistration, _projectNo, row));
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
                else if (columnName == _userInitials)
                {
                    _result = TimeregistrationHandler.Instance.GetIDFromFieldValue(_userList, _fieldValue);
                }
                else if (columnName == _groupType)
                {
                    _result = TimeregistrationHandler.Instance.GetIDFromFieldValue(_groupTypeList, _fieldValue);
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
                _errorRowCount = TimeregistrationHandler.Instance.HandleInvalidFieldValueToIDMapping(columnName, row, _fieldValue, textBox_timeregistrationImportMessages,
                    WorkerFetcher, this, _isFirstTimeInvalidMapping, _errorRowCount);
                _isMappingFieldValueToIDCorrect = false;
                _isFirstTimeInvalidMapping = false;
            }

           

            return 0;
        }

        private void ClearAndResetAllComboBoxes()
        {
            comboBox_timeregistrationTaskName.ResetText();
            comboBox_timeregistrationTaskName.Items.Clear();
            comboBox_timeregistrationProjectNo.ResetText();
            comboBox_timeregistrationProjectNo.Items.Clear();
            comboBox_timeregistrationContractName.ResetText();
            comboBox_timeregistrationContractName.Items.Clear();
            comboBox_timeregistrationUserInitials.ResetText();
            comboBox_timeregistrationUserInitials.Items.Clear();
            comboBox_timeregistrationDate.ResetText();
            comboBox_timeregistrationDate.Items.Clear();
            comboBox_timeregistrationHours.ResetText();
            comboBox_timeregistrationHours.Items.Clear();
            comboBox_timeregistrationGroupType.ResetText();
            comboBox_timeregistrationGroupType.Items.Clear();
            comboBox_timeregistrationIsBillable.ResetText();
            comboBox_timeregistrationIsBillable.Items.Clear();
            comboBox_timeregistrationBillableHours.ResetText();
            comboBox_timeregistrationBillableHours.Items.Clear(); 
            comboBox_timeregistrationHourlyRate.ResetText();
            comboBox_timeregistrationHourlyRate.Items.Clear(); 
            comboBox_timeregistrationHourlyRateName.ResetText();
            comboBox_timeregistrationHourlyRateName.Items.Clear(); 
            comboBox_timeregistrationCostPrice.ResetText();
            comboBox_timeregistrationCostPrice.Items.Clear(); 
            comboBox_timeregistrationCostPriceName.ResetText();
            comboBox_timeregistrationCostPriceName.Items.Clear();
            comboBox_timeregistrationComment.ResetText();
            comboBox_timeregistrationComment.Items.Clear();
            comboBox_timeregistrationAdditionalComment.ResetText();
            comboBox_timeregistrationAdditionalComment.Items.Clear();
            comboBox_timeregistrationMonthlyPeriod.ResetText();
            comboBox_timeregistrationMonthlyPeriod.Items.Clear();

        }




        #endregion

        #region Get default values from API



        #endregion

        #region Combobox implementations

        private void comboBox_timeregistrationTaskName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProjectHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_timeregistration, _timeregistrationTable, comboBox_timeregistrationTaskName, _taskName);

        }

        private void comboBox_timeregistrationProjectNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProjectHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_timeregistration, _timeregistrationTable, comboBox_timeregistrationProjectNo, _projectNo);

        }

        private void comboBox_timeregistrationContractName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProjectHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_timeregistration, _timeregistrationTable, comboBox_timeregistrationContractName, _contractName);

        }

        private void comboBox_timeregistrationUserInitials_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProjectHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_timeregistration, _timeregistrationTable, comboBox_timeregistrationUserInitials, _userInitials);

        }

        private void comboBox_timeregistrationDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProjectHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_timeregistration, _timeregistrationTable, comboBox_timeregistrationDate, _date);

        }

        private void comboBox_timeregistrationHours_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProjectHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_timeregistration, _timeregistrationTable, comboBox_timeregistrationHours, _hours);

        }

        private void comboBox_timeregistrationGroupType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProjectHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_timeregistration, _timeregistrationTable, comboBox_timeregistrationGroupType, _groupType);

        }

        private void comboBox_timeregistrationIsBillable_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProjectHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_timeregistration, _timeregistrationTable, comboBox_timeregistrationIsBillable, _isBillable);

        }

        private void comboBox_timeregistrationBillableHours_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProjectHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_timeregistration, _timeregistrationTable, comboBox_timeregistrationBillableHours, _billableHours);

        }

        private void comboBox_timeregistrationHourlyRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProjectHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_timeregistration, _timeregistrationTable, comboBox_timeregistrationHourlyRate, _hourlyRate);

        }

        private void comboBox_timeregistrationHourlyRateName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProjectHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_timeregistration, _timeregistrationTable, comboBox_timeregistrationHourlyRateName, _hourlyRateName);

        }

        private void comboBox_timeregistrationCostPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProjectHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_timeregistration, _timeregistrationTable, comboBox_timeregistrationCostPrice, _costPrice);

        }

        private void comboBox_timeregistrationCostPriceName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProjectHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_timeregistration, _timeregistrationTable, comboBox_timeregistrationCostPriceName, _costPriceName);

        }

        private void comboBox_timeregistrationComment_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProjectHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_timeregistration, _timeregistrationTable, comboBox_timeregistrationComment, _comment);

        }

        private void comboBox_timeregistrationAdditionalComment_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProjectHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_timeregistration, _timeregistrationTable, comboBox_timeregistrationAdditionalComment, _additionalComment);

        }

        private void comboBox_timeregistrationMonthlyPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProjectHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_timeregistration, _timeregistrationTable, comboBox_timeregistrationMonthlyPeriod, _monthlyPeriod);

        }



        #endregion



    }
}