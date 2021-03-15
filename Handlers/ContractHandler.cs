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

        //public DefaultApiResponse ValidateContract(ContractCreateModel project, string token, out BusinessRulesApiResponse businessRulesApiResponse)
        //{
        //    var _data = JsonConvert.SerializeObject(project, Newtonsoft.Json.Formatting.None,
        //        new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        //    var _address = ApiHelper.Instance.SiteUrl + ApiHelper.Instance.ProjectValidateEndpoint;
        //    businessRulesApiResponse = null;

        //    try
        //    {
        //        var _jsonResult = ApiHelper.Instance.WebClient(token).UploadString(_address, "POST", _data);

        //        if (_jsonResult == "null")
        //        {
        //            return new DefaultApiResponse(200, "OK", new string[] { });
        //        }

        //        return new DefaultApiResponse(500, "Internal Application Error: Fail to Validate Project", new string[] { });
        //    }
        //    catch (WebException _webEx)
        //    {
        //        using StreamReader _r = new StreamReader(_webEx.Response.GetResponseStream());
        //        string _responseContent = _r.ReadToEnd();

        //        return ApiHelper.Instance.ProcessApiResponseContent(_webEx, _responseContent, out businessRulesApiResponse);
        //    }
        //}

        //public DefaultApiResponse ImportContract(ContractCreateModel contract, string token, out BusinessRulesApiResponse businessRulesApiResponse)
        //{
        //    var _data = JsonConvert.SerializeObject(project, Newtonsoft.Json.Formatting.None,
        //        new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        //    var _address = ApiHelper.Instance.SiteUrl + ApiHelper.Instance.ProjectCreateEndpoint;
        //    businessRulesApiResponse = null;

        //    try
        //    {
        //        var _jsonResult = ApiHelper.Instance.WebClient(token).UploadString(_address, "POST", _data);

        //        if (_jsonResult != "null")
        //        {
        //            return new DefaultApiResponse(200, "OK", new string[] { });
        //        }

        //        return new DefaultApiResponse(500, "Internal Application Error: Fail to Import Project", new string[] { });
        //    }
        //    catch (WebException _webEx)
        //    {
        //        using StreamReader _r = new StreamReader(_webEx.Response.GetResponseStream());
        //        string _responseContent = _r.ReadToEnd();

        //        return ApiHelper.Instance.ProcessApiResponseContent(_webEx, _responseContent, out businessRulesApiResponse);
        //    }
        //}


    }
}