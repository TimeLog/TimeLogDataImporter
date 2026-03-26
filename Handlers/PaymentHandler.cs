using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;
using TimeLog.DataImporter.TimeLogApi;
using TimeLog.DataImporter.TimeLogApi.Model;

namespace TimeLog.DataImporter.Handlers
{
    public class PaymentHandler : BaseHandler
    {
        private static PaymentHandler _instance;

        private PaymentHandler()
        {
        }

        public static PaymentHandler Instance
        {
            get
            {
                return _instance ??= new PaymentHandler();
            }
        }

        public DefaultApiResponse ValidatePayment(PaymentCreateModel payment, string token, out BusinessRulesApiResponse businessRulesApiResponse)
        {
            var _data = JsonConvert.SerializeObject(payment, Newtonsoft.Json.Formatting.None,
                new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            var _address = ApiHelper.Instance.SiteUrl + ApiHelper.Instance.PaymentValidateEndpoint;
            businessRulesApiResponse = null;

            try
            {
                var _jsonResult = ApiHelper.Instance.UploadString(token, _address, _data);

                if (_jsonResult == "null")
                {
                    return new DefaultApiResponse(200, "OK", new string[] { });
                }

                return new DefaultApiResponse(500, "Internal Application Error: Fail to Validate Project", new string[] { });
            }
            catch (ApiHttpException _ex)
            {
                return ApiHelper.Instance.ProcessApiResponseContent(_ex, out businessRulesApiResponse);
            }
        }
        public DefaultApiResponse ImportPayment(PaymentCreateModel payment, string token, out BusinessRulesApiResponse businessRulesApiResponse)
        {
            var _data = JsonConvert.SerializeObject(payment, Newtonsoft.Json.Formatting.None,
                new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            var _address = ApiHelper.Instance.SiteUrl + ApiHelper.Instance.PaymentCreateEndpoint;
            businessRulesApiResponse = null;

            try
            {
                var _jsonResult = ApiHelper.Instance.UploadString(token, _address, _data);

                if (_jsonResult != "null")
                {
                    return new DefaultApiResponse(200, "OK", new string[] { });
                }

                return new DefaultApiResponse(500, "Internal Application Error: Fail to Import Project", new string[] { });
            }
            catch (ApiHttpException _ex)
            {
                return ApiHelper.Instance.ProcessApiResponseContent(_ex, out businessRulesApiResponse);
            }
        }
    }
}