using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
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
        private readonly List<string> _percentageList = new List<string>() ;

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
                    using Microsoft.VisualBasic.FileIO.TextFieldParser _csvReader = new Microsoft.VisualBasic.FileIO.TextFieldParser(csvFilePath,Encoding.GetEncoding("iso-8859-1"));
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

                            int _count = 0;

                            for (int i = 0; i < _fieldData.Length; i++)
                            {
                                if (_fieldData[i] == "")
                                {
                                    _fieldData[i] = null;
                                }
                                
                                if (_fieldData[i] != null && _fieldData[i] != "")
                                {
                                    _count++;
                                }
                            }

                            if (_count != 0)
                            {
                                _csvData.Rows.Add(_fieldData);
                            }
                            else
                            {
                                // All lines are empty if you end up here.
                            }
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


        public List<string> GetPercentageList()
        {
            if (_percentageList.Any())
            {
                return _percentageList;
            }

            for (int i = 0; i <= 100; i++)
            {
                _percentageList.Add(i.ToString());
            }

            return _percentageList;

        }


        public int GetIDFromFieldValue(List<KeyValuePair<int, string>> keyValuePairList, string fieldValue)
        {
            foreach (var _field in keyValuePairList)
            {
                if (_field.Value.ToLower().Trim().Equals(fieldValue.ToLower().Trim()))
                {
                    var _fieldKey = _field.Key;
                    return _fieldKey;
                }
            }

            return -1;
        }

       

        public int GetLegalEntityIDFromFieldValue(List<KeyValuePair<string, string>> keyValuePairList, string fieldValue, int legalEntityID)
        {
            foreach (var _field in keyValuePairList)
            {
                if (_field.Value.ToLower().Trim().Equals(fieldValue.ToLower().Trim()) && Convert.ToInt32(_field.Key.Split("_")[1]) == legalEntityID)
                {
                    var _fieldKey = _field.Key.Split("_")[0];
                    return Convert.ToInt32(_fieldKey);
                }
            }

            return -1;
        }

        #endregion

        #region Get methods for shared default values

        public List<CurrencyReadModel> GetAllCurrency(string token)
        {
            var _address = ApiHelper.Instance.SiteUrl + string.Format(ApiHelper.Instance.GetAllCurrencyEndpoint, 1);

            try
            {
                string _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);
                dynamic _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);

                if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities.Count > 0)
                {
                    List<CurrencyReadModel> _apiResponse = new List<CurrencyReadModel>();
                    var _totalPages = Convert.ToInt32(_jsonDeserializedObject.Properties.TotalPage.Value);
                    var _currentPage = Convert.ToInt32(_jsonDeserializedObject.Properties.PageNumber.Value);

                    foreach (var _entity in _jsonDeserializedObject.Entities)
                    {
                        foreach (var _property in _entity.Properties())
                        {
                            _apiResponse.Add(JsonConvert.DeserializeObject<CurrencyReadModel>(_property.Value.ToString()));
                        }
                    }

                    while (_totalPages > _currentPage)
                    {
                        _address = ApiHelper.Instance.SiteUrl + string.Format(ApiHelper.Instance.GetAllCurrencyEndpoint, _currentPage + 1);
                        _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);

                        _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);
                        if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities.Count > 0)
                        {
                            _currentPage = Convert.ToInt32(_jsonDeserializedObject.Properties.PageNumber.Value);

                            foreach (var _entity in _jsonDeserializedObject.Entities)
                            {
                                foreach (var _property in _entity.Properties())
                                {
                                    if (_property.Name == "Properties")
                                    {
                                        _apiResponse.Add(JsonConvert.DeserializeObject<CustomerReadModel>(_property.Value.ToString()));
                                    }
                                }
                            }
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

        public List<LegalEntityReadModel> GetAllLegalEntity(string token)
        {
            var _address = ApiHelper.Instance.SiteUrl + string.Format(ApiHelper.Instance.GetAllLegalEntityEndpoint, 1);

            try
            {
                string _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);
                dynamic _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);

                if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities.Count > 0)
                {
                    List<LegalEntityReadModel> _apiResponse = new List<LegalEntityReadModel>();
                    var _totalPages = Convert.ToInt32(_jsonDeserializedObject.Properties.TotalPage.Value);
                    var _currentPage = Convert.ToInt32(_jsonDeserializedObject.Properties.PageNumber.Value);

                    foreach (var _entity in _jsonDeserializedObject.Entities)
                    {
                        foreach (var _property in _entity.Properties())
                        {
                            _apiResponse.Add(JsonConvert.DeserializeObject<LegalEntityReadModel>(_property.Value.ToString()));
                        }
                    }

                    while (_totalPages > _currentPage)
                    {
                        _address = ApiHelper.Instance.SiteUrl + string.Format(ApiHelper.Instance.GetAllLegalEntityEndpoint, _currentPage + 1);
                        _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);

                        _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);
                        if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities.Count > 0)
                        {
                            _currentPage = Convert.ToInt32(_jsonDeserializedObject.Properties.PageNumber.Value);

                            foreach (var _entity in _jsonDeserializedObject.Entities)
                            {
                                foreach (var _property in _entity.Properties())
                                {
                                    if (_property.Name == "Properties")
                                    {
                                        _apiResponse.Add(JsonConvert.DeserializeObject<CustomerReadModel>(_property.Value.ToString()));
                                    }
                                }
                            }
                        }
                    }
                    return _apiResponse;
                }
            }
            catch (WebException _webEx)
            {
                MessageBox.Show("Failed to obtain default legal entity ID list. " + _webEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return null;
        }

        public List<EmployeeReadModel> GetAllEmployee(string token)
        {
            var _address = ApiHelper.Instance.SiteUrl + string.Format(ApiHelper.Instance.GetAllEmployeeEndpoint, 1);

            try
            {
                string _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);
                dynamic _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);

                if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities.Count > 0)
                {
                    List<EmployeeReadModel> _apiResponse = new List<EmployeeReadModel>();
                    var _totalPages = Convert.ToInt32(_jsonDeserializedObject.Properties.TotalPage.Value);
                    var _currentPage = Convert.ToInt32(_jsonDeserializedObject.Properties.PageNumber.Value);

                    foreach (var _entity in _jsonDeserializedObject.Entities)
                    {
                        foreach (var _property in _entity.Properties())
                        {
                            if (_property.Name == "Properties")
                            {
                                _apiResponse.Add(JsonConvert.DeserializeObject<EmployeeReadModel>(_property.Value.ToString()));
                            }
                        }
                    }
                    
                    while (_totalPages > _currentPage)
                    {
                        _address = ApiHelper.Instance.SiteUrl + string.Format(ApiHelper.Instance.GetAllEmployeeEndpoint, _currentPage + 1);
                        _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);

                        _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);
                        if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities.Count > 0)
                        {
                            _currentPage = Convert.ToInt32(_jsonDeserializedObject.Properties.PageNumber.Value);

                            foreach (var _entity in _jsonDeserializedObject.Entities)
                            {
                                foreach (var _property in _entity.Properties())
                                {
                                    if (_property.Name == "Properties")
                                    {
                                        _apiResponse.Add(JsonConvert.DeserializeObject<EmployeeReadModel>(_property.Value.ToString()));
                                    }
                                }
                            }
                        }
                    }
                    
                    return _apiResponse.Where(x=>x.IsActive && x.UserType.Equals("Employee")).ToList();
                }
            }
            catch (WebException _webEx)
            {
                MessageBox.Show("Failed to obtain default primary and secondary KAM ID list. " + _webEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return null;
        }

        public List<CustomerReadModel> GetAllCustomer(string token)
        {
            var _address = ApiHelper.Instance.SiteUrl + string.Format(ApiHelper.Instance.GetAllCustomerEndpoint, 1);

            try
            {
                string _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);
                dynamic _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);

                if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities.Count > 0)
                {
                    List<CustomerReadModel> _apiResponse = new List<CustomerReadModel>();

                    var _totalPages = Convert.ToInt32(_jsonDeserializedObject.Properties.TotalPage.Value);
                    var _currentPage = Convert.ToInt32(_jsonDeserializedObject.Properties.PageNumber.Value);

                    foreach (var _entity in _jsonDeserializedObject.Entities)
                    {
                        foreach (var _property in _entity.Properties())
                        {
                            if (_property.Name == "Properties")
                            {
                                _apiResponse.Add(JsonConvert.DeserializeObject<CustomerReadModel>(_property.Value.ToString()));
                            }
                        }
                    }

                    while (_totalPages > _currentPage)
                    {
                        _address = ApiHelper.Instance.SiteUrl + string.Format(ApiHelper.Instance.GetAllCustomerEndpoint, _currentPage + 1);
                        _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);

                        _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);
                        if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities.Count > 0)
                        {
                             _currentPage = Convert.ToInt32(_jsonDeserializedObject.Properties.PageNumber.Value);

                            foreach (var _entity in _jsonDeserializedObject.Entities)
                            {
                                foreach (var _property in _entity.Properties())
                                {
                                    if (_property.Name == "Properties")
                                    {
                                        _apiResponse.Add(JsonConvert.DeserializeObject<CustomerReadModel>(_property.Value.ToString()));
                                    }
                                }
                            }
                        }
                    }

                    return _apiResponse;
                }
            }
            catch (WebException _webEx)
            {
                MessageBox.Show("Failed to obtain default customer ID list. " + _webEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return null;
        }

        public List<CustomerStatusReadModel> GetAllCustomerStatus(string token)
        {
            var _address = ApiHelper.Instance.SiteUrl + string.Format(ApiHelper.Instance.GetAllCustomerStatusEndpoint, 1);

            try
            {
                string _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);
                dynamic _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);

                if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities != null && _jsonDeserializedObject.Entities.Count > 0)
                {
                    List<CustomerStatusReadModel> _apiResponse = new List<CustomerStatusReadModel>();

                    var _totalPages = Convert.ToInt32(_jsonDeserializedObject.Properties.TotalPage.Value);
                    var _currentPage = Convert.ToInt32(_jsonDeserializedObject.Properties.PageNumber.Value);

                    foreach (var _entity in _jsonDeserializedObject.Entities)
                    {
                        foreach (var _property in _entity.Properties())
                        {
                            _apiResponse.Add(JsonConvert.DeserializeObject<CustomerStatusReadModel>(_property.Value.ToString()));
                        }
                    }

                    while (_totalPages > _currentPage)
                    {
                        _address = ApiHelper.Instance.SiteUrl + string.Format(ApiHelper.Instance.GetAllCustomerStatusEndpoint, _currentPage + 1);
                        _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);

                        _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);
                        if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities.Count > 0)
                        {
                            _currentPage = Convert.ToInt32(_jsonDeserializedObject.Properties.PageNumber.Value);
                            foreach (var _entity in _jsonDeserializedObject.Entities)
                            {
                                foreach (var _property in _entity.Properties())
                                {
                                    _apiResponse.Add(JsonConvert.DeserializeObject<CustomerStatusReadModel>(_property.Value.ToString()));
                                }
                            }

                        }
                    }

                    return _apiResponse;
                }
            }
            catch (WebException _webEx)
            {
                MessageBox.Show("Failed to obtain default customer status ID list. " + _webEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return null;
        }

        public List<ProjectReadModel> GetAllProject(string token)
        {
            var _address = ApiHelper.Instance.SiteUrl + string.Format(ApiHelper.Instance.GetAllProjectEndpoint, 1);

            try
            {
                string _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);
                dynamic _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);

                if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities != null && _jsonDeserializedObject.Entities.Count > 0)
                {
                    List<ProjectReadModel> _apiResponse = new List<ProjectReadModel>();
                    var _totalPages = Convert.ToInt32(_jsonDeserializedObject.Properties.TotalPage.Value);
                    var _currentPage = Convert.ToInt32(_jsonDeserializedObject.Properties.PageNumber.Value);

                    foreach (var _entity in _jsonDeserializedObject.Entities)
                    {
                        foreach (var _property in _entity.Properties())
                        {
                            if (_property.Name == "Properties")
                            {
                                _apiResponse.Add(JsonConvert.DeserializeObject<ProjectReadModel>(_property.Value.ToString()));
                            }
                        }
                    }
                    
                    while (_totalPages > _currentPage)
                    {
                        _address = ApiHelper.Instance.SiteUrl + string.Format(ApiHelper.Instance.GetAllProjectEndpoint, _currentPage + 1);
                        _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);

                        _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);
                        if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities.Count > 0)
                        {
                            _currentPage = Convert.ToInt32(_jsonDeserializedObject.Properties.PageNumber.Value);

                            foreach (var _entity in _jsonDeserializedObject.Entities)
                            {
                                foreach (var _property in _entity.Properties())
                                {
                                    if (_property.Name == "Properties")
                                    {
                                        _apiResponse.Add(JsonConvert.DeserializeObject<ProjectReadModel>(_property.Value.ToString()));
                                    }
                                }
                            }

                        }
                    }
                    return _apiResponse;
                }
            }
            catch (WebException _webEx)
            {
                MessageBox.Show("Failed to obtain default project ID list. " + _webEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return null;
        }

       

        public List<ProjectSubContractReadModel> GetAllContract(string token, int projectID)
        {
            var _address = ApiHelper.Instance.SiteUrl + string.Format(ApiHelper.Instance.GetAllContractEndpoint + "&projectID=" + projectID, 1);

            try
            {
                string _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);
                dynamic _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);

                if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities.Count > 0)
                {
                    List<ProjectSubContractReadModel> _apiResponse = new List<ProjectSubContractReadModel>();
                    var _totalPages = Convert.ToInt32(_jsonDeserializedObject.Properties.TotalPage.Value);
                    var _currentPage = Convert.ToInt32(_jsonDeserializedObject.Properties.PageNumber.Value);

                    foreach (var _entity in _jsonDeserializedObject.Entities)
                    {
                        foreach (var _property in _entity.Properties())
                        {
                            if (_property.Name == "Properties")
                            {
                                _apiResponse.Add(JsonConvert.DeserializeObject<ProjectSubContractReadModel>(_property.Value.ToString()));
                            }
                        }
                    }

                    while (_totalPages > _currentPage)
                    {
                        _address = ApiHelper.Instance.SiteUrl + string.Format(ApiHelper.Instance.GetAllContractEndpoint, _currentPage + 1);
                        _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);

                        _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);
                        if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities.Count > 0)
                        {
                            _currentPage = Convert.ToInt32(_jsonDeserializedObject.Properties.PageNumber.Value);

                            foreach (var _entity in _jsonDeserializedObject.Entities)
                            {
                                foreach (var _property in _entity.Properties())
                                {
                                    if (_property.Name == "Properties")
                                    {
                                        _apiResponse.Add(JsonConvert.DeserializeObject<ProjectSubContractReadModel>(_property.Value.ToString()));
                                    }
                                }
                            }

                        }
                    }

                    return _apiResponse;
                }
            }
            catch (WebException _webEx)
            {
                MessageBox.Show("Failed to obtain default project sub contract ID list. " + _webEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return null;
        }



        public List<ContractModelReadModel> GetAllContractModels(string token)
        {
            var _address = ApiHelper.Instance.SiteUrl + string.Format(ApiHelper.Instance.GetAllContractModelsEndpoint, 1);

            try
            {
                string _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);
                dynamic _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);

                if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities.Count > 0)
                {
                    List<ContractModelReadModel> _apiResponse = new List<ContractModelReadModel>();
                    //var _totalPages = Convert.ToInt32(_jsonDeserializedObject.Properties.TotalPage.Value);
                    //var _currentPage = Convert.ToInt32(_jsonDeserializedObject.Properties.PageNumber.Value);

                    foreach (var _entity in _jsonDeserializedObject.Entities)
                    {
                        foreach (var _property in _entity.Properties())
                        {
                            if (_property.Name == "Properties")
                            {
                                _apiResponse.Add(JsonConvert.DeserializeObject<ContractModelReadModel>(_property.Value.ToString()));
                            }
                        }
                    }

                    //while (_totalPages > _currentPage)
                    //{
                    //    _address = ApiHelper.Instance.SiteUrl + string.Format(ApiHelper.Instance.GetAllContractModelsEndpoint, _currentPage + 1);
                    //    _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);

                    //    _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);
                    //    if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities.Count > 0)
                    //    {
                    //        _currentPage = Convert.ToInt32(_jsonDeserializedObject.Properties.PageNumber.Value);
                    //        foreach (var _entity in _jsonDeserializedObject.Entities)
                    //        {
                    //            foreach (var _property in _entity.Properties())
                    //            {
                    //                if (_property.Name == "Properties")
                    //                {
                    //                    _apiResponse.Add(JsonConvert.DeserializeObject<ContractModelReadModel>(_property.Value.ToString()));
                    //                }
                    //            }
                    //        }

                    //    }
                    //}
                    return _apiResponse;
                }
            }
            catch (WebException _webEx)
            {
                MessageBox.Show("Failed to obtain default contract model list. " + _webEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return null;
        }

        public List<HourlyRateReadModel> GetAllDefaultHourlyRate(string token)
        {
            var _address = ApiHelper.Instance.SiteUrl + string.Format(ApiHelper.Instance.GetDefaultHourlyRatesEndpoint, 1);

            try
            {
                string _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);
                dynamic _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);

                if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities != null && _jsonDeserializedObject.Entities.Count > 0)
                {
                    List<HourlyRateReadModel> _apiResponse = new List<HourlyRateReadModel>();
                    var _totalPages = Convert.ToInt32(_jsonDeserializedObject.Properties.TotalPage.Value);
                    var _currentPage = Convert.ToInt32(_jsonDeserializedObject.Properties.PageNumber.Value);

                    foreach (var _entity in _jsonDeserializedObject.Entities)
                    {
                        foreach (var _property in _entity.Properties())
                        {
                            _apiResponse.Add(JsonConvert.DeserializeObject<HourlyRateReadModel>(_property.Value.ToString()));
                        }
                    }

                    while (_totalPages > _currentPage)
                    {
                        _address = ApiHelper.Instance.SiteUrl + string.Format(ApiHelper.Instance.GetDefaultHourlyRatesEndpoint, _currentPage + 1);
                        _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);

                        _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);
                        if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities.Count > 0)
                        {
                            _currentPage = Convert.ToInt32(_jsonDeserializedObject.Properties.PageNumber.Value);

                            foreach (var _entity in _jsonDeserializedObject.Entities)
                            {
                                foreach (var _property in _entity.Properties())
                                {
                                    _apiResponse.Add(JsonConvert.DeserializeObject<HourlyRateReadModel>(_property.Value.ToString()));
                                }
                            }
                        }
                    }
                    return _apiResponse;
                }
            }
            catch (WebException _webEx)
            {
                MessageBox.Show("Failed to obtain default hourly rate ID list. " + _webEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return null;
        }

        public List<DepartmentReadModel> GetAllDepartment(string token)
        {
            var _address = ApiHelper.Instance.SiteUrl + string.Format(ApiHelper.Instance.GetAllDepartmentEndpoint, 1);

            try
            {
                string _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);
                dynamic _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);

                if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities != null && _jsonDeserializedObject.Entities.Count > 0)
                {
                    List<DepartmentReadModel> _apiResponse = new List<DepartmentReadModel>();
                    var _totalPages = Convert.ToInt32(_jsonDeserializedObject.Properties.TotalPage.Value);
                    var _currentPage = Convert.ToInt32(_jsonDeserializedObject.Properties.PageNumber.Value);

                    foreach (var _entity in _jsonDeserializedObject.Entities)
                    {
                        foreach (var _property in _entity.Properties())
                        {
                            _apiResponse.Add(JsonConvert.DeserializeObject<DepartmentReadModel>(_property.Value.ToString()));
                        }
                    }

                    while (_totalPages > _currentPage)
                    {
                        _address = ApiHelper.Instance.SiteUrl + string.Format(ApiHelper.Instance.GetAllDepartmentEndpoint, _currentPage + 1);
                        _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);

                        _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);
                        if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities.Count > 0)
                        {
                            _currentPage = Convert.ToInt32(_jsonDeserializedObject.Properties.PageNumber.Value);

                            foreach (var _entity in _jsonDeserializedObject.Entities)
                            {
                                foreach (var _property in _entity.Properties())
                                {
                                    _apiResponse.Add(JsonConvert.DeserializeObject<DepartmentReadModel>(_property.Value.ToString()));
                                }
                            }
                        }
                    }

                    return _apiResponse;
                }
            }
            catch (WebException _webEx)
            {
                MessageBox.Show("Failed to obtain default department ID list. " + _webEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return null;
        }

        public List<UnitTypeReadModel> GetAllUnitType(string token)
        {
            var _address = ApiHelper.Instance.SiteUrl + string.Format(ApiHelper.Instance.GetAllUnitTypeEndpoint, 1);

            try
            {
                string _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);
                dynamic _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);

                if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities != null && _jsonDeserializedObject.Entities.Count > 0)
                {
                    List<UnitTypeReadModel> _apiResponse = new List<UnitTypeReadModel>();
                    //var _totalPages = Convert.ToInt32(_jsonDeserializedObject.Properties.TotalPage.Value);
                    //var _currentPage = Convert.ToInt32(_jsonDeserializedObject.Properties.PageNumber.Value);

                    foreach (var _entity in _jsonDeserializedObject.Entities)
                    {
                        foreach (var _property in _entity.Properties())
                        {
                            _apiResponse.Add(JsonConvert.DeserializeObject<UnitTypeReadModel>(_property.Value.ToString()));
                        }
                    }

                    //while (_totalPages > _currentPage)
                    //{
                    //    _address = ApiHelper.Instance.SiteUrl + string.Format(ApiHelper.Instance.GetAllUnitTypeEndpoint, _currentPage + 1);
                    //    _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);

                    //    _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);
                    //    if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities.Count > 0)
                    //    {
                    //        _currentPage = Convert.ToInt32(_jsonDeserializedObject.Properties.PageNumber.Value);

                    //        foreach (var _entity in _jsonDeserializedObject.Entities)
                    //        {
                    //            foreach (var _property in _entity.Properties())
                    //            {
                    //                _apiResponse.Add(JsonConvert.DeserializeObject<UnitTypeReadModel>(_property.Value.ToString()));
                    //            }
                    //        }

                    //    }
                    //}
                    return _apiResponse;
                }
            }
            catch (WebException _webEx)
            {
                MessageBox.Show("Failed to obtain default Unit Type list. " + _webEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return null;
        }

        public List<AbsenceCodeReadModel> GetAllAbsenceCode(string token)
        {
            var _address = ApiHelper.Instance.SiteUrl + string.Format(ApiHelper.Instance.GetAllAbsenceCodeEndpoint, 1);

            try
            {
                string _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);
                dynamic _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);

                if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities != null && _jsonDeserializedObject.Entities.Count > 0)
                {
                    List<AbsenceCodeReadModel> _apiResponse = new List<AbsenceCodeReadModel>();
                    var _totalPages = Convert.ToInt32(_jsonDeserializedObject.Properties.TotalPage.Value);
                    var _currentPage = Convert.ToInt32(_jsonDeserializedObject.Properties.PageNumber.Value);

                    foreach (var _entity in _jsonDeserializedObject.Entities)
                    {
                        foreach (var _property in _entity.Properties())
                        {
                            if (_property.Name == "Properties")
                            {
                                _apiResponse.Add(JsonConvert.DeserializeObject<AbsenceCodeReadModel>(_property.Value.ToString()));
                            }
                        }
                    }

                    while (_totalPages > _currentPage)
                    {
                        _address = ApiHelper.Instance.SiteUrl + string.Format(ApiHelper.Instance.GetAllAbsenceCodeEndpoint, _currentPage + 1);
                        _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);

                        _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);
                        if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities.Count > 0)
                        {
                            _currentPage = Convert.ToInt32(_jsonDeserializedObject.Properties.PageNumber.Value);

                            foreach (var _entity in _jsonDeserializedObject.Entities)
                            {
                                foreach (var _property in _entity.Properties())
                                {
                                    if (_property.Name == "Properties")
                                    {
                                        _apiResponse.Add(JsonConvert.DeserializeObject<AbsenceCodeReadModel>(_property.Value.ToString()));
                                    }
                                }
                            }
                        }
                    }
                    return _apiResponse;
                }
            }
            catch (WebException _webEx)
            {
                MessageBox.Show("Failed to obtain absence code list. " + _webEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return null;
        }

        public List<CountryReadModel> GetAllCountry(string token)
        {
            var _address = ApiHelper.Instance.SiteUrl + string.Format(ApiHelper.Instance.GetAllCountryEndpoint, 1);

            try
            {
                string _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);
                dynamic _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);

                if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities != null && _jsonDeserializedObject.Entities.Count > 0)
                {
                    List<CountryReadModel> _apiResponse = new List<CountryReadModel>();
                    var _totalPages = Convert.ToInt32(_jsonDeserializedObject.Properties.TotalPage.Value);
                    var _currentPage = Convert.ToInt32(_jsonDeserializedObject.Properties.PageNumber.Value);

                    foreach (var _entity in _jsonDeserializedObject.Entities)
                    {
                        foreach (var _property in _entity.Properties())
                        {
                            _apiResponse.Add(JsonConvert.DeserializeObject<CountryReadModel>(_property.Value.ToString()));
                        }
                    }

                    while (_totalPages > _currentPage)
                    {
                        _address = ApiHelper.Instance.SiteUrl + string.Format(ApiHelper.Instance.GetAllCountryEndpoint, _currentPage + 1);
                        _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);

                        _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);
                        if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities.Count > 0)
                        {
                            _currentPage = Convert.ToInt32(_jsonDeserializedObject.Properties.PageNumber.Value);

                            foreach (var _entity in _jsonDeserializedObject.Entities)
                            {
                                foreach (var _property in _entity.Properties())
                                {
                                    _apiResponse.Add(JsonConvert.DeserializeObject<CountryReadModel>(_property.Value.ToString()));
                                }
                            }

                        }
                    }
                    return _apiResponse;
                }
            }
            catch (WebException _webEx)
            {
                MessageBox.Show("Failed to obtain default country ID list. " + _webEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return null;
        }



        public List<IndustryReadModel> GetAllIndustry(string token)
        {
            var _address = ApiHelper.Instance.SiteUrl + string.Format(ApiHelper.Instance.GetAllIndustryEndpoint, 1);

            try
            {
                string _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);
                dynamic _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);

                if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities != null && _jsonDeserializedObject.Entities.Count > 0)
                {
                    List<IndustryReadModel> _apiResponse = new List<IndustryReadModel>();
                    var _totalPages = Convert.ToInt32(_jsonDeserializedObject.Properties.TotalPage.Value);
                    var _currentPage = Convert.ToInt32(_jsonDeserializedObject.Properties.PageNumber.Value);

                    foreach (var _entity in _jsonDeserializedObject.Entities)
                    {
                        foreach (var _property in _entity.Properties())
                        {
                            _apiResponse.Add(JsonConvert.DeserializeObject<IndustryReadModel>(_property.Value.ToString()));
                        }
                    }

                    while (_totalPages > _currentPage)
                    {
                        _address = ApiHelper.Instance.SiteUrl + string.Format(ApiHelper.Instance.GetAllIndustryEndpoint, _currentPage + 1);
                        _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);

                        _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);
                        if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities.Count > 0)
                        {
                            _currentPage = Convert.ToInt32(_jsonDeserializedObject.Properties.PageNumber.Value);

                            foreach (var _entity in _jsonDeserializedObject.Entities)
                            {
                                foreach (var _property in _entity.Properties())
                                {
                                    _apiResponse.Add(JsonConvert.DeserializeObject<IndustryReadModel>(_property.Value.ToString()));
                                }
                            }
                        }
                    }
                    return _apiResponse;
                }
            }
            catch (WebException _webEx)
            {
                MessageBox.Show("Failed to obtain default industry ID list. " + _webEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return null;
        }

        public List<PaymentTermReadModel> GetAllPaymentTerm(string token)
        {
            var _address = ApiHelper.Instance.SiteUrl + string.Format(ApiHelper.Instance.GetAllPaymentTermEndpoint, 1);

            try
            {
                string _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);
                dynamic _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);

                if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities != null && _jsonDeserializedObject.Entities.Count > 0)
                {
                    List<PaymentTermReadModel> _apiResponse = new List<PaymentTermReadModel>();
                    var _totalPages = Convert.ToInt32(_jsonDeserializedObject.Properties.TotalPage.Value);
                    var _currentPage = Convert.ToInt32(_jsonDeserializedObject.Properties.PageNumber.Value);

                    foreach (var _entity in _jsonDeserializedObject.Entities)
                    {
                        foreach (var _property in _entity.Properties())
                        {
                            _apiResponse.Add(JsonConvert.DeserializeObject<PaymentTermReadModel>(_property.Value.ToString()));
                        }
                    }

                    while (_totalPages > _currentPage)
                    {
                        _address = ApiHelper.Instance.SiteUrl + string.Format(ApiHelper.Instance.GetAllPaymentTermEndpoint, _currentPage + 1);
                        _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);

                        _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);
                        if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities.Count > 0)
                        {
                            _currentPage = Convert.ToInt32(_jsonDeserializedObject.Properties.PageNumber.Value);

                            foreach (var _entity in _jsonDeserializedObject.Entities)
                            {
                                foreach (var _property in _entity.Properties())
                                {
                                    _apiResponse.Add(JsonConvert.DeserializeObject<PaymentTermReadModel>(_property.Value.ToString()));
                                }
                            }
                        }
                    }
                    return _apiResponse;
                }
            }
            catch (WebException _webEx)
            {
                MessageBox.Show("Failed to obtain default payment term ID list. " + _webEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return null;
        }

        public List<EmployeeTypeReadModel> GetAllEmployeeTypes(string token)
        {
            var _address = ApiHelper.Instance.SiteUrl + string.Format(ApiHelper.Instance.GetAllEmployeeTypeEndpoint, 1);

            try
            {
                string _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);
                dynamic _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);

                if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities != null && _jsonDeserializedObject.Entities.Count > 0)
                {
                    List<EmployeeTypeReadModel> _apiResponse = new List<EmployeeTypeReadModel>();
                    //var _totalPages = Convert.ToInt32(_jsonDeserializedObject.Properties.TotalPage.Value);
                    //var _currentPage = Convert.ToInt32(_jsonDeserializedObject.Properties.PageNumber.Value);

                    foreach (var _entity in _jsonDeserializedObject.Entities)
                    {
                        foreach (var _property in _entity.Properties())
                        {
                            _apiResponse.Add(JsonConvert.DeserializeObject<EmployeeTypeReadModel>(_property.Value.ToString()));
                        }
                    }

                    //while (_totalPages > _currentPage)
                    //{
                    //    _address = ApiHelper.Instance.SiteUrl + string.Format(ApiHelper.Instance.GetAllEmployeeTypeEndpoint, _currentPage + 1);
                    //    _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);

                    //    _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);
                    //    if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities.Count > 0)
                    //    {
                    //        _currentPage = Convert.ToInt32(_jsonDeserializedObject.Properties.PageNumber.Value);

                    //        foreach (var _entity in _jsonDeserializedObject.Entities)
                    //        {
                    //            foreach (var _property in _entity.Properties())
                    //            {
                    //                _apiResponse.Add(JsonConvert.DeserializeObject<EmployeeTypeReadModel>(_property.Value.ToString()));
                    //            }
                    //        }
                    //    }
                    //}
                    return _apiResponse;
                }
            }
            catch (WebException _webEx)
            {
                MessageBox.Show("Failed to obtain default EmployyType ID list. " + _webEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return null;
        }

        public List<PaymentMethodReadModel> GetAllPaymentMethod(string token)
        {
            var _address = ApiHelper.Instance.SiteUrl + string.Format(ApiHelper.Instance.GetAllPaymentMethodEndpoint, 1);

            try
            {
                string _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);
                dynamic _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);

                if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities != null && _jsonDeserializedObject.Entities.Count > 0)
                {
                    List<PaymentMethodReadModel> _apiResponse = new List<PaymentMethodReadModel>();
                    var _totalPages = Convert.ToInt32(_jsonDeserializedObject.Properties.TotalPage.Value);
                    var _currentPage = Convert.ToInt32(_jsonDeserializedObject.Properties.PageNumber.Value);

                    foreach (var _entity in _jsonDeserializedObject.Entities)
                    {
                        foreach (var _property in _entity.Properties())
                        {
                            _apiResponse.Add(JsonConvert.DeserializeObject<PaymentMethodReadModel>(_property.Value.ToString()));
                        }
                    }

                    while (_totalPages > _currentPage)
                    {
                        _address = ApiHelper.Instance.SiteUrl + string.Format(ApiHelper.Instance.GetAllPaymentMethodEndpoint, _currentPage + 1);
                        _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);

                        _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);
                        if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities.Count > 0)
                        {
                            _currentPage = Convert.ToInt32(_jsonDeserializedObject.Properties.PageNumber.Value);

                            foreach (var _entity in _jsonDeserializedObject.Entities)
                            {
                                foreach (var _property in _entity.Properties())
                                {
                                    _apiResponse.Add(JsonConvert.DeserializeObject<PaymentMethodReadModel>(_property.Value.ToString()));
                                }
                            }
                        }
                    }
                    return _apiResponse;
                }
            }
            catch (WebException _webEx)
            {
                MessageBox.Show("Failed to obtain default payment method ID list. " + _webEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return null;
        }

        public List<ExpenseTypeReadModel> GetAllExpenseType(string token)
        {
            var _address = ApiHelper.Instance.SiteUrl + string.Format(ApiHelper.Instance.GetAllExpenseTypeEndpoint, 1);

            try
            {
                string _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);
                dynamic _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);

                if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities != null && _jsonDeserializedObject.Entities.Count > 0)
                {
                    List<ExpenseTypeReadModel> _apiResponse = new List<ExpenseTypeReadModel>();
                    var _totalPages = Convert.ToInt32(_jsonDeserializedObject.Properties.TotalPage.Value);
                    var _currentPage = Convert.ToInt32(_jsonDeserializedObject.Properties.PageNumber.Value);

                    foreach (var _entity in _jsonDeserializedObject.Entities)
                    {
                        foreach (var _property in _entity.Properties())
                        {
                            _apiResponse.Add(JsonConvert.DeserializeObject<ExpenseTypeReadModel>(_property.Value.ToString()));
                        }
                    }

                    while (_totalPages > _currentPage)
                    {
                        _address = ApiHelper.Instance.SiteUrl + string.Format(ApiHelper.Instance.GetAllExpenseTypeEndpoint, _currentPage + 1);
                        _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);

                        _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);
                        if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities.Count > 0)
                        {
                            _currentPage = Convert.ToInt32(_jsonDeserializedObject.Properties.PageNumber.Value);

                            foreach (var _entity in _jsonDeserializedObject.Entities)
                            {
                                foreach (var _property in _entity.Properties())
                                {
                                    _apiResponse.Add(JsonConvert.DeserializeObject<ExpenseTypeReadModel>(_property.Value.ToString()));
                                }
                            }
                        }
                    }
                    return _apiResponse;
                }
            }
            catch (WebException _webEx)
            {
                MessageBox.Show("Failed to obtain default expense type ID list. " + _webEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return null;
        }

        public List<ProjectTemplateReadModel> GetAllProjectTemplate(string token)
        {
            var _address = ApiHelper.Instance.SiteUrl + string.Format(ApiHelper.Instance.GetAllProjectTemplateEndpoint, 1);


            try
            {
                string _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);
                dynamic _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);

                if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities != null && _jsonDeserializedObject.Entities.Count > 0)
                {
                    List<ProjectTemplateReadModel> _apiResponse = new List<ProjectTemplateReadModel>();
                    //var _totalPages = Convert.ToInt32(_jsonDeserializedObject.Properties.TotalPage.Value);
                    //var _currentPage = Convert.ToInt32(_jsonDeserializedObject.Properties.PageNumber.Value);

                    foreach (var _entity in _jsonDeserializedObject.Entities)
                    {
                        foreach (var _property in _entity.Properties())
                        {
                            _apiResponse.Add(JsonConvert.DeserializeObject<ProjectTemplateReadModel>(_property.Value.ToString()));
                        }
                    }

                    //while (_totalPages > _currentPage)
                    //{
                    //    _address = ApiHelper.Instance.SiteUrl + string.Format(ApiHelper.Instance.GetAllProjectTemplateEndpoint, _currentPage + 1);
                    //    _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);

                    //    _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);
                    //    if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities.Count > 0)
                    //    {
                    //        _currentPage = Convert.ToInt32(_jsonDeserializedObject.Properties.PageNumber.Value);

                    //        foreach (var _entity in _jsonDeserializedObject.Entities)
                    //        {
                    //            foreach (var _property in _entity.Properties())
                    //            {
                    //                _apiResponse.Add(JsonConvert.DeserializeObject<ProjectTemplateReadModel>(_property.Value.ToString()));
                    //            }
                    //        }
                    //    }
                    //}
                    return _apiResponse;
                }
            }
            catch (WebException _webEx)
            {
                MessageBox.Show("Failed to obtain default project template ID list. " + _webEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return null;
        }

        public List<ProjectTypeReadModel> GetAllProjectType(string token)
        {
            var _address = ApiHelper.Instance.SiteUrl + string.Format(ApiHelper.Instance.GetAllProjectTypeEndpoint, 1);

            try
            {
                string _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);
                dynamic _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);

                if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities != null && _jsonDeserializedObject.Entities.Count > 0)
                {
                    List<ProjectTypeReadModel> _apiResponse = new List<ProjectTypeReadModel>();
                    var _totalPages = Convert.ToInt32(_jsonDeserializedObject.Properties.TotalPage.Value);
                    var _currentPage = Convert.ToInt32(_jsonDeserializedObject.Properties.PageNumber.Value);

                    foreach (var _entity in _jsonDeserializedObject.Entities)
                    {
                        foreach (var _property in _entity.Properties())
                        {
                            _apiResponse.Add(JsonConvert.DeserializeObject<ProjectTypeReadModel>(_property.Value.ToString()));
                        }
                    }

                    while (_totalPages > _currentPage)
                    {
                        _address = ApiHelper.Instance.SiteUrl + string.Format(ApiHelper.Instance.GetAllProjectTypeEndpoint, _currentPage + 1);
                        _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);

                        _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);
                        if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities.Count > 0)
                        {
                            _currentPage = Convert.ToInt32(_jsonDeserializedObject.Properties.PageNumber.Value);

                            foreach (var _entity in _jsonDeserializedObject.Entities)
                            {
                                foreach (var _property in _entity.Properties())
                                {
                                    _apiResponse.Add(JsonConvert.DeserializeObject<ProjectTypeReadModel>(_property.Value.ToString()));
                                }
                            }
                        }
                    }
                    return _apiResponse;
                }
            }
            catch (WebException _webEx)
            {
                MessageBox.Show("Failed to obtain default project type ID list. " + _webEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return null;
        }

        public List<ProjectCategoryReadModel> GetAllProjectCategory(string token)
        {
            var _address = ApiHelper.Instance.SiteUrl + string.Format(ApiHelper.Instance.GetAllProjectCategoryEndpoint, 1);

            try
            {
                string _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);
                dynamic _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);

                if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities != null && _jsonDeserializedObject.Entities.Count > 0)
                {
                    List<ProjectCategoryReadModel> _apiResponse = new List<ProjectCategoryReadModel>();
                    var _totalPages = Convert.ToInt32(_jsonDeserializedObject.Properties.TotalPage.Value);
                    var _currentPage = Convert.ToInt32(_jsonDeserializedObject.Properties.PageNumber.Value);

                    foreach (var _entity in _jsonDeserializedObject.Entities)
                    {
                        foreach (var _property in _entity.Properties())
                        {
                            _apiResponse.Add(JsonConvert.DeserializeObject<ProjectCategoryReadModel>(_property.Value.ToString()));
                        }
                    }

                    while (_totalPages > _currentPage)
                    {
                        _address = ApiHelper.Instance.SiteUrl + string.Format(ApiHelper.Instance.GetAllProjectCategoryEndpoint, _currentPage + 1);
                        _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);

                        _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);
                        if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities.Count > 0)
                        {
                            _currentPage = Convert.ToInt32(_jsonDeserializedObject.Properties.PageNumber.Value);

                            foreach (var _entity in _jsonDeserializedObject.Entities)
                            {
                                foreach (var _property in _entity.Properties())
                                {
                                    _apiResponse.Add(JsonConvert.DeserializeObject<ProjectCategoryReadModel>(_property.Value.ToString()));
                                }
                            }
                        }
                    }
                    return _apiResponse;
                }
            }
            catch (WebException _webEx)
            {
                MessageBox.Show("Failed to obtain default project category ID list. " + _webEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return null;
        }

        public List<TaskTypeReadModel> GetAllTaskType(string token)
        {
            var _address = ApiHelper.Instance.SiteUrl + string.Format(ApiHelper.Instance.GetAllTaskTypeEndpoint, 1);

            try
            {
                string _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);
                dynamic _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);

                if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities != null && _jsonDeserializedObject.Entities.Count > 0)
                {
                    List<TaskTypeReadModel> _apiResponse = new List<TaskTypeReadModel>();
                    var _totalPages = Convert.ToInt32(_jsonDeserializedObject.Properties.TotalPage.Value);
                    var _currentPage = Convert.ToInt32(_jsonDeserializedObject.Properties.PageNumber.Value);

                    foreach (var _entity in _jsonDeserializedObject.Entities)
                    {
                        foreach (var _property in _entity.Properties())
                        {
                            if (_property.Name == "Properties")
                            {
                                _apiResponse.Add(
                                    JsonConvert.DeserializeObject<TaskTypeReadModel>(_property.Value.ToString()));
                            }
                        }
                    }

                    while (_totalPages > _currentPage)
                    {
                        _address = ApiHelper.Instance.SiteUrl + string.Format(ApiHelper.Instance.GetAllTaskTypeEndpoint, _currentPage + 1);
                        _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);

                        _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);
                        if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities.Count > 0)
                        {
                            _currentPage = Convert.ToInt32(_jsonDeserializedObject.Properties.PageNumber.Value);

                            foreach (var _entity in _jsonDeserializedObject.Entities)
                            {
                                foreach (var _property in _entity.Properties())
                                {
                                    if (_property.Name == "Properties")
                                    {
                                        _apiResponse.Add(
                                            JsonConvert.DeserializeObject<TaskTypeReadModel>(_property.Value.ToString()));
                                    }
                                }
                            }
                        }
                    }
                    return _apiResponse;
                }
            }
            catch (WebException _webEx)
            {
                MessageBox.Show("Failed to obtain default task type ID list. " + _webEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return null;
        }

        public List<ContractHourlyRateReadModel> GetAllContractHourlyRates(string token, int contractID)
        {
            var _address = ApiHelper.Instance.SiteUrl + string.Format(ApiHelper.Instance.GetAllContractHourlyRatesEndpoint + "&contractID=" + contractID, 1);

            try
            {
                string _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);
                dynamic _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);

                if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities != null && _jsonDeserializedObject.Entities.Count > 0)
                {
                    List<ContractHourlyRateReadModel> _apiResponse = new List<ContractHourlyRateReadModel>();
                    var _totalPages = Convert.ToInt32(_jsonDeserializedObject.Properties.TotalPage.Value);
                    var _currentPage = Convert.ToInt32(_jsonDeserializedObject.Properties.PageNumber.Value);

                    foreach (var _entity in _jsonDeserializedObject.Entities)
                    {
                        foreach (var _property in _entity.Properties())
                        {
                            if (_property.Name == "Properties")
                            {
                                _apiResponse.Add(
                                    JsonConvert.DeserializeObject<ContractHourlyRateReadModel>(
                                        _property.Value.ToString()));
                            }
                        }
                    }

                    while (_totalPages > _currentPage)
                    {
                        _address = ApiHelper.Instance.SiteUrl + string.Format(ApiHelper.Instance.GetAllContractHourlyRatesEndpoint + "&contractID=" + contractID, _currentPage + 1);
                        _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);

                        _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);
                        if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities.Count > 0)
                        {
                            _currentPage = Convert.ToInt32(_jsonDeserializedObject.Properties.PageNumber.Value);

                            foreach(var _entity in _jsonDeserializedObject.Entities)
                            {
                                foreach (var _property in _entity.Properties())
                                {
                                    if (_property.Name == "Properties")
                                    {
                                        _apiResponse.Add(
                                            JsonConvert.DeserializeObject<ContractHourlyRateReadModel>(
                                                _property.Value.ToString()));
                                    }
                                }
                            }
                        }
                    }
                    return _apiResponse;
                }
            }
            catch (WebException _webEx)
            {
                MessageBox.Show("Failed to obtain contract hourly rate ID list for contractID: " + contractID + ". " + _webEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return null;
        }

        public List<ProductReadModel> GetAllProduct(string token)
        {
            var _address = ApiHelper.Instance.SiteUrl + string.Format(ApiHelper.Instance.GetAllProductEndpoint, 1);

            try
            {
                string _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);
                dynamic _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);

                if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities != null && _jsonDeserializedObject.Entities.Count > 0)
                {
                    List<ProductReadModel> _apiResponse = new List<ProductReadModel>();
                    var _totalPages = Convert.ToInt32(_jsonDeserializedObject.Properties.TotalPage.Value);
                    var _currentPage = Convert.ToInt32(_jsonDeserializedObject.Properties.PageNumber.Value);

                    foreach (var _entity in _jsonDeserializedObject.Entities)
                    {
                        foreach (var _property in _entity.Properties())
                        {
                            if (_property.Name == "Properties")
                            {
                                _apiResponse.Add(
                                    JsonConvert.DeserializeObject<ProductReadModel>(_property.Value.ToString()));
                            }
                        }
                    }

                    while (_totalPages > _currentPage)
                    {
                        _address = ApiHelper.Instance.SiteUrl + string.Format(ApiHelper.Instance.GetAllProductEndpoint, _currentPage + 1);
                        _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);

                        _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);
                        if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities.Count > 0)
                        {
                            _currentPage = Convert.ToInt32(_jsonDeserializedObject.Properties.PageNumber.Value);

                            foreach (var _entity in _jsonDeserializedObject.Entities)
                            {
                                foreach (var _property in _entity.Properties())
                                {
                                    if (_property.Name == "Properties")
                                    {
                                        _apiResponse.Add(
                                            JsonConvert.DeserializeObject<ProductReadModel>(_property.Value.ToString()));
                                    }
                                }
                            }
                        }
                    }
                    return _apiResponse;
                }
            }
            catch (WebException _webEx)
            {
                MessageBox.Show("Failed to obtain default product ID list. " + _webEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return null;
        }


        public List<TaskReadModel> GetAllTask(string token, int projectID)
        {
            var _address = ApiHelper.Instance.SiteUrl + string.Format(ApiHelper.Instance.GetAllTaskEndpoint + "&projectID=" + projectID,  1);

            try
            {
                string _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);
                dynamic _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);

                if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities.Count > 0)
                {
                    List<TaskReadModel> _apiResponse = new List<TaskReadModel>();
                    var _totalPages = Convert.ToInt32(_jsonDeserializedObject.Properties.TotalPage.Value);
                    var _currentPage = Convert.ToInt32(_jsonDeserializedObject.Properties.PageNumber.Value);

                    foreach (var _entity in _jsonDeserializedObject.Entities)
                    {
                        foreach (var _property in _entity.Properties())
                        {
                            if (_property.Name == "Properties")
                            {
                                _apiResponse.Add(JsonConvert.DeserializeObject<TaskReadModel>(_property.Value.ToString()));
                            }
                        }
                    }

                    while (_totalPages > _currentPage)
                    {
                        _address = ApiHelper.Instance.SiteUrl + string.Format(ApiHelper.Instance.GetAllTaskEndpoint + "&projectID=" + projectID, _currentPage + 1);
                        _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);

                        _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);
                        if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities.Count > 0)
                        {
                            _currentPage = Convert.ToInt32(_jsonDeserializedObject.Properties.PageNumber.Value);

                            foreach (var _entity in _jsonDeserializedObject.Entities)
                            {
                                foreach (var _property in _entity.Properties())
                                {
                                    if (_property.Name == "Properties")
                                    {
                                        _apiResponse.Add(JsonConvert.DeserializeObject<TaskReadModel>(_property.Value.ToString()));
                                    }
                                }
                            }
                        }
                    }
                    return _apiResponse;
                }
            }
            catch (WebException _webEx)
            {
                MessageBox.Show("Failed to obtain project task list. " + _webEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        public int[] CheckAndGetIntegerArray(DataGridView dataGridView, string columnName, DataGridViewRow dataGridViewRow, string selectFileDelimiter, string fieldDelimiter, List<KeyValuePair<int,string>> dataSet)
        {
            if (selectFileDelimiter == fieldDelimiter)
            {
                throw new FormatException("Delimiter for column [" + columnName + "] cannot be the same delimiter as file delimiter. Please recheck input.");
            }

            var _intList = new List<int>();

            if (dataGridView.Columns[columnName] != null)
            {
                try
                {
                    if (dataGridViewRow.Cells[dataGridView.Columns[columnName].Index].Value != DBNull.Value
                        && !string.IsNullOrEmpty(dataGridViewRow.Cells[dataGridView.Columns[columnName].Index].Value.ToString()))
                    {
                        foreach (var _value in dataGridViewRow.Cells[dataGridView.Columns[columnName].Index].Value.ToString().Split(fieldDelimiter))
                        {
                            if (dataSet.Exists(x=>x.Value.ToLower().Trim().Equals(_value.ToLower().Trim())))
                            {
                                _intList.Add(dataSet.First(x=>x.Value.ToLower().Trim().Equals(_value.ToLower().Trim())).Key);
                            }
                            else
                            {
                                throw new ArgumentException();
                            }
                        }
                    }
                }
                catch (ArgumentException)
                {
                    throw new FormatException("[" + columnName + "] has wrong delimiter or invalid data. Please recheck.");
                }
                catch (Exception)
                {
                    throw new FormatException("String format cannot be converted to integer array for column [" + columnName + "]. Please recheck input.");
                }
            }

            return _intList.ToArray();
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

        public DateTime? CheckAndGetNullableDate(DataGridView dataGridView, string columnName, DataGridViewRow dataGridViewRow)
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

            return null;
        }

        #endregion

        #region Helper - Initialization methods

        public void InitializeDelimiterComboBox(ComboBox delimiterComboBox)
        {
            delimiterComboBox.Items.AddRange(GetDelimiterList().Cast<object>().ToArray());
            delimiterComboBox.SelectedIndex = 0;
        }

        public void InitializeDelimiterComboBox(ComboBox delimiterComboBox, int selectedIndex)
        {
            delimiterComboBox.Items.AddRange(GetDelimiterList().Cast<object>().ToArray());
            delimiterComboBox.SelectedIndex = selectedIndex;
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

        #endregion

        #region Helper - Mapping methods

        public void AutoMapFileColumns(DataTable fileContent, ComboBox comboBox, string columnName)
        {

            int _columnIndex = fileContent.Columns.IndexOf(columnName);
            comboBox.SelectedIndex = _columnIndex;


        }

        public void MapMandatorySelectedColumnToTable(DataTable fileContent, DataGridView dataGridView, DataTable domainTable, ComboBox comboBox, string columnName)
        {
            var _columnIndex = fileContent.Columns.IndexOf(comboBox.SelectedItem.ToString());
            
            var _tableColumnIndex = domainTable.Columns.IndexOf(columnName);

            if (_tableColumnIndex >= 0 && _columnIndex >= 0)
            {
                ClearColumn(dataGridView, _tableColumnIndex);

                MapFileContentToTable(fileContent, dataGridView, domainTable, _tableColumnIndex, _columnIndex);

                CheckCellsForNullOrEmpty(dataGridView, _tableColumnIndex);
            }
        }

        //for fields with default value checkbox
        public void MapMandatorySelectedColumnToTable(DataTable fileContent, DataGridView dataGridView, DataTable domainTable, ComboBox comboBox, string columnName, CheckBox checkBox)
        {
            var _tableColumnIndex = domainTable.Columns.IndexOf(columnName);

            if (_tableColumnIndex >= 0)
            {
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
        }

        //for fields with non key value pair default value checkbox
        public void MapMandatoryNonKeyValuePairSelectedColumnToTable(DataTable fileContent, DataGridView dataGridView, DataTable domainTable, ComboBox comboBox, string columnName, CheckBox checkBox)
        {
            var _tableColumnIndex = domainTable.Columns.IndexOf(columnName);

            if (_tableColumnIndex >= 0)
            {
                ClearColumn(dataGridView, _tableColumnIndex);

                if (!checkBox.Checked)
                {
                    var _columnIndex = fileContent.Columns.IndexOf(comboBox.SelectedItem.ToString());

                    MapFileContentToTable(fileContent, dataGridView, domainTable, _tableColumnIndex, _columnIndex);
                }
                else
                {
                    var _defaultValue = comboBox.SelectedItem.ToString();

                    MapDefaultValueToTable(dataGridView, domainTable, _tableColumnIndex, _defaultValue);
                }

                CheckCellsForNullOrEmpty(dataGridView, _tableColumnIndex);
            }
        }

        public void MapNonMandatorySelectedColumnToTable(DataTable fileContent, DataGridView dataGridView, DataTable domainTable, ComboBox comboBox, string columnName)
        {
            var _columnIndex = fileContent.Columns.IndexOf(comboBox.SelectedItem.ToString());
            if (_columnIndex >= 0)
            {
                CheckAndAddColumn(domainTable, columnName);
                
                var _tableColumnIndex = domainTable.Columns.IndexOf(columnName);
                if (_tableColumnIndex >= 0)
                {
                    ClearColumn(dataGridView, _tableColumnIndex);

                    MapFileContentToTable(fileContent, dataGridView, domainTable, _tableColumnIndex, _columnIndex);

                    CheckCellsForNullOrEmpty(dataGridView, _tableColumnIndex);
                }
            }
        }

        //for fields with default value checkbox
        public void MapNonMandatorySelectedColumnToTable(DataTable fileContent, DataGridView dataGridView, DataTable domainTable, ComboBox comboBox, string columnName, CheckBox checkBox)
        {
            CheckAndAddColumn(domainTable, columnName);

            var _tableColumnIndex = domainTable.Columns.IndexOf(columnName);

            if (_tableColumnIndex >= 0)
            {
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
        }

        //for fields with non key value pair default value checkbox
        public void MapNonMandatoryNonKeyValuePairSelectedColumnToTable(DataTable fileContent, DataGridView dataGridView, DataTable domainTable, ComboBox comboBox, string columnName, CheckBox checkBox)
        {
            CheckAndAddColumn(domainTable, columnName);

            var _tableColumnIndex = domainTable.Columns.IndexOf(columnName);

            if (_tableColumnIndex >= 0)
            {
                ClearColumn(dataGridView, _tableColumnIndex);

                if (!checkBox.Checked)
                {
                    var _columnIndex = fileContent.Columns.IndexOf(comboBox.SelectedItem.ToString());

                    MapFileContentToTable(fileContent, dataGridView, domainTable, _tableColumnIndex, _columnIndex);
                }
                else
                {
                    var _defaultValue = comboBox.SelectedItem.ToString();

                    MapDefaultValueToTable(dataGridView, domainTable, _tableColumnIndex, _defaultValue);
                }

                CheckCellsForNullOrEmpty(dataGridView, _tableColumnIndex);
            }
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

        public void MapValuesToComboBoxByCheckboxStatus(DataGridView dataGridView, DataTable domainTable, ComboBox comboBox, string columnName, 
            CheckBox checkBox, List<KeyValuePair<string, string>> keyValuePairList, object[] fileColumnHeaderArray)
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

        private void MapFileContentToTable(DataTable fileContent, DataGridView dataGridView, DataTable domainTable, int tableColumnIndex, int fileColumnIndex)
        {
            if (domainTable.Rows.Count >= fileContent.Rows.Count)
            {
                for (int i = 0; i < fileContent.Rows.Count; i++)
                {
                    domainTable.Rows[i][tableColumnIndex] = fileContent.Rows[i][fileColumnIndex];
                }

                dataGridView.Rows[0].Cells[tableColumnIndex].Selected = true;
                dataGridView.FirstDisplayedScrollingColumnIndex = tableColumnIndex;
                dataGridView.Focus();
            }
        }

        private void MapDefaultValueToTable(DataGridView dataGridView, DataTable domainTable, int tableColumnIndex, string defaultValue)
        {
            for (int i = 0; i < domainTable.Rows.Count; i++)
            {
                domainTable.Rows[i][tableColumnIndex] = defaultValue;
            }

            dataGridView.Rows[0].Cells[tableColumnIndex].Selected = true;
            dataGridView.FirstDisplayedScrollingColumnIndex = tableColumnIndex;
            dataGridView.Focus();
        }

        #endregion

        #region Helper - Checking and adding methods

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

        private void AddKeyValuePairListToDomainComboBox(ComboBox comboBox, List<KeyValuePair<string, string>> keyValuePairList)
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
            }
        }

        #endregion

        #region Helper - Error handling and UI display methods

        public int HandleInvalidFieldValueToIDMapping(string columnName, DataGridViewRow row, string fieldValue, TextBox domainTextBox, BackgroundWorker workerFetcher, Control control, bool isFirstTimeInvalidMapping, int errorRowCount)
        {
            control.Invoke((MethodInvoker)(() => row.DefaultCellStyle.BackColor = Color.Red));

            if (isFirstTimeInvalidMapping)
            {
                control.Invoke((MethodInvoker)(() => domainTextBox.AppendText(Environment.NewLine)));

                if (string.IsNullOrEmpty(fieldValue))
                {
                    control.Invoke((MethodInvoker) (() => domainTextBox.AppendText("Row " + (row.Index + 1) +
                        " - " + columnName + " is empty.")));
                }
                else
                {
                    control.Invoke((MethodInvoker) (() => domainTextBox.AppendText("Row " + (row.Index + 1) +
                        " - " + columnName + " '" + fieldValue + "' doesn't exist in TimeLog.")));
                }

                errorRowCount++;
            }
            else
            {
                if (string.IsNullOrEmpty(fieldValue))
                {
                    control.Invoke((MethodInvoker)(() => domainTextBox.AppendText(" | " + columnName + " is empty.")));
                }
                else
                {
                    control.Invoke((MethodInvoker)(() => domainTextBox.AppendText(" | " + columnName + " '" + fieldValue + "' doesn't exist in TimeLog.")));
                }
            }

            //workerFetcher.CancelAsync();
            return errorRowCount;
        }

        public void DisplayErrorRowCountAndSuccessMessage(int errorRowCount, Button importButton, Button validateButton, Button senderButton, TextBox domainTextBox, Control control)
        {
            //show error row count at the end
            control.Invoke((MethodInvoker)(() => domainTextBox.AppendText(Environment.NewLine + Environment.NewLine)));
            control.Invoke((MethodInvoker)(() => domainTextBox.AppendText("Invalid data input row count: " + errorRowCount)));
            control.Invoke((MethodInvoker)(() => domainTextBox.AppendText(Environment.NewLine + Environment.NewLine)));

            //display success message after import / validation is done
            if (errorRowCount == 0)
            {
                if (senderButton.Name == validateButton.Name)
                {
                    control.Invoke((MethodInvoker)(() => domainTextBox.AppendText("Validation completed successfully with no error. You may press the Import button to start importing data right away.")));
                    control.Invoke((MethodInvoker)(() => importButton.Enabled = true));
                }
                else
                {
                    control.Invoke((MethodInvoker)(() => domainTextBox.AppendText("Data import completed successfully with no error. Excellent!")));
                    control.Invoke((MethodInvoker)(() => importButton.Enabled = false));
                }
            }
            else
            {
                control.Invoke((MethodInvoker)(() => domainTextBox.AppendText("Validation completed successfully with " + errorRowCount + " error(s). You may modify the invalid input data and then press Validate button again.")));
                control.Invoke((MethodInvoker)(() => importButton.Enabled = false));
            }

            control.Invoke((MethodInvoker)(() => domainTextBox.AppendText(Environment.NewLine)));
            control.Invoke((MethodInvoker)(() => domainTextBox.AppendText("End time: " + DateTime.Now)));


        }

        public void HighlightDataTableRowByTextBoxClick(MouseEventArgs e, DataGridView dataGridView, TextBox domainTextBox)
        {
            if (e.Button == MouseButtons.Left)
            {
                var _position = domainTextBox.GetCharIndexFromPosition(e.Location);
                var _lineNo = domainTextBox.GetLineFromCharIndex(_position) - 1;

                for (var i = 0; i < dataGridView.Rows.Count - 1; i++)
                {
                    if (i == _lineNo)
                    {
                        dataGridView.Rows[i].Selected = true;
                        dataGridView.FirstDisplayedScrollingRowIndex = i;
                        dataGridView.Focus();
                        break;
                    }
                }
            }
        }

        public void ExpandCollapseFieldByButtonClick(object sender, ExpandState[] expandStates, Button[] expandButtons, Timer tmrExpand)
        {
            Button _button = sender as Button;
            int _index = (int)_button.Tag;

            // Get this panel's current expand state and set its new state
            ExpandState _oldState = expandStates[_index];

            if (_oldState == ExpandState.Collapsed || _oldState == ExpandState.Collapsing)
            {
                expandStates[_index] = ExpandState.Expanding;
                expandButtons[_index].BackgroundImage = Properties.Resources.upload;
            }
            else
            {
                expandStates[_index] = ExpandState.Collapsing;
                expandButtons[_index].BackgroundImage = Properties.Resources.download;
            }

            tmrExpand.Enabled = true;
        }

        public void ProcessExpandCollapseFieldForPanel(Panel[] expandPanels, ExpandState[] expandStates, int expansionPerTick, Timer tmrExpand)
        {
            bool _notDone = false;

            for (int i = 0; i < expandPanels.Length; i++)
            {
                Panel _panel = expandPanels[i];
                int _newHeight = _panel.Height;

                if (expandStates[i] == ExpandState.Expanding)
                {
                    _newHeight = _panel.Height + expansionPerTick;

                    if (_newHeight <= _panel.MaximumSize.Height)
                    {
                        _newHeight = _panel.MaximumSize.Height;
                    }
                    else
                    {
                        _notDone = true;
                    }
                }
                else if (expandStates[i] == ExpandState.Collapsing)
                {
                    _newHeight = _panel.Height - expansionPerTick;

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

        #endregion
    }
}