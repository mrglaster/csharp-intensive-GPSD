using System.Text.Json.Serialization;



//{"class":"GST","device":"/dev/pts/2","time":"2022-07-07T04:03:52.069Z","rms":0.000,"major":99999.000,"minor":99999.000,"orient":0.000,"lat":99999.000,"lon":99999.000,"alt":99999.000}

namespace intensive_csharp_app
{
    public class GpsdGSTModel:GpsdModel
    {
        [JsonPropertyName("device")]
        public string Device { get; set; }

        [JsonPropertyName("time")]
        public DateTime Time { get; set; }

        [JsonPropertyName("rms")]
        public float Rms { get; set; }

        [JsonPropertyName("major")]
        public float Major { get; set; }

        [JsonPropertyName("minor")]
        public float Minor { get; set; }

        [JsonPropertyName("orient")]
        public float Orient { get; set; }

        [JsonPropertyName("lat")]
        public float Lat { get; set; }

        [JsonPropertyName("lon")]
        public float Lon { get; set; }

        [JsonPropertyName("alt")]
        public float Alt { get; set; }

        public override string ToString()
        {
            return $"Name: {nameof(GpsdGSTModel)}, Device: {Device} etc";
        }
    }
}
