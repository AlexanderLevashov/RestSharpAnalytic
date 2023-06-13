using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharpAnalytic4Test
{
    [TestClass]
    public class ApiN4Info
    {
        [TestMethod]
        public void TestInfoN4()
        {
            var client = ApiClientProvider.GetApiClient();

            var expectedResponse = new InfoResponseN4
            {
                program = "n4",
                version = "4.2305.10.00"
            };

            var actualResponse = client.GetInfoN4();

            // Assert that the response matches the expected values
            if (actualResponse.program != expectedResponse.program ||
                actualResponse.version != expectedResponse.version)
            {
                throw new ApplicationException("Unexpected response");
            }
        }
    }
}
