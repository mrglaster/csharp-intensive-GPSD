using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

// {"class":"TPV","device":"/dev/pts/2","mode":3,"time":"2022-07-06T07:37:53.000Z","ept":0.005,"lat":59.987305000,"lon":30.312196667,"alt":3.700,"epx":10.180,"epy":10.214,"epv":28.520,"track":0.0000,"speed":0.129,"climb":-0.100,"eps":20.43,"epc":57.04}

namespace intensive_csharp_app
{
    public class GpsdTPVModel:GpsdModel
   {
        [JsonPropertyName("device")]
        public string Device { get; set; }

        [JsonPropertyName("mode")]
        public int Mode { get; set; }

        [JsonPropertyName("time")]
        public DateTime Time { get; set; }

        [JsonPropertyName("ept")]
        public double Ept { get; set; }

        [JsonPropertyName("lat")]
        public double Lat { get; set; }

        [JsonPropertyName("lon")]
        public double Lon { get; set; }

        [JsonPropertyName("alt")]
        public double Alt { get; set; }

        [JsonPropertyName("epx")]
        public double Epx { get; set; }

        [JsonPropertyName("epy")]
        public double Epy { get; set; }

        [JsonPropertyName("epv")]
        public double Epv { get; set; }

        [JsonPropertyName("track")]
        public double Track { get; set; }

        [JsonPropertyName("speed")]
        public double Speed { get; set; }

        [JsonPropertyName("climb")]
        public double Climb { get; set; }


        [JsonPropertyName("eps")]
        public double Eps { get; set; }

        [JsonPropertyName("epc")]
        public double Epc { get; set; }
    }
}
