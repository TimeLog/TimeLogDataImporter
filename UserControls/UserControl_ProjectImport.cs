using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
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
        private bool _isRowValid = true;
        private int _errorRowCount;
        private bool _isMappingFieldValueToIDCorrect = true;

        private static readonly Dictionary<int, string> MandatoryFields = new Dictionary<int, string>
        {
            {0, "Project Name"},
            {1, "Customer ID"},
            {2, "Project Template"},
            {3, "Project Manager ID"},
            {4, "Currency ISO"},
            {5, "Legal Entity"},
            {6, "Project Type"}
        };

        //all column header variables
        private readonly string _projectName = "Project Name";
        private readonly string _customerID = "Customer ID";
        private readonly string _projectTemplate = "Project Template";
        private readonly string _projectManagerID = "Project Manager ID";
        private readonly string _currencyISO = "Currency ISO";
        private readonly string _legalEntity = "Legal Entity";
        private readonly string _projectNo = "Project No";
        private readonly string _description = "Description";
        private readonly string _projectStartDate = "Project Start Date";
        private readonly string _projectEndDate = "Project End Date";
        private readonly string _projectType = "Project Type";
        private readonly string _projectCategory = "Project Category";

        //default value lists from API 
        private List<KeyValuePair<int, string>> _projectTemplateList;
        private List<KeyValuePair<int, string>> _currencyISOList;
        private List<KeyValuePair<int, string>> _legalEntityList;
        private List<KeyValuePair<int, string>> _projectTypeList;
        private List<KeyValuePair<int, string>> _projectCategoryList;

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

        //private void InitializeDelimiterComboBox()
        //{
        //    comboBox_delimiter.Items.AddRange(ProjectHandler.Instance.GetDelimiterList().Cast<object>().ToArray());
        //    comboBox_delimiter.SelectedIndex = 0;
        //}

        //private void InitializeProjectDataTable()
        //{
        //    _projectTable = new DataTable();

        //    foreach (var _mandatoryField in MandatoryFields)
        //    {
        //        _projectTable.Columns.Add(_mandatoryField.Value);
        //    }
        //}

        private void InitializeAllDefaultValues()
        {
            GetAllProjectTemplateFromApi();
            GetAllCurrencyFromApi();
            GetAllLegalEntityFromApi();
            GetAllProjectTypeFromApi();
            GetAllProjectCategoryFromApi();
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
                    //InitializeProjectDataTable();
                    dataGridView_project.DataSource = _projectTable;
                }

                foreach (DataRow _fileContentRow in _fileContent.Rows)
                {
                    _projectTable.Rows.Add();
                }

                AddFileColumnHeaderToComboBox(ProjectHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());
            }
            else
            {
                button_clear_Click(sender, e);
            }
        }

        private void button_validate_Click(object sender, EventArgs e)
        {
            textBox_projectImportMessages.Text = string.Empty;
            _senderButton = (Button) sender;
            WorkerFetcher.RunWorkerAsync();
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            WorkerFetcher.CancelAsync();
        }

        private void button_import_Click(object sender, EventArgs e)
        {
            textBox_projectImportMessages.Text = string.Empty;
            _senderButton = (Button) sender;
            WorkerFetcher.RunWorkerAsync();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            ProjectHandler.Instance.FileColumnHeaders = new List<string>();
            textBox_projectImportMessages.Text = string.Empty;
            ClearAndResetAllCheckBoxes();
            ClearAndResetAllComboBoxes();
            Invoke((MethodInvoker)(() => button_import.Enabled = false));

            dataGridView_project.DataSource = null;
            _projectTable = ProjectHandler.Instance.InitializeDomainDataTable(MandatoryFields);
            dataGridView_project.DataSource = _projectTable;
        }

        private void textBox_projectImportMessages_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var _position = textBox_projectImportMessages.GetCharIndexFromPosition(e.Location);
                var _lineNo = textBox_projectImportMessages.GetLineFromCharIndex(_position) - 1;

                for (int i = 0; i < dataGridView_project.Rows.Count - 1; i++)
                {
                    if (i == _lineNo)
                    {
                        Invoke((MethodInvoker)(() => dataGridView_project.Rows[i].Selected = true));
                        dataGridView_project.FirstDisplayedScrollingRowIndex = i;
                        dataGridView_project.Focus();
                        break;
                    }
                }
            }
        }

        private void button_expand_Click(object sender, EventArgs e)
        {
            Button _button = sender as Button;
            int _index = (int)_button.Tag;

            // Get this panel's current expand state and set its new state
            BaseHandler.ExpandState _oldState = _expandStates[_index];

            if (_oldState == BaseHandler.ExpandState.Collapsed || _oldState == BaseHandler.ExpandState.Collapsing)
            {
                _expandStates[_index] = BaseHandler.ExpandState.Expanding;
                _expandButtons[_index].BackgroundImage = Properties.Resources.upload;
            }
            else
            {
                _expandStates[_index] = BaseHandler.ExpandState.Collapsing;
                _expandButtons[_index].BackgroundImage = Properties.Resources.download;
            }

            tmrExpand.Enabled = true;
        }

        private void tmrExpand_Tick(object sender, EventArgs e)
        {
            bool _notDone = false;

            for (int i = 0; i < _expandPanels.Length; i++)
            {
                Panel _panel = _expandPanels[i];
                int _newHeight = _panel.Height;

                if (_expandStates[i] == BaseHandler.ExpandState.Expanding)
                {
                    _newHeight = _panel.Height + ExpansionPerTick;

                    if (_newHeight <= _panel.MaximumSize.Height)
                    {
                        _newHeight = _panel.MaximumSize.Height;
                    }
                    else
                    {
                        _notDone = true;
                    }
                }
                else if (_expandStates[i] == BaseHandler.ExpandState.Collapsing)
                {
                    _newHeight = _panel.Height - ExpansionPerTick;

                    if (_newHeight <= _panel.MinimumSize.Height)
                    {
                        _newHeight = _panel.MinimumSize.Height;
                    }
                    else
                    {
                        _notDone = true;
                    }
                }

                _panel.Height = _newHeight;
            }

            // If we are done, disable the timer
            tmrExpand.Enabled = _notDone;
        }

        private void WorkerFetcherDoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (dataGridView_project != null && dataGridView_project.RowCount > 1)
            {
                _isRowValid = true;
                _errorRowCount = 0;

                //while validating, deactivate other buttons
                Invoke((MethodInvoker)(() => button_validate.Enabled = false));
                Invoke((MethodInvoker)(() => button_import.Enabled = false));
                Invoke((MethodInvoker)(() => button_clear.Enabled = false));
                Invoke((MethodInvoker)(() => button_projectSelectFile.Enabled = false));

                try
                {
                    foreach (DataGridViewRow _row in dataGridView_project.Rows)
                    {
                        if (WorkerFetcher.CancellationPending)
                        {
                            break;
                        }

                        _isMappingFieldValueToIDCorrect = true;

                        if (_row.DataBoundItem != null)
                        {
                            ProjectCreateModel _newProject = new ProjectCreateModel
                            {
                                Name = ProjectHandler.Instance.CheckAndGetString(dataGridView_project, _projectName, _row),
                                CustomerID = ProjectHandler.Instance.CheckAndGetInteger(dataGridView_project, _customerID, _row),
                                ProjectTemplateID = (int) MapFieldValueToID(_projectTemplate, _row, false),
                                ProjectManagerID = ProjectHandler.Instance.CheckAndGetInteger(dataGridView_project, _projectManagerID, _row),
                                CurrencyID = (int) MapFieldValueToID(_currencyISO, _row, false),
                                LegalEntityID = (int) MapFieldValueToID(_legalEntity, _row, false),
                                ProjectNo = ProjectHandler.Instance.CheckAndGetString(dataGridView_project, _projectNo, _row),
                                Description = ProjectHandler.Instance.CheckAndGetString(dataGridView_project, _description, _row),
                                ProjectStartDate = ProjectHandler.Instance.CheckAndGetDate(dataGridView_project, _projectStartDate, _row),
                                ProjectEndDate = ProjectHandler.Instance.CheckAndGetDate(dataGridView_project, _projectEndDate, _row),
                                ProjectTypeID = (int) MapFieldValueToID(_projectType, _row, false),
                                ProjectCategoryID = (int) MapFieldValueToID(_projectCategory, _row, false)
                            };

                            if (_isMappingFieldValueToIDCorrect)
                            {
                                if (_senderButton.Name == button_validate.Name)
                                {
                                    var _defaultApiResponse = ProjectHandler.Instance.ValidateProject(_newProject,
                                        AuthenticationHandler.Instance.Token, out var _businessRulesApiResponse);

                                    HandleApiResponse(_defaultApiResponse, _row, _businessRulesApiResponse);

                                }
                                else
                                {
                                    var _defaultApiResponse = ProjectHandler.Instance.ImportProject(_newProject,
                                        AuthenticationHandler.Instance.Token, out var _businessRulesApiResponse);

                                    HandleApiResponse(_defaultApiResponse, _row, _businessRulesApiResponse);

                                    _isRowValid = false;
                                }
                            }
                        }
                    }

                    //show error row count at the end
                    Invoke((MethodInvoker)(() => textBox_projectImportMessages.AppendText(Environment.NewLine + Environment.NewLine)));
                    Invoke((MethodInvoker)(() => textBox_projectImportMessages.AppendText("Invalid data input row count: " + _errorRowCount)));
                    Invoke((MethodInvoker)(() => textBox_projectImportMessages.AppendText(Environment.NewLine + Environment.NewLine)));

                    //display success message after import / validation is done
                    if (_errorRowCount == 0)
                    {
                        if (_senderButton.Name == button_validate.Name)
                        {
                            Invoke((MethodInvoker)(() => textBox_projectImportMessages.AppendText("Validation completed successfully with no error. You may press the Import button to start importing data right away.")));
                        }
                        else
                        {
                            Invoke((MethodInvoker)(() => textBox_projectImportMessages.AppendText("Data import completed successfully with no error. Excellent!")));
                        }
                    }
                    else
                    {
                        Invoke((MethodInvoker)(() => textBox_projectImportMessages.AppendText("Validation completed successfully with " + _errorRowCount + " error(s). You may modify the invalid input data and then press Validate button again.")));
                    }

                    //enable import button when there is no error in validation
                    if (_isRowValid)
                    {
                        Invoke((MethodInvoker)(() => button_import.Enabled = true));
                    }
                    else
                    {
                        Invoke((MethodInvoker)(() => button_import.Enabled = false));
                    }
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

        private void HandleApiResponse(DefaultApiResponse defaultResponse, DataGridViewRow row, BusinessRulesApiResponse businessRulesResponse)
        {
            if (defaultResponse != null)
            {
                if (defaultResponse.Code == 200)
                {
                    Invoke((MethodInvoker)(() => row.DefaultCellStyle.BackColor = Color.LimeGreen));
                    Invoke((MethodInvoker)(() => textBox_projectImportMessages.AppendText(Environment.NewLine)));
                    Invoke((MethodInvoker)(() => textBox_projectImportMessages.AppendText("Row " + (row.Index + 1) + " - " + defaultResponse.Message)));
                }
                else if (defaultResponse.Code == 401)
                {
                    Invoke((MethodInvoker)(() => row.DefaultCellStyle.BackColor = Color.Red));
                    Invoke((MethodInvoker)(() => textBox_projectImportMessages.AppendText(Environment.NewLine)));
                    Invoke((MethodInvoker)(() => textBox_projectImportMessages.AppendText("Row " + (row.Index + 1) + " - " + defaultResponse.Message)));
                    _errorRowCount++;
                    _isRowValid = false;
                    //return to login page if token has expired
                    RedirectToLoginPage();
                }
                else if (defaultResponse.Code == 201)
                {
                    Invoke((MethodInvoker)(() => row.DefaultCellStyle.BackColor = Color.Red));
                    Invoke((MethodInvoker)(() => textBox_projectImportMessages.AppendText(Environment.NewLine)));
                    Invoke((MethodInvoker)(() => textBox_projectImportMessages.AppendText("Row " + (row.Index + 1)
                       + " - " + defaultResponse.Message + " Details: " + string.Join("  ", defaultResponse.Details))));
                    _errorRowCount++;
                    _isRowValid = false;
                }
                else if (defaultResponse.Code == 500)
                {
                    Invoke((MethodInvoker)(() => row.DefaultCellStyle.BackColor = Color.Red));
                    Invoke((MethodInvoker)(() => textBox_projectImportMessages.AppendText(Environment.NewLine)));
                    Invoke((MethodInvoker)(() => textBox_projectImportMessages.AppendText("Row " + (row.Index + 1) + " - " + defaultResponse.Message)));
                    _errorRowCount++;
                    _isRowValid = false;
                }
            }
            else
            {
                if (businessRulesResponse.Code == 102)
                {
                    Invoke((MethodInvoker)(() => row.DefaultCellStyle.BackColor = Color.Red));
                    Invoke((MethodInvoker)(() => textBox_projectImportMessages.AppendText(Environment.NewLine)));
                    Invoke((MethodInvoker)(() => textBox_projectImportMessages.AppendText("Row " + (row.Index + 1)
                       + " - " + businessRulesResponse.Message + " Details: "
                       + string.Join(".  ", businessRulesResponse.Details.Select(x => x.Message)))));
                    _errorRowCount++;
                    _isRowValid = false;
                }
            }
        }

        private void RedirectToLoginPage()
        {
            MessageBox.Show("Authentication token has expired. You will be redirected to the Login page to login again.",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            WorkerFetcher.CancelAsync();
            Invoke((MethodInvoker)(() => Login.MainForm.Hide()));
            Invoke((MethodInvoker)(() => Program.LoginForm.Show()));
        }

        private void AddFileColumnHeaderToComboBox(object[] fileColumnHeaderArray)
        {
            comboBox_projectName.Items.AddRange(fileColumnHeaderArray);
            comboBox_projectCustomerID.Items.AddRange(fileColumnHeaderArray);
            comboBox_projectManagerID.Items.AddRange(fileColumnHeaderArray);
            comboBox_projectTemplate.Items.AddRange(fileColumnHeaderArray);
            comboBox_projectCurrencyISO.Items.AddRange(fileColumnHeaderArray);
            comboBox_projectLegalEntity.Items.AddRange(fileColumnHeaderArray);
            comboBox_projectNo.Items.AddRange(fileColumnHeaderArray);
            comboBox_description.Items.AddRange(fileColumnHeaderArray);
            comboBox_projectStartDate.Items.AddRange(fileColumnHeaderArray);
            comboBox_projectEndDate.Items.AddRange(fileColumnHeaderArray);
            comboBox_projectType.Items.AddRange(fileColumnHeaderArray);
            comboBox_projectCategory.Items.AddRange(fileColumnHeaderArray);
        }

        private void MapFileContentToTable(int tableColumnIndex, int fileColumnIndex)
        {
            for (int i = 0; i < _fileContent.Rows.Count; i++)
            {
                Invoke((MethodInvoker)(() => _projectTable.Rows[i][tableColumnIndex] = _fileContent.Rows[i][fileColumnIndex]));
            }

            dataGridView_project.Rows[0].Cells[tableColumnIndex].Selected = true;
            dataGridView_project.FirstDisplayedScrollingColumnIndex = tableColumnIndex;
            dataGridView_project.Focus();
        }

        private void MapDefaultValueToTable(int tableColumnIndex, string defaultValue)
        {
            for (int i = 0; i < _projectTable.Rows.Count; i++)
            {
                Invoke((MethodInvoker)(() => _projectTable.Rows[i][tableColumnIndex] = defaultValue));
            }

            dataGridView_project.Rows[0].Cells[tableColumnIndex].Selected = true;
            dataGridView_project.FirstDisplayedScrollingColumnIndex = tableColumnIndex;
            dataGridView_project.Focus();
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

                if (_result != -1)
                {
                    return _result;
                }

                //if can't match, display error message
                HandleInvalidFieldValueToIDMapping(columnName, row, _fieldValue);
            }

            if (isNullableField)
            {
                return null;
            }

            return 0;
        }

        private void HandleInvalidFieldValueToIDMapping(string columnName, DataGridViewRow row, string fieldValue)
        {
            Invoke((MethodInvoker)(() => row.DefaultCellStyle.BackColor = Color.Red));
            Invoke((MethodInvoker)(() => textBox_projectImportMessages.AppendText(Environment.NewLine)));

            if (string.IsNullOrEmpty(fieldValue))
            {
                Invoke((MethodInvoker)(() => textBox_projectImportMessages.AppendText("Row " + (row.Index + 1) +
                   " - " + columnName + " is empty.")));
            }
            else
            {
                Invoke((MethodInvoker)(() => textBox_projectImportMessages.AppendText("Row " + (row.Index + 1) +
                    " - " + columnName + " '" + fieldValue + "' doesn't exist in TimeLog.")));
            }

            _isMappingFieldValueToIDCorrect = false;
            _errorRowCount++;
            _isRowValid = false;
            WorkerFetcher.CancelAsync();
        }

        private void CheckAndAddColumn(string columnName)
        {
            if (!_projectTable.Columns.Contains(columnName))
            {
                _projectTable.Columns.Add(columnName);
            }
        }

        private void CheckCellsForNullOrEmpty(int columnIndex)
        {
            foreach (DataGridViewRow _row in dataGridView_project.Rows)
            {
                if (_row.Cells[columnIndex].Value == null || string.IsNullOrEmpty(_row.Cells[columnIndex].Value.ToString()))
                {
                    if (_row.DataBoundItem != null)
                    {
                        _row.Cells[columnIndex].Style.BackColor = Color.Red;
                    }
                }
            }
        }

        private void ClearColumn(int columnIndex)
        {
            if (dataGridView_project != null && dataGridView_project.Columns.Count - 1 >= columnIndex)
            {
                var _tmpCol = dataGridView_project.Columns[columnIndex];
                dataGridView_project.Columns.Remove(dataGridView_project.Columns[columnIndex]);
                dataGridView_project.Columns.Insert(columnIndex, _tmpCol);
            }
        }

        private void ClearRow(int tableColumnIndex)
        {
            for (int i = 0; i < _projectTable.Rows.Count; i++)
            {
                Invoke((MethodInvoker)(() => _projectTable.Rows[i][tableColumnIndex] = ""));
            }
        }

        private void ClearAndResetAllComboBoxes()
        {
            comboBox_projectName.ResetText();
            comboBox_projectName.Items.Clear();
            comboBox_projectCustomerID.ResetText();
            comboBox_projectCustomerID.Items.Clear();
            comboBox_projectTemplate.ResetText();
            comboBox_projectTemplate.Items.Clear();
            comboBox_projectManagerID.ResetText();
            comboBox_projectManagerID.Items.Clear();
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
        }

        private void ClearAndResetAllCheckBoxes()
        {
            checkBox_defaultProjectTemplate.Checked = false;
            checkBox_defaultCurrencyISO.Checked = false;
            checkBox_defaultLegalEntity.Checked = false;
            checkBox_defaultProjectType.Checked = false;
            checkBox_defaultProjectCategory.Checked = false;
        }

        #endregion

        #region Get default values from API

        private void GetAllProjectTemplateFromApi()
        {
            var _apiResponse = ProjectHandler.Instance.GetAllProjectTemplate(AuthenticationHandler.Instance.Token);

            if (_apiResponse != null)
            {
                _projectTemplateList = new List<KeyValuePair<int, string>>();

                foreach (var _projectTemplate in _apiResponse)
                {
                    _projectTemplateList.Add(new KeyValuePair<int, string>(_projectTemplate.ProjectTemplateID, _projectTemplate.ProjectTemplateName));
                }
            }
        }

        private void GetAllCurrencyFromApi()
        {
            var _apiResponse = ProjectHandler.Instance.GetAllCurrency(AuthenticationHandler.Instance.Token);

            if (_apiResponse != null)
            {
                _currencyISOList = new List<KeyValuePair<int, string>>();

                foreach (var _currency in _apiResponse)
                {
                    _currencyISOList.Add(new KeyValuePair<int, string>(_currency.CurrencyID, _currency.CurrencyABB));
                }
            }
        }

        private void GetAllLegalEntityFromApi()
        {
            var _apiResponse = ProjectHandler.Instance.GetAllLegalEntity(AuthenticationHandler.Instance.Token);

            if (_apiResponse != null)
            {
                _legalEntityList = new List<KeyValuePair<int, string>>();

                foreach (var _legalEntity in _apiResponse)
                {
                    _legalEntityList.Add(new KeyValuePair<int, string>(_legalEntity.LegalEntityID, _legalEntity.Name));
                }
            }
        }

        private void GetAllProjectTypeFromApi()
        {
            var _apiResponse = ProjectHandler.Instance.GetAllProjectType(AuthenticationHandler.Instance.Token);

            if (_apiResponse != null)
            {
                _projectTypeList = new List<KeyValuePair<int, string>>();

                foreach (var _projectType in _apiResponse)
                {
                    _projectTypeList.Add(new KeyValuePair<int, string>(_projectType.ProjectTypeID, _projectType.Name));
                }
            }
        }

        private void GetAllProjectCategoryFromApi()
        {
            var _apiResponse = ProjectHandler.Instance.GetAllProjectCategory(AuthenticationHandler.Instance.Token);

            if (_apiResponse != null)
            {
                _projectCategoryList = new List<KeyValuePair<int, string>>();

                foreach (var _projectCategory in _apiResponse)
                {
                    _projectCategoryList.Add(new KeyValuePair<int, string>(_projectCategory.ProjectCategoryID, _projectCategory.Name));
                }
            }
        }

        #endregion

        #region Add default key value pair list to Combobox

        private void AddKeyValuePairListToProjectTemplateIDComboBox()
        {
            comboBox_projectTemplate.DisplayMember = "Value";
            comboBox_projectTemplate.ValueMember = "Key";

            if (_projectTemplateList != null)
            {
                foreach (var _projectTemplate in _projectTemplateList)
                {
                    comboBox_projectTemplate.Items.Add(new { _projectTemplate.Key, _projectTemplate.Value });
                }
            }
        }

        private void AddKeyValuePairListToCurrencyIDComboBox()
        {
            comboBox_projectCurrencyISO.DisplayMember = "Value";
            comboBox_projectCurrencyISO.ValueMember = "Key";

            if (_currencyISOList != null)
            {
                foreach (var _currency in _currencyISOList)
                {
                    comboBox_projectCurrencyISO.Items.Add(new { _currency.Key, _currency.Value });
                }
            }
        }

        private void AddKeyValuePairListToLegalEntityIDComboBox()
        {
            comboBox_projectLegalEntity.DisplayMember = "Value";
            comboBox_projectLegalEntity.ValueMember = "Key";

            if (_legalEntityList != null)
            {
                foreach (var _legalEntity in _legalEntityList)
                {
                    comboBox_projectLegalEntity.Items.Add(new { _legalEntity.Key, _legalEntity.Value });
                }
            }
        }

        private void AddKeyValuePairListToProjectTypeIDComboBox()
        {
            comboBox_projectType.DisplayMember = "Value";
            comboBox_projectType.ValueMember = "Key";

            if (_projectTypeList != null)
            {
                foreach (var _projectType in _projectTypeList)
                {
                    comboBox_projectType.Items.Add(new { _projectType.Key, _projectType.Value });
                }
            }
        }

        private void AddKeyValuePairListToProjectCategoryIDComboBox()
        {
            comboBox_projectCategory.DisplayMember = "Value";
            comboBox_projectCategory.ValueMember = "Key";

            if (_projectCategoryList != null)
            {
                foreach (var _projectCategory in _projectCategoryList)
                {
                    comboBox_projectCategory.Items.Add(new { _projectCategory.Key, _projectCategory.Value });
                }
            }
        }

        #endregion

        #region Combobox implementations

        private void comboBox_projectName_SelectedIndexChanged(object sender, EventArgs e)
        {
            var _columnIndex = _fileContent.Columns.IndexOf(comboBox_projectName.SelectedItem.ToString());

            var _tableColumnIndex = _projectTable.Columns.IndexOf(_projectName);

            ClearColumn(_tableColumnIndex);

            MapFileContentToTable(_tableColumnIndex, _columnIndex);

            CheckCellsForNullOrEmpty(_tableColumnIndex);
        }

        private void comboBox_projectCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            var _columnIndex = _fileContent.Columns.IndexOf(comboBox_projectCustomerID.SelectedItem.ToString());

            var _tableColumnIndex = _projectTable.Columns.IndexOf(_customerID);

            ClearColumn(_tableColumnIndex);

            MapFileContentToTable(_tableColumnIndex, _columnIndex);

            CheckCellsForNullOrEmpty(_tableColumnIndex);
        }

        private void comboBox_projectTemplate_SelectedIndexChanged(object sender, EventArgs e)
        {
            var _tableColumnIndex = _projectTable.Columns.IndexOf(_projectTemplate);

            ClearColumn(_tableColumnIndex);

            if (!checkBox_defaultProjectTemplate.Checked)
            {
                var _columnIndex = _fileContent.Columns.IndexOf(comboBox_projectTemplate.SelectedItem.ToString());

                MapFileContentToTable(_tableColumnIndex, _columnIndex);
            }
            else
            {
                var _defaultValue = (comboBox_projectTemplate.SelectedItem as dynamic).Value.ToString();

                MapDefaultValueToTable(_tableColumnIndex, _defaultValue);
            }

            CheckCellsForNullOrEmpty(_tableColumnIndex);
        }

        private void comboBox_projectManager_SelectedIndexChanged(object sender, EventArgs e)
        {
            var _columnIndex = _fileContent.Columns.IndexOf(comboBox_projectManagerID.SelectedItem.ToString());

            var _tableColumnIndex = _projectTable.Columns.IndexOf(_projectManagerID);

            ClearColumn(_tableColumnIndex);

            MapFileContentToTable(_tableColumnIndex, _columnIndex);

            CheckCellsForNullOrEmpty(_tableColumnIndex);
        }

        private void comboBox_projectCurrencyISO_SelectedIndexChanged(object sender, EventArgs e)
        {
            var _tableColumnIndex = _projectTable.Columns.IndexOf(_currencyISO);

            ClearColumn(_tableColumnIndex);

            if (!checkBox_defaultCurrencyISO.Checked)
            {
                var _columnIndex = _fileContent.Columns.IndexOf(comboBox_projectCurrencyISO.SelectedItem.ToString());

                MapFileContentToTable(_tableColumnIndex, _columnIndex);
            }
            else
            {
                var _defaultValue = (comboBox_projectCurrencyISO.SelectedItem as dynamic).Value.ToString();

                MapDefaultValueToTable(_tableColumnIndex, _defaultValue);
            }

            CheckCellsForNullOrEmpty(_tableColumnIndex);
        }

        private void comboBox_projectLegalEntity_SelectedIndexChanged(object sender, EventArgs e)
        {
            var _tableColumnIndex = _projectTable.Columns.IndexOf(_legalEntity);

            ClearColumn(_tableColumnIndex);

            if (!checkBox_defaultLegalEntity.Checked)
            {
                var _columnIndex = _fileContent.Columns.IndexOf(comboBox_projectLegalEntity.SelectedItem.ToString());

                MapFileContentToTable(_tableColumnIndex, _columnIndex);
            }
            else
            {
                var _defaultValue = (comboBox_projectLegalEntity.SelectedItem as dynamic).Value.ToString();

                MapDefaultValueToTable(_tableColumnIndex, _defaultValue);
            }

            CheckCellsForNullOrEmpty(_tableColumnIndex);
        }

        private void comboBox_projectNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var _columnIndex = _fileContent.Columns.IndexOf(comboBox_projectNo.SelectedItem.ToString());

            CheckAndAddColumn(_projectNo);

            var _tableColumnIndex = _projectTable.Columns.IndexOf(_projectNo);

            ClearColumn(_tableColumnIndex);

            MapFileContentToTable(_tableColumnIndex, _columnIndex);

            CheckCellsForNullOrEmpty(_tableColumnIndex);
        }

        private void comboBox_description_SelectedIndexChanged(object sender, EventArgs e)
        {
            var _columnIndex = _fileContent.Columns.IndexOf(comboBox_description.SelectedItem.ToString());

            CheckAndAddColumn(_description);

            var _tableColumnIndex = _projectTable.Columns.IndexOf(_description);

            ClearColumn(_tableColumnIndex);

            MapFileContentToTable(_tableColumnIndex, _columnIndex);

            CheckCellsForNullOrEmpty(_tableColumnIndex);
        }

        private void comboBox_projectStartDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            var _columnIndex = _fileContent.Columns.IndexOf(comboBox_projectStartDate.SelectedItem.ToString());

            CheckAndAddColumn(_projectStartDate);

            var _tableColumnIndex = _projectTable.Columns.IndexOf(_projectStartDate);

            ClearColumn(_tableColumnIndex);

            MapFileContentToTable(_tableColumnIndex, _columnIndex);

            CheckCellsForNullOrEmpty(_tableColumnIndex);
        }

        private void comboBox_projectEndDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            var _columnIndex = _fileContent.Columns.IndexOf(comboBox_projectEndDate.SelectedItem.ToString());

            CheckAndAddColumn(_projectEndDate);

            var _tableColumnIndex = _projectTable.Columns.IndexOf(_projectEndDate);

            ClearColumn(_tableColumnIndex);

            MapFileContentToTable(_tableColumnIndex, _columnIndex);

            CheckCellsForNullOrEmpty(_tableColumnIndex);
        }

        private void comboBox_projectType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var _tableColumnIndex = _projectTable.Columns.IndexOf(_projectType);

            ClearColumn(_tableColumnIndex);

            if (!checkBox_defaultProjectType.Checked)
            {
                var _columnIndex = _fileContent.Columns.IndexOf(comboBox_projectType.SelectedItem.ToString());

                MapFileContentToTable(_tableColumnIndex, _columnIndex);
            }
            else
            {
                var _defaultValue = (comboBox_projectType.SelectedItem as dynamic).Value.ToString();

                MapDefaultValueToTable(_tableColumnIndex, _defaultValue);
            }

            CheckCellsForNullOrEmpty(_tableColumnIndex);
        }

        private void comboBox_projectCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckAndAddColumn(_projectCategory);

            var _tableColumnIndex = _projectTable.Columns.IndexOf(_projectCategory);

            ClearColumn(_tableColumnIndex);

            if (!checkBox_defaultProjectCategory.Checked)
            {
                var _columnIndex = _fileContent.Columns.IndexOf(comboBox_projectCategory.SelectedItem.ToString());

                MapFileContentToTable(_tableColumnIndex, _columnIndex);
            }
            else
            {
                var _defaultValue = (comboBox_projectCategory.SelectedItem as dynamic).Value.ToString();

                MapDefaultValueToTable(_tableColumnIndex, _defaultValue);
            }

            CheckCellsForNullOrEmpty(_tableColumnIndex);
        }

        #endregion

        #region Checkbox implementations

        private void checkBox_defaultCurrencyISO_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_projectCurrencyISO.ResetText();
            comboBox_projectCurrencyISO.Items.Clear();

            if (checkBox_defaultCurrencyISO.Checked)
            {
                if (_currencyISOList == null)
                {
                    GetAllCurrencyFromApi();
                }

                AddKeyValuePairListToCurrencyIDComboBox();
            }
            else
            {
                comboBox_projectCurrencyISO.Items.AddRange(ProjectHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());
            }

            var _tableColumnIndex = _projectTable.Columns.IndexOf(_currencyISO);

            if (_tableColumnIndex != -1)
            {
                ClearColumn(_tableColumnIndex);

                ClearRow(_tableColumnIndex);

                CheckCellsForNullOrEmpty(_tableColumnIndex);
            }
        }

        private void checkBox_defaultProjectTemplate_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_projectTemplate.ResetText();
            comboBox_projectTemplate.Items.Clear();

            if (checkBox_defaultProjectTemplate.Checked)
            {
                if (_projectTemplateList == null)
                {
                    GetAllProjectTemplateFromApi();
                }

                AddKeyValuePairListToProjectTemplateIDComboBox();
            }
            else
            {
                comboBox_projectTemplate.Items.AddRange(ProjectHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());
            }

            var _tableColumnIndex = _projectTable.Columns.IndexOf(_projectTemplate);

            if (_tableColumnIndex != -1)
            {
                ClearColumn(_tableColumnIndex);

                ClearRow(_tableColumnIndex);

                CheckCellsForNullOrEmpty(_tableColumnIndex);
            }
        }

        private void checkBox_defaultLegalEntity_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_projectLegalEntity.ResetText();
            comboBox_projectLegalEntity.Items.Clear();

            if (checkBox_defaultLegalEntity.Checked)
            {
                if (_legalEntityList == null)
                {
                    GetAllLegalEntityFromApi();
                }

                AddKeyValuePairListToLegalEntityIDComboBox();
            }
            else
            {
                comboBox_projectLegalEntity.Items.AddRange(ProjectHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());
            }

            var _tableColumnIndex = _projectTable.Columns.IndexOf(_legalEntity);

            if (_tableColumnIndex != -1)
            {
                ClearColumn(_tableColumnIndex);

                ClearRow(_tableColumnIndex);

                CheckCellsForNullOrEmpty(_tableColumnIndex);
            }
        }

        private void checkBox_defaultProjectType_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_projectType.ResetText();
            comboBox_projectType.Items.Clear();

            if (checkBox_defaultProjectType.Checked)
            {
                if (_projectTypeList == null)
                {
                    GetAllProjectTypeFromApi();
                }

                AddKeyValuePairListToProjectTypeIDComboBox();
            }
            else
            {
                comboBox_projectType.Items.AddRange(ProjectHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());
            }

            var _tableColumnIndex = _projectTable.Columns.IndexOf(_projectType);

            if (_tableColumnIndex != -1)
            {
                ClearColumn(_tableColumnIndex);

                ClearRow(_tableColumnIndex);

                CheckCellsForNullOrEmpty(_tableColumnIndex);
            }
        }

        private void checkBox_defaultProjectCategory_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_projectCategory.ResetText();
            comboBox_projectCategory.Items.Clear();

            if (checkBox_defaultProjectCategory.Checked)
            {
                if (_projectCategoryList == null)
                {
                    GetAllProjectCategoryFromApi();
                }

                AddKeyValuePairListToProjectCategoryIDComboBox();
            }
            else
            {
                comboBox_projectCategory.Items.AddRange(ProjectHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());
            }

            var _tableColumnIndex = _projectTable.Columns.IndexOf(_projectCategory);

            if (_tableColumnIndex != -1)
            {
                ClearColumn(_tableColumnIndex);

                ClearRow(_tableColumnIndex);

                CheckCellsForNullOrEmpty(_tableColumnIndex);
            }
        }

        #endregion
    }
}