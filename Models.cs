using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePinger.Models
{
    public class PingResult
    {
        public string Location { get; set; }
        public string Value { get; set; }
    }

    public class JsonObj
    {
        public List<RangeObj> IpRange;
    }
    public class RangeObj
    {
        public string LocationText { get; set; }
        public string IpText { get; set; }
    }
}
