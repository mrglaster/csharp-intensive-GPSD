using intensive_csharp_app;
namespace IntensiveUnitTests
{
    public class Tests
    {


        [Test]
        public void check_GetHeaderForSelectQuerry() {
            var item = new GpsdVersionModel()
            {
                Class = "Version",
                Major = 1,
                Release = "test",
                Revision = "test"
            };
            var result = ReflectionHelper.generateSqlQuerryGet(item);
            ReflectionHelper.selectThrow(result);
            Console.WriteLine(result);
            Assert.IsNotNull(result);   
        }


        [Test]
        public void check_Helper_properties() {
            var item = new GpsdVersionModel() {
                Class = "Version",
                Major = 1,
                Release = "test",
                Revision = "test"
            };

            var result = ReflectionHelper.GetProperties(item);
            Assert.IsTrue(result.Any());
            foreach (var key in result.Keys) {
                Console.WriteLine($"{key} : {result[key]}");
            }


        }


        [Test]
        [TestCase(typeof(GpsdVersionModel))]
        [TestCase(typeof(GpsdSateliteModel))]
        [TestCase(typeof(GpsdSKYModel))]
        public void Check_Helper_GetTable(Type type) {
            var result = ReflectionHelper.GetTableName(type);
            Console.WriteLine(result);
            Assert.IsFalse(string.IsNullOrEmpty(result));

        }


        [Test]
        [TestCase ("{\"class\":\"VERSION\",\"release\":\"3.17\",\"rev\":\"3.17\",\"proto_major\":3,\"proto_minor\":12}")]
        [TestCase("{\"class\":\"GST\",\"device\":\"/dev/pts/2\",\"time\":\"2022-07-07T04:04:14.000Z\",\"rms\":2.800,\"major\":1391.000,\"minor\":50.000,\"orient\":91.700,\"lat\":65.000,\"lon\":1390.000,\"alt\":985.000}")]
        public void checkGPSDModel_classDetectionTest(string data)
        {
            var manager = new GpsdManager();


            manager.OnLoadData = (sender, args) => {
                var item = args as GpsdEventArg;
                if (item is null) return;
                Console.WriteLine(item.Model);
            };


            var result = manager.LoadData(data);
            Assert.Pass();
        }

        [Test]
        [TestCase("GST", typeof(GpsdGSTModel))]
        [TestCase("VERSION", typeof(GpsdVersionModel))]
        [TestCase("WATCH", typeof(GpsdWatchModel))]
        [TestCase("DEVICE", typeof(GpsdDeviceModel))]
        [TestCase("TPV", typeof(GpsdTPVModel))]
        [TestCase("SKY", typeof(GpsdSKYModel))]
        public void checkFactory(string type, Type assertType) {
            var factory = new GpsdFactory();
            var resut = factory.Create(type);
            Assert.That(resut, Is.EqualTo(assertType));

        }

    }
}