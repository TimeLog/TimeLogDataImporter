using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;
using TimeLog.DataImporter.TimeLogApi;
using TimeLog.DataImporter.TimeLogApi.Model;

namespace TimeLog.DataImporter.Handlers
{
    public class ContractHandler : BaseHandler
    {
        private static ContractHandler _instance;

        private ContractHandler()
        {
        }

        public static ContractHandler Instance
        {
            get
            {
                return _instance ??= new ContractHandler();
            }
        }


        public DefaultApiResponse ValidateTimeMaterialBasicContract(TimeMaterialBasicContractCreateModel contract, string token, out BusinessRulesApiResponse businessRulesApiResponse)
        {
            var _data = JsonConvert.SerializeObject(contract, Newtonsoft.Json.Formatting.None, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });

            var _address = ApiHelper.Instance.SiteUrl + ApiHelper.Instance.TimeMaterialBasicValidateEndpoint;

            return Import(_address, _data, token, out businessRulesApiResponse);
        }

        public DefaultApiResponse ValidateFixedPriceBasicContract(FixedPriceBasicContractCreateModel contract, string token, out BusinessRulesApiResponse businessRulesApiResponse)
        {
            var _data = JsonConvert.SerializeObject(contract, Newtonsoft.Json.Formatting.None, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });

            var _address = ApiHelper.Instance.SiteUrl + ApiHelper.Instance.FixedPriceBasicValidateEndpoint;

            return Import(_address, _data, token, out businessRulesApiResponse);
        }

        public DefaultApiResponse ValidateTimeMaterialAccountEndBalancingContract(TimeMaterialAccountEndBalancingContractCreateModel contract, string token, out BusinessRulesApiResponse businessRulesApiResponse)
        {
            var _data = JsonConvert.SerializeObject(contract, Newtonsoft.Json.Formatting.None, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });

            var _address = ApiHelper.Instance.SiteUrl + ApiHelper.Instance.TimeMaterialAccountEndBalancingValidateEndpoint;

            return Import(_address, _data, token, out businessRulesApiResponse);
        }

        public DefaultApiResponse ValidatePrepaidServicesContract(PrepaidServicesContractCreateModel contract, string token, out BusinessRulesApiResponse businessRulesApiResponse)
        {
            var _data = JsonConvert.SerializeObject(contract, Newtonsoft.Json.Formatting.None, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });

            var _address = ApiHelper.Instance.SiteUrl + ApiHelper.Instance.PrepaidServicesValidateEndpoint;

            return Import(_address, _data, token, out businessRulesApiResponse);
        }

        public DefaultApiResponse ValidateTaskDrivenRevenueContract(TaskDrivenRevenueContractCreateModel contract, string token, out BusinessRulesApiResponse businessRulesApiResponse)
        {
            var _data = JsonConvert.SerializeObject(contract, Newtonsoft.Json.Formatting.None, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });

            var _address = ApiHelper.Instance.SiteUrl + ApiHelper.Instance.TaskDrivenRevenueValidateEndpoint;

            return Import(_address, _data, token, out businessRulesApiResponse);
        }




        public DefaultApiResponse ImportTimeMaterialBasicContract(TimeMaterialBasicContractCreateModel contract, string token, out BusinessRulesApiResponse businessRulesApiResponse)
        {
            var _data = JsonConvert.SerializeObject(contract, Newtonsoft.Json.Formatting.None, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });

            var _address = ApiHelper.Instance.SiteUrl + ApiHelper.Instance.TimeMaterialBasicCreateEndpoint;

            return Import(_address, _data, token, out businessRulesApiResponse);
        }

        public DefaultApiResponse ImportFixedPriceBasicContract(FixedPriceBasicContractCreateModel contract, string token, out BusinessRulesApiResponse businessRulesApiResponse)
        {
            var _data = JsonConvert.SerializeObject(contract, Newtonsoft.Json.Formatting.None, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });

            var _address = ApiHelper.Instance.SiteUrl + ApiHelper.Instance.FixedPriceBasicCreateEndpoint;

            return Import(_address, _data, token, out businessRulesApiResponse);
        }

        public DefaultApiResponse ImportTimeMaterialAccountEndBalancingContract(TimeMaterialAccountEndBalancingContractCreateModel contract, string token, out BusinessRulesApiResponse businessRulesApiResponse)
        {
            var _data = JsonConvert.SerializeObject(contract, Newtonsoft.Json.Formatting.None, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });

            var _address = ApiHelper.Instance.SiteUrl + ApiHelper.Instance.TimeMaterialAccountEndBalancingCreateEndpoint;

            return Import(_address, _data, token, out businessRulesApiResponse);
        }

        public DefaultApiResponse ImportPrepaidServicesContract(PrepaidServicesContractCreateModel contract, string token, out BusinessRulesApiResponse businessRulesApiResponse)
        {
            var _data = JsonConvert.SerializeObject(contract, Newtonsoft.Json.Formatting.None, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });

            var _address = ApiHelper.Instance.SiteUrl + ApiHelper.Instance.PrepaidServicesCreateEndpoint;

            return Import(_address, _data, token, out businessRulesApiResponse);
        }

        public DefaultApiResponse ImportTaskDrivenRevenueContract(TaskDrivenRevenueContractCreateModel contract, string token, out BusinessRulesApiResponse businessRulesApiResponse)
        {
            var _data = JsonConvert.SerializeObject(contract, Newtonsoft.Json.Formatting.None, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });

            var _address = ApiHelper.Instance.SiteUrl + ApiHelper.Instance.TaskDrivenRevenueCreateEndpoint;

            return Import(_address, _data, token, out businessRulesApiResponse);
        }

        public DefaultApiResponse Import(string address, string data, string token, out BusinessRulesApiResponse businessRulesApiResponse)
        {

            businessRulesApiResponse = null;

            try
            {
                var _jsonResult = ApiHelper.Instance.WebClient(token).UploadString(address, "POST", data);

                if (_jsonResult != "null")
                {
                    return new DefaultApiResponse(200, "OK", new string[] { });
                }

                //return new DefaultApiResponse(200, "OK", new string[] { });

                return new DefaultApiResponse(500, "Internal Application Error: Fail to Import Project", new string[] { });
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