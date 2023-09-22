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
    public partial class UserControl_ContactPersonImport : UserControl
    {
        #region Variable declarations

        private DataTable _contactPersonTable;
        private DataTable _fileContent;
        private Button _senderButton;
        private int _errorRowCount;
        private bool _isMappingFieldValueToIDCorrect;
        private bool _isFirstTimeInvalidMapping;


        private static readonly Dictionary<int, string> MandatoryFields = new Dictionary<int, string>
        {
            {0, "First Name"},
            {1, "Last Name"}
        };

        //all column header variables
        private readonly string _firstName = "First name";
        private readonly string _lastName = "Last name";
        private readonly string _customerNo = @"Customer #";
        private readonly string _owner = "Owner initials";
        private readonly string _reportsTo = "Reports To";
        private readonly string _jobTitle = "Job title";
        private readonly string _department = "Department";
        private readonly string _birthday = "Birthday";
        private readonly string _phoneNo = "Phone no";
        private readonly string _mobilePhone = "Mobile phone no";
        private readonly string _homePhone = "Home phone no";
        private readonly string _faxNo = "Fax";
        private readonly string _email = "E-mail";
        private readonly string _address = "Address";
        private readonly string _address2 = "Address 2";
        private readonly string _address3 = "Address 3";
        private readonly string _zipCode = "Zip code";
        private readonly string _city = "City";
        private readonly string _state = "State";
        private readonly string _country = "Country ISO";
        private readonly string _professionalTitle1 = "Professional title 1";
        private readonly string _initials = "Initials";
        private readonly string _professionalTitle2 = "Professional title 2";

        //default value lists from API 
        private static readonly List<KeyValuePair<int, string>> CountryISOList = new List<KeyValuePair<int, string>>();
        private static readonly List<KeyValuePair<int, string>> CustomerList = new List<KeyValuePair<int, string>>();
        private static readonly List<KeyValuePair<int, string>> EmployeeList = new List<KeyValuePair<int, string>>();

        //expanding panels' current states, expand panels, expand buttons
        private BaseHandler.ExpandState[] _expandStates;
        private Panel[] _expandPanels;
        private Button[] _expandButtons;

        //set the number of pixels expanded per timer Tick
        private const int ExpansionPerTick = 7;

        #endregion

        public UserControl_ContactPersonImport()
        {
            InitializeComponent();
            ContactPersonHandler.Instance.InitializeDelimiterComboBox(comboBox_delimiter);
            InitializeExpandCollapsePanels();
            AddRowNumberToDataTable();
            InitializeAllDefaultValues();
            _contactPersonTable = ContactPersonHandler.Instance.InitializeDomainDataTable(MandatoryFields);
            dataGridView_contactPerson.DataSource = _contactPersonTable;
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
                BaseHandler.ExpandState.Expanded,
                BaseHandler.ExpandState.Expanded
            };
            _expandPanels = new[]
            {
                panel_personDetails,
                panel_contactDetails
            };
            _expandButtons = new[]
            {
                button_personDetails,
                button_contactDetails
            };

            for (int i = 0; i < _expandButtons.Length; i++)
            {
                _expandButtons[i].Tag = i;
                _expandButtons[i].BackgroundImage = Properties.Resources.upload;
            }
        }

        private void InitializeAllDefaultValues()
        {
            GetAllCountryFromApi();
            GetAllEmployeeFromApi();
            GetAllCustomerFromApi();
        }

        #endregion

        #region Functionalities implementations

        private void button_select_contactPerson_file_Click(object sender, EventArgs e)
        {
            ContactPersonHandler.Instance.FileColumnHeaders = new List<string>();
            _fileContent = new DataTable();
            _fileContent = ContactPersonHandler.Instance.GetFileContent(comboBox_delimiter.SelectedItem.ToString());

            if (_fileContent != null)
            {
                textBox_contactPersonImportMessages.Text = string.Empty;
                ClearAndResetAllCheckBoxes();
                ClearAndResetAllComboBoxes();
                Invoke((MethodInvoker)(() => button_import.Enabled = false));

                if (dataGridView_contactPerson.RowCount > 1)
                {
                    dataGridView_contactPerson.DataSource = null;
                    _contactPersonTable = ContactPersonHandler.Instance.InitializeDomainDataTable(MandatoryFields);
                }

                _contactPersonTable = _fileContent.Copy();
                dataGridView_contactPerson.DataSource = _contactPersonTable;

                AddFileColumnHeaderToComboBox(ContactPersonHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());

                ContactPersonHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_profTitle1, _professionalTitle1);
                ContactPersonHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_profTitle2, _professionalTitle2);
                ContactPersonHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_initials, _initials);
                ContactPersonHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_contactPersonFirstName, _firstName);
                ContactPersonHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_contactPersonLastName, _lastName);
                ContactPersonHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_country, _country);
                ContactPersonHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_customerNo, _customerNo);
                ContactPersonHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_jobTitle, _jobTitle);
                ContactPersonHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_owner, _owner);
                ContactPersonHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_reportsTo, _reportsTo);
                ContactPersonHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_birthday, _birthday);
                ContactPersonHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_department, _department);
                ContactPersonHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_phoneNo, _phoneNo);
                ContactPersonHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_mobilePhone, _mobilePhone);
                ContactPersonHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_homePhone, _homePhone);
                ContactPersonHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_faxNo, _faxNo);
                ContactPersonHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_email, _email);
                ContactPersonHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_address, _address);
                ContactPersonHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_address2, _address2);
                ContactPersonHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_address3, _address3);
                ContactPersonHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_zipCode, _zipCode);
                ContactPersonHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_city, _city);
                ContactPersonHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_state, _state);

                this.comboBox_contactPersonFirstName.SelectedIndexChanged += new System.EventHandler(this.comboBox_firstName_SelectedIndexChanged);
                this.comboBox_contactPersonLastName.SelectedIndexChanged += new System.EventHandler(this.comboBox_lastName_SelectedIndexChanged);
                this.comboBox_department.SelectedIndexChanged += new System.EventHandler(this.comboBox_department_SelectedIndexChanged);
                this.comboBox_birthday.SelectedIndexChanged += new System.EventHandler(this.comboBox_birthday_SelectedIndexChanged);
                this.comboBox_owner.SelectedIndexChanged += new System.EventHandler(this.comboBox_owner_SelectedIndexChanged);
                this.comboBox_reportsTo.SelectedIndexChanged += new System.EventHandler(this.comboBox_reportsTo_SelectedIndexChanged);
                this.comboBox_jobTitle.SelectedIndexChanged += new System.EventHandler(this.comboBox_jobTitle_SelectedIndexChanged);
                this.comboBox_customerNo.SelectedIndexChanged += new System.EventHandler(this.comboBox_customerNo_SelectedIndexChanged);
                this.comboBox_phoneNo.SelectedIndexChanged += new System.EventHandler(this.comboBox_phoneNo_SelectedIndexChanged);
                this.comboBox_mobilePhone.SelectedIndexChanged += new System.EventHandler(this.comboBox_phoneNo_SelectedIndexChanged);
                this.comboBox_homePhone.SelectedIndexChanged += new System.EventHandler(this.comboBox_phoneNo_SelectedIndexChanged);
                this.comboBox_faxNo.SelectedIndexChanged += new System.EventHandler(this.comboBox_faxNo_SelectedIndexChanged);
                this.comboBox_email.SelectedIndexChanged += new System.EventHandler(this.comboBox_email_SelectedIndexChanged);
                this.comboBox_address.SelectedIndexChanged += new System.EventHandler(this.comboBox_address_SelectedIndexChanged);
                this.comboBox_address2.SelectedIndexChanged += new System.EventHandler(this.comboBox_address2_SelectedIndexChanged);
                this.comboBox_address3.SelectedIndexChanged += new System.EventHandler(this.comboBox_address3_SelectedIndexChanged);
                this.comboBox_zipCode.SelectedIndexChanged += new System.EventHandler(this.comboBox_zipCode_SelectedIndexChanged);
                this.comboBox_city.SelectedIndexChanged += new System.EventHandler(this.comboBox_city_SelectedIndexChanged);
                this.comboBox_state.SelectedIndexChanged += new System.EventHandler(this.comboBox_state_SelectedIndexChanged);
                this.comboBox_country.SelectedIndexChanged += new System.EventHandler(this.comboBox_country_SelectedIndexChanged);
                this.comboBox_initials.SelectedIndexChanged += new System.EventHandler(this.comboBox_initials_SelectedIndexChanged);
                this.comboBox_profTitle1.SelectedIndexChanged += new System.EventHandler(this.comboBox_profTitle1_SelectedIndexChanged);
                this.comboBox_profTitle2.SelectedIndexChanged += new System.EventHandler(this.comboBox_profTitle2_SelectedIndexChanged);
            }
            else
            {
                button_clear_Click(sender, e);
            }
        }

        private void button_validate_Click(object sender, EventArgs e)
        {
            textBox_contactPersonImportMessages.Text = string.Empty;
            _senderButton = (Button)sender;
            WorkerFetcher.RunWorkerAsync();
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            WorkerFetcher.CancelAsync();
        }

        private void button_import_Click(object sender, EventArgs e)
        {
            textBox_contactPersonImportMessages.Text = string.Empty;
            _senderButton = (Button)sender;
            WorkerFetcher.RunWorkerAsync();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            ContactPersonHandler.Instance.FileColumnHeaders = new List<string>();
            textBox_contactPersonImportMessages.Text = string.Empty;
            ClearAndResetAllCheckBoxes();
            ClearAndResetAllComboBoxes();
            Invoke((MethodInvoker)(() => button_import.Enabled = false));

            dataGridView_contactPerson.DataSource = null;
            _contactPersonTable = ContactPersonHandler.Instance.InitializeDomainDataTable(MandatoryFields);
            dataGridView_contactPerson.DataSource = _contactPersonTable;
        }

        private void textBox_contactPersonImportMessages_MouseClick(object sender, MouseEventArgs e)
        {
            ContactPersonHandler.Instance.HighlightDataTableRowByTextBoxClick(e, dataGridView_contactPerson, textBox_contactPersonImportMessages);
        }

        private void button_expand_Click(object sender, EventArgs e)
        {
            ContactPersonHandler.Instance.ExpandCollapseFieldByButtonClick(sender, _expandStates, _expandButtons, tmrExpand);
        }

        private void tmrExpand_Tick(object sender, EventArgs e)
        {
            ContactPersonHandler.Instance.ProcessExpandCollapseFieldForPanel(_expandPanels, _expandStates, ExpansionPerTick, tmrExpand);
        }

        private void WorkerFetcherDoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (dataGridView_contactPerson != null && dataGridView_contactPerson.RowCount > 1)
            {
                _errorRowCount = 0;

                //while validating, deactivate other buttons
                Invoke((MethodInvoker)(() => button_validate.Enabled = false));
                Invoke((MethodInvoker)(() => button_import.Enabled = false));
                Invoke((MethodInvoker)(() => button_clear.Enabled = false));
                Invoke((MethodInvoker)(() => button_contactPersonSelectFile.Enabled = false));

                Invoke((MethodInvoker)(() => textBox_contactPersonImportMessages.AppendText("Start time: " + DateTime.Now)));

                try
                {
                    foreach (DataGridViewRow _row in dataGridView_contactPerson.Rows)
                    {
                        if (WorkerFetcher.CancellationPending)
                        {
                            break;
                        }

                        _isMappingFieldValueToIDCorrect = true;
                        _isFirstTimeInvalidMapping = true;

                        if (_row.DataBoundItem != null)
                        {
                            ContactPersonCreateModel _newContactPerson = new ContactPersonCreateModel
                            {
                                ProfessionalTitle1 = ContactPersonHandler.Instance.CheckAndGetString(dataGridView_contactPerson, _professionalTitle1, _row),
                                ProfessionalTitle2 = ContactPersonHandler.Instance.CheckAndGetString(dataGridView_contactPerson, _professionalTitle2, _row),
                                Initials = ContactPersonHandler.Instance.CheckAndGetString(dataGridView_contactPerson, _initials, _row),
                                FirstName = ContactPersonHandler.Instance.CheckAndGetString(dataGridView_contactPerson, _firstName, _row),
                                LastName = ContactPersonHandler.Instance.CheckAndGetString(dataGridView_contactPerson, _lastName, _row),
                                CountryID = (int)MapFieldValueToID(_country, _row, false),
                                CustomerID = (int)MapFieldValueToID(_customerNo, _row, false),
                                OwnerID = (int)MapFieldValueToID(_owner, _row, false),
                                JobTitle = ContactPersonHandler.Instance.CheckAndGetString(dataGridView_contactPerson, _jobTitle, _row),
                                Birthday = ContactPersonHandler.Instance.CheckAndGetDate(dataGridView_contactPerson, _birthday, _row),
                                Phone = ContactPersonHandler.Instance.CheckAndGetString(dataGridView_contactPerson, _phoneNo, _row),
                                Mobile = ContactPersonHandler.Instance.CheckAndGetString(dataGridView_contactPerson, _mobilePhone, _row),
                                PrivatePhone = ContactPersonHandler.Instance.CheckAndGetString(dataGridView_contactPerson, _homePhone, _row),
                                Fax = ContactPersonHandler.Instance.CheckAndGetString(dataGridView_contactPerson, _faxNo, _row),
                                Email = ContactPersonHandler.Instance.CheckAndGetString(dataGridView_contactPerson, _email, _row),
                                Department = ContactPersonHandler.Instance.CheckAndGetString(dataGridView_contactPerson, _department, _row),
                                Address = ContactPersonHandler.Instance.CheckAndGetString(dataGridView_contactPerson, _address, _row),
                                Address2 = ContactPersonHandler.Instance.CheckAndGetString(dataGridView_contactPerson, _address2, _row),
                                Address3 = ContactPersonHandler.Instance.CheckAndGetString(dataGridView_contactPerson, _address3, _row),
                                ZipCode = ContactPersonHandler.Instance.CheckAndGetString(dataGridView_contactPerson, _zipCode, _row),
                                City = ContactPersonHandler.Instance.CheckAndGetString(dataGridView_contactPerson, _city, _row),
                                State = ContactPersonHandler.Instance.CheckAndGetString(dataGridView_contactPerson, _state, _row)
                            };

                            if (_isMappingFieldValueToIDCorrect)
                            {
                                if (_senderButton.Name == button_validate.Name)
                                {
                                    var _defaultApiResponse = ContactPersonHandler.Instance.ValidateContactPerson(_newContactPerson,
                                        AuthenticationHandler.Instance.Token, out var _businessRulesApiResponse);

                                    _errorRowCount = ApiHelper.Instance.HandleApiResponse(_defaultApiResponse, _row, _businessRulesApiResponse,
                                        textBox_contactPersonImportMessages, _errorRowCount, WorkerFetcher, this);
                                }
                                else
                                {
                                    var _defaultApiResponse = ContactPersonHandler.Instance.ImportContactPerson(_newContactPerson,
                                        AuthenticationHandler.Instance.Token, out var _businessRulesApiResponse);

                                    _errorRowCount = ApiHelper.Instance.HandleApiResponse(_defaultApiResponse, _row, _businessRulesApiResponse,
                                        textBox_contactPersonImportMessages, _errorRowCount, WorkerFetcher, this);
                                }
                            }
                        }
                    }

                    ContactPersonHandler.Instance.DisplayErrorRowCountAndSuccessMessage(_errorRowCount, button_import, button_validate, _senderButton, textBox_contactPersonImportMessages, this);

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
                Invoke((MethodInvoker)(() => button_contactPersonSelectFile.Enabled = true));
            }
        }

        #endregion

        #region Helper methods

        private void AddFileColumnHeaderToComboBox(object[] fileColumnHeaderArray)
        {
            comboBox_contactPersonFirstName.Items.AddRange(fileColumnHeaderArray);
            comboBox_contactPersonLastName.Items.AddRange(fileColumnHeaderArray);
            comboBox_country.Items.AddRange(fileColumnHeaderArray);
            comboBox_customerNo.Items.AddRange(fileColumnHeaderArray);
            comboBox_jobTitle.Items.AddRange(fileColumnHeaderArray);
            comboBox_owner.Items.AddRange(fileColumnHeaderArray);
            comboBox_reportsTo.Items.AddRange(fileColumnHeaderArray);
            comboBox_birthday.Items.AddRange(fileColumnHeaderArray);
            comboBox_department.Items.AddRange(fileColumnHeaderArray);
            comboBox_phoneNo.Items.AddRange(fileColumnHeaderArray);
            comboBox_mobilePhone.Items.AddRange(fileColumnHeaderArray);
            comboBox_homePhone.Items.AddRange(fileColumnHeaderArray);
            comboBox_faxNo.Items.AddRange(fileColumnHeaderArray);
            comboBox_email.Items.AddRange(fileColumnHeaderArray);
            comboBox_address.Items.AddRange(fileColumnHeaderArray);
            comboBox_address2.Items.AddRange(fileColumnHeaderArray);
            comboBox_address3.Items.AddRange(fileColumnHeaderArray);
            comboBox_zipCode.Items.AddRange(fileColumnHeaderArray);
            comboBox_city.Items.AddRange(fileColumnHeaderArray);
            comboBox_state.Items.AddRange(fileColumnHeaderArray);
            comboBox_initials.Items.AddRange(fileColumnHeaderArray);
            comboBox_profTitle1.Items.AddRange(fileColumnHeaderArray);
            comboBox_profTitle2.Items.AddRange(fileColumnHeaderArray);
        }

        private int? MapFieldValueToID(string columnName, DataGridViewRow row, bool isNullableField)
        {
            if (dataGridView_contactPerson.Columns[columnName] != null)
            {
                var _fieldValue = ContactPersonHandler.Instance.CheckAndGetString(dataGridView_contactPerson, columnName, row);
                int _result = -1;

                if (columnName == _country)
                {
                    _result = ContactPersonHandler.Instance.GetIDFromFieldValue(CountryISOList, _fieldValue);
                }

                else if (columnName == _customerNo)
                {
                    _result = ContactPersonHandler.Instance.GetIDFromFieldValue(CustomerList, _fieldValue);
                }

                else if (columnName == _owner)
                {
                    _result = ContactPersonHandler.Instance.GetIDFromFieldValue(EmployeeList, _fieldValue);
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
                _errorRowCount = ContactPersonHandler.Instance.HandleInvalidFieldValueToIDMapping(columnName, row, _fieldValue, textBox_contactPersonImportMessages,
                    WorkerFetcher, this, _isFirstTimeInvalidMapping, _errorRowCount);
                _isMappingFieldValueToIDCorrect = false;
                _isFirstTimeInvalidMapping = false;
            }



            return 0;
        }

        private void ClearAndResetAllComboBoxes()
        {
            comboBox_profTitle1.ResetText();
            comboBox_profTitle1.Items.Clear();
            comboBox_profTitle2.ResetText();
            comboBox_profTitle2.Items.Clear();
            comboBox_initials.ResetText();
            comboBox_initials.Items.Clear();
            comboBox_contactPersonFirstName.ResetText();
            comboBox_contactPersonFirstName.Items.Clear();
            comboBox_contactPersonLastName.ResetText();
            comboBox_contactPersonLastName.Items.Clear();
            comboBox_country.ResetText();
            comboBox_country.Items.Clear();
            comboBox_customerNo.ResetText();
            comboBox_customerNo.Items.Clear();
            comboBox_jobTitle.ResetText();
            comboBox_jobTitle.Items.Clear();
            comboBox_owner.ResetText();
            comboBox_owner.Items.Clear();
            comboBox_reportsTo.ResetText();
            comboBox_reportsTo.Items.Clear();
            comboBox_birthday.ResetText();
            comboBox_birthday.Items.Clear();
            comboBox_department.ResetText();
            comboBox_department.Items.Clear();
            comboBox_phoneNo.ResetText();
            comboBox_phoneNo.Items.Clear();
            comboBox_faxNo.ResetText();
            comboBox_faxNo.Items.Clear();
            comboBox_email.ResetText();
            comboBox_email.Items.Clear();
            comboBox_address.ResetText();
            comboBox_address.Items.Clear();
            comboBox_address2.ResetText();
            comboBox_address2.Items.Clear();
            comboBox_address3.ResetText();
            comboBox_address3.Items.Clear();
            comboBox_zipCode.ResetText();
            comboBox_zipCode.Items.Clear();
            comboBox_city.ResetText();
            comboBox_city.Items.Clear();
            comboBox_state.ResetText();
            comboBox_state.Items.Clear();

        }

        private void ClearAndResetAllCheckBoxes()
        {
        }

        #endregion

        #region Get default values from API

        private void GetAllCountryFromApi()
        {
            var _apiResponse = ContactPersonHandler.Instance.GetAllCountry(AuthenticationHandler.Instance.Token);

            if (_apiResponse != null)
            {
                foreach (var _country in _apiResponse)
                {
                    CountryISOList.Add(new KeyValuePair<int, string>(_country.CountryID, _country.ISO));
                }
            }
        }

        private void GetAllCustomerFromApi()
        {
            var _apiResponse = ProjectHandler.Instance.GetAllCustomer(AuthenticationHandler.Instance.Token);

            if (_apiResponse != null)
            {
                foreach (var _supplier in _apiResponse)
                {
                    CustomerList.Add(new KeyValuePair<int, string>(_supplier.CustomerID, _supplier.No));
                }
            }
        }

        private void GetAllEmployeeFromApi()
        {
            var _apiResponse = ContractHandler.Instance.GetAllEmployee(AuthenticationHandler.Instance.Token);

            if (_apiResponse != null)
            {
                foreach (var _employee in _apiResponse)
                {
                    EmployeeList.Add(new KeyValuePair<int, string>(_employee.UserID, _employee.Initials));
                }
            }
        }

        #endregion

        #region Combobox implementations

        private void comboBox_firstName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContactPersonHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_contactPerson, _contactPersonTable, comboBox_contactPersonFirstName, _firstName);
        }

        private void comboBox_lastName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContactPersonHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_contactPerson, _contactPersonTable, comboBox_contactPersonLastName, _lastName);
        }

        private void comboBox_country_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContactPersonHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_contactPerson, _contactPersonTable, comboBox_country, _country);
        }

        private void comboBox_customerNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContactPersonHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_contactPerson, _contactPersonTable, comboBox_customerNo, _customerNo);
        }

        private void comboBox_jobTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContactPersonHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_contactPerson, _contactPersonTable, comboBox_jobTitle, _jobTitle);
        }

        private void comboBox_owner_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContactPersonHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_contactPerson, _contactPersonTable, comboBox_owner, _owner);
        }

        private void comboBox_reportsTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContactPersonHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_contactPerson, _contactPersonTable, comboBox_reportsTo, _department);
        }

        private void comboBox_birthday_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContactPersonHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_contactPerson, _contactPersonTable, comboBox_birthday, _birthday);
        }

        private void comboBox_department_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContactPersonHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_contactPerson, _contactPersonTable, comboBox_department, _department);
        }

        private void comboBox_phoneNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContactPersonHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_contactPerson, _contactPersonTable, comboBox_phoneNo, _phoneNo);
        }

        private void comboBox_mobilePhone_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContactPersonHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_contactPerson, _contactPersonTable, comboBox_mobilePhone, _mobilePhone);
        }

        private void comboBox_homePhone_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContactPersonHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_contactPerson, _contactPersonTable, comboBox_homePhone, _homePhone);
        }

        private void comboBox_faxNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContactPersonHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_contactPerson, _contactPersonTable, comboBox_faxNo, _faxNo);
        }

        private void comboBox_email_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContactPersonHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_contactPerson, _contactPersonTable, comboBox_email, _email);
        }

        private void comboBox_address_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContactPersonHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_contactPerson, _contactPersonTable, comboBox_address, _address);
        }

        private void comboBox_address2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContactPersonHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_contactPerson, _contactPersonTable, comboBox_address2, _address2);
        }

        private void comboBox_address3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContactPersonHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_contactPerson, _contactPersonTable, comboBox_address3, _address3);
        }

        private void comboBox_zipCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContactPersonHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_contactPerson, _contactPersonTable, comboBox_zipCode, _zipCode);
        }

        private void comboBox_city_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContactPersonHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_contactPerson, _contactPersonTable, comboBox_city, _city);
        }
        private void comboBox_profTitle1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContactPersonHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_contactPerson, _contactPersonTable, comboBox_profTitle1, _professionalTitle1);
        }
        private void comboBox_profTitle2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContactPersonHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_contactPerson, _contactPersonTable, comboBox_profTitle2, _professionalTitle2);
        }
        private void comboBox_initials_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContactPersonHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_contactPerson, _contactPersonTable, comboBox_initials, _initials);
        }

        private void comboBox_state_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContactPersonHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_contactPerson, _contactPersonTable, comboBox_state, _state);
        }

        #endregion

        private void panel_contactDetails_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label_address_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}