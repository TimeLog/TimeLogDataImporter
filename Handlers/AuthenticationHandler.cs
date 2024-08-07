﻿using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using IdentityModel.Client;
using IdentityModel.OidcClient;
using TimeLog.DataImporter.TimeLogApi;

namespace TimeLog.DataImporter.Handlers
{
    public class AuthenticationHandler
    {
        private OidcClient _oidcClient;
        public string Token = string.Empty;

        private static AuthenticationHandler _instance;

        private AuthenticationHandler()
        {
            //var _options = new OidcClientOptions
            //{
            //    Authority = "http://192.168.1.100/login",
            //    ClientId = "coldemo",
            //    ClientSecret = "coldemo",
            //    Scope = "openid profile tlp",
            //    RedirectUri = "com.timelog:/oauthredirect",
            //    ResponseMode = OidcClientOptions.AuthorizeResponseMode.Redirect,
            //    Flow = OidcClientOptions.AuthenticationFlow.AuthorizationCode,
            //    Policy = new Policy { Discovery = new DiscoveryPolicy { RequireHttps = false } },
            //    Browser = new WinFormsWebView()
            //};

            var _options = new OidcClientOptions
            {
                Authority = "https://login.timelog.com",
                ClientId = "tdi",
                ClientSecret = "a2c06677-ad29-4213-9c84-983c301379af",
                Scope = "openid profile tlp",
                RedirectUri = "com.timelog:/oauthredirect",
                ResponseMode = OidcClientOptions.AuthorizeResponseMode.Redirect,
                Flow = OidcClientOptions.AuthenticationFlow.AuthorizationCode,
                Policy = new Policy { Discovery = new DiscoveryPolicy { RequireHttps = false } },
                Browser = new WinFormsWebView()
            };


            _oidcClient = new OidcClient(_options);
        }
        public static AuthenticationHandler Instance
        {
            get
            {
                return _instance ??= new AuthenticationHandler();
            }
        }

        public async Task<string> Authenticate()
        {
            var _result = await _oidcClient.LoginAsync();
            Token = _result.AccessToken;
            //_result.RefreshToken;  //need to implement auto refresh token
            return Token;
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

        public async Task<string> Logout()
        {
            var _result = await _oidcClient.LogoutAsync();
            return _result.Error;
        }
    }
}