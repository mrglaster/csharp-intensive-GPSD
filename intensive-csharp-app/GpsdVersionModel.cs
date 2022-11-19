using System.Text.Json.Serialization;


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

        public override string ToString()
        {
            return $"Name: {nameof(GpsdWatchModel)}, Release : {Release}, Revision: {Revision}, Major: {Major}, Minor: {Minor}";
        }
    }
}
