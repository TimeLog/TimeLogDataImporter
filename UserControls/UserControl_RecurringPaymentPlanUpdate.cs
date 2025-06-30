using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TimeLog.DataImporter.Handlers;
using TimeLog.DataImporter.Helpers;
using TimeLog.DataImporter.TimeLogApi;
using TimeLog.DataImporter.TimeLogApi.Model;
using TimeLog.DataImporter.TimeLogApi.Model.Contracts;

namespace TimeLog.DataImporter.UserControls
{
    public partial class UserControl_RecurringPaymentPlanUpdate : UserControl
    {
        #region Variable declarations

        private DataTable _recurringPaymentPlanAmountUpdateTable;
        private DataTable _fileContent;
        private Button _senderButton;
        private int _errorRowCount;
        private bool _isMappingFieldValueToIDCorrect;
        private bool _isFirstTimeInvalidMapping;
        private Encoding? ANSI = CodePagesEncodingProvider.Instance.GetEncoding(1252);

        private static readonly Dictionary<int, string> MandatoryFields = new Dictionary<int, string>
        {
            {0, "Project No"},
            {1, "Contract Name"},
            {2, "Payment Plan Amount"},
            

        };

        //all column header variables
        private readonly string _projectNo = "Project No";
        private readonly string _contractName = "Contract Name";
        private readonly string _paymentPlanAmount = "Payment Plan Amount";

        
        

        //default value lists from API 
        private static readonly List<KeyValuePair<int, string>> ProjectList = new List<KeyValuePair<int, string>>();

        //expanding panels' current states, expand panels, expand buttons
        private BaseHandler.ExpandState[] _expandStates;
        private Panel[] _expandPanels;
        private Button[] _expandButtons;

        //set the number of pixels expanded per timer Tick
        private const int ExpansionPerTick = 7;

        #endregion

        public UserControl_RecurringPaymentPlanUpdate()
        {
            InitializeComponent();
            RecurringPaymentPlanAmountHandler.Instance.InitializeDelimiterComboBox(comboBox_delimiter);
            InitializeExpandCollapsePanels();
            AddRowNumberToDataTable();
            InitializeAllDefaultValues();
            _recurringPaymentPlanAmountUpdateTable = RecurringPaymentPlanAmountHandler.Instance.InitializeDomainDataTable(MandatoryFields);
            dataGridView_recurringPaymentPlanAmountUpdate.DataSource = _recurringPaymentPlanAmountUpdateTable;
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

        private void button_select_recurringPaymentPlanAmountUpdate_file_Click(object sender, EventArgs e)
        {
            RecurringPaymentPlanAmountHandler.Instance.FileColumnHeaders = new List<string>();
            _fileContent = new DataTable();
            _fileContent = RecurringPaymentPlanAmountHandler.Instance.GetFileContent(comboBox_delimiter.SelectedItem.ToString());

            if (_fileContent != null)
            {
                textBox_recurringPaymentPlanAmountUpdateImportMessages.Text = string.Empty;
                ClearAndResetAllComboBoxes();
                Invoke((MethodInvoker)(() => button_import.Enabled = false));

                if (dataGridView_recurringPaymentPlanAmountUpdate.RowCount > 1)
                {
                    dataGridView_recurringPaymentPlanAmountUpdate.DataSource = null;
                    _recurringPaymentPlanAmountUpdateTable = RecurringPaymentPlanAmountHandler.Instance.InitializeDomainDataTable(MandatoryFields);
                }

                _recurringPaymentPlanAmountUpdateTable = _fileContent.Copy();
                dataGridView_recurringPaymentPlanAmountUpdate.DataSource = _recurringPaymentPlanAmountUpdateTable;

                AddFileColumnHeaderToComboBox(RecurringPaymentPlanAmountHandler.Instance.FileColumnHeaders.Cast<object>().ToArray());

                RecurringPaymentPlanAmountHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_recurringPaymentPlanAmountUpdateProjectNo, _projectNo);
                RecurringPaymentPlanAmountHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_recurringPaymentPlanAmountUpdateContractName, _contractName);
                RecurringPaymentPlanAmountHandler.Instance.AutoMapFileColumns(_fileContent, comboBox_PaymentPlanAmount, _paymentPlanAmount);

                
                this.comboBox_PaymentPlanAmount.SelectedIndexChanged += new System.EventHandler(this.comboBox_recurringPaymentPlanAmountUpdatePaymentPlanAmount_SelectedIndexChanged);
                this.comboBox_recurringPaymentPlanAmountUpdateContractName.SelectedIndexChanged += new System.EventHandler(this.comboBox_recurringPaymentPlanAmountUpdateContractName_SelectedIndexChanged);
                this.comboBox_recurringPaymentPlanAmountUpdateProjectNo.SelectedIndexChanged += new System.EventHandler(this.comboBox_recurringPaymentPlanAmountUpdateProjectNo_SelectedIndexChanged);

            }
            else
            {
                button_clear_Click(sender, e);
            }
        }

        private void button_validate_Click(object sender, EventArgs e)
        {
            textBox_recurringPaymentPlanAmountUpdateImportMessages.Text = string.Empty;
            _senderButton = (Button) sender;
            WorkerFetcher.RunWorkerAsync();
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            WorkerFetcher.CancelAsync();
        }

        private void button_import_Click(object sender, EventArgs e)
        {
            textBox_recurringPaymentPlanAmountUpdateImportMessages.Text = string.Empty;
            _senderButton = (Button) sender;
            WorkerFetcher.RunWorkerAsync();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            RecurringPaymentPlanAmountHandler.Instance.FileColumnHeaders = new List<string>();
            textBox_recurringPaymentPlanAmountUpdateImportMessages.Text = string.Empty;
            ClearAndResetAllComboBoxes();
            InitializeAllDefaultValues();
            Invoke((MethodInvoker)(() => button_import.Enabled = false));

            dataGridView_recurringPaymentPlanAmountUpdate.DataSource = null;
            _recurringPaymentPlanAmountUpdateTable = RecurringPaymentPlanAmountHandler.Instance.InitializeDomainDataTable(MandatoryFields);
            dataGridView_recurringPaymentPlanAmountUpdate.DataSource = _recurringPaymentPlanAmountUpdateTable;
        }

        private void textBox_recurringPaymentPlanAmountUpdateImportMessages_MouseClick(object sender, MouseEventArgs e)
        {
            RecurringPaymentPlanAmountHandler.Instance.HighlightDataTableRowByTextBoxClick(e, dataGridView_recurringPaymentPlanAmountUpdate, textBox_recurringPaymentPlanAmountUpdateImportMessages);
        }

        private void button_expand_Click(object sender, EventArgs e)
        {
            RecurringPaymentPlanAmountHandler.Instance.ExpandCollapseFieldByButtonClick(sender, _expandStates, _expandButtons, tmrExpand);
        }

        private void tmrExpand_Tick(object sender, EventArgs e)
        {
            RecurringPaymentPlanAmountHandler.Instance.ProcessExpandCollapseFieldForPanel(_expandPanels, _expandStates, ExpansionPerTick, tmrExpand);
        }

        private void WorkerFetcherDoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (dataGridView_recurringPaymentPlanAmountUpdate != null && dataGridView_recurringPaymentPlanAmountUpdate.RowCount > 1)
            {
                _errorRowCount = 0;

                string errorLog = "FailedRecurringPaymentPlanImports" + DateTime.Now.ToString("yyyyMMddHHmm") + ".csv";

                if (File.Exists(errorLog))
                    File.Delete(errorLog);

                File.WriteAllText(errorLog, "Project No;Contract Name;Payment Plan Amount" + Environment.NewLine, ANSI);

                //while validating, deactivate other buttons
                Invoke((MethodInvoker)(() => button_validate.Enabled = false));
                Invoke((MethodInvoker)(() => button_import.Enabled = false));
                Invoke((MethodInvoker)(() => button_clear.Enabled = false));
                Invoke((MethodInvoker)(() => button_recurringPaymentPlanAmountUpdateSelectFile.Enabled = false));

                Invoke((MethodInvoker)(() => textBox_recurringPaymentPlanAmountUpdateImportMessages.AppendText("Start time: " + DateTime.Now)));

                try {
                    foreach (DataGridViewRow _row in dataGridView_recurringPaymentPlanAmountUpdate.Rows) {
                        try {
                            if (WorkerFetcher.CancellationPending) {
                                break;
                            }

                            _isMappingFieldValueToIDCorrect = true;
                            _isFirstTimeInvalidMapping = true;

                            if (_row.DataBoundItem != null) {
                                RecurringPaymentPlanAmountUpdateModel _newRecurringPaymentPlanAmountUpdateModel = new RecurringPaymentPlanAmountUpdateModel
                                {
                                    ProjectId = (int)MapFieldValueToID(_projectNo, _row, false),
                                    ProjectSubContractId = (int)MapFieldValueToID(_contractName, _row, false),
                                    PaymentPlanAmount = RecurringPaymentPlanAmountHandler.Instance.CheckAndGetDouble(dataGridView_recurringPaymentPlanAmountUpdate, _paymentPlanAmount, _row),

                                };

                                if (_isMappingFieldValueToIDCorrect) {
                                    int currCount = _errorRowCount;
                                    
                                    if (_senderButton.Name == button_validate.Name) {
                                        var _defaultApiResponse = RecurringPaymentPlanAmountHandler.Instance.ValidateRecurringPaymentPlanAmountUpdate(_newRecurringPaymentPlanAmountUpdateModel,
                                            AuthenticationHandler.Instance.Token, out var _businessRulesApiResponse);
                                        
                                        _errorRowCount = ApiHelper.Instance.HandleApiResponse(_defaultApiResponse, _row, _businessRulesApiResponse,
                                            textBox_recurringPaymentPlanAmountUpdateImportMessages, _errorRowCount, WorkerFetcher, this);
                                        
                                    } else {
                                        var _defaultApiResponse = RecurringPaymentPlanAmountHandler.Instance.ImportRecurringPaymentPlanAmount(_newRecurringPaymentPlanAmountUpdateModel,
                                            AuthenticationHandler.Instance.Token, out var _businessRulesApiResponse);
                                        
                                        _errorRowCount = ApiHelper.Instance.HandleApiResponse(_defaultApiResponse, _row, _businessRulesApiResponse,
                                            textBox_recurringPaymentPlanAmountUpdateImportMessages, _errorRowCount, WorkerFetcher, this);
                                    }
                                    
                                    if (currCount != _errorRowCount)
                                        WriteRowToCSV(_row, errorLog);
                                } else {
                                    WriteRowToCSV(_row, errorLog);
                                }
                            } 
                        } catch (Exception _ex) {
                            this.Invoke((MethodInvoker)(() => _row.DefaultCellStyle.BackColor = Color.Red));
                            this.Invoke((MethodInvoker)(() => textBox_recurringPaymentPlanAmountUpdateImportMessages.AppendText(Environment.NewLine)));
                            this.Invoke((MethodInvoker)(() => textBox_recurringPaymentPlanAmountUpdateImportMessages.AppendText("Row " + (_row.Index + 1) + " - " + _ex.Message)));
                            _errorRowCount++;

                            WriteRowToCSV(_row, errorLog);
                        }
                    }

                    RecurringPaymentPlanAmountHandler.Instance.DisplayErrorRowCountAndSuccessMessage(_errorRowCount, button_import, button_validate, _senderButton, textBox_recurringPaymentPlanAmountUpdateImportMessages, this);
                } catch (FormatException _ex) {
                    MessageBox.Show(_ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } catch (Exception _ex) {
                    MessageBox.Show(_ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                //reactivate buttons after work is done
                Invoke((MethodInvoker)(() => button_validate.Enabled = true));
                Invoke((MethodInvoker)(() => button_clear.Enabled = true));
                Invoke((MethodInvoker)(() => button_recurringPaymentPlanAmountUpdateSelectFile.Enabled = true));
            }
        }

        #endregion

        #region Helper methods

        private void AddFileColumnHeaderToComboBox(object[] fileColumnHeaderArray)
        {
            comboBox_recurringPaymentPlanAmountUpdateProjectNo.Items.AddRange(fileColumnHeaderArray);
            comboBox_recurringPaymentPlanAmountUpdateContractName.Items.AddRange(fileColumnHeaderArray);
            comboBox_PaymentPlanAmount.Items.AddRange(fileColumnHeaderArray);

        }

        private int? MapFieldValueToID(string columnName, DataGridViewRow row, bool isNullableField)
        {
            if (dataGridView_recurringPaymentPlanAmountUpdate.Columns[columnName] != null)
            {
                var _fieldValue = RecurringPaymentPlanAmountHandler.Instance.CheckAndGetString(dataGridView_recurringPaymentPlanAmountUpdate, columnName, row);
                int _result = -1;

                
                 if (columnName == _projectNo)
                {
                    if (!string.IsNullOrWhiteSpace(_fieldValue))
                    {
                        _result = RecurringPaymentPlanAmountHandler.Instance.GetIDFromFieldValue(ProjectList, _fieldValue);
                    }
                    else
                    {
                        _result = 0;
                    }
                }
                else if (columnName == _contractName)
                {
                    if (!string.IsNullOrWhiteSpace(_fieldValue))
                    {
                        var _projectID = RecurringPaymentPlanAmountHandler.Instance.GetIDFromFieldValue(ProjectList, RecurringPaymentPlanAmountHandler.Instance.CheckAndGetString(dataGridView_recurringPaymentPlanAmountUpdate, _projectNo, row));
                        if (_projectID == -1)
                        {
                            // The project does not exist. Don't try to get contracts.
                            return _result;
                        }

                        var _projectContracts = RecurringPaymentPlanAmountHandler.Instance.GetAllContract(AuthenticationHandler.Instance.Token, _projectID);

                        try
                        {
                            _result = _projectContracts.FirstOrDefault(x => x.ContractName.ToLower().Trim().Equals(_fieldValue.ToLower().Trim())).ContractID;
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


                if (_result != -1)
                {
                    return _result;
                }

                if (isNullableField)
                {
                    return null;
                }

                //if can't match, display error message
                _errorRowCount = RecurringPaymentPlanAmountHandler.Instance.HandleInvalidFieldValueToIDMapping(columnName, row, _fieldValue, textBox_recurringPaymentPlanAmountUpdateImportMessages,
                    WorkerFetcher, this, _isFirstTimeInvalidMapping, _errorRowCount);
                _isMappingFieldValueToIDCorrect = false;
                _isFirstTimeInvalidMapping = false;
            }

           

            return 0;
        }

        private void ClearAndResetAllComboBoxes()
        {

            comboBox_recurringPaymentPlanAmountUpdateProjectNo.ResetText();
            comboBox_recurringPaymentPlanAmountUpdateProjectNo.Items.Clear();
            comboBox_recurringPaymentPlanAmountUpdateContractName.ResetText();
            comboBox_recurringPaymentPlanAmountUpdateContractName.Items.Clear();
            comboBox_PaymentPlanAmount.ResetText();
            comboBox_PaymentPlanAmount.Items.Clear(); 
            
        }




        #endregion

        #region Get default values from API
        private void GetAllProjectFromApi()
        {
            ProjectList.Clear();

            var _apiResponse = CacheManager.GetOrCreate("AllProject", () =>
            {
                // This will only execute if the data is not in cache
                return ContractHandler.Instance.GetAllProject(AuthenticationHandler.Instance.Token);
            }, TimeSpan.FromMinutes(5));

            //var _apiResponse = RecurringPaymentPlanAmountHandler.Instance.GetAllProject(AuthenticationHandler.Instance.Token);

            if (_apiResponse != null)
            {
                foreach (var _project in _apiResponse)
                {
                    ProjectList.Add(new KeyValuePair<int, string>(_project.ProjectID, _project.No));
                }
            }
        }




        #endregion

        public void WriteRowToCSV(DataGridViewRow row, string filePath)
        {
            // Create CSV line from the cells
            var values = row.Cells.Cast<DataGridViewCell>().Select(cell => FormatCellValue(cell.Value)).ToList();

            string csvLine = string.Join(";", values) + Environment.NewLine;

            File.AppendAllText(filePath, csvLine, ANSI);
        }

        private string FormatCellValue(object value)
        {
            if (value == null)
                return "";

            string stringValue = value.ToString();

            // If the value contains a comma, quote, or newline, wrap it in quotes and escape existing quotes
            if (stringValue.Contains(",") || stringValue.Contains("\"") || stringValue.Contains("\n") || stringValue.Contains(";"))
            {
                stringValue = $"\"{stringValue.Replace("\"", "\"\"")}\"";
            }

            return stringValue;
        }

        #region Combobox implementations


        private void comboBox_recurringPaymentPlanAmountUpdateProjectNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            RecurringPaymentPlanAmountHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_recurringPaymentPlanAmountUpdate, _recurringPaymentPlanAmountUpdateTable, comboBox_recurringPaymentPlanAmountUpdateProjectNo, _projectNo);

        }

        private void comboBox_recurringPaymentPlanAmountUpdateContractName_SelectedIndexChanged(object sender, EventArgs e)
        {
            RecurringPaymentPlanAmountHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_recurringPaymentPlanAmountUpdate, _recurringPaymentPlanAmountUpdateTable, comboBox_recurringPaymentPlanAmountUpdateContractName, _contractName);

        }


        private void comboBox_recurringPaymentPlanAmountUpdatePaymentPlanAmount_SelectedIndexChanged(object sender, EventArgs e)
        {
            RecurringPaymentPlanAmountHandler.Instance.MapMandatorySelectedColumnToTable(_fileContent, dataGridView_recurringPaymentPlanAmountUpdate, _recurringPaymentPlanAmountUpdateTable, comboBox_PaymentPlanAmount, _paymentPlanAmount);

        }







        #endregion

        private void label_recurringPaymentPlanAmountSetup_Click(object sender, EventArgs e)
        {

        }
    }
}