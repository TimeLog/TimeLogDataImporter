using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;
using TimeLog.DataImporter.TimeLogApi;
using TimeLog.DataImporter.TimeLogApi.Model;

namespace TimeLog.DataImporter.Handlers
{
    public class ProjectExpenseHandler : BaseHandler
    {
        private static ProjectExpenseHandler _instance;

        private ProjectExpenseHandler()
        {
        }

        public static ProjectExpenseHandler Instance
        {
            get { return _instance ??= new ProjectExpenseHandler(); }
        }

        public DefaultApiResponse ValidateProjectExpense(ProjectExpenseCreateModel projectExpense, string token, out BusinessRulesApiResponse businessRulesApiResponse)
        {
            var _data = JsonConvert.SerializeObject(projectExpense, Newtonsoft.Json.Formatting.None, 
                new JsonSerializerSettings {NullValueHandling = NullValueHandling.Ignore});
            //lack of validate endpoint
            var _address = ApiHelper.Instance.LocalhostUrl + ApiHelper.Instance.ProjectExpenseCreateEndpoint;
            businessRulesApiResponse = null;

            try
            {
                var _jsonResult = ApiHelper.Instance.WebClient(token).UploadString(_address, "POST", _data);

                if (_jsonResult == "null")
                {
                    return new DefaultApiResponse(200, "OK", new string[] { });
                }

                return new DefaultApiResponse(500, "Internal Application Error: Fail to Validate Project Expense", new string[] { });
            }
            catch (WebException _webEx)
            {
                using StreamReader _r = new StreamReader(_webEx.Response.GetResponseStream());
                string _responseContent = _r.ReadToEnd();

                return ApiHelper.Instance.ProcessApiResponseContent(_webEx, _responseContent, out businessRulesApiResponse);
            }
        }

        public DefaultApiResponse ImportProjectExpense(ProjectExpenseCreateModel projectExpense, string token, out BusinessRulesApiResponse businessRulesApiResponse)
        {
            var _data = JsonConvert.SerializeObject(projectExpense, Newtonsoft.Json.Formatting.None,
                new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            var _address = ApiHelper.Instance.LocalhostUrl + ApiHelper.Instance.ProjectExpenseCreateEndpoint;
            businessRulesApiResponse = null;

            try
            {
                var _jsonResult = ApiHelper.Instance.WebClient(token).UploadString(_address, "POST", _data);

                if (_jsonResult != "null")
                {
                    return new DefaultApiResponse(200, "OK", new string[] { });
                }

                return new DefaultApiResponse(500, "Internal Application Error: Fail to Import Project Expense", new string[] { });
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
    }
}