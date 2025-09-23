using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeLog.DataImporter.TimeLogApi;

namespace TimeLog.DataImporter.Handlers
{
    public class AuthenticationHandler
    {
        public string Token = string.Empty;

        private static AuthenticationHandler _instance;

        private AuthenticationHandler()
        {
            
        }
        public static AuthenticationHandler Instance
        {
            get
            {
                return _instance ??= new AuthenticationHandler();
            }
        }

        public async Task<string> Authenticate(string pat)
        {

            var _address = ApiHelper.Instance.SiteUrl + string.Format(ApiHelper.Instance.GetAllEmployeeEndpoint, 1);

            try
            {
                string _jsonResult = ApiHelper.Instance.WebClient(pat).DownloadString(_address);
                Token = pat;
            }
            catch (WebException _webEx)
            {
                if (_webEx.Response == null)
				{
					MessageBox.Show( _webEx.Message);
					return null;
				}
                HttpWebResponse _response = (HttpWebResponse)_webEx.Response;

                if (_response.StatusCode == HttpStatusCode.NotFound)
                {
                    MessageBox.Show("The requested resource was not found.");
                    return null;
                }

                string _responseContent = string.Empty;
                try
                {
	                using StreamReader _r = new StreamReader(_webEx.Response.GetResponseStream());
	                _responseContent = _r.ReadToEnd();
                }
                catch (Exception _ex)
                {
	                MessageBox.Show("Error reading response content: " + _ex.Message);
	                return null;
                }

                var apiResponse = ApiHelper.Instance.ProcessApiResponseContent(_webEx, _responseContent, out _);
                if (apiResponse.Code == 401)
				{
					MessageBox.Show("Invalid PAT token.");
				}
				else
				{
					MessageBox.Show(apiResponse.Message);
				}
            }

            return Token;
        }
    }
}