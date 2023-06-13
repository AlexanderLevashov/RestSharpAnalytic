using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharpAnalytic4Test
{
    // Класс для десериализации JSON-данных
    public partial class Info
    {
        public string program { get; set; }
        public string version { get; set; }
        public List<InfoElement> info { get; set; }
        public bool isInternal { get; set; }
    }

    public partial class InfoElement
    {
        public string name { get; set; }
        public long size { get; set; }
    }
}
