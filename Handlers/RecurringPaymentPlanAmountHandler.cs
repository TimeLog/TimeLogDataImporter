using System.Collections.Generic;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using TimeLog.DataImporter.TimeLogApi;
using TimeLog.DataImporter.TimeLogApi.Model.Contracts;

namespace TimeLog.DataImporter.Handlers
{
    public class RecurringPaymentPlanAmountHandler : BaseHandler
    {
        private static RecurringPaymentPlanAmountHandler _instance;

        private RecurringPaymentPlanAmountHandler()
        {
        }

        public static RecurringPaymentPlanAmountHandler Instance
        {
            get
            {
                return _instance ??= new RecurringPaymentPlanAmountHandler();
            }
        }

        public DefaultApiResponse ValidateRecurringPaymentPlanAmountUpdate(RecurringPaymentPlanAmountUpdateModel recurringPaymentPlanAmountModel, string token, out BusinessRulesApiResponse businessRulesApiResponse)
        {
            var _data = JsonConvert.SerializeObject(recurringPaymentPlanAmountModel, Newtonsoft.Json.Formatting.None,
                new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            var _address = ApiHelper.Instance.SiteUrl + ApiHelper.Instance.RecurringPaymentPlanAmountUpdateValidateEndpoint;
            businessRulesApiResponse = null;

            try
            {
                var _jsonResult = ApiHelper.Instance.WebClient(token).UploadString(_address, "POST", _data);

                if (_jsonResult == "null")
                {
                    return new DefaultApiResponse(200, "OK", new string[] { });
                }

                return new DefaultApiResponse(500, "Internal Application Error: Fail to Validate RecurringPaymentPlanAmount update", new string[] { });
            }
            catch (WebException _webEx)
            {
                using StreamReader _r = new StreamReader(_webEx.Response.GetResponseStream());
                string _responseContent = _r.ReadToEnd();

                return ApiHelper.Instance.ProcessApiResponseContent(_webEx, _responseContent, out businessRulesApiResponse);
            }
        }

        public DefaultApiResponse ImportRecurringPaymentPlanAmount(RecurringPaymentPlanAmountUpdateModel recurringPaymentPlanAmountUpdateModel, string token, out BusinessRulesApiResponse businessRulesApiResponse)
        {
            var _data = JsonConvert.SerializeObject(recurringPaymentPlanAmountUpdateModel, Newtonsoft.Json.Formatting.None,
                new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            var _address = ApiHelper.Instance.SiteUrl + ApiHelper.Instance.RecurringPaymentPlanAmountUpdateEndpoint;
            businessRulesApiResponse = null;

            try
            {
                var _jsonResult = ApiHelper.Instance.WebClient(token).UploadString(_address, "POST", _data);

                if (_jsonResult != "null")
                {
                    return new DefaultApiResponse(200, "OK", new string[] { });
                }

                return new DefaultApiResponse(500, "Internal Application Error: Fail to update RecurringPaymentPlanAmount", new string[] { });
            }
            catch (WebException _webEx)
            {
                using StreamReader _r = new StreamReader(_webEx.Response.GetResponseStream());
                string _responseContent = _r.ReadToEnd();

                return ApiHelper.Instance.ProcessApiResponseContent(_webEx, _responseContent, out businessRulesApiResponse);
            }
        }


    }
}