using System.Text.Json.Serialization;


namespace intensive_csharp_app
{
    public class GpsdModel: IGpsdModel
    {
        [JsonPropertyName("class")]
        public string Class { get; set; }
    }
}
