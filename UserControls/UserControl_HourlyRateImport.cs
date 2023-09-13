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
    public partial class UserControl_HourlyRateImport : UserControl
    {
        #region Variable declarations

        private DataTable _contractHourlyRateTable;
        private DataTable _fileContent;
        private Button _senderButton;
        private int _errorRowCount;
        private bool _isMappingFieldValueToIDCorrect;
        private bool _isFirstTimeInvalidMapping;

        private static readonly Dictionary<int, string> MandatoryFields = new Dictionary<int, string>
        {
            {0, "Project No"},
            {1, "Contract Name"},
            {2, "Hourly Rate Name"},
            {3, "Hourly Rate"},
            {4, "Hourly Rate Category"},

        };

        //all column header variables
        private readonly string _projectNo = "Project No";
        private readonly string _contractName = "Contract Name";
        private readonly string _contractHourlyRateName = "Hourly Rate Name";
        private readonly string _contractHourlyRateAmount = "Hourly Rate";
        private readonly string _costPrice = "Cost Price";
        private readonly string _contractHourlyRateProductNo = "Product No";
        private readonly string _contractHhourlyRateCategory = "Hourly Rate Category";
        
        

        //default value lists from API 
        private static readonly List<KeyValuePair<int, string>> ProjectList = new List<KeyValuePair<int, string>>();
        private static readonly List<KeyValuePair<int, string>> ContractNameList = new List<KeyValuePair<int, string>>();

        //expanding panels' current states, expand panels, expand buttons
        private BaseHandler.ExpandState[] _expandStates;
        private Panel[] _expandPanels;
        private Button[] _expandButtons;

        //set the number of pixels expanded per timer Tick
        private const int ExpansionPerTick = 7;

        #endregion

        public UserControl_HourlyRateImport()
        {
            InitializeComponent();
            HourlyRateHandler.Instance.InitializeDelimiterComboBox(comboBox_delimiter);
            InitializeExpandCollapsePanels();
            AddRowNumberToDataTable();
            InitializeAllDefaultValues();
            _contractHourlyRateTable = HourlyRateHandler.Instance.InitializeDomainDataTable(MandatoryFields);
            dataGridView_contractHourlyRate.DataSource = _contractHourlyRateTable;
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
        }

        #endregion

        #region Functionalities implementations

        private void button_select_contractHourlyRate_file_Click(object sender, EventArgs e)
        {
            HourlyRateHandler.Instance.FileColumnHeaders = new List<string>();
            _fileContent = new DataTable();
            _fileContent = HourlyRateHandler.Instance.GetFileContent(comboBox_delimiter.SelectedItem.ToString());

            if (_fileContent != null)
            {
                textBox_contractHourlyRateImportMessages.Text = string.Empty;
                ClearAndResetAllComboBoxes();
                Invoke((MethodInvoker)(() => button_import.Enabled = false));

                if (dataGridView_contractHourlyRate.RowCount > 1)
                {
                    dataGridView_contractHourlyRate.DataSource = null;
                    _contractHourlyRateTable = HourlyRateHandler.Instance.InitializeDomainDataTable(MandatoryFields);
                }

                _contractHourlyRateTable = _fileContent.Copy();
                dataGridView_contractHourlyRate.DataSource = _contractHourlyRateTable;

                AddFileColumnHeaderToComboBox(HourlyRateHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());

                HourlyRateHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_contractHourlyRateProjectNo, _projectNo);
                HourlyRateHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_contractHourlyRateContractName, _contractName);
                HourlyRateHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_contractHourlyRateName, _contractHourlyRateName);
                HourlyRateHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_contractHourlyRateAmount, _contractHourlyRateAmount);
                HourlyRateHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_contractHourlyRateProductNo, _contractHourlyRateProductNo);
                HourlyRateHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_contractHourlyRateCreateCategory, _contractHhourlyRateCategory);
              
                this.comboBox_contractHourlyRateProjectNo.SelectedIndexChanged += new System.EventHandler(this.comboBox_contractHourlyRateProjectNo_SelectedIndexChanged);
                this.comboBox_contractHourlyRateContractName.SelectedIndexChanged += new System.EventHandler(this.comboBox_contractHourlyRateContractName_SelectedIndexChanged);
                this.comboBox_contractHourlyRateName.SelectedIndexChanged += new System.EventHandler(this.comboBox_contractHourlyRateName_SelectedIndexChanged);
                this.comboBox_contractHourlyRateAmount.SelectedIndexChanged += new System.EventHandler(this.comboBox_contractHourlyRateAmount_SelectedIndexChanged);
                this.comboBox_contractHourlyRateProductNo.SelectedIndexChanged += new System.EventHandler(this.comboBox_contractHourlyRateProductNo_SelectedIndexChanged);
                this.comboBox_contractHourlyRateCreateCategory.SelectedIndexChanged += new System.EventHandler(this.comboBox_contractHourlyRateCreateCategory_SelectedIndexChanged);
                

            }
            else
            {
                button_clear_Click(sender, e);
            }
        }

        private void button_validate_Click(object sender, EventArgs e)
        {
            textBox_contractHourlyRateImportMessages.Text = string.Empty;
            _senderButton = (Button) sender;
            WorkerFetcher.RunWorkerAsync();
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            WorkerFetcher.CancelAsync();
        }

        private void button_import_Click(object sender, EventArgs e)
        {
            textBox_contractHourlyRateImportMessages.Text = string.Empty;
            _senderButton = (Button) sender;
            WorkerFetcher.RunWorkerAsync();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            HourlyRateHandler.Instance.FileColumnHeaders = new List<string>();
            textBox_contractHourlyRateImportMessages.Text = string.Empty;
            ClearAndResetAllComboBoxes();
            Invoke((MethodInvoker)(() => button_import.Enabled = false));

            dataGridView_contractHourlyRate.DataSource = null;
            _contractHourlyRateTable = HourlyRateHandler.Instance.InitializeDomainDataTable(MandatoryFields);
            dataGridView_contractHourlyRate.DataSource = _contractHourlyRateTable;
        }

        private void textBox_contractHourlyRateImportMessages_MouseClick(object sender, MouseEventArgs e)
        {
            HourlyRateHandler.Instance.HighlightDataTableRowByTextBoxClick(e, dataGridView_contractHourlyRate, textBox_contractHourlyRateImportMessages);
        }

        private void button_expand_Click(object sender, EventArgs e)
        {
            HourlyRateHandler.Instance.ExpandCollapseFieldByButtonClick(sender, _expandStates, _expandButtons, tmrExpand);
        }

        private void tmrExpand_Tick(object sender, EventArgs e)
        {
            HourlyRateHandler.Instance.ProcessExpandCollapseFieldForPanel(_expandPanels, _expandStates, ExpansionPerTick, tmrExpand);
        }

        private void WorkerFetcherDoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (dataGridView_contractHourlyRate != null && dataGridView_contractHourlyRate.RowCount > 1)
            {
                _errorRowCount = 0;

                //while validating, deactivate other buttons
                Invoke((MethodInvoker)(() => button_validate.Enabled = false));
                Invoke((MethodInvoker)(() => button_import.Enabled = false));
                Invoke((MethodInvoker)(() => button_clear.Enabled = false));
                Invoke((MethodInvoker)(() => button_contractHourlyRateSelectFile.Enabled = false));

                Invoke((MethodInvoker)(() => textBox_contractHourlyRateImportMessages.AppendText("Start time: " + DateTime.Now)));

                try
                {
                    foreach (DataGridViewRow _row in dataGridView_contractHourlyRate.Rows)
                    {
                        if (WorkerFetcher.CancellationPending)
                        {
                            break;
                        }

                        _isMappingFieldValueToIDCorrect = true;
                        _isFirstTimeInvalidMapping = true;

                        if (_row.DataBoundItem != null)
                        {
                            ContractHourlyRateApiCreateModel _newContractHourlyRate = new ContractHourlyRateApiCreateModel
                            {
                                ProjectId = (int)MapFieldValueToID(_projectNo, _row, false),
                                ProjectSubContractId = (int)MapFieldValueToID(_contractName, _row, false),
                                ContractHourlyRateValue = HourlyRateHandler.Instance.CheckAndGetDouble(dataGridView_contractHourlyRate, _contractHourlyRateAmount, _row),
                                ContractHourlyRateName = HourlyRateHandler.Instance.CheckAndGetString(dataGridView_contractHourlyRate, _contractHourlyRateName, _row),
                                ProductNo = HourlyRateHandler.Instance.CheckAndGetString(dataGridView_contractHourlyRate, _contractHourlyRateProductNo, _row),
                                ContractHourlyRateCreateCategory = HourlyRateHandler.Instance.CheckAndGetString(dataGridView_contractHourlyRate, _contractHhourlyRateCategory, _row),

                            };

                            if (_isMappingFieldValueToIDCorrect)
                            {
                                if (_senderButton.Name == button_validate.Name)
                                {
                                    var _defaultApiResponse = HourlyRateHandler.Instance.ValidateHourlyRate(_newContractHourlyRate,
                                        AuthenticationHandler.Instance.Token, out var _businessRulesApiResponse);

                                    _errorRowCount = ApiHelper.Instance.HandleApiResponse(_defaultApiResponse, _row, _businessRulesApiResponse,
                                        textBox_contractHourlyRateImportMessages, _errorRowCount, WorkerFetcher, this);
                                }
                                else
                                {
                                    var _defaultApiResponse = HourlyRateHandler.Instance.ImportHourlyRate(_newContractHourlyRate,
                                        AuthenticationHandler.Instance.Token, out var _businessRulesApiResponse);

                                    _errorRowCount = ApiHelper.Instance.HandleApiResponse(_defaultApiResponse, _row, _businessRulesApiResponse,
                                        textBox_contractHourlyRateImportMessages, _errorRowCount, WorkerFetcher, this);
                                }
                            }
                        }
                    }

                    HourlyRateHandler.Instance.DisplayErrorRowCountAndSuccessMessage(_errorRowCount, button_import, button_validate, _senderButton, textBox_contractHourlyRateImportMessages, this);
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
                Invoke((MethodInvoker)(() => button_contractHourlyRateSelectFile.Enabled = true));
            }
        }

        #endregion

        #region Helper methods

        private void AddFileColumnHeaderToComboBox(object[] fileColumnHeaderArray)
        {
            comboBox_contractHourlyRateProjectNo.Items.AddRange(fileColumnHeaderArray);
            comboBox_contractHourlyRateContractName.Items.AddRange(fileColumnHeaderArray);
            comboBox_contractHourlyRateName.Items.AddRange(fileColumnHeaderArray);
            comboBox_contractHourlyRateAmount.Items.AddRange(fileColumnHeaderArray);
            comboBox_contractHourlyRateProductNo.Items.AddRange(fileColumnHeaderArray);
            comboBox_contractHourlyRateCreateCategory.Items.AddRange(fileColumnHeaderArray);
            
        }

        private int? MapFieldValueToID(string columnName, DataGridViewRow row, bool isNullableField)
        {
            if (dataGridView_contractHourlyRate.Columns[columnName] != null)
            {
                var _fieldValue = HourlyRateHandler.Instance.CheckAndGetString(dataGridView_contractHourlyRate, columnName, row);
                int _result = -1;

                if (columnName == _projectNo)
                {
                    _result = TaskHandler.Instance.GetIDFromFieldValue(ProjectList, _fieldValue);
                    if (_result != -1)
                    {
                        GetAllContractFromApi(_result);
                    }
                }
                else if (columnName == _contractName)
                {
                    _result = TaskHandler.Instance.GetIDFromFieldValue(ContractNameList, _fieldValue);
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
                _errorRowCount = HourlyRateHandler.Instance.HandleInvalidFieldValueToIDMapping(columnName, row, _fieldValue, textBox_contractHourlyRateImportMessages,
                    WorkerFetcher, this, _isFirstTimeInvalidMapping, _errorRowCount);
                _isMappingFieldValueToIDCorrect = false;
                _isFirstTimeInvalidMapping = false;
            }

           

            return 0;
        }

        private void ClearAndResetAllComboBoxes()
        {
            comboBox_contractHourlyRateProjectNo.ResetText();
            comboBox_contractHourlyRateProjectNo.Items.Clear();
            comboBox_contractHourlyRateContractName.ResetText();
            comboBox_contractHourlyRateContractName.Items.Clear();
            comboBox_contractHourlyRateName.ResetText();
            comboBox_contractHourlyRateName.Items.Clear();
            comboBox_contractHourlyRateAmount.ResetText();
            comboBox_contractHourlyRateAmount.Items.Clear();
            comboBox_contractHourlyRateProductNo.ResetText();
            comboBox_contractHourlyRateProductNo.Items.Clear();
            comboBox_contractHourlyRateCreateCategory.ResetText();
            comboBox_contractHourlyRateCreateCategory.Items.Clear();
           
        }




        #endregion

        #region Get default values from API
        private void GetAllProjectFromApi()
        {
            var _apiResponse = HourlyRateHandler.Instance.GetAllProject(AuthenticationHandler.Instance.Token);

            if (_apiResponse != null)
            {
                foreach (var _project in _apiResponse)
                {
                    ProjectList.Add(new KeyValuePair<int, string>(_project.ProjectID, _project.No));
                }
            }
        }

        private void GetAllContractFromApi(int projectID)
        {
            var _apiResponse = TaskHandler.Instance.GetAllContract(AuthenticationHandler.Instance.Token, projectID);

            if (_apiResponse != null)
            {
                foreach (var _contract in _apiResponse)
                {
                    ContractNameList.Add(new KeyValuePair<int, string>(_contract.ContractID, _contract.ContractName));
                }
            }
        }




        #endregion

        #region Combobox implementations

        private void comboBox_contractHourlyRateProjectNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            HourlyRateHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_contractHourlyRate, _contractHourlyRateTable, comboBox_contractHourlyRateProjectNo, _projectNo);

        }

        private void comboBox_contractHourlyRateContractName_SelectedIndexChanged(object sender, EventArgs e)
        {
            HourlyRateHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_contractHourlyRate, _contractHourlyRateTable, comboBox_contractHourlyRateContractName, _contractName);

        }

        private void comboBox_contractHourlyRateCreateCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            HourlyRateHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_contractHourlyRate, _contractHourlyRateTable, comboBox_contractHourlyRateCreateCategory, _contractHhourlyRateCategory);

        }

        private void comboBox_contractHourlyRateName_SelectedIndexChanged(object sender, EventArgs e)
        {
            HourlyRateHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_contractHourlyRate, _contractHourlyRateTable, comboBox_contractHourlyRateName, _contractHourlyRateName);

        }

        private void comboBox_contractHourlyRateAmount_SelectedIndexChanged(object sender, EventArgs e)
        {
            HourlyRateHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_contractHourlyRate, _contractHourlyRateTable, comboBox_contractHourlyRateAmount, _contractHourlyRateAmount);

        }

        private void comboBox_contractHourlyRateProductNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            HourlyRateHandler.Instance.MapNonMandatorySelectedColumnToTable(_fileContent, dataGridView_contractHourlyRate, _contractHourlyRateTable, comboBox_contractHourlyRateProductNo, _contractHourlyRateProductNo);

        }




        #endregion

        
    }
}