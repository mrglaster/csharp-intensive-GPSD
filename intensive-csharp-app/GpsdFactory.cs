namespace intensive_csharp_app
{
    public class GpsdFactory
    {
        private IReadOnlyDictionary<string, Type> _map = new Dictionary<string, Type>
        {
            { "VERSION", typeof(GpsdVersionModel)}, 
            { "GST", typeof(GpsdGSTModel)},
            { "WATCH", typeof(GpsdWatchModel)},
            { "DEVICE", typeof(GpsdDeviceModel)},
            { "TPV", typeof(GpsdTPVModel)},
            { "SKY", typeof(GpsdSKYModel)}
        };

        public Type Create(string type) => _map.ContainsKey(type) ? _map[type] : throw new ArgumentException(message: nameof(type));
    }
}
