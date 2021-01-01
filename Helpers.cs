using GamePinger.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePinger
{
    public static class Helpers
    {
        private static string ConfigPath = Path.Combine(Directory.GetCurrentDirectory(), "config.json");
        public static List<RangeObj> ReadIpsFromFile()
        {
            var ranges = File.ReadAllText(ConfigPath);
            return JsonConvert.DeserializeObject<JsonObj>(ranges).IpRange;
        }

        public static void WriteIpsToFile(List<RangeObj> obj)
        {
            JsonObj toAddObj = new JsonObj
            {
                IpRange = obj
            };
            var jsonString = JsonConvert.SerializeObject(toAddObj);
            File.WriteAllText(ConfigPath,jsonString);
        }
    }

}
