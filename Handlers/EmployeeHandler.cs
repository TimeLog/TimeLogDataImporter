using System;
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
            var _address = ApiHelper.Instance.SiteUrl + ApiHelper.Instance.EmployeeValidateEndpoint;
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
            var _address = ApiHelper.Instance.SiteUrl + ApiHelper.Instance.EmployeeCreateEndpoint;
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

        

        


       

        public List<CostPriceReadModel> GetAllCostPrices(string token)
        {
            var _address = ApiHelper.Instance.SiteUrl + string.Format(ApiHelper.Instance.GetAllCostPriceEndpoint, 1);


            try
            {
                string _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);
                dynamic _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);

                if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities != null && _jsonDeserializedObject.Entities.Count > 0)
                {
                    List<CostPriceReadModel> _apiResponse = new List<CostPriceReadModel>();
                    var _totalPages = Convert.ToInt32(_jsonDeserializedObject.Properties.TotalPage.Value);
                    var _currentPage = Convert.ToInt32(_jsonDeserializedObject.Properties.PageNumber.Value);

                    foreach (var _entity in _jsonDeserializedObject.Entities)
                    {
                        foreach (var _property in _entity.Properties())
                        {
                            _apiResponse.Add(JsonConvert.DeserializeObject<CostPriceReadModel>(_property.Value.ToString()));
                        }
                    }

                    while (_totalPages > _currentPage)
                    {
                        _address = ApiHelper.Instance.SiteUrl + string.Format(ApiHelper.Instance.GetAllCostPriceEndpoint, _currentPage + 1);
                        _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);

                        _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);
                        if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities.Count > 0)
                        {
                            _currentPage = Convert.ToInt32(_jsonDeserializedObject.Properties.PageNumber.Value);

                            foreach (var _entity in _jsonDeserializedObject.Entities)
                            {
                                foreach (var _property in _entity.Properties())
                                {
                                    _apiResponse.Add(JsonConvert.DeserializeObject<CostPriceReadModel>(_property.Value.ToString()));
                                }
                            }
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
            var _address = ApiHelper.Instance.SiteUrl + string.Format(ApiHelper.Instance.GetAllHolidayCalendarEndpoint, 1);


            try
            {
                string _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);
                dynamic _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);

                if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities != null && _jsonDeserializedObject.Entities.Count > 0)
                {
                    List<HolidayCalendarReadModel> _apiResponse = new List<HolidayCalendarReadModel>();
                    var _totalPages = Convert.ToInt32(_jsonDeserializedObject.Properties.TotalPage.Value);
                    var _currentPage = Convert.ToInt32(_jsonDeserializedObject.Properties.PageNumber.Value);

                    foreach (var _entity in _jsonDeserializedObject.Entities)
                    {
                        foreach (var _property in _entity.Properties())
                        {
                            _apiResponse.Add(JsonConvert.DeserializeObject<HolidayCalendarReadModel>(_property.Value.ToString()));
                        }
                    }

                    while (_totalPages > _currentPage)
                    {
                        _address = ApiHelper.Instance.SiteUrl + string.Format(ApiHelper.Instance.GetAllHolidayCalendarEndpoint, _currentPage + 1);
                        _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);

                        _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);
                        if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities.Count > 0)
                        {
                            _currentPage = Convert.ToInt32(_jsonDeserializedObject.Properties.PageNumber.Value);

                            foreach (var _entity in _jsonDeserializedObject.Entities)
                            {
                                foreach (var _property in _entity.Properties())
                                {
                                    _apiResponse.Add(JsonConvert.DeserializeObject<HolidayCalendarReadModel>(_property.Value.ToString()));
                                }
                            }
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
            var _address = ApiHelper.Instance.SiteUrl + string.Format(ApiHelper.Instance.GetAllAllowanceLegislationEndpoint, 1);


            try
            {
                string _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);
                dynamic _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);

                if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities != null && _jsonDeserializedObject.Entities.Count > 0)
                {
                    List<AllowanceLegislationReadModel> _apiResponse = new List<AllowanceLegislationReadModel>();
                    var _totalPages = Convert.ToInt32(_jsonDeserializedObject.Properties.TotalPage.Value);
                    var _currentPage = Convert.ToInt32(_jsonDeserializedObject.Properties.PageNumber.Value);

                    foreach (var _entity in _jsonDeserializedObject.Entities)
                    {
                        foreach (var _property in _entity.Properties())
                        {
                            _apiResponse.Add(JsonConvert.DeserializeObject<AllowanceLegislationReadModel>(_property.Value.ToString()));
                        }
                    }

                    while (_totalPages > _currentPage)
                    {
                        _address = ApiHelper.Instance.SiteUrl + string.Format(ApiHelper.Instance.GetAllAllowanceLegislationEndpoint, _currentPage + 1);
                        _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);

                        _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);
                        if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities.Count > 0)
                        {
                            _currentPage = Convert.ToInt32(_jsonDeserializedObject.Properties.PageNumber.Value);

                            foreach (var _entity in _jsonDeserializedObject.Entities)
                            {
                                foreach (var _property in _entity.Properties())
                                {
                                    _apiResponse.Add(JsonConvert.DeserializeObject<AllowanceLegislationReadModel>(_property.Value.ToString()));
                                }
                            }
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
            var _address = ApiHelper.Instance.SiteUrl + string.Format(ApiHelper.Instance.GetAllNormalWorkingTimeEndpoint, 1);


            try
            {
                string _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);
                dynamic _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);

                if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities != null && _jsonDeserializedObject.Entities.Count > 0)
                {
                    List<NormalWorkingTimeReadModel> _apiResponse = new List<NormalWorkingTimeReadModel>();
                    var _totalPages = Convert.ToInt32(_jsonDeserializedObject.Properties.TotalPage.Value);
                    var _currentPage = Convert.ToInt32(_jsonDeserializedObject.Properties.PageNumber.Value);

                    foreach (var _entity in _jsonDeserializedObject.Entities)
                    {
                        foreach (var _property in _entity.Properties())
                        {
                            _apiResponse.Add(JsonConvert.DeserializeObject<NormalWorkingTimeReadModel>(_property.Value.ToString()));
                        }
                    }

                    while (_totalPages > _currentPage)
                    {
                        _address = ApiHelper.Instance.SiteUrl + string.Format(ApiHelper.Instance.GetAllNormalWorkingTimeEndpoint, _currentPage + 1);
                        _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);

                        _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);
                        if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities.Count > 0)
                        {
                            _currentPage = Convert.ToInt32(_jsonDeserializedObject.Properties.PageNumber.Value);

                            foreach (var _entity in _jsonDeserializedObject.Entities)
                            {
                                foreach (var _property in _entity.Properties())
                                {
                                    _apiResponse.Add(JsonConvert.DeserializeObject<NormalWorkingTimeReadModel>(_property.Value.ToString()));
                                }
                            }
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
            var _address = ApiHelper.Instance.SiteUrl + string.Format(ApiHelper.Instance.GetAllSalaryGroupEndpoint, 1);


            try
            {
                string _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);
                dynamic _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);

                if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities != null && _jsonDeserializedObject.Entities.Count > 0)
                {
                    List<SalaryGroupReadModel> _apiResponse = new List<SalaryGroupReadModel>();
                    var _totalPages = Convert.ToInt32(_jsonDeserializedObject.Properties.TotalPage.Value);
                    var _currentPage = Convert.ToInt32(_jsonDeserializedObject.Properties.PageNumber.Value);

                    foreach (var _entity in _jsonDeserializedObject.Entities)
                    {
                        foreach (var _property in _entity.Properties())
                        {
                            _apiResponse.Add(JsonConvert.DeserializeObject<SalaryGroupReadModel>(_property.Value.ToString()));
                        }
                    }

                    while (_totalPages > _currentPage)
                    {
                        _address = ApiHelper.Instance.SiteUrl + string.Format(ApiHelper.Instance.GetAllSalaryGroupEndpoint, _currentPage + 1);
                        _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);

                        _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);
                        if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities.Count > 0)
                        {
                            _currentPage = Convert.ToInt32(_jsonDeserializedObject.Properties.PageNumber.Value);

                            foreach (var _entity in _jsonDeserializedObject.Entities)
                            {
                                foreach (var _property in _entity.Properties())
                                {
                                    _apiResponse.Add(JsonConvert.DeserializeObject<SalaryGroupReadModel>(_property.Value.ToString()));
                                }
                            }
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

        public List<UserRoleReadModel> GetAllUserRoles(string token)
        {
            var _address = ApiHelper.Instance.SiteUrl + string.Format(ApiHelper.Instance.GetAllUserRolesEndpoint, 1);


            try
            {
                string _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);
                dynamic _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);

                if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities != null && _jsonDeserializedObject.Entities.Count > 0)
                {
                    List<UserRoleReadModel> _apiResponse = new List<UserRoleReadModel>();
                    var _totalPages = Convert.ToInt32(_jsonDeserializedObject.Properties.TotalPage.Value);
                    var _currentPage = Convert.ToInt32(_jsonDeserializedObject.Properties.PageNumber.Value);

                    foreach (var _entity in _jsonDeserializedObject.Entities)
                    {
                        foreach (var _property in _entity.Properties())
                        {
                            _apiResponse.Add(JsonConvert.DeserializeObject<UserRoleReadModel>(_property.Value.ToString()));
                        }
                    }

                    while (_totalPages > _currentPage)
                    {
                        _address = ApiHelper.Instance.SiteUrl + string.Format(ApiHelper.Instance.GetAllUserRolesEndpoint, _currentPage + 1);
                        _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);

                        _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);
                        if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities.Count > 0)
                        {
                            _currentPage = Convert.ToInt32(_jsonDeserializedObject.Properties.PageNumber.Value);

                            foreach (var _entity in _jsonDeserializedObject.Entities)
                            {
                                foreach (var _property in _entity.Properties())
                                {
                                    _apiResponse.Add(JsonConvert.DeserializeObject<UserRoleReadModel>(_property.Value.ToString()));
                                }
                            }
                        }
                    }
                    return _apiResponse;
                }
            }
            catch (WebException _webEx)
            {
                MessageBox.Show("Failed to obtain user role ID list. " + _webEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return null;
        }
    }
}