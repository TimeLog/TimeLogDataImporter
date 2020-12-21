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

        public List<ProjectReadModel> GetAllProject(string token)
        {
            var _address = ApiHelper.Instance.LocalhostUrl + ApiHelper.Instance.GetAllProjectEndpoint;

            try
            {
                string _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);
                dynamic _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);

                if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities.Count > 0)
                {
                    List<ProjectReadModel> _apiResponse = new List<ProjectReadModel>();

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

                    return _apiResponse;
                }
            }
            catch (WebException _webEx)
            {
                MessageBox.Show("Failed to obtain default project ID list. " + _webEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return null;
        }

        public List<PaymentMethodReadModel> GetAllPaymentMethod(string token)
        {
            var _address = ApiHelper.Instance.LocalhostUrl + ApiHelper.Instance.GetAllPaymentMethodEndpoint;

            try
            {
                string _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);
                dynamic _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);

                if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities.Count > 0)
                {
                    List<PaymentMethodReadModel> _apiResponse = new List<PaymentMethodReadModel>();

                    foreach (var _entity in _jsonDeserializedObject.Entities)
                    {
                        foreach (var _property in _entity.Properties())
                        {
                            _apiResponse.Add(JsonConvert.DeserializeObject<PaymentMethodReadModel>(_property.Value.ToString()));
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
            var _address = ApiHelper.Instance.LocalhostUrl + ApiHelper.Instance.GetAllExpenseTypeEndpoint;

            try
            {
                string _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);
                dynamic _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);

                if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities.Count > 0)
                {
                    List<ExpenseTypeReadModel> _apiResponse = new List<ExpenseTypeReadModel>();

                    foreach (var _entity in _jsonDeserializedObject.Entities)
                    {
                        foreach (var _property in _entity.Properties())
                        {
                            _apiResponse.Add(JsonConvert.DeserializeObject<ExpenseTypeReadModel>(_property.Value.ToString()));
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

        public List<ProjectSubContractReadModel> GetAllContract(string token, int projectID)
        {
            var _address = ApiHelper.Instance.LocalhostUrl + ApiHelper.Instance.GetAllContractEndpoint + "&projectID=" + projectID ;

            try
            {
                string _jsonResult = ApiHelper.Instance.WebClient(token).DownloadString(_address);
                dynamic _jsonDeserializedObject = JsonConvert.DeserializeObject<dynamic>(_jsonResult);

                if (_jsonDeserializedObject != null && _jsonDeserializedObject.Entities.Count > 0)
                {
                    List<ProjectSubContractReadModel> _apiResponse = new List<ProjectSubContractReadModel>();

                    foreach (var _entity in _jsonDeserializedObject.Entities)
                    {
                        foreach (var _property in _entity.Properties())
                        {
                            _apiResponse.Add(JsonConvert.DeserializeObject<ProjectSubContractReadModel>(_property.Value.ToString()));
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
    }
}