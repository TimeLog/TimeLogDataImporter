using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;
using TimeLog.DataImporter.TimeLogApi;
using TimeLog.DataImporter.TimeLogApi.Model;

namespace TimeLog.DataImporter.Handlers
{
    public class CustomerHandler : BaseHandler
    {
        private static CustomerHandler _instance;

        private CustomerHandler()
        {
        }

        public static CustomerHandler Instance
        {
            get { return _instance ??= new CustomerHandler(); }
        }

        public DefaultApiResponse ValidateCustomer(CustomerCreateModel customer, string token, out BusinessRulesApiResponse businessRulesApiResponse)
        {
            var _data = JsonConvert.SerializeObject(customer, Newtonsoft.Json.Formatting.None, 
                new JsonSerializerSettings {NullValueHandling = NullValueHandling.Ignore});
            var _address = ApiHelper.Instance.SiteUrl + ApiHelper.Instance.CustomerValidateEndpoint;
            businessRulesApiResponse = null;

            try
            {
                var _jsonResult = ApiHelper.Instance.WebClient(token).UploadString(_address, "POST", _data);

                if (_jsonResult == "null")
                {
                    return new DefaultApiResponse(200, "OK", new string[] { });
                }

                return new DefaultApiResponse(500, "Internal Application Error: Fail to Validate Customer", new string[] { });
            }
            catch (WebException _webEx)
            {
                using StreamReader _r = new StreamReader(_webEx.Response.GetResponseStream());
                string _responseContent = _r.ReadToEnd();

                return ApiHelper.Instance.ProcessApiResponseContent(_webEx, _responseContent, out businessRulesApiResponse);
            }
        }

        public DefaultApiResponse ImportCustomer(CustomerCreateModel customer, string token, out BusinessRulesApiResponse businessRulesApiResponse)
        {
            var _data = JsonConvert.SerializeObject(customer, Newtonsoft.Json.Formatting.None,
                new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            var _address = ApiHelper.Instance.SiteUrl + ApiHelper.Instance.CustomerCreateEndpoint;
            businessRulesApiResponse = null;
            _address = "http://localhost/tlp/api/v1/contact";
            try
            {
                var _jsonResult = ApiHelper.Instance.WebClient(token).UploadString(_address, "POST", _data);

                if (_jsonResult != "null")
                {
                    return new DefaultApiResponse(200, "OK", new string[] { });
                }

                return new DefaultApiResponse(500, "Internal Application Error: Fail to Import Customer", new string[] { });
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