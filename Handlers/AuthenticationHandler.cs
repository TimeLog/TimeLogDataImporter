using System;
using System.Net;
using System.Net.Http;
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
				string _jsonResult = ApiHelper.Instance.DownloadString(pat, _address);
				Token = pat;
			}
			catch (ApiHttpException _ex)
			{
				if (_ex.StatusCode == HttpStatusCode.NotFound)
				{
					MessageBox.Show("The requested resource was not found.");
					return null;
				}

				var apiResponse = ApiHelper.Instance.ProcessApiResponseContent(_ex, out _);
				if (apiResponse.Code == 401)
				{
					MessageBox.Show("Invalid PAT token.");
				}
				else
				{
					MessageBox.Show(apiResponse.Message);
				}
			}
			catch (HttpRequestException _ex)
			{
				MessageBox.Show(_ex.Message);
				return null;
			}

            return Token;
        }
    }
}