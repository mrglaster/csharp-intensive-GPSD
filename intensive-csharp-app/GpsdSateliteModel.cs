using System.Text.Json.Serialization;
namespace intensive_csharp_app
{

    public  class GpsdSateliteModel
    {
        //{"PRN":29,"el":61,"az":106,"ss":28,"used":true},{"PRN":18,"el":59,"az":201,"ss":36,"used":true}

        [JsonPropertyName("PRN")]
        public int PRN { get; set; }
        
        [JsonPropertyName("el")]
        public int El { get; set; }

        [JsonPropertyName("az")]
        public int Az { get; set; }

        [JsonPropertyName("ss")]
        public int Ss { get; set; }

        [JsonPropertyName("used")]
        public bool Used { get; set; }

        public override string ToString()
        {
            return $"Name: {nameof(GpsdSateliteModel)}, PRN: {PRN}, El: {El}, Az: {Az}, Ss: {Ss}, Used: {Used}";
        }
    }
}
