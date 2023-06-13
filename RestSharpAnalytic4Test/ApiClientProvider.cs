using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharpAnalytic4Test
{
    public class ApiClientProvider
    {
        private static ApiClient _client;

        public static ApiClient GetApiClient()
        {
            _client = new ApiClient("http://192.168.0.243");

            return _client;
        }
    }
}
