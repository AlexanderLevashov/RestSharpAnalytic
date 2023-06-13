using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using RestSharp;
using System;

namespace RestSharpAnalytic4Test
{
    public class ApiClient
    {
        private readonly RestClient _client;

        public ApiClient(string baseUrl)
        {
            _client = new RestClient(baseUrl);
        }

        public InfoResponse GetInfo()
        {
            var request = new RestRequest("/api/n4/v1/info", Method.GET);
            var response = _client.Execute(request);

            if (response.ErrorException != null)
            {
                throw new ApplicationException("Failed to execute request", response.ErrorException);
            }

            return JsonConvert.DeserializeObject<InfoResponse>(response.Content);
        }

        public InfoResponseN4 GetInfoN4()
        {
            var request = new RestRequest("/n4/info", Method.GET);
            var response = _client.Execute(request);

            if (response.ErrorException != null)
            {
                throw new ApplicationException("Failed to execute request", response.ErrorException);
            }

            return JsonConvert.DeserializeObject<InfoResponseN4>(response.Content);
        }

        public TimeResponse GetTime()
        {
            var request = new RestRequest("/api/a4/v1/time", Method.GET);
            var response = _client.Execute(request);

            return JsonConvert.DeserializeObject<TimeResponse>(response.Content);
        }
    }
}
