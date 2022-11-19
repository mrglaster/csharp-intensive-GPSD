using System.Text.Json;
namespace intensive_csharp_app
{
    public class GpsdManager
    {

        public EventHandler? OnLoadData;

        public IGpsdModel? LoadData(string data) {

            var factory = new GpsdFactory();
            var result = JsonSerializer.Deserialize<GpsdModel>(data);
            var jsonType = factory.Create(result.Class);
            var second = JsonSerializer.Deserialize(data, jsonType);
            var model = second as IGpsdModel;
            if (OnLoadData is not null) OnLoadData(this, new GpsdEventArg(model));

            return second as IGpsdModel;
        }
    }
}
