using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharpAnalytic4Test
{
    [TestClass]
    public class ApiTestInfo
    {
        [TestMethod]
        public void TestInfoEndpoint()
        {
            var client = ApiClientProvider.GetApiClient();

            var expectedResponse = new InfoResponse
            {
                program = "n4s",
                version = "4.2305.10.00",
                info = new[]
                {
                    new InfoResponse.Info { name = "handbooks", size = 63513 },
                    new InfoResponse.Info { name = "msd", size = 168920314 },
                    new InfoResponse.Info { name = "reports", size = 389761 },
                    new InfoResponse.Info { name = "tmp", size = 0 },
                    new InfoResponse.Info { name = "trend", size = 13918958 }
                },
                isInternal = false
            };

            var actualResponse = client.GetInfo();

            // Assert that the response matches the expected values
            if (actualResponse.program != expectedResponse.program ||
                actualResponse.version != expectedResponse.version ||
                actualResponse.isInternal != expectedResponse.isInternal ||
                actualResponse.info.Length != expectedResponse.info.Length)
            {
                throw new ApplicationException("Unexpected response");
            }

            for (int i = 0; i < actualResponse.info.Length; i++)
            {
                if (actualResponse.info[i].name != expectedResponse.info[i].name ||
                    actualResponse.info[i].size != expectedResponse.info[i].size)
                {
                    throw new ApplicationException("Unexpected response");
                }
            }
        }
    }
}
