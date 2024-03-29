using Newtonsoft.Json;
using NSOWater.HotMigration.Models;

namespace NSOFunctionTest
{
    public class Data
    {
        public HouseHoldSample Unt1 { get; set; }
        public HouseHoldSample Unt2 { get; set; }
        public HouseHoldSample Unt3 { get; set; }
        public HouseHoldSample Unt4 { get; set; }
        public HouseHoldSample Unt5 { get; set; }
        public HouseHoldSample Unt6 { get; set; }
        public HouseHoldSample Unt7 { get; set; }
        public BuildingSample Bld1 { get; set; }
        public BuildingSample Bld2 { get; set; }
        public BuildingSample Bld3 { get; set; }
        public BuildingSample Bld4 { get; set; }
        public BuildingSample Bld5 { get; set; }
        public CommunitySample Com5_1 { get; set; }
        public CommunitySample Com5_2 { get; set; }
        public CommunitySample Com8_1 { get; set; }

        public Data()
        {
            Unt1 = JsonConvert.DeserializeObject<HouseHoldSample>(ReadText(@"..\..\..\RawFile\unt1.json"));
            Unt2 = JsonConvert.DeserializeObject<HouseHoldSample>(ReadText(@"..\..\..\RawFile\unt2.json"));
            Unt3 = JsonConvert.DeserializeObject<HouseHoldSample>(ReadText(@"..\..\..\RawFile\unt3.json"));
            Unt4 = JsonConvert.DeserializeObject<HouseHoldSample>(ReadText(@"..\..\..\RawFile\unt4.json"));
            Unt5 = JsonConvert.DeserializeObject<HouseHoldSample>(ReadText(@"..\..\..\RawFile\unt5.json"));
            Unt6 = JsonConvert.DeserializeObject<HouseHoldSample>(ReadText(@"..\..\..\RawFile\unt6.json"));
            Unt7 = JsonConvert.DeserializeObject<HouseHoldSample>(ReadText(@"..\..\..\RawFile\unt7.json"));
            Bld1 = JsonConvert.DeserializeObject<BuildingSample>(ReadText(@"..\..\..\RawFile\bld1.json"));
            Bld2 = JsonConvert.DeserializeObject<BuildingSample>(ReadText(@"..\..\..\RawFile\bld2.json"));
            Bld3 = JsonConvert.DeserializeObject<BuildingSample>(ReadText(@"..\..\..\RawFile\bld3.json"));
            Bld4 = JsonConvert.DeserializeObject<BuildingSample>(ReadText(@"..\..\..\RawFile\bld4.json"));
            Bld5 = JsonConvert.DeserializeObject<BuildingSample>(ReadText(@"..\..\..\RawFile\bld5.json"));
            Com5_1 = JsonConvert.DeserializeObject<CommunitySample>(ReadText(@"..\..\..\RawFile\com5_1.json"));
            Com5_2 = JsonConvert.DeserializeObject<CommunitySample>(ReadText(@"..\..\..\RawFile\com5_2.json"));
            Com8_1 = JsonConvert.DeserializeObject<CommunitySample>(ReadText(@"..\..\..\RawFile\com8_1.json"));
        }

        public string ReadText(string path)
        {
            return System.IO.File.OpenText(path).ReadToEnd();
        }
    }
}