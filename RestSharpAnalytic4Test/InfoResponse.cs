using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharpAnalytic4Test
{
    public class InfoResponse
    {
        public string program { get; set; }
        public string version { get; set; }
        public Info[] info { get; set; }
        public bool isInternal { get; set; }

        public class Info
        {
            public string name { get; set; }
            public int size { get; set; }
        }
    }
}
