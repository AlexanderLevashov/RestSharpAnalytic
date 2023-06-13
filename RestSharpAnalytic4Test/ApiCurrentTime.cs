using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharpAnalytic4Test
{
    [TestClass]
    public class ApiCurrentTime
    {
        [TestMethod]
        public void TestCurrentTime()
        {
            var client = ApiClientProvider.GetApiClient();

            var expectedResponse = new TimeResponse
            {
                time = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds()
            };

            var actualResponse = client.GetTime();
            //var currentTimeMillis = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            Assert.IsFalse(Math.Abs(actualResponse.time - expectedResponse.time) < 1000);
        }
    }
}
