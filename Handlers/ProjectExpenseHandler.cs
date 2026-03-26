using System.Collections.Generic;
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
            var _data = JsonConvert.SerializeObject(projectExpense, Newtonsoft.Json.Formatting.None, new JsonSerializerSettings {NullValueHandling = NullValueHandling.Ignore});
            var _address = ApiHelper.Instance.SiteUrl + ApiHelper.Instance.ProjectExpenseValidateEndpoint;
            businessRulesApiResponse = null;

            try
            {
                var _jsonResult = ApiHelper.Instance.UploadString(token, _address, _data);

                if (_jsonResult == "null")
                {
                    return new DefaultApiResponse(200, "OK", new string[] { });
                }

                return new DefaultApiResponse(500, "Internal Application Error: Fail to Validate Project Expense", new string[] { });
            }
            catch (ApiHttpException _ex)
            {
                return ApiHelper.Instance.ProcessApiResponseContent(_ex, out businessRulesApiResponse);
            }
        }
        public DefaultApiResponse ImportProjectExpense(ProjectExpenseCreateModel projectExpense, string token, out BusinessRulesApiResponse businessRulesApiResponse)
        {
            var _data = JsonConvert.SerializeObject(projectExpense, Newtonsoft.Json.Formatting.None,
                new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            var _address = ApiHelper.Instance.SiteUrl + ApiHelper.Instance.ProjectExpenseCreateEndpoint;
            businessRulesApiResponse = null;

            try
            {
                var _jsonResult = ApiHelper.Instance.UploadString(token, _address, _data);

                if (_jsonResult != "null")
                {
                    return new DefaultApiResponse(200, "OK", new string[] { });
                }

                return new DefaultApiResponse(500, "Internal Application Error: Fail to Import Project Expense", new string[] { });
            }
            catch (ApiHttpException _ex)
            {
                return ApiHelper.Instance.ProcessApiResponseContent(_ex, out businessRulesApiResponse);
            }
        }
    }
}