using System.Collections.Generic;
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

            return Validate(_address, _data, token, out businessRulesApiResponse);
        }

        public DefaultApiResponse ValidateFixedPriceBasicContract(FixedPriceBasicContractCreateModel contract, string token, out BusinessRulesApiResponse businessRulesApiResponse)
        {
            var _data = JsonConvert.SerializeObject(contract, Newtonsoft.Json.Formatting.None, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });

            var _address = ApiHelper.Instance.SiteUrl + ApiHelper.Instance.FixedPriceBasicValidateEndpoint;

            return Validate(_address, _data, token, out businessRulesApiResponse);
        }

        public DefaultApiResponse ValidateTimeMaterialAccountEndBalancingContract(TimeMaterialAccountEndBalancingContractCreateModel contract, string token, out BusinessRulesApiResponse businessRulesApiResponse)
        {
            var _data = JsonConvert.SerializeObject(contract, Newtonsoft.Json.Formatting.None, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });

            var _address = ApiHelper.Instance.SiteUrl + ApiHelper.Instance.TimeMaterialAccountEndBalancingValidateEndpoint;

            return Validate(_address, _data, token, out businessRulesApiResponse);
        }

        public DefaultApiResponse ValidatePrepaidServicesContract(PrepaidServicesContractCreateModel contract, string token, out BusinessRulesApiResponse businessRulesApiResponse)
        {
            var _data = JsonConvert.SerializeObject(contract, Newtonsoft.Json.Formatting.None, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });

            var _address = ApiHelper.Instance.SiteUrl + ApiHelper.Instance.PrepaidServicesValidateEndpoint;

            return Validate(_address, _data, token, out businessRulesApiResponse);
        }

        public DefaultApiResponse ValidateTaskDrivenRevenueContract(TaskDrivenRevenueContractCreateModel contract, string token, out BusinessRulesApiResponse businessRulesApiResponse)
        {
            var _data = JsonConvert.SerializeObject(contract, Newtonsoft.Json.Formatting.None, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });

            var _address = ApiHelper.Instance.SiteUrl + ApiHelper.Instance.TaskDrivenRevenueValidateEndpoint;

            return Validate(_address, _data, token, out businessRulesApiResponse);
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
                var _jsonResult = ApiHelper.Instance.UploadString(token, address, data);

                if (_jsonResult != "null")
                {
                    return new DefaultApiResponse(200, "OK", new string[] { });
                }

                return new DefaultApiResponse(500, "Internal Application Error: Fail to validate or import Contract", new string[] { });
            }
            catch (ApiHttpException _ex)
            {
                return ApiHelper.Instance.ProcessApiResponseContent(_ex, out businessRulesApiResponse);
            }
        }


        public DefaultApiResponse Validate(string address, string data, string token, out BusinessRulesApiResponse businessRulesApiResponse)
        {
            businessRulesApiResponse = null;

            try
            {
                var _jsonResult = ApiHelper.Instance.UploadString(token, address, data);

                if (_jsonResult == "null")
                {
                    return new DefaultApiResponse(200, "OK", new string[] { });
                }

                return new DefaultApiResponse(500, "Internal Application Error: Fail to Validate Customer", new string[] { });
            }
            catch (ApiHttpException _ex)
            {
                return ApiHelper.Instance.ProcessApiResponseContent(_ex, out businessRulesApiResponse);
            }
        }
    }
}