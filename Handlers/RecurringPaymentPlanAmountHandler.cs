using System.Collections.Generic;
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
                var _jsonResult = ApiHelper.Instance.UploadString(token, _address, _data);

                if (_jsonResult == "null")
                {
                    return new DefaultApiResponse(200, "OK", new string[] { });
                }

                return new DefaultApiResponse(500, "Internal Application Error: Fail to Validate RecurringPaymentPlanAmount update", new string[] { });
            }
            catch (ApiHttpException _ex)
            {
                return ApiHelper.Instance.ProcessApiResponseContent(_ex, out businessRulesApiResponse);
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
                var _jsonResult = ApiHelper.Instance.UploadString(token, _address, _data);

                if (_jsonResult != "null")
                {
                    return new DefaultApiResponse(200, "OK", new string[] { });
                }

                return new DefaultApiResponse(500, "Internal Application Error: Fail to update RecurringPaymentPlanAmount", new string[] { });
            }
            catch (ApiHttpException _ex)
            {
                return ApiHelper.Instance.ProcessApiResponseContent(_ex, out businessRulesApiResponse);
            }
        }


    }
}