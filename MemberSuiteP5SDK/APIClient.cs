using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MemberSuiteP5SDK
{
    /// <summary>
    /// Contains the HttpClient used to make calls to the P5 REST Endpoints.
    /// </summary>
    public class APIClient
    {
        private static HttpClient _HttpClient;
        private UriBuilder _UriBuilder;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url">The Base address of the REST API</param>
        /// <param name="user">The username used to fetch the auth token</param>
        /// <param name="password">The password used to fetch the auth token</param>
        /// <param name="clientID">The clientID used to fetch the auth token</param>
        /// <param name="tenantID">The tenantID used to fetch the auth token</param>
        public APIClient(string url, string user, string password, string clientID, string tenantID)
        {
             _UriBuilder = new UriBuilder(url);
            _HttpClient = new HttpClient(new ValidTokenHandler(user, password, clientID, url, tenantID));
            _HttpClient.BaseAddress = _UriBuilder.Uri;
            _HttpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            
        }

        public HttpResponseMessage MakePostCall(string endpoint, string payload)
        {
            _UriBuilder.Path = endpoint;

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, _UriBuilder.Uri);
            request.Content = new StringContent(payload);

            return _HttpClient.SendAsync(request).Result;
        }
    }

    /// <summary>
    /// Handles fetching the auth token for all api calls. Will attempt to get a new token if the request is unauthorized or no previous token exists
    /// </summary>
    public class ValidTokenHandler : DelegatingHandler
    {
        private string _user;
        private string _password;
        private string _clientID;
        private string _url;
        private string _tenantID;
        private string _token;

        public ValidTokenHandler(string user, string password, string clientID, string url, string tenantID)
        {
            _user = user;
            _password = password;
            _clientID = clientID;
            _url = url;
            _tenantID = tenantID;
            _token = "";
            InnerHandler = new HttpClientHandler();
        }

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {

            //try to fetch a new token if the token is null or empty
            if(string.IsNullOrEmpty(_token))
            {
                HttpRequestMessage tokenRequest = new HttpRequestMessage(HttpMethod.Post, _url + "/platform/v2/authtoken/" + _tenantID);
                tokenRequest.Content = new StringContent(string.Format(@"{{""username"": ""{0}"",""password"": ""{1}"",""clientID"": ""{2}""}}", _user, _password, _clientID), Encoding.UTF8, "application/json");

                var tokenResponse = base.SendAsync(tokenRequest, cancellationToken);

                if(!tokenResponse.Result.IsSuccessStatusCode)
                {
                    throw new Exception("Error making API call. Reason Code: " + tokenResponse.Result.StatusCode + ",\nReason Phrase: " + tokenResponse.Result.ReasonPhrase + ",\nResponse Body: " + tokenResponse);
                }
                else
                {
                    _token = tokenResponse.Result.Content.ReadAsStringAsync().Result;
                }
            }

            request.Headers.Add("Authorization" , _token);
            request.Content.Headers.ContentType.MediaType = "application/json";

            //send the response
            var response = base.SendAsync(request, cancellationToken);

            //If the user is unauthorized, fetch a new token and try again.
            if(response.Result.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            {
                HttpRequestMessage tokenRequest = new HttpRequestMessage(HttpMethod.Post, _url + "/platform/v2/authtoken/" + _tenantID);
                tokenRequest.Content = new StringContent(string.Format(@"{{""username"": ""{0}"",""password"": ""{1}"",""clientID"": ""{2}""}}", _user, _password, _clientID), Encoding.UTF8, "application/json");

                var tokenResponse = base.SendAsync(tokenRequest, cancellationToken);

                if (!tokenResponse.Result.IsSuccessStatusCode)
                {
                    return tokenResponse;
                }
                else
                {
                    _token = tokenResponse.Result.Content.ReadAsStringAsync().Result;
                }

                request.Headers.Remove("Authorization");
                request.Headers.Add("Authorization", _token);

                response = base.SendAsync(request, cancellationToken);
            }

            if(!response.Result.IsSuccessStatusCode)
            {
                throw new Exception("Error making API call. Reason Code: " + response.Result.StatusCode + ",\nReason Phrase: " + response.Result.ReasonPhrase + ",\nResponse Body: " + response);
            }

            return response;
        }
    }
}
