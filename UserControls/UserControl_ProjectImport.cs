﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TimeLog.DataImporter.Handlers;
using TimeLog.DataImporter.TimeLogApi;
using TimeLog.DataImporter.TimeLogApi.Model;

namespace TimeLog.DataImporter.UserControls
{
    public partial class UserControl_ProjectImport : UserControl
    {
        #region Variable declarations

        private DataTable _projectTable;
        private DataTable _fileContent;
        private Button _senderButton;
        private int _errorRowCount;
        private bool _isMappingFieldValueToIDCorrect;
        private bool _isFirstTimeInvalidMapping;

        private static readonly Dictionary<int, string> MandatoryFields = new Dictionary<int, string>
        {
            {0, "Project Name"},
            {1, "Customer No"},
            {2, "Project Template"},
            {3, "Project Manager Initials"},
            {4, "Currency ISO"},
            {5, "Legal Entity Name"},
            {6, "Project Type"},
            {7, "Department Name"}

        };

        //all column header variables
        private readonly string _projectName = "Project Name";
        private readonly string _customerNo = "Customer No";
        private readonly string _projectTemplate = "Project Template";
        private readonly string _projectManager = "Project Manager Initials";
        private readonly string _currencyISO = "Currency ISO";
        private readonly string _legalEntity = "Legal Entity Name";
        private readonly string _departmentName = "Department Name";
        private readonly string _projectNo = "Project No";
        private readonly string _description = "Description";
        private readonly string _projectStartDate = "Project Start Date";
        private readonly string _projectEndDate = "Project End Date";
        private readonly string _projectType = "Project Type";
        private readonly string _projectCategory = "Project Category";
        private readonly string _contactPerson = "Contact Person (email)";
        private readonly string _invoicingCustomerReference = "Customer Inv. Ref.";

        //default value lists from API 
        private static readonly List<KeyValuePair<int, string>> _projectTemplateList = new List<KeyValuePair<int, string>>();
        private static readonly List<KeyValuePair<int, string>> _currencyISOList = new List<KeyValuePair<int, string>>();
        private static readonly List<KeyValuePair<int, string>> _legalEntityList = new List<KeyValuePair<int, string>>();
        private static readonly List<KeyValuePair<int, string>> _departmentList = new List<KeyValuePair<int, string>>();
        private static readonly List<KeyValuePair<int, string>> _projectTypeList = new List<KeyValuePair<int, string>>();
        private static readonly List<KeyValuePair<int, string>> _projectCategoryList = new List<KeyValuePair<int, string>>();
        private static readonly List<KeyValuePair<int, string>> _customerNoList = new List<KeyValuePair<int, string>>();
        private static readonly List<KeyValuePair<int, string>> _projectManagerList = new List<KeyValuePair<int, string>>();
        private static readonly List<KeyValuePair<int, string>> _contactPersonList = new List<KeyValuePair<int, string>>();



        //expanding panels' current states, expand panels, expand buttons
        private BaseHandler.ExpandState[] _expandStates;
        private Panel[] _expandPanels;
        private Button[] _expandButtons;

        //set the number of pixels expanded per timer Tick
        private const int ExpansionPerTick = 7;

        #endregion

        public UserControl_ProjectImport()
        {
            InitializeComponent();
            ProjectHandler.Instance.InitializeDelimiterComboBox(comboBox_delimiter);
            InitializeExpandCollapsePanels();
            AddRowNumberToDataTable();
            InitializeAllDefaultValues();
            _projectTable = ProjectHandler.Instance.InitializeDomainDataTable(MandatoryFields);
            dataGridView_project.DataSource = _projectTable;
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
            GetAllProjectTemplateFromApi();
            GetAllCurrencyFromApi();
            GetAllLegalEntityFromApi();
            GetAllDepartmentsFromApi();
            GetAllProjectTypeFromApi();
            GetAllProjectCategoryFromApi();
            GetAllProjectManagerFromApi();
            GetAllCustomerFromApi();
            GetAllContactPersonFromApi();
        }

        #endregion

        #region Functionalities implementations

        private void button_select_project_file_Click(object sender, EventArgs e)
        {
            ProjectHandler.Instance.FileColumnHeaders = new List<string>();
            _fileContent = new DataTable();
            _fileContent = ProjectHandler.Instance.GetFileContent(comboBox_delimiter.SelectedItem.ToString());

            if (_fileContent != null)
            {
                textBox_projectImportMessages.Text = string.Empty;
                ClearAndResetAllCheckBoxes();
                ClearAndResetAllComboBoxes();
                Invoke((MethodInvoker)(() => button_import.Enabled = false));

                if (dataGridView_project.RowCount > 1)
                {
                    dataGridView_project.DataSource = null;
                    _projectTable = ProjectHandler.Instance.InitializeDomainDataTable(MandatoryFields);
                }

                _projectTable = _fileContent.Copy();
                dataGridView_project.DataSource = _projectTable;

                AddFileColumnHeaderToComboBox(ProjectHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());

                ProjectHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_projectName, _projectName);
                ProjectHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_contactPerson, _contactPerson);
                ProjectHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_projectCustomerNo, _customerNo);
                ProjectHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_projectTemplate, _projectTemplate);
                ProjectHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_projectManager, _projectManager);
                ProjectHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_projectCurrencyISO, _currencyISO);
                ProjectHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_projectLegalEntity, _legalEntity);
                ProjectHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_projectNo, _projectNo);
                ProjectHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_description, _description);
                ProjectHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_projectStartDate, _projectStartDate);
                ProjectHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_projectEndDate, _projectEndDate);
                ProjectHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_projectType, _projectType);
                ProjectHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_projectCategory, _projectCategory);
                ProjectHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_projectDepartment, _departmentName);
                ProjectHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_customerInvRef, _invoicingCustomerReference);

                this.comboBox_projectNo.SelectedIndexChanged += new System.EventHandler(this.comboBox_projectNo_SelectedIndexChanged);
                this.comboBox_description.SelectedIndexChanged += new System.EventHandler(this.comboBox_description_SelectedIndexChanged);
                this.comboBox_projectCategory.SelectedIndexChanged += new System.EventHandler(this.comboBox_projectCategory_SelectedIndexChanged);
                this.comboBox_projectStartDate.SelectedIndexChanged += new System.EventHandler(this.comboBox_projectStartDate_SelectedIndexChanged);
                this.comboBox_projectEndDate.SelectedIndexChanged += new System.EventHandler(this.comboBox_projectEndDate_SelectedIndexChanged);
                this.comboBox_projectDepartment.SelectedIndexChanged += new System.EventHandler(this.comboBox_projectDepartment_SelectedIndexChanged);
                this.comboBox_projectLegalEntity.SelectedIndexChanged += new System.EventHandler(this.comboBox_projectLegalEntity_SelectedIndexChanged);
                this.comboBox_projectCurrencyISO.SelectedIndexChanged += new System.EventHandler(this.comboBox_projectCurrencyISO_SelectedIndexChanged);
                this.comboBox_projectManager.SelectedIndexChanged += new System.EventHandler(this.comboBox_projectManager_SelectedIndexChanged);
                this.comboBox_projectType.SelectedIndexChanged += new System.EventHandler(this.comboBox_projectType_SelectedIndexChanged);
                this.comboBox_projectTemplate.SelectedIndexChanged += new System.EventHandler(this.comboBox_projectTemplate_SelectedIndexChanged);
                this.comboBox_projectCustomerNo.SelectedIndexChanged += new System.EventHandler(this.comboBox_projectCustomerNo_SelectedIndexChanged);
                this.comboBox_projectName.SelectedIndexChanged += new System.EventHandler(this.comboBox_projectName_SelectedIndexChanged);
                this.comboBox_contactPerson.SelectedIndexChanged += new System.EventHandler(this.comboBox_contactPerson_SelectedIndexChanged);
                this.comboBox_customerInvRef.SelectedIndexChanged += new System.EventHandler(this.comboBox_InvoicingCustomerReference_SelectedIndexChanged);
            }
            else
            {
                button_clear_Click(sender, e);
            }
        }

        private void button_validate_Click(object sender, EventArgs e)
        {
            textBox_projectImportMessages.Text = string.Empty;
            _senderButton = (Button)sender;
            WorkerFetcher.RunWorkerAsync();
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            WorkerFetcher.CancelAsync();
        }

        private void button_import_Click(object sender, EventArgs e)
        {
            textBox_projectImportMessages.Text = string.Empty;
            _senderButton = (Button)sender;
            WorkerFetcher.RunWorkerAsync();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            ProjectHandler.Instance.FileColumnHeaders = new List<string>();
            textBox_projectImportMessages.Text = string.Empty;
            ClearAndResetAllCheckBoxes();
            ClearAndResetAllComboBoxes();
            InitializeAllDefaultValues();
            Invoke((MethodInvoker)(() => button_import.Enabled = false));

            dataGridView_project.DataSource = null;
            _projectTable = ProjectHandler.Instance.InitializeDomainDataTable(MandatoryFields);
            dataGridView_project.DataSource = _projectTable;
        }

        private void textBox_projectImportMessages_MouseClick(object sender, MouseEventArgs e)
        {
            ProjectHandler.Instance.HighlightDataTableRowByTextBoxClick(e, dataGridView_project, textBox_projectImportMessages);
        }

        private void button_expand_Click(object sender, EventArgs e)
        {
            ProjectHandler.Instance.ExpandCollapseFieldByButtonClick(sender, _expandStates, _expandButtons, tmrExpand);
        }

        private void tmrExpand_Tick(object sender, EventArgs e)
        {
            ProjectHandler.Instance.ProcessExpandCollapseFieldForPanel(_expandPanels, _expandStates, ExpansionPerTick, tmrExpand);
        }

        private void WorkerFetcherDoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (dataGridView_project != null && dataGridView_project.RowCount > 1)
            {
                _errorRowCount = 0;

                //while validating, deactivate other buttons
                Invoke((MethodInvoker)(() => button_validate.Enabled = false));
                Invoke((MethodInvoker)(() => button_import.Enabled = false));
                Invoke((MethodInvoker)(() => button_clear.Enabled = false));
                Invoke((MethodInvoker)(() => button_projectSelectFile.Enabled = false));

                Invoke((MethodInvoker)(() => textBox_projectImportMessages.AppendText("Start time: " + DateTime.Now)));

                try
                {
                    foreach (DataGridViewRow _row in dataGridView_project.Rows)
                    {
                        if (WorkerFetcher.CancellationPending)
                        {
                            break;
                        }

                        _isMappingFieldValueToIDCorrect = true;
                        _isFirstTimeInvalidMapping = true;

                        if (_row.DataBoundItem != null)
                        {
                            ProjectCreateModel _newProject = new ProjectCreateModel
                            {
                                Name = ProjectHandler.Instance.CheckAndGetString(dataGridView_project, _projectName, _row),
                                CustomerID = (int)MapFieldValueToID(_customerNo, _row, false),
                                ProjectTemplateID = (int)MapFieldValueToID(_projectTemplate, _row, false),
                                ProjectManagerID = (int)MapFieldValueToID(_projectManager, _row, false),
                                CurrencyID = (int)MapFieldValueToID(_currencyISO, _row, false),
                                LegalEntityID = (int)MapFieldValueToID(_legalEntity, _row, false),
                                ProjectNo = ProjectHandler.Instance.CheckAndGetString(dataGridView_project, _projectNo, _row),
                                Description = ProjectHandler.Instance.CheckAndGetString(dataGridView_project, _description, _row),
                                ProjectStartDate = ProjectHandler.Instance.CheckAndGetDate(dataGridView_project, _projectStartDate, _row),
                                ProjectEndDate = ProjectHandler.Instance.CheckAndGetDate(dataGridView_project, _projectEndDate, _row),
                                ProjectTypeID = MapFieldValueToID(_projectType, _row, true),
                                ProjectCategoryID = MapFieldValueToID(_projectCategory, _row, true),
                                DepartmentID = (int)MapFieldValueToID(_departmentName, _row, false),
                                ContactID = MapFieldValueToID(_contactPerson, _row, true),
                                InvoicingCustomerReferenceID = MapFieldValueToID(_invoicingCustomerReference, _row, true)
                            };

                            if (_isMappingFieldValueToIDCorrect)
                            {
                                if (_senderButton.Name == button_validate.Name)
                                {
                                    var _defaultApiResponse = ProjectHandler.Instance.ValidateProject(_newProject,
                                        AuthenticationHandler.Instance.Token, out var _businessRulesApiResponse);

                                    _errorRowCount = ApiHelper.Instance.HandleApiResponse(_defaultApiResponse, _row, _businessRulesApiResponse,
                                        textBox_projectImportMessages, _errorRowCount, WorkerFetcher, this);
                                }
                                else
                                {
                                    var _defaultApiResponse = ProjectHandler.Instance.ImportProject(_newProject,
                                        AuthenticationHandler.Instance.Token, out var _businessRulesApiResponse);

                                    _errorRowCount = ApiHelper.Instance.HandleApiResponse(_defaultApiResponse, _row, _businessRulesApiResponse,
                                        textBox_projectImportMessages, _errorRowCount, WorkerFetcher, this);
                                }
                            }
                        }
                    }

                    ProjectHandler.Instance.DisplayErrorRowCountAndSuccessMessage(_errorRowCount, button_import, button_validate, _senderButton, textBox_projectImportMessages, this);
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
                Invoke((MethodInvoker)(() => button_projectSelectFile.Enabled = true));
            }
        }

        #endregion

        #region Helper methods

        private void AddFileColumnHeaderToComboBox(object[] fileColumnHeaderArray)
        {
            comboBox_projectName.Items.AddRange(fileColumnHeaderArray);
            comboBox_contactPerson.Items.AddRange(fileColumnHeaderArray);
            comboBox_projectCustomerNo.Items.AddRange(fileColumnHeaderArray);
            comboBox_projectManager.Items.AddRange(fileColumnHeaderArray);
            comboBox_projectTemplate.Items.AddRange(fileColumnHeaderArray);
            comboBox_projectCurrencyISO.Items.AddRange(fileColumnHeaderArray);
            comboBox_projectLegalEntity.Items.AddRange(fileColumnHeaderArray);
            comboBox_projectNo.Items.AddRange(fileColumnHeaderArray);
            comboBox_description.Items.AddRange(fileColumnHeaderArray);
            comboBox_projectStartDate.Items.AddRange(fileColumnHeaderArray);
            comboBox_projectEndDate.Items.AddRange(fileColumnHeaderArray);
            comboBox_projectType.Items.AddRange(fileColumnHeaderArray);
            comboBox_projectCategory.Items.AddRange(fileColumnHeaderArray);
            comboBox_projectDepartment.Items.AddRange(fileColumnHeaderArray);
            comboBox_customerInvRef.Items.AddRange(fileColumnHeaderArray);
        }

        private int? MapFieldValueToID(string columnName, DataGridViewRow row, bool isNullableField)
        {
            if (dataGridView_project.Columns[columnName] != null)
            {
                var _fieldValue = ProjectHandler.Instance.CheckAndGetString(dataGridView_project, columnName, row);
                int _result = -1;

                if (columnName == _projectTemplate)
                {
                    _result = ProjectHandler.Instance.GetIDFromFieldValue(_projectTemplateList, _fieldValue);
                }
                else if (columnName == _currencyISO)
                {
                    _result = ProjectHandler.Instance.GetIDFromFieldValue(_currencyISOList, _fieldValue);
                }
                else if (columnName == _legalEntity)
                {
                    _result = ProjectHandler.Instance.GetIDFromFieldValue(_legalEntityList, _fieldValue);
                }
                else if (columnName == _projectType)
                {
                    _result = ProjectHandler.Instance.GetIDFromFieldValue(_projectTypeList, _fieldValue);
                }
                else if (columnName == _projectCategory)
                {
                    _result = ProjectHandler.Instance.GetIDFromFieldValue(_projectCategoryList, _fieldValue);
                }
                else if (columnName == _projectManager)
                {
                    _result = ProjectHandler.Instance.GetIDFromFieldValue(_projectManagerList, _fieldValue);
                }
                else if (columnName == _customerNo)
                {
                    _result = ProjectHandler.Instance.GetIDFromFieldValue(_customerNoList, _fieldValue);
                }
                else if (columnName == _departmentName)
                {
                    _result = ProjectHandler.Instance.GetIDFromFieldValue(_departmentList, _fieldValue);
                }
                else if (columnName == _contactPerson)
                {
                    if (string.IsNullOrWhiteSpace(_fieldValue))
                    {
                        return null;
                    }

                    _result = ProjectHandler.Instance.GetIDFromFieldValue(_contactPersonList, _fieldValue);
                    
                    if(_result == -1)
                    {
                        isNullableField = false;
                    }
                }
                else if (columnName == _invoicingCustomerReference)
                {
                    switch (_fieldValue)
                    {
                        case "-1":
                            return -1;
                        case "0":
                            return 0;
                        default:
                            _result = ProjectHandler.Instance.GetIDFromFieldValue(_contactPersonList, _fieldValue);
                            break;
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
                _errorRowCount = ProjectHandler.Instance.HandleInvalidFieldValueToIDMapping(columnName, row, _fieldValue, textBox_projectImportMessages,
                    WorkerFetcher, this, _isFirstTimeInvalidMapping, _errorRowCount);
                _isMappingFieldValueToIDCorrect = false;
                _isFirstTimeInvalidMapping = false;
            }



            return 0;
        }

        private void ClearAndResetAllComboBoxes()
        {
            comboBox_contactPerson.ResetText();
            comboBox_contactPerson.Items.Clear();
            comboBox_projectName.ResetText();
            comboBox_projectName.Items.Clear();
            comboBox_projectCustomerNo.ResetText();
            comboBox_projectCustomerNo.Items.Clear();
            comboBox_projectTemplate.ResetText();
            comboBox_projectTemplate.Items.Clear();
            comboBox_projectManager.ResetText();
            comboBox_projectManager.Items.Clear();
            comboBox_projectCurrencyISO.ResetText();
            comboBox_projectCurrencyISO.Items.Clear();
            comboBox_projectLegalEntity.ResetText();
            comboBox_projectLegalEntity.Items.Clear();
            comboBox_projectNo.ResetText();
            comboBox_projectNo.Items.Clear();
            comboBox_description.ResetText();
            comboBox_description.Items.Clear();
            comboBox_projectStartDate.ResetText();
            comboBox_projectStartDate.Items.Clear();
            comboBox_projectEndDate.ResetText();
            comboBox_projectEndDate.Items.Clear();
            comboBox_projectType.ResetText();
            comboBox_projectType.Items.Clear();
            comboBox_projectCategory.ResetText();
            comboBox_projectCategory.Items.Clear();
            comboBox_projectDepartment.ResetText();
            comboBox_projectDepartment.Items.Clear();
            comboBox_customerInvRef.Items.Clear();
            comboBox_customerInvRef.ResetText();
        }

        private void ClearAndResetAllCheckBoxes()
        {
            checkBox_defaultProjectTemplate.Checked = false;
            checkBox_defaultCurrencyISO.Checked = false;
            checkBox_defaultLegalEntity.Checked = false;
            checkBox_defaultProjectType.Checked = false;
            checkBox_defaultProjectCategory.Checked = false;
            checkBox_defaultProjectDepartment.Checked = false;
        }

        #endregion

        #region Get default values from API

        private void GetAllProjectTemplateFromApi()
        {
            _projectTemplateList.Clear();
            var _apiResponse = ProjectHandler.Instance.GetAllProjectTemplate(AuthenticationHandler.Instance.Token);

            if (_apiResponse != null)
            {
                foreach (var _projectTemplate in _apiResponse)
                {
                    _projectTemplateList.Add(new KeyValuePair<int, string>(_projectTemplate.ProjectTemplateID, _projectTemplate.ProjectTemplateName));
                }
            }
        }

        private void GetAllCurrencyFromApi()
        {
            _currencyISOList.Clear();
            var _apiResponse = ProjectHandler.Instance.GetAllCurrency(AuthenticationHandler.Instance.Token);

            if (_apiResponse != null)
            {
                foreach (var _currency in _apiResponse)
                {
                    _currencyISOList.Add(new KeyValuePair<int, string>(_currency.CurrencyID, _currency.CurrencyABB));
                }
            }
        }

        private void GetAllLegalEntityFromApi()
        {
            _legalEntityList.Clear();
            var _apiResponse = ProjectHandler.Instance.GetAllLegalEntity(AuthenticationHandler.Instance.Token);

            if (_apiResponse != null)
            {
                foreach (var _legalEntity in _apiResponse)
                {
                    _legalEntityList.Add(new KeyValuePair<int, string>(_legalEntity.LegalEntityID, _legalEntity.Name));
                }
            }
        }

        private void GetAllDepartmentsFromApi()
        {
            _departmentList.Clear();
            var _apiResponse = ProjectHandler.Instance.GetAllDepartment(AuthenticationHandler.Instance.Token);

            if (_apiResponse != null)
            {
                foreach (var _department in _apiResponse)
                {
                    _departmentList.Add(new KeyValuePair<int, string>(_department.DepartmentID, _department.Name));
                }
            }
        }

        private void GetAllProjectTypeFromApi()
        {
            _projectTypeList.Clear();
            var _apiResponse = ProjectHandler.Instance.GetAllProjectType(AuthenticationHandler.Instance.Token);

            if (_apiResponse != null)
            {
                foreach (var _projectType in _apiResponse)
                {
                    _projectTypeList.Add(new KeyValuePair<int, string>(_projectType.ProjectTypeID, _projectType.Name));
                }
            }
        }

        private void GetAllProjectCategoryFromApi()
        {
            _projectCategoryList.Clear();
            var _apiResponse = ProjectHandler.Instance.GetAllProjectCategory(AuthenticationHandler.Instance.Token);

            if (_apiResponse != null)
            {
                foreach (var _projectCategory in _apiResponse)
                {
                    _projectCategoryList.Add(new KeyValuePair<int, string>(_projectCategory.ProjectCategoryID, _projectCategory.Name));
                }
            }
        }

        private void GetAllProjectManagerFromApi()
        {
            _projectManagerList.Clear();
            var _apiResponse = ProjectHandler.Instance.GetAllEmployee(AuthenticationHandler.Instance.Token);

            if (_apiResponse != null)
            {
                foreach (var _projectManager in _apiResponse)
                {
                    _projectManagerList.Add(new KeyValuePair<int, string>(_projectManager.UserID, _projectManager.Initials));
                }
            }
        }

        private void GetAllCustomerFromApi()
        {
            _customerNoList.Clear();
            var _customerStatus = ProjectHandler.Instance.GetAllCustomerStatus(AuthenticationHandler.Instance.Token);

            var _apiResponse = ProjectHandler.Instance.GetAllCustomer(AuthenticationHandler.Instance.Token);

            if (_apiResponse != null)
            {
                foreach (var _customer in _apiResponse.Where(x => x.CustomerStatusID == _customerStatus.First(y => y.IsDefault).CustomerStatusID))
                {
                    _customerNoList.Add(new KeyValuePair<int, string>(_customer.CustomerID, _customer.No));
                }
            }
        }

        private void GetAllContactPersonFromApi()
        {
            _contactPersonList.Clear();

            _contactPersonList.Add(new KeyValuePair<int, string>(-1, "Projects contact"));
            _contactPersonList.Add(new KeyValuePair<int, string>(0, "select on invoicing"));

            var _apiResponse = CustomerHandler.Instance.GetContactPersonMethod(AuthenticationHandler.Instance.Token);

            if (_apiResponse != null)
            {
                foreach (var _contactPerson in _apiResponse)
                {
                    _contactPersonList.Add(new KeyValuePair<int, string>(_contactPerson.ID,
                        _contactPerson.Email));
                }
            }
        }

        #endregion

        #region Combobox implementations

        private void comboBox_contactPerson_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProjectHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_project, _projectTable, comboBox_contactPerson, _contactPerson);
        }

        private void comboBox_InvoicingCustomerReference_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProjectHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_project, _projectTable, comboBox_customerInvRef, _contactPerson);
        }

        private void comboBox_projectName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProjectHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_project, _projectTable, comboBox_projectName, _projectName);
        }

        private void comboBox_projectCustomerNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProjectHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_project, _projectTable, comboBox_projectCustomerNo, _customerNo);
        }

        private void comboBox_projectTemplate_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProjectHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_project, _projectTable, comboBox_projectTemplate, _projectTemplate, checkBox_defaultProjectTemplate);
        }

        private void comboBox_projectManager_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProjectHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_project, _projectTable, comboBox_projectManager, _projectManager);
        }

        private void comboBox_projectCurrencyISO_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProjectHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_project, _projectTable, comboBox_projectCurrencyISO, _currencyISO, checkBox_defaultCurrencyISO);
        }

        private void comboBox_projectLegalEntity_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProjectHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_project, _projectTable, comboBox_projectLegalEntity, _legalEntity, checkBox_defaultLegalEntity);
        }

        private void comboBox_projectNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProjectHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_project, _projectTable, comboBox_projectNo, _projectNo);
        }

        private void comboBox_description_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProjectHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_project, _projectTable, comboBox_description, _description);
        }

        private void comboBox_projectStartDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProjectHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_project, _projectTable, comboBox_projectStartDate, _projectStartDate);
        }

        private void comboBox_projectEndDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProjectHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_project, _projectTable, comboBox_projectEndDate, _projectEndDate);
        }

        private void comboBox_projectType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProjectHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_project, _projectTable, comboBox_projectType, _projectType, checkBox_defaultProjectType);
        }

        private void comboBox_projectCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProjectHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_project, _projectTable, comboBox_projectCategory, _projectCategory, checkBox_defaultProjectCategory);
        }

        private void comboBox_projectDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProjectHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_project, _projectTable, comboBox_projectDepartment, _departmentName, checkBox_defaultProjectDepartment);
        }
        #endregion

        #region Checkbox implementations

        private void checkBox_defaultCurrencyISO_CheckedChanged(object sender, EventArgs e)
        {
            ProjectHandler.Instance.MapValuesToComboBoxByCheckboxStatus(dataGridView_project, _projectTable, comboBox_projectCurrencyISO,
                _currencyISO, checkBox_defaultCurrencyISO, _currencyISOList, ProjectHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());
        }

        private void checkBox_defaultProjectTemplate_CheckedChanged(object sender, EventArgs e)
        {
            ProjectHandler.Instance.MapValuesToComboBoxByCheckboxStatus(dataGridView_project, _projectTable, comboBox_projectTemplate,
                _projectTemplate, checkBox_defaultProjectTemplate, _projectTemplateList, ProjectHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());
        }

        private void checkBox_defaultLegalEntity_CheckedChanged(object sender, EventArgs e)
        {
            ProjectHandler.Instance.MapValuesToComboBoxByCheckboxStatus(dataGridView_project, _projectTable, comboBox_projectLegalEntity,
                _legalEntity, checkBox_defaultLegalEntity, _legalEntityList, ProjectHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());
        }

        private void checkBox_defaultProjectType_CheckedChanged(object sender, EventArgs e)
        {
            ProjectHandler.Instance.MapValuesToComboBoxByCheckboxStatus(dataGridView_project, _projectTable, comboBox_projectType,
                _projectType, checkBox_defaultProjectType, _projectTypeList, ProjectHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());
        }

        private void checkBox_defaultProjectCategory_CheckedChanged(object sender, EventArgs e)
        {
            ProjectHandler.Instance.MapValuesToComboBoxByCheckboxStatus(dataGridView_project, _projectTable, comboBox_projectCategory,
                _projectCategory, checkBox_defaultProjectCategory, _projectCategoryList, ProjectHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());
        }

        private void checkBox_defaultProjectDepartment_CheckedChanged(object sender, EventArgs e)
        {
            ProjectHandler.Instance.MapValuesToComboBoxByCheckboxStatus(dataGridView_project, _projectTable, comboBox_projectDepartment,
                _departmentName, checkBox_defaultProjectDepartment, _departmentList, ProjectHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());
        }

        //private void checkBox_defaultContactPerson_CheckedChanged(object sender, EventArgs e)
        //{
        //    ProjectHandler.Instance.MapValuesToComboBoxByCheckboxStatus(dataGridView_project, _projectTable, comboBox_contactPerson,
        //        _contactPerson, checkBox_defaultProjectDepartment, _departmentList, ProjectHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());
        //}
        #endregion


    }
}