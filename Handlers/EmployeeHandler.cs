using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;
using TimeLog.DataImporter.TimeLogApi;
using TimeLog.DataImporter.TimeLogApi.Model;

namespace TimeLog.DataImporter.Handlers
{
    public class EmployeeHandler : BaseHandler
    {
        private static EmployeeHandler _instance;

        private EmployeeHandler()
        {
        }

        public static EmployeeHandler Instance
        {
            get { return _instance ??= new EmployeeHandler(); }
        }

        public DefaultApiResponse ValidateEmployee(EmployeeCreateModel employee, string token, out BusinessRulesApiResponse businessRulesApiResponse)
        {
            var _data = JsonConvert.SerializeObject(employee, Newtonsoft.Json.Formatting.None, 
                new JsonSerializerSettings {NullValueHandling = NullValueHandling.Ignore});
            var _address = ApiHelper.Instance.LocalhostUrl + ApiHelper.Instance.EmployeeValidateEndpoint;
            businessRulesApiResponse = null;

            try
            {
                var _jsonResult = ApiHelper.Instance.WebClient(token).UploadString(_address, "POST", _data);

                if (_jsonResult == "null")
                {
                    return new DefaultApiResponse(200, "OK", new string[] { });
                }

                return new DefaultApiResponse(500, "Internal Application Error: Fail to Validate Employee", new string[] { });
            }
            catch (WebException _webEx)
            {
                using StreamReader _r = new StreamReader(_webEx.Response.GetResponseStream());
                string _responseContent = _r.ReadToEnd();

                return ApiHelper.Instance.ProcessApiResponseContent(_webEx, _responseContent, out businessRulesApiResponse);
            }
        }

        public DefaultApiResponse ImportEmployee(EmployeeCreateModel employee, string token, out BusinessRulesApiResponse businessRulesApiResponse)
        {
            var _data = JsonConvert.SerializeObject(employee, Newtonsoft.Json.Formatting.None,
                new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            var _address = ApiHelper.Instance.LocalhostUrl + ApiHelper.Instance.EmployeeCreateEndpoint;
            businessRulesApiResponse = null;

            try
            {
                var _jsonResult = ApiHelper.Instance.WebClient(token).UploadString(_address, "POST", _data);

                if (_jsonResult != "null")
                {
                    return new DefaultApiResponse(200, "OK", new string[] { });
                }

                return new DefaultApiResponse(500, "Internal Application Error: Fail to Import Employee", new string[] { });
            }
            catch (WebException _webEx)
            {
                using StreamReader _r = new StreamReader(_webEx.Response.GetResponseStream());
                string _responseContent = _r.ReadToEnd();

                return ApiHelper.Instance.ProcessApiResponseContent(_webEx, _responseContent, out businessRulesApiResponse);
            }
        }

        public List<DepartmentReadModel> GetAllDepartment(string token)
        {
            var _address = ApiHelper.Instance.LocalhostUrl + ApiHelper.Instance.GetAllDepartmentEndpoint;

            try
            {
                string _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);
                dynamic _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);

                if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities.Count > 0)
                {
                    List<DepartmentReadModel> _apiResponse = new List<DepartmentReadModel>();

                    foreach (var _entity in _jsonDeserializedObject.Entities)
                    {
                        foreach (var _property in _entity.Properties())
                        {
                            _apiResponse.Add(JsonConvert.DeserializeObject<DepartmentReadModel>(_property.Value.ToString()));
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

        public List<EmployeeTypeReadModel> GetAllEmployeeTypes(string token)
        {
            var _address = ApiHelper.Instance.LocalhostUrl + ApiHelper.Instance.GetAllEmployeeTypeEndpoint;

            try
            {
                string _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);
                dynamic _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);

                if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities.Count > 0)
                {
                    List<EmployeeTypeReadModel> _apiResponse = new List<EmployeeTypeReadModel>();

                    foreach (var _entity in _jsonDeserializedObject.Entities)
                    {
                        foreach (var _property in _entity.Properties())
                        {
                            _apiResponse.Add(JsonConvert.DeserializeObject<EmployeeTypeReadModel>(_property.Value.ToString()));
                        }
                    }

                    return _apiResponse;
                }
            }
            catch (WebException _webEx)
            {
                MessageBox.Show("Failed to obtain default EmployyType ID list. " + _webEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return null;
        }


        public List<HourlyRateReadModel> GetAllDefaultHourlyRate(string token)
        {
            var _address = ApiHelper.Instance.LocalhostUrl + ApiHelper.Instance.GetDefaultHourlyRatesEndpoint;

            try
            {
                string _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);
                dynamic _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);

                if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities.Count > 0)
                {
                    List<HourlyRateReadModel> _apiResponse = new List<HourlyRateReadModel>();

                    foreach (var _entity in _jsonDeserializedObject.Entities)
                    {
                        foreach (var _property in _entity.Properties())
                        {
                            _apiResponse.Add(JsonConvert.DeserializeObject<HourlyRateReadModel>(_property.Value.ToString()));
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

        public List<CostPriceReadModel> GetAllCostPrices(string token)
        {
            var _address = ApiHelper.Instance.LocalhostUrl + ApiHelper.Instance.GetAllCostPriceEndpoint;

            try
            {
                string _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);
                dynamic _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);

                if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities.Count > 0)
                {
                    List<CostPriceReadModel> _apiResponse = new List<CostPriceReadModel>();

                    foreach (var _entity in _jsonDeserializedObject.Entities)
                    {
                        foreach (var _property in _entity.Properties())
                        {
                            _apiResponse.Add(JsonConvert.DeserializeObject<CostPriceReadModel>(_property.Value.ToString()));
                        }
                    }

                    return _apiResponse;
                }
            }
            catch (WebException _webEx)
            {
                MessageBox.Show("Failed to obtain cost price ID list. " + _webEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return null;
        }

        public List<HolidayCalendarReadModel> GetAllHolidayCalendars(string token)
        {
            var _address = ApiHelper.Instance.LocalhostUrl + ApiHelper.Instance.GetAllHolidayCalendarEndpoint;

            try
            {
                string _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);
                dynamic _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);

                if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities.Count > 0)
                {
                    List<HolidayCalendarReadModel> _apiResponse = new List<HolidayCalendarReadModel>();

                    foreach (var _entity in _jsonDeserializedObject.Entities)
                    {
                        foreach (var _property in _entity.Properties())
                        {
                            _apiResponse.Add(JsonConvert.DeserializeObject<HolidayCalendarReadModel>(_property.Value.ToString()));
                        }
                    }

                    return _apiResponse;
                }
            }
            catch (WebException _webEx)
            {
                MessageBox.Show("Failed to obtain holiday calendar ID list. " + _webEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return null;
        }

        public List<AllowanceLegislationReadModel> GetAllAllowanceLegislations(string token)
        {
            var _address = ApiHelper.Instance.LocalhostUrl + ApiHelper.Instance.GetAllAllowanceLegislationEndpoint;

            try
            {
                string _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);
                dynamic _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);

                if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities.Count > 0)
                {
                    List<AllowanceLegislationReadModel> _apiResponse = new List<AllowanceLegislationReadModel>();

                    foreach (var _entity in _jsonDeserializedObject.Entities)
                    {
                        foreach (var _property in _entity.Properties())
                        {
                            _apiResponse.Add(JsonConvert.DeserializeObject<AllowanceLegislationReadModel>(_property.Value.ToString()));
                        }
                    }

                    return _apiResponse;
                }
            }
            catch (WebException _webEx)
            {
                MessageBox.Show("Failed to obtain allowance legislation ID list. " + _webEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return null;
        }

        public List<NormalWorkingTimeReadModel> GetAllNormalWorkingTimes(string token)
        {
            var _address = ApiHelper.Instance.LocalhostUrl + ApiHelper.Instance.GetAllNormalWorkingTimeEndpoint;

            try
            {
                string _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);
                dynamic _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);

                if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities.Count > 0)
                {
                    List<NormalWorkingTimeReadModel> _apiResponse = new List<NormalWorkingTimeReadModel>();

                    foreach (var _entity in _jsonDeserializedObject.Entities)
                    {
                        foreach (var _property in _entity.Properties())
                        {
                            _apiResponse.Add(JsonConvert.DeserializeObject<NormalWorkingTimeReadModel>(_property.Value.ToString()));
                        }
                    }

                    return _apiResponse;
                }
            }
            catch (WebException _webEx)
            {
                MessageBox.Show("Failed to obtain normal working time ID list. " + _webEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return null;
        }

        public List<SalaryGroupReadModel> GetAllSalaryGroups(string token)
        {
            var _address = ApiHelper.Instance.LocalhostUrl + ApiHelper.Instance.GetAllSalaryGroupEndpoint;

            try
            {
                string _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);
                dynamic _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);

                if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities.Count > 0)
                {
                    List<SalaryGroupReadModel> _apiResponse = new List<SalaryGroupReadModel>();

                    foreach (var _entity in _jsonDeserializedObject.Entities)
                    {
                        foreach (var _property in _entity.Properties())
                        {
                            _apiResponse.Add(JsonConvert.DeserializeObject<SalaryGroupReadModel>(_property.Value.ToString()));
                        }
                    }

                    return _apiResponse;
                }
            }
            catch (WebException _webEx)
            {
                MessageBox.Show("Failed to obtain salary group time ID list. " + _webEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return null;
        }
    }
}