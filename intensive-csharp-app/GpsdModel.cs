using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace intensive_csharp_app
{
    public class GpsdModel: IGpsdModel
    {
        [JsonPropertyName("class")]
        public string Class { get; set; }
    }
}
