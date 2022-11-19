using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

// {"class":"WATCH","enable":true,"json":true,"nmea":false,"raw":0,"scaled":false,"timing":false,"split24":false,"pps":false}

namespace intensive_csharp_app
{
    public class GpsdWatchModel : GpsdModel
    {
        [JsonPropertyName("enable")]
        public bool Enable { get; set; }

        [JsonPropertyName("json")]
        public bool Json { get; set; }

        [JsonPropertyName("nmea")]
        public bool Nmea { get; set; }

        [JsonPropertyName("raw")]
        public int Raw { get; set; }

        [JsonPropertyName("scaled")]
        public bool Scaled { get; set; }

        [JsonPropertyName("timing")]
        public bool Timing { get; set; }

        [JsonPropertyName("split24")]
        public bool Split24 {get; set;}

        [JsonPropertyName("pps")]
        public bool Pps { get; set; }
    }
}
