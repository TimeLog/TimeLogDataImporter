using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;
using TimeLog.DataImporter.TimeLogApi;
using TimeLog.DataImporter.TimeLogApi.Model;

namespace TimeLog.DataImporter.Handlers
{
    public class HourlyRateHandler : BaseHandler
    {
        private static HourlyRateHandler _instance;

        private HourlyRateHandler()
        {
        }

        public static HourlyRateHandler Instance
        {
            get
            {
                return _instance ??= new HourlyRateHandler();
            }
        }

        public DefaultApiResponse ValidateHourlyRate(ContractHourlyRateApiCreateModel hourlyRate, string token, out BusinessRulesApiResponse businessRulesApiResponse)
        {
            var _data = JsonConvert.SerializeObject(hourlyRate, Newtonsoft.Json.Formatting.None,
                new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            var _address = ApiHelper.Instance.SiteUrl + ApiHelper.Instance.HourlyRateValidateEndpoint;
            businessRulesApiResponse = null;

            try
            {
                var _jsonResult = ApiHelper.Instance.UploadString(token, _address, _data);

                if (_jsonResult == "null")
                {
                    return new DefaultApiResponse(200, "OK", new string[] { });
                }

                return new DefaultApiResponse(500, "Internal Application Error: Fail to Validate Hourly Rate", new string[] { });
            }
            catch (ApiHttpException _ex)
            {
                return ApiHelper.Instance.ProcessApiResponseContent(_ex, out businessRulesApiResponse);
            }
        }
        public DefaultApiResponse ImportHourlyRate(ContractHourlyRateApiCreateModel hourlyRate, string token, out BusinessRulesApiResponse businessRulesApiResponse)
        {
            var _data = JsonConvert.SerializeObject(hourlyRate, Newtonsoft.Json.Formatting.None,
                new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            var _address = ApiHelper.Instance.SiteUrl + ApiHelper.Instance.HourlyRateCreateEndpoint;
            businessRulesApiResponse = null;

            try
            {
                var _jsonResult = ApiHelper.Instance.UploadString(token, _address, _data);

                if (_jsonResult != "null")
                {
                    return new DefaultApiResponse(200, "OK", new string[] { });
                }

                return new DefaultApiResponse(500, "Internal Application Error: Fail to Import Hourly Rate", new string[] { });
            }
            catch (ApiHttpException _ex)
            {
                return ApiHelper.Instance.ProcessApiResponseContent(_ex, out businessRulesApiResponse);
            }
        }
    }
}