using System.Text.Json.Serialization;
namespace intensive_csharp_app
{
    // {"class":"SKY","device":"/dev/pts/2","xdop":0.68,"ydop":0.68,"vdop":0.77,"tdop":0.85,"hdop":0.95,"gdop":1.78,"pdop":1.22,"satellites":[{"PRN":29,"el":61,"az":106,"ss":28,"used":true},{"PRN":18,"el":59,"az":201,"ss":36,"used":true},{"PRN":26,"el":53,"az":273,"ss":39,"used":true},{"PRN":5,"el":41,"az":79,"ss":40,"used":true},{"PRN":31,"el":14,"az":234,"ss":32,"used":true},{"PRN":133,"el":0,"az":0,"ss":0,"used":false},{"PRN":20,"el":0,"az":0,"ss":32,"used":false},{"PRN":2,"el":0,"az":0,"ss":17,"used":false},{"PRN":88,"el":62,"az":62,"ss":36,"used":true},{"PRN":81,"el":59,"az":257,"ss":36,"used":true},{"PRN":79,"el":55,"az":248,"ss":38,"used":true},{"PRN":72,"el":30,"az":45,"ss":38,"used":true},{"PRN":78,"el":21,"az":192,"ss":42,"used":true},{"PRN":65,"el":21,"az":99,"ss":23,"used":false},{"PRN":87,"el":15,"az":66,"ss":23,"used":false},{"PRN":71,"el":13,"az":357,"ss":32,"used":true},{"PRN":82,"el":10,"az":250,"ss":20,"used":false}]}

    [TableName("public.data_sky")]
    public class GpsdSKYModel: GpsdModel
    {
        [JsonPropertyName("device")]
        public string Device { get; set; }

        [JsonPropertyName("xdop")]
        public double Xdop { get; set; }

        [JsonPropertyName("ydop")]
        public double Ydop { get; set; }

        [JsonPropertyName("vdop")]
        public double Vdop { get; set; }

        [JsonPropertyName("tdop")]
        public double Tdop { get; set; }

        [JsonPropertyName("hdop")]
        public double Hdop { get; set; }

        [JsonPropertyName("gdop")]
        public double Gdop { get; set; }

        [JsonPropertyName("pdop")]
        public double Pdop { get; set; }

        [JsonPropertyName("satellites")]
        public IEnumerable<GpsdSateliteModel> Satellites { get; set; }

        public override string ToString()
        {
            return $"Name: {nameof(GpsdSKYModel)}, Device: {Device}, xdop: {Xdop}, ydop: {Ydop}, vdop: {Vdop}, tdop: {Tdop}, hdop: {Hdop}, gdop: {Gdop}, pdop: {Pdop}, amount of satellites: {Satellites.Count()} ";
        }
    }
}
