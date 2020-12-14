using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;
using TimeLog.DataImporter.TimeLogApi;
using TimeLog.DataImporter.TimeLogApi.Model;

namespace TimeLog.DataImporter.Handlers
{
    public class BaseHandler
    {
        #region Variable and enum declarations

        public List<string> FileColumnHeaders = new List<string>();
        private readonly List<string> _delimiterList = new List<string> { ",", ";", "|" };

        // The state of expanding or collapsing panel
        public enum ExpandState
        {
            Expanded,
            Expanding,
            Collapsing,
            Collapsed,
        }

        #endregion

        #region Helper - Get methods

        public DataTable GetFileContent(string selectedDelimiter)
        {
            try
            {
                OpenFileDialog _dialog = new OpenFileDialog();
                _dialog.ShowDialog();

                if (_dialog.FileName != "")
                {
                    if (_dialog.FileName.EndsWith(".csv"))
                    {
                        DataTable _fileData = new DataTable();
                        _fileData = GetDataTableFromCSVFile(_dialog.FileName, selectedDelimiter);

                        if (_fileData != null)
                        {
                            if (_fileData.Rows.Count > 0)
                            {
                                return _fileData;
                            }

                            //return this message when the row count is zero
                            MessageBox.Show("There is no data in this file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Selected file is invalid, please select a valid CSV file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception " + ex);
            }

            return null;
        }

        private DataTable GetDataTableFromCSVFile(string csvFilePath, string selectedDelimiter)
        {
            DataTable _csvData = new DataTable();

            try
            {
                if (csvFilePath.EndsWith(".csv"))
                {
                    using Microsoft.VisualBasic.FileIO.TextFieldParser _csvReader = new Microsoft.VisualBasic.FileIO.TextFieldParser(csvFilePath);
                    _csvReader.SetDelimiters(new string[]
                    {
                            selectedDelimiter
                    });

                    string[] _colFields = _csvReader.ReadFields();

                    if (_colFields != null)
                    {
                        foreach (string _column in _colFields)
                        {
                            DataColumn _dataColumn = new DataColumn(_column)
                            {
                                AllowDBNull = true
                            };

                            _csvData.Columns.Add(_dataColumn);
                            FileColumnHeaders.Add(_dataColumn.ColumnName);
                        }

                        while (!_csvReader.EndOfData)
                        {
                            string[] _fieldData = _csvReader.ReadFields();

                            for (int i = 0; i < _fieldData.Length; i++)
                            {
                                if (_fieldData[i] == "")
                                {
                                    _fieldData[i] = null;
                                }
                            }

                            _csvData.Rows.Add(_fieldData);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception " + ex);
            }

            return _csvData;
        }

        public List<string> GetDelimiterList()
        {
            return _delimiterList;
        }

        public int GetIDFromFieldValue(List<KeyValuePair<int, string>> keyValuePairList, string fieldValue)
        {
            foreach (var _field in keyValuePairList)
            {
                if (_field.Value == fieldValue)
                {
                    var _fieldKey = _field.Key;
                    return _fieldKey;
                }
            }

            return -1;
        }

        #endregion

        #region Get methods for shared default values

        public List<CurrencyReadModel> GetAllCurrency(string token)
        {
            var _address = ApiHelper.Instance.LocalhostUrl + ApiHelper.Instance.GetAllCurrencyEndpoint;

            try
            {
                string _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);
                dynamic _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);

                if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities.Count > 0)
                {
                    List<CurrencyReadModel> _apiResponse = new List<CurrencyReadModel>();

                    foreach (var _entity in _jsonDeserializedObject.Entities)
                    {
                        foreach (var _property in _entity.Properties())
                        {
                            _apiResponse.Add(JsonConvert.DeserializeObject<CurrencyReadModel>(_property.Value.ToString()));
                        }
                    }

                    return _apiResponse;
                }
            }
            catch (WebException _webEx)
            {
                MessageBox.Show("Failed to obtain default currency ID list. " + _webEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return null;
        }

        #endregion

        #region Helper - Get data of different type methods

        public string CheckAndGetString(DataGridView dataGridView, string columnName, DataGridViewRow dataGridViewRow)
        {
            return dataGridView.Columns[columnName] != null ? dataGridViewRow.Cells[dataGridView.Columns[columnName].Index].Value.ToString() : string.Empty;
        }

        public bool CheckAndGetBoolean(DataGridView dataGridView, string columnName, DataGridViewRow dataGridViewRow)
        {
            if (dataGridView.Columns[columnName] != null)
            {
                var _value = dataGridViewRow.Cells[dataGridView.Columns[columnName].Index].Value.ToString();

                if (_value != "")
                {
                    if (bool.TryParse(_value, out var _result))
                    {
                        return _result;
                    }

                    if (_value == "1")
                    {
                        return true;
                    }

                    if (_value == "0")
                    {
                        return false;
                    }

                    throw new FormatException("String format cannot be converted to boolean for column [" + columnName + "]. Please recheck input.");
                }
            }

            return false;
        }

        public int CheckAndGetInteger(DataGridView dataGridView, string columnName, DataGridViewRow dataGridViewRow)
        {
            if (dataGridView.Columns[columnName] != null)
            {
                try
                {
                    if (dataGridViewRow.Cells[dataGridView.Columns[columnName].Index].Value != DBNull.Value 
                        && dataGridViewRow.Cells[dataGridView.Columns[columnName].Index].Value.ToString() != "")
                    {
                        return Convert.ToInt32(dataGridViewRow.Cells[dataGridView.Columns[columnName].Index].Value);
                    }
                }
                catch (Exception)
                {
                    throw new FormatException("String format cannot be converted to integer for column [" + columnName + "]. Please recheck input.");
                }
            }

            return 0;
        }

        public int? CheckAndGetNullableInteger(DataGridView dataGridView, string columnName, DataGridViewRow dataGridViewRow)
        {
            if (dataGridView.Columns[columnName] != null)
            {
                try
                {
                    if (dataGridViewRow.Cells[dataGridView.Columns[columnName].Index].Value == DBNull.Value | dataGridViewRow.Cells[dataGridView.Columns[columnName].Index].Value.ToString() == "")
                    {
                        return null;
                    }

                    return Convert.ToInt32(dataGridViewRow.Cells[dataGridView.Columns[columnName].Index].Value);
                }
                catch (Exception)
                {
                    throw new FormatException("String format cannot be converted to integer for column [" + columnName + "]. Please recheck input.");
                }
            }

            return null;
        }

        public double CheckAndGetDouble(DataGridView dataGridView, string columnName, DataGridViewRow dataGridViewRow)
        {
            if (dataGridView.Columns[columnName] != null)
            {
                try
                {
                    if (dataGridViewRow.Cells[dataGridView.Columns[columnName].Index].Value != DBNull.Value)
                    {
                        return Convert.ToDouble(dataGridViewRow.Cells[dataGridView.Columns[columnName].Index].Value);
                    }
                }
                catch (Exception)
                {
                    throw new FormatException("String format cannot be converted to double for column [" + columnName + "]. Please recheck input.");
                }
            }

            return 0;
        }

        public DateTime CheckAndGetDate(DataGridView dataGridView, string columnName, DataGridViewRow dataGridViewRow)
        {
            if (dataGridView.Columns[columnName] != null)
            {
                try
                {
                    if (dataGridViewRow.Cells[dataGridView.Columns[columnName].Index].Value != DBNull.Value)
                    {
                        return Convert.ToDateTime(dataGridViewRow.Cells[dataGridView.Columns[columnName].Index].Value);
                    }
                }
                catch (Exception)
                {
                    throw new FormatException("String format cannot be converted to datetime for column [" +
                                              columnName + "]. Please recheck input.");
                }
            }

            return DateTime.Now;
        }

        #endregion

        #region Helper - Initialization, mapping and checking methods

        public void InitializeDelimiterComboBox(ComboBox delimiterComboBox)
        {
            delimiterComboBox.Items.AddRange(GetDelimiterList().Cast<object>().ToArray());
            delimiterComboBox.SelectedIndex = 0;
        }

        public DataTable InitializeDomainDataTable(Dictionary<int, string> mandatoryFields)
        {
            DataTable _domainTable = new DataTable();

            foreach (var _mandatoryField in mandatoryFields)
            {
                _domainTable.Columns.Add(_mandatoryField.Value);
            }

            return _domainTable;
        }

        public void MapMandatorySelectedColumnToTable(DataTable fileContent, DataGridView dataGridView, DataTable domainTable, ComboBox comboBox, string columnName)
        {
            var _columnIndex = fileContent.Columns.IndexOf(comboBox.SelectedItem.ToString());

            var _tableColumnIndex = domainTable.Columns.IndexOf(columnName);

            ClearColumn(dataGridView, _tableColumnIndex);

            MapFileContentToTable(fileContent, dataGridView, domainTable, _tableColumnIndex, _columnIndex);

            CheckCellsForNullOrEmpty(dataGridView, _tableColumnIndex);
        }

        //for fields with default value checkbox
        public void MapMandatorySelectedColumnToTable(DataTable fileContent, DataGridView dataGridView, DataTable domainTable, ComboBox comboBox, string columnName, CheckBox checkBox)
        {
            var _tableColumnIndex = domainTable.Columns.IndexOf(columnName);

            ClearColumn(dataGridView, _tableColumnIndex);

            if (!checkBox.Checked)
            {
                var _columnIndex = fileContent.Columns.IndexOf(comboBox.SelectedItem.ToString());

                MapFileContentToTable(fileContent, dataGridView, domainTable, _tableColumnIndex, _columnIndex);
            }
            else
            {
                var _defaultValue = (comboBox.SelectedItem as dynamic).Value.ToString();

                MapDefaultValueToTable(dataGridView, domainTable, _tableColumnIndex, _defaultValue);
            }

            CheckCellsForNullOrEmpty(dataGridView, _tableColumnIndex);
        }

        public void MapNonMandatorySelectedColumnToTable(DataTable fileContent, DataGridView dataGridView, DataTable domainTable, ComboBox comboBox, string columnName)
        {
            var _columnIndex = fileContent.Columns.IndexOf(comboBox.SelectedItem.ToString());

            CheckAndAddColumn(domainTable, columnName);

            var _tableColumnIndex = domainTable.Columns.IndexOf(columnName);

            ClearColumn(dataGridView, _tableColumnIndex);

            MapFileContentToTable(fileContent, dataGridView, domainTable, _tableColumnIndex, _columnIndex);

            CheckCellsForNullOrEmpty(dataGridView, _tableColumnIndex);
        }

        //for fields with default value checkbox
        public void MapNonMandatorySelectedColumnToTable(DataTable fileContent, DataGridView dataGridView, DataTable domainTable, ComboBox comboBox, string columnName, CheckBox checkBox)
        {
            CheckAndAddColumn(domainTable, columnName);

            var _tableColumnIndex = domainTable.Columns.IndexOf(columnName);

            ClearColumn(dataGridView, _tableColumnIndex);

            if (!checkBox.Checked)
            {
                var _columnIndex = fileContent.Columns.IndexOf(comboBox.SelectedItem.ToString());

                MapFileContentToTable(fileContent, dataGridView, domainTable, _tableColumnIndex, _columnIndex);
            }
            else
            {
                var _defaultValue = (comboBox.SelectedItem as dynamic).Value.ToString();

                MapDefaultValueToTable(dataGridView, domainTable, _tableColumnIndex, _defaultValue);
            }

            CheckCellsForNullOrEmpty(dataGridView, _tableColumnIndex);
        }

        public void MapValuesToComboBoxByCheckboxStatus(DataGridView dataGridView, DataTable domainTable, ComboBox comboBox, string columnName, 
            CheckBox checkBox, List<KeyValuePair<int, string>> keyValuePairList, object[] fileColumnHeaderArray)
        {
            comboBox.ResetText();
            comboBox.Items.Clear();

            if (checkBox.Checked)
            {
                AddKeyValuePairListToDomainComboBox(comboBox, keyValuePairList);
            }
            else
            {
                comboBox.Items.AddRange(fileColumnHeaderArray);
            }

            var _tableColumnIndex = domainTable.Columns.IndexOf(columnName);

            if (_tableColumnIndex != -1)
            {
                ClearColumn(dataGridView, _tableColumnIndex);

                ClearRow(domainTable, _tableColumnIndex);

                CheckCellsForNullOrEmpty(dataGridView, _tableColumnIndex);
            }
        }

        //for default non-key value pair list that is not from API
        public void MapNonKeyValuePairToComboBoxByCheckboxStatus(DataGridView dataGridView, DataTable domainTable, ComboBox comboBox, string columnName,
            CheckBox checkBox, List<string> defaultValueList, object[] fileColumnHeaderArray)
        {
            comboBox.ResetText();
            comboBox.Items.Clear();

            comboBox.Items.AddRange(checkBox.Checked ? defaultValueList.Cast<object>().ToArray() : fileColumnHeaderArray);

            var _tableColumnIndex = domainTable.Columns.IndexOf(columnName);

            if (_tableColumnIndex != -1)
            {
                ClearColumn(dataGridView, _tableColumnIndex);

                ClearRow(domainTable, _tableColumnIndex);

                CheckCellsForNullOrEmpty(dataGridView, _tableColumnIndex);
            }
        }

        private void AddKeyValuePairListToDomainComboBox(ComboBox comboBox, List<KeyValuePair<int, string>> keyValuePairList)
        {
            comboBox.DisplayMember = "Value";
            comboBox.ValueMember = "Key";

            if (keyValuePairList != null)
            {
                foreach (var _domain in keyValuePairList)
                {
                    comboBox.Items.Add(new { _domain.Key, _domain.Value });
                }
            }
        }

        private void MapFileContentToTable(DataTable fileContent, DataGridView dataGridView, DataTable domainTable, int tableColumnIndex, int fileColumnIndex)
        {
            for (int i = 0; i < fileContent.Rows.Count; i++)
            {
                //Invoke((MethodInvoker)(() => _customerTable.Rows[i][tableColumnIndex] = fileContent.Rows[i][fileColumnIndex]));
                domainTable.Rows[i][tableColumnIndex] = fileContent.Rows[i][fileColumnIndex];
            }

            dataGridView.Rows[0].Cells[tableColumnIndex].Selected = true;
            dataGridView.FirstDisplayedScrollingColumnIndex = tableColumnIndex;
            dataGridView.Focus();
        }

        private void MapDefaultValueToTable(DataGridView dataGridView, DataTable domainTable, int tableColumnIndex, string defaultValue)
        {
            for (int i = 0; i < domainTable.Rows.Count; i++)
            {
                //Invoke((MethodInvoker)(() =>domainTable.Rows[i][tableColumnIndex] = defaultValue));
                domainTable.Rows[i][tableColumnIndex] = defaultValue;
            }

            dataGridView.Rows[0].Cells[tableColumnIndex].Selected = true;
            dataGridView.FirstDisplayedScrollingColumnIndex = tableColumnIndex;
            dataGridView.Focus();
        }

        private void CheckAndAddColumn(DataTable domainTable, string columnName)
        {
            if (!domainTable.Columns.Contains(columnName))
            {
                domainTable.Columns.Add(columnName);
            }
        }

        private void CheckCellsForNullOrEmpty(DataGridView dataGridView, int columnIndex)
        {
            foreach (DataGridViewRow _row in dataGridView.Rows)
            {
                if (_row.Cells[columnIndex].Value == null ||
                    string.IsNullOrEmpty(_row.Cells[columnIndex].Value.ToString()))
                {
                    if (_row.DataBoundItem != null)
                    {
                        _row.Cells[columnIndex].Style.BackColor = Color.Red;
                    }
                }
            }
        }

        private void ClearColumn(DataGridView dataGridView, int columnIndex)
        {
            if (dataGridView!= null && dataGridView.Columns.Count - 1 >= columnIndex)
            {
                var _tmpCol = dataGridView.Columns[columnIndex];
                dataGridView.Columns.Remove(dataGridView.Columns[columnIndex]);
                dataGridView.Columns.Insert(columnIndex, _tmpCol);
            }
        }

        private void ClearRow(DataTable domainTable, int tableColumnIndex)
        {
            for (int i = 0; i < domainTable.Rows.Count; i++)
            {
                domainTable.Rows[i][tableColumnIndex] = "";
                //MethodInvoker((MethodInvoker)(() => domainTable.Rows[i][tableColumnIndex] = ""));
            }
        }

        public void HandleInvalidFieldValueToIDMapping(string columnName, DataGridViewRow row, string fieldValue, TextBox domainTextBox, BackgroundWorker workerFetcher, Control control)
        {
            control.Invoke((MethodInvoker)(() => row.DefaultCellStyle.BackColor = Color.Red));
            control.Invoke((MethodInvoker)(() => domainTextBox.AppendText(Environment.NewLine)));

            if (string.IsNullOrEmpty(fieldValue))
            {
                control.Invoke((MethodInvoker)(() => domainTextBox.AppendText("Row " + (row.Index + 1) +
                                                                               " - " + columnName + " is empty.")));
            }
            else
            {
                control.Invoke((MethodInvoker)(() => domainTextBox.AppendText("Row " + (row.Index + 1) +
                                                                               " - " + columnName + " '" + fieldValue + "' doesn't exist in TimeLog.")));
            }

            workerFetcher.CancelAsync();
        }

        #endregion
    }
}