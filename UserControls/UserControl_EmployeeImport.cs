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
    public partial class UserControl_EmployeeImport : UserControl
    {
        #region Variable declarations

        private DataTable _employeeTable;
        private DataTable _fileContent;
        private Button _senderButton;
        private int _errorRowCount;
        private bool _isMappingFieldValueToIDCorrect;
        private bool _isFirstTimeInvalidMapping;

        private static readonly Dictionary<int, string> MandatoryFields = new Dictionary<int, string>
        {
            {0, "Username"},
            {1, "First Name"},
            {2, "Last Name"},
            {3, "Initials"},
            {4, "Email"},
            {5, "Manager Initials"},
            {6, "Legal Entity"},
            {7, "Department"},
            {8, "Default Hourly Rate"},
            {9, "Cost Price"},
            {10, "Public Holiday Calendar"},
            {11, "Normal Working Time"},
            {12, "Salary Group"}
        };

        //all column header variables
        private const string UserName = "Username";   
        private const string FirstName = "First Name";
        private const string LastName = "Last Name";
        private const string Initials = "Initials";
        private const string Email = "Email";
        private const string JobTitle = "Job Title";
        private const string EmployeeNo = "Employee No";
        private const string EmploymentDate = "Employment Date";   //see if got date time picker
        private const string LegalEntity = "Legal Entity";  
        private const string Department = "Department";
        private const string ManagerInitials = "Manager Initials";
        private const string EmployeeType = "Employee Type"; 
        private const string DefaultHourlyRate = "Default Hourly Rate";
        private const string CostPrice = "Cost Price";  
        private const string PublicHolidayCalendar = "Public Holiday Calendar";
        private const string AllowanceLegislation = "Allowance Legislation";  
        private const string NormalWorkingTime = "Normal Working Time";  
        private const string SalaryGroup = "Salary Group"; 
        private const string UserRoleNames = "User Role Names";   

        //default value lists from API 
        private static readonly List<KeyValuePair<int, string>> LegalEntityList = new List<KeyValuePair<int, string>>();
        private static readonly List<KeyValuePair<int, string>> DepartmentList = new List<KeyValuePair<int, string>>();
        private static readonly List<KeyValuePair<int, string>> EmployeeTypeList = new List<KeyValuePair<int, string>>();
        private static readonly List<KeyValuePair<string, string>> DefaultHourlyRateList = new List<KeyValuePair<string, string>>();
        private static readonly List<KeyValuePair<int, string>> CostPriceList = new List<KeyValuePair<int, string>>();
        private static readonly List<KeyValuePair<int, string>> PublicHolidayCalendarList = new List<KeyValuePair<int, string>>();
        private static readonly List<KeyValuePair<int, string>> AllowanceLegislationList = new List<KeyValuePair<int, string>>();
        private static readonly List<KeyValuePair<int, string>> NormalWorkingTimeList = new List<KeyValuePair<int, string>>();
        private static readonly List<KeyValuePair<int, string>> SalaryGroupList = new List<KeyValuePair<int, string>>();
        private static readonly List<KeyValuePair<int, string>> ManagerInitialsList = new List<KeyValuePair<int, string>>();
        private static readonly List<KeyValuePair<int, string>> UserRolesList = new List<KeyValuePair<int, string>>();

        //expanding panels' current states, expand panels, expand buttons
        private BaseHandler.ExpandState[] _expandStates;
        private Panel[] _expandPanels;
        private Button[] _expandButtons;

        //set the number of pixels expanded per timer Tick
        private const int ExpansionPerTick = 7;

        #endregion

        public UserControl_EmployeeImport()
        {
            InitializeComponent();
            EmployeeHandler.Instance.InitializeDelimiterComboBox(comboBox_delimiter);
            EmployeeHandler.Instance.InitializeDelimiterComboBox(comboBox_userRoleDelimiter, 1);
            InitializeExpandCollapsePanels();
            AddRowNumberToDataTable();
            InitializeAllDefaultValues();
            _employeeTable = EmployeeHandler.Instance.InitializeDomainDataTable(MandatoryFields);
            dataGridView_employee.DataSource = _employeeTable;
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
            GetAllLegalEntityFromApi();
            GetAllDepartmentFromApi();
            GetAllEmployeeTypeFromApi();
            GetAllDefaultHourlyRateFromApi();
            GetAllCostPriceFromApi();
            GetAllPublicHolidayCalendarFromApi();
            GetAllAllowanceLegislationFromApi();
            GetAllNormalWorkingTimeFromApi();
            GetAllSalaryGroupFromApi();
            GetAllManagerFromApi();
            GetAllUserRolesFromApi();
        }

        #endregion

        #region Functionalities implementations

        private void button_select_employee_file_Click(object sender, EventArgs e)
        {
            EmployeeHandler.Instance.FileColumnHeaders = new List<string>();
            _fileContent = new DataTable();
            _fileContent = EmployeeHandler.Instance.GetFileContent(comboBox_delimiter.SelectedItem.ToString());

            if (_fileContent != null)
            {
                textBox_employeeImportMessages.Text = string.Empty;
                ClearAndResetAllCheckBoxes();
                ClearAndResetAllComboBoxes();
                Invoke((MethodInvoker)(() => button_import.Enabled = false));

                if (dataGridView_employee.RowCount > 1)
                {
                    dataGridView_employee.DataSource = null;
                    _employeeTable = EmployeeHandler.Instance.InitializeDomainDataTable(MandatoryFields);
                    dataGridView_employee.DataSource = _employeeTable;
                }

                foreach (DataRow _fileContentRow in _fileContent.Rows)
                {
                    _employeeTable.Rows.Add();
                }

                AddFileColumnHeaderToComboBox(EmployeeHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());


                //this.checkBox_defaultLegalEntity.Checked = true;
                //EmployeeHandler.Instance.MapValuesToComboBoxByCheckboxStatus(dataGridView_employee, _employeeTable, comboBox_legalEntity,
                //    LegalEntity, checkBox_defaultLegalEntity, LegalEntityList, EmployeeHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());
                //this.comboBox_legalEntity.SelectedIndex = 0;
            }
            else
            {
                button_clear_Click(sender, e);
            }
        }

        private void button_validate_Click(object sender, EventArgs e)
        {
            textBox_employeeImportMessages.Text = string.Empty;
            _senderButton = (Button) sender;
            WorkerFetcher.RunWorkerAsync();
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            WorkerFetcher.CancelAsync();
        }

        private void button_import_Click(object sender, EventArgs e)
        {
            textBox_employeeImportMessages.Text = string.Empty;
            _senderButton = (Button) sender;
            WorkerFetcher.RunWorkerAsync();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            InitializeAllDefaultValues();

            EmployeeHandler.Instance.FileColumnHeaders = new List<string>();
            textBox_employeeImportMessages.Text = string.Empty;
            ClearAndResetAllCheckBoxes();
            ClearAndResetAllComboBoxes();
            Invoke((MethodInvoker)(() => button_import.Enabled = false));

            dataGridView_employee.DataSource = null;
            _employeeTable = EmployeeHandler.Instance.InitializeDomainDataTable(MandatoryFields);
            dataGridView_employee.DataSource = _employeeTable;
        }

        private void textBox_employeeImportMessages_MouseClick(object sender, MouseEventArgs e)
        {
            EmployeeHandler.Instance.HighlightDataTableRowByTextBoxClick(e, dataGridView_employee, textBox_employeeImportMessages);
        }

        private void button_expand_Click(object sender, EventArgs e)
        {
            EmployeeHandler.Instance.ExpandCollapseFieldByButtonClick(sender, _expandStates, _expandButtons, tmrExpand);
        }

        private void tmrExpand_Tick(object sender, EventArgs e)
        {
            EmployeeHandler.Instance.ProcessExpandCollapseFieldForPanel(_expandPanels, _expandStates, ExpansionPerTick, tmrExpand);
        }

        private void WorkerFetcherDoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (dataGridView_employee != null && dataGridView_employee.RowCount > 1)
            {
                _errorRowCount = 0;

                //while validating, deactivate other buttons
                Invoke((MethodInvoker)(() => button_validate.Enabled = false));
                Invoke((MethodInvoker)(() => button_import.Enabled = false));
                Invoke((MethodInvoker)(() => button_clear.Enabled = false));
                Invoke((MethodInvoker)(() => button_employeeSelectFile.Enabled = false));

                //get strings of delimiters chosen
                var _fileDelimiter = (string) comboBox_delimiter.Invoke(new Func<string>(() => comboBox_delimiter.SelectedItem.ToString()));
                var _userRoleDelimiter = (string) comboBox_userRoleDelimiter.Invoke(new Func<string>(() => comboBox_userRoleDelimiter.SelectedItem.ToString()));

                try
                {
                    foreach (DataGridViewRow _row in dataGridView_employee.Rows)
                    {
                        if (WorkerFetcher.CancellationPending)
                        {
                            break;
                        }

                        _isMappingFieldValueToIDCorrect = true;
                        _isFirstTimeInvalidMapping = true;

                        if (_row.DataBoundItem != null)
                        {
                            EmployeeCreateModel _newEmployee = new EmployeeCreateModel
                            {
                                UserName = EmployeeHandler.Instance.CheckAndGetString(dataGridView_employee, UserName, _row),
                                FirstName = EmployeeHandler.Instance.CheckAndGetString(dataGridView_employee, FirstName, _row),
                                LastName = EmployeeHandler.Instance.CheckAndGetString(dataGridView_employee, LastName, _row),
                                Initials = EmployeeHandler.Instance.CheckAndGetString(dataGridView_employee, Initials, _row),
                                Email = EmployeeHandler.Instance.CheckAndGetString(dataGridView_employee, Email, _row),
                                Title = EmployeeHandler.Instance.CheckAndGetString(dataGridView_employee, JobTitle, _row),
                                EmployeeNo = EmployeeHandler.Instance.CheckAndGetString(dataGridView_employee, EmployeeNo, _row),
                                EmploymentDate = EmployeeHandler.Instance.CheckAndGetDate(dataGridView_employee, EmploymentDate, _row),
                                LegalEntityID = (int) MapFieldValueToID(LegalEntity, _row, false),
                                DepartmentID = (int) MapFieldValueToID(Department, _row, false),
                                ApprovalManagerID = (int) MapFieldValueToID(ManagerInitials, _row, false),
                                EmployeeTypeID = (int) MapFieldValueToID(EmployeeType, _row, false),
                                StandardHourlyRateID = (int) MapFieldValueToID(DefaultHourlyRate, _row, false),
                                CostPriceID = (int) MapFieldValueToID(CostPrice, _row, false),
                                PublicHolidayCalendarID = (int) MapFieldValueToID(PublicHolidayCalendar, _row, false),
                                AllowanceLegislationID = (int) MapFieldValueToID(AllowanceLegislation, _row, false),
                                NormalWorkingTimeID = (int) MapFieldValueToID(NormalWorkingTime, _row, false),
                                SalaryGroupID =(int) MapFieldValueToID(SalaryGroup, _row, false),
                                UserRoleIDs = EmployeeHandler.Instance.CheckAndGetIntegerArray(dataGridView_employee, UserRoleNames, _row, _fileDelimiter, _userRoleDelimiter,UserRolesList)
                            };

                            if (_isMappingFieldValueToIDCorrect)
                            {
                                if (_senderButton.Name == button_validate.Name)
                                {
                                    var _defaultApiResponse = EmployeeHandler.Instance.ValidateEmployee(_newEmployee,
                                        AuthenticationHandler.Instance.Token, out var _businessRulesApiResponse);

                                    _errorRowCount = ApiHelper.Instance.HandleApiResponse(_defaultApiResponse, _row, _businessRulesApiResponse,
                                        textBox_employeeImportMessages, _errorRowCount, WorkerFetcher, this);
                                }
                                else
                                {
                                    var _defaultApiResponse = EmployeeHandler.Instance.ImportEmployee(_newEmployee,
                                        AuthenticationHandler.Instance.Token, out var _businessRulesApiResponse);

                                    _errorRowCount = ApiHelper.Instance.HandleApiResponse(_defaultApiResponse, _row, _businessRulesApiResponse,
                                        textBox_employeeImportMessages, _errorRowCount, WorkerFetcher, this);
                                }
                            }
                        }
                    }

                    EmployeeHandler.Instance.DisplayErrorRowCountAndSuccessMessage(_errorRowCount, button_import, button_validate, _senderButton, textBox_employeeImportMessages, this);
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
                Invoke((MethodInvoker)(() => button_employeeSelectFile.Enabled = true));
            }
        }

        #endregion

        #region Helper methods

        private void AddFileColumnHeaderToComboBox(object[] fileColumnHeaderArray)
        {
            comboBox_userName.Items.AddRange(fileColumnHeaderArray);
            comboBox_firstName.Items.AddRange(fileColumnHeaderArray);
            comboBox_lastName.Items.AddRange(fileColumnHeaderArray);
            comboBox_initials.Items.AddRange(fileColumnHeaderArray);
            comboBox_email.Items.AddRange(fileColumnHeaderArray);
            comboBox_managerInitials.Items.AddRange(fileColumnHeaderArray);
            comboBox_defaultHourlyRate.Items.AddRange(fileColumnHeaderArray);
            comboBox_costPrice.Items.AddRange(fileColumnHeaderArray);
            comboBox_publicHolidayCalendar.Items.AddRange(fileColumnHeaderArray);
            comboBox_normalWorkingTime.Items.AddRange(fileColumnHeaderArray);
            comboBox_salaryGroup.Items.AddRange(fileColumnHeaderArray);
            comboBox_jobTitle.Items.AddRange(fileColumnHeaderArray);
            comboBox_employeeNo.Items.AddRange(fileColumnHeaderArray);
            comboBox_employmentDate.Items.AddRange(fileColumnHeaderArray);
            comboBox_legalEntity.Items.AddRange(fileColumnHeaderArray);
            comboBox_department.Items.AddRange(fileColumnHeaderArray);
            comboBox_employeeType.Items.AddRange(fileColumnHeaderArray);
            comboBox_allowanceLegislation.Items.AddRange(fileColumnHeaderArray);
            comboBox_userRoles.Items.AddRange(fileColumnHeaderArray);
        }

        private int? MapFieldValueToID(string columnName, DataGridViewRow row, bool isNullableField)
        {
            if (dataGridView_employee.Columns[columnName] != null)
            {
                var _fieldValue = EmployeeHandler.Instance.CheckAndGetString(dataGridView_employee, columnName, row);
                int _result = -1;

                if (columnName == LegalEntity)
                {
                    _result = EmployeeHandler.Instance.GetIDFromFieldValue(LegalEntityList, _fieldValue);
                }
                else if (columnName == Department)
                {
                    _result = EmployeeHandler.Instance.GetIDFromFieldValue(DepartmentList, _fieldValue);
                }
                else if (columnName == EmployeeType)
                {
                    _result = EmployeeHandler.Instance.GetIDFromFieldValue(EmployeeTypeList, _fieldValue);
                }
                else if (columnName == DefaultHourlyRate)
                {
                    var _legalEntity = EmployeeHandler.Instance.CheckAndGetString(dataGridView_employee, LegalEntity, row);
                    var legalEntityID = EmployeeHandler.Instance.GetIDFromFieldValue(LegalEntityList, _legalEntity);

                    _result = EmployeeHandler.Instance.GetLegalEntityIDFromFieldValue(DefaultHourlyRateList, _fieldValue, legalEntityID);
                }
                else if (columnName == CostPrice)
                {
                    _result = EmployeeHandler.Instance.GetIDFromFieldValue(CostPriceList, _fieldValue);
                }
                else if (columnName == PublicHolidayCalendar)
                {
                    _result = EmployeeHandler.Instance.GetIDFromFieldValue(PublicHolidayCalendarList, _fieldValue);
                }
                else if (columnName == AllowanceLegislation)
                {
                    _result = EmployeeHandler.Instance.GetIDFromFieldValue(AllowanceLegislationList, _fieldValue);
                }
                else if (columnName == NormalWorkingTime)
                {
                    _result = EmployeeHandler.Instance.GetIDFromFieldValue(NormalWorkingTimeList, _fieldValue);
                }
                else if (columnName == SalaryGroup)
                {
                    _result = EmployeeHandler.Instance.GetIDFromFieldValue(SalaryGroupList, _fieldValue);
                }
                else if (columnName == ManagerInitials)
                {
                    _result = EmployeeHandler.Instance.GetIDFromFieldValue(ManagerInitialsList, _fieldValue);
                }
                

                if (_result != -1)
                {
                    return _result;
                }

                //if can't match, display error message
                _errorRowCount = EmployeeHandler.Instance.HandleInvalidFieldValueToIDMapping(columnName, row, _fieldValue, textBox_employeeImportMessages, 
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
            comboBox_userName.ResetText();
            comboBox_userName.Items.Clear();
            comboBox_firstName.ResetText();
            comboBox_firstName.Items.Clear();
            comboBox_lastName.ResetText();
            comboBox_lastName.Items.Clear();
            comboBox_initials.ResetText();
            comboBox_initials.Items.Clear();
            comboBox_email.ResetText();
            comboBox_email.Items.Clear();
            comboBox_managerInitials.ResetText();
            comboBox_managerInitials.Items.Clear();
            comboBox_defaultHourlyRate.ResetText();
            comboBox_defaultHourlyRate.Items.Clear();
            comboBox_costPrice.ResetText();
            comboBox_costPrice.Items.Clear();
            comboBox_publicHolidayCalendar.ResetText();
            comboBox_publicHolidayCalendar.Items.Clear();
            comboBox_normalWorkingTime.ResetText();
            comboBox_normalWorkingTime.Items.Clear();
            comboBox_salaryGroup.ResetText();
            comboBox_salaryGroup.Items.Clear();
            comboBox_jobTitle.ResetText();
            comboBox_jobTitle.Items.Clear();
            comboBox_employeeNo.ResetText();
            comboBox_employeeNo.Items.Clear();
            comboBox_employmentDate.ResetText();
            comboBox_employmentDate.Items.Clear();
            comboBox_legalEntity.ResetText();
            comboBox_legalEntity.Items.Clear();
            comboBox_department.ResetText();
            comboBox_department.Items.Clear();
            comboBox_employeeType.ResetText();
            comboBox_employeeType.Items.Clear();
            comboBox_allowanceLegislation.ResetText();
            comboBox_allowanceLegislation.Items.Clear();
            comboBox_userRoles.ResetText();
            comboBox_userRoles.Items.Clear();
        }

        private void ClearAndResetAllCheckBoxes()
        {
            checkBox_defaultHourlyRate.Checked = false;
            checkBox_defaultCostPrice.Checked = false;
            checkBox_defaultPublicHolidayCalendar.Checked = false;
            checkBox_defaultNormalWorkingTime.Checked = false;
            checkBox_defaultSalaryGroup.Checked = false;
            checkBox_defaultLegalEntity.Checked = false;
            checkBox_defaultDepartment.Checked = false;
            checkBox_defaultEmployeeType.Checked = false;
            checkBox_defaultAllowanceLegislation.Checked = false;
        }

        #endregion

        #region Get default values from API

        private void GetAllLegalEntityFromApi()
        {
            LegalEntityList.Clear();
            var _apiResponse = EmployeeHandler.Instance.GetAllLegalEntity(AuthenticationHandler.Instance.Token);

            if (_apiResponse != null)
            {
                foreach (var _legalEntity in _apiResponse)
                {
                    LegalEntityList.Add(new KeyValuePair<int, string>(_legalEntity.LegalEntityID, _legalEntity.Name));
                }
            }
        }

        private void GetAllDepartmentFromApi()
        {
            DepartmentList.Clear();
            var _apiResponse = EmployeeHandler.Instance.GetAllDepartment(AuthenticationHandler.Instance.Token);

            if (_apiResponse != null)
            {
                foreach (var _department in _apiResponse)
                {
                    DepartmentList.Add(new KeyValuePair<int, string>(_department.DepartmentID, _department.Name));
                }
            }
        }

        private void GetAllEmployeeTypeFromApi()
        {
            EmployeeTypeList.Clear();
            var _apiResponse = EmployeeHandler.Instance.GetAllEmployeeTypes(AuthenticationHandler.Instance.Token);

            if (_apiResponse != null)
            {
                foreach (var _employeeType in _apiResponse)
                {
                    EmployeeTypeList.Add(new KeyValuePair<int, string>(_employeeType.EmployeeTypeID, _employeeType.Name));
                }
            }
        }

        private void GetAllDefaultHourlyRateFromApi()
        {
            DefaultHourlyRateList.Clear();
            var _apiResponse = EmployeeHandler.Instance.GetAllDefaultHourlyRate(AuthenticationHandler.Instance.Token);

            if (_apiResponse != null)
            {
                foreach (var _hourlyRate in _apiResponse)
                {
                    DefaultHourlyRateList.Add(new KeyValuePair<string, string>(_hourlyRate.HourlyRateID + "_" + _hourlyRate.LegalEntityID, _hourlyRate.HourlyRateName));
                }
            }
        }

        private void GetAllCostPriceFromApi()
        {
            CostPriceList.Clear();
            var _apiResponse = EmployeeHandler.Instance.GetAllCostPrices(AuthenticationHandler.Instance.Token);

            if (_apiResponse != null)
            {
                foreach (var _costPrice in _apiResponse)
                {
                    CostPriceList.Add(new KeyValuePair<int, string>(_costPrice.CostPriceID, _costPrice.Name));
                }
            }
        }

        private void GetAllPublicHolidayCalendarFromApi()
        {
            PublicHolidayCalendarList.Clear();
            var _apiResponse = EmployeeHandler.Instance.GetAllHolidayCalendars(AuthenticationHandler.Instance.Token);

            if (_apiResponse != null)
            {
                foreach (var _holidayCalendar in _apiResponse)
                {
                    PublicHolidayCalendarList.Add(new KeyValuePair<int, string>(_holidayCalendar.HolidayCalendarID, _holidayCalendar.Name));
                }
            }
        }

        private void GetAllAllowanceLegislationFromApi()
        {
            AllowanceLegislationList.Clear();
            var _apiResponse = EmployeeHandler.Instance.GetAllAllowanceLegislations(AuthenticationHandler.Instance.Token);

            if (_apiResponse != null)
            {
                foreach (var _allowanceLegislation in _apiResponse)
                {
                    AllowanceLegislationList.Add(new KeyValuePair<int, string>(_allowanceLegislation.AllowanceLegislationID, _allowanceLegislation.Description));
                }
            }
        }

        private void GetAllNormalWorkingTimeFromApi()
        {
            NormalWorkingTimeList.Clear();
            var _apiResponse = EmployeeHandler.Instance.GetAllNormalWorkingTimes(AuthenticationHandler.Instance.Token);

            if (_apiResponse != null)
            {
                foreach (var _normalWorkingTime in _apiResponse)
                {
                    NormalWorkingTimeList.Add(new KeyValuePair<int, string>(_normalWorkingTime.NormalWorkingTimeID, _normalWorkingTime.Name));
                }
            }
        }

        private void GetAllSalaryGroupFromApi()
        {
            SalaryGroupList.Clear();
            var _apiResponse = EmployeeHandler.Instance.GetAllSalaryGroups(AuthenticationHandler.Instance.Token);

            if (_apiResponse != null)
            {
                foreach (var _salaryGroup in _apiResponse)
                {
                    SalaryGroupList.Add(new KeyValuePair<int, string>(_salaryGroup.SalaryGroupID, _salaryGroup.Name));
                }
            }
        }

        private void GetAllManagerFromApi()
        {
            ManagerInitialsList.Clear();
            var _apiResponse = EmployeeHandler.Instance.GetAllEmployee(AuthenticationHandler.Instance.Token);

            if (_apiResponse != null)
            {
                foreach (var _manager in _apiResponse)
                {
                    ManagerInitialsList.Add(new KeyValuePair<int, string>(_manager.UserID, _manager.Initials));
                }
            }
        }

        private void GetAllUserRolesFromApi()
        {
            UserRolesList.Clear();
            var _apiResponse = EmployeeHandler.Instance.GetAllUserRoles(AuthenticationHandler.Instance.Token);

            if (_apiResponse != null)
            {
                foreach (var _userRole in _apiResponse)
                {
                    UserRolesList.Add(new KeyValuePair<int, string>(_userRole.RoleID, _userRole.Name));
                }
            }
        }

        #endregion

        #region Combobox implementations

        private void comboBox_userName_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_employee, _employeeTable,
                comboBox_userName, UserName);
        }

        private void comboBox_firstName_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_employee, _employeeTable,
                comboBox_firstName, FirstName);
        }

        private void comboBox_lastName_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_employee, _employeeTable,
                comboBox_lastName, LastName);
        }

        private void comboBox_initials_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_employee, _employeeTable,
                comboBox_initials, Initials);
        }

        private void comboBox_email_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_employee, _employeeTable,
                comboBox_email, Email);
        }

        private void comboBox_managerInitials_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_employee, _employeeTable,
                comboBox_managerInitials, ManagerInitials);
        }

        private void comboBox_costPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_employee, _employeeTable,
                comboBox_costPrice, CostPrice, checkBox_defaultCostPrice);
        }

        private void comboBox_publicHolidayCalendar_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_employee, _employeeTable,
                comboBox_publicHolidayCalendar, PublicHolidayCalendar, checkBox_defaultPublicHolidayCalendar);
        }

        private void comboBox_normalWorkingTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_employee, _employeeTable,
                comboBox_normalWorkingTime, NormalWorkingTime, checkBox_defaultNormalWorkingTime);
        }

        private void comboBox_salaryGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_employee, _employeeTable,
                comboBox_salaryGroup, SalaryGroup, checkBox_defaultSalaryGroup);
        }

        private void comboBox_legalEntity_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_employee, _employeeTable,
                comboBox_legalEntity, LegalEntity, checkBox_defaultLegalEntity);
        }

        private void comboBox_department_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_employee, _employeeTable,
                comboBox_department, Department, checkBox_defaultDepartment);
        }
        private void comboBox_defaultHourlyRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_employee, _employeeTable,
                comboBox_defaultHourlyRate, DefaultHourlyRate, checkBox_defaultHourlyRate);
        }

        private void comboBox_employeeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_employee, _employeeTable,
                comboBox_employeeType, EmployeeType, checkBox_defaultEmployeeType);
        }
        private void comboBox_jobTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_employee, _employeeTable,
                comboBox_jobTitle, JobTitle);
        }

        private void comboBox_employeeNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_employee, _employeeTable,
                comboBox_employeeNo, EmployeeNo);
        }

        private void comboBox_employmentDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_employee, _employeeTable,
                comboBox_employmentDate, EmploymentDate);
        }

        private void comboBox_allowanceLegislation_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_employee, _employeeTable,
                comboBox_allowanceLegislation, AllowanceLegislation, checkBox_defaultAllowanceLegislation);
        }

        private void comboBox_userRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_employee, _employeeTable,
                comboBox_userRoles, UserRoleNames);
        }

        #endregion

        #region Checkbox implementations

        private void checkBox_defaultEmployeeType_CheckedChanged(object sender, EventArgs e)
        {
            EmployeeHandler.Instance.MapValuesToComboBoxByCheckboxStatus(dataGridView_employee, _employeeTable, comboBox_employeeType,
               EmployeeType, checkBox_defaultEmployeeType, EmployeeTypeList, EmployeeHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());
        }

        private void checkBox_defaultLegalEntity_CheckedChanged(object sender, EventArgs e)
        {
            EmployeeHandler.Instance.MapValuesToComboBoxByCheckboxStatus(dataGridView_employee, _employeeTable, comboBox_legalEntity,
                LegalEntity, checkBox_defaultLegalEntity, LegalEntityList, EmployeeHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());
        }

        private void checkBox_defaultCostPrice_CheckedChanged(object sender, EventArgs e)
        {
            EmployeeHandler.Instance.MapValuesToComboBoxByCheckboxStatus(dataGridView_employee, _employeeTable, comboBox_costPrice,
                CostPrice, checkBox_defaultCostPrice, CostPriceList, EmployeeHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());
        }

        private void checkBox_defaultHourlyRate_CheckedChanged(object sender, EventArgs e)
        {
            var _selectedLegalEntityID = this.comboBox_legalEntity.SelectedItem;
            EmployeeHandler.Instance.MapValuesToComboBoxByCheckboxStatus(dataGridView_employee, _employeeTable, comboBox_defaultHourlyRate,
                DefaultHourlyRate, checkBox_defaultHourlyRate, DefaultHourlyRateList, EmployeeHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());
        }

        private void checkBox_defaultDepartment_CheckedChanged(object sender, EventArgs e)
        {
            EmployeeHandler.Instance.MapValuesToComboBoxByCheckboxStatus(dataGridView_employee, _employeeTable, comboBox_department,
                Department, checkBox_defaultDepartment, DepartmentList, EmployeeHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());
        }

        private void checkBox_defaultPublicHolidayCalendar_CheckedChanged(object sender, EventArgs e)
        {
            EmployeeHandler.Instance.MapValuesToComboBoxByCheckboxStatus(dataGridView_employee, _employeeTable, comboBox_publicHolidayCalendar,
                PublicHolidayCalendar, checkBox_defaultPublicHolidayCalendar, PublicHolidayCalendarList, EmployeeHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());
        }

        private void checkBox_defaultNormalWorkingTime_CheckedChanged(object sender, EventArgs e)
        {
            EmployeeHandler.Instance.MapValuesToComboBoxByCheckboxStatus(dataGridView_employee, _employeeTable, comboBox_normalWorkingTime,
                NormalWorkingTime, checkBox_defaultNormalWorkingTime, NormalWorkingTimeList, EmployeeHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());
        }

        private void checkBox_defaultSalaryGroup_CheckedChanged(object sender, EventArgs e)
        {
            EmployeeHandler.Instance.MapValuesToComboBoxByCheckboxStatus(dataGridView_employee, _employeeTable, comboBox_salaryGroup,
                SalaryGroup, checkBox_defaultSalaryGroup, SalaryGroupList, EmployeeHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());
        }

        private void checkBox_defaultAllowanceLegislation_CheckedChanged(object sender, EventArgs e)
        {
            EmployeeHandler.Instance.MapValuesToComboBoxByCheckboxStatus(dataGridView_employee, _employeeTable, comboBox_allowanceLegislation,
                AllowanceLegislation, checkBox_defaultAllowanceLegislation, AllowanceLegislationList, EmployeeHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());
        }

        #endregion
    }
}