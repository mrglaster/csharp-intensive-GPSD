using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace intensive_csharp_app
{
    public class GpsdVersionModel : GpsdModel
    {
        [JsonPropertyName("release")]
        public string Release { get; set; }
        [JsonPropertyName("rev")]
        public string Revision { get; set; }
        [JsonPropertyName("proto_major")]
        public int Major { get; set; }
        [JsonPropertyName("proto_minor")]
        public int Minor { get; set; }


    }
}
