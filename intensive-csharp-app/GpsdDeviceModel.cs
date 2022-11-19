using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
//{"class":"DEVICE","path":"/dev/pts/2","driver":"NMEA0183","activated":"2022-09-05T06:37:52.262Z","flags":1,"native":0,"bps":4800,"parity":"N","stopbits":1,"cycle":1.00}
namespace intensive_csharp_app
{
    public class GpsdDeviceModel:GpsdModel
    {
        [JsonPropertyName("path")]
        public string Path { get; set; }

        [JsonPropertyName("driver")]
        public string Driver { get; set; }

        [JsonPropertyName("activated")]
        public DateTime Activated { get; set; }

        [JsonPropertyName("flags")]
        public int Flags { get; set; }

        [JsonPropertyName("native")]
        public int Native { get; set; }

        [JsonPropertyName("bps")]
        public int Bps { get; set; }

        [JsonPropertyName("parity")]
        public string Parity { get; set; }

        [JsonPropertyName("stopbits")]
        public int Stopbits { get; set; }

        [JsonPropertyName("cycle")]
        public double Cycle { get; set; }

        public override string ToString()
        {
            return $"Name: {nameof(GpsdDeviceModel)}, Path: {Path} etc";
        }
    }
}
