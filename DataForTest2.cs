using System.Collections.Generic;
using NSOFunction.Models;

namespace NSOFunctionTest
{
    public class DataForTest2
    {
        public static Data Data = new Data();
        public static IEnumerable<object[]> IsCommunityWaterManagementHasWaterTreatment = new List<object[]>
        {
            new object[] {
                Data.Com5_1,
                "test",
            },
            new object[] {
                Data.Com5_2,
                "test",
            },
        };
        public static IEnumerable<object[]> CountGroundWaterCommunity = new List<object[]>
        {
            new object[] {
                Data.Com5_1,
                0,
            },
            new object[] {
                Data.Com5_2,
                0,
            },
        };
        public static IEnumerable<object[]> FieldCommunity = new List<object[]>
        {
            new object[] {
                Data.Com5_1,
                0,
            },
            new object[] {
                Data.Com5_2,
                0,
            },
        };
        public static IEnumerable<object[]> CommunityNatureDisaster = new List<object[]>
        {
            new object[] {
                Data.Com5_1,
                0,
            },
            new object[] {
                Data.Com5_2,
                0,
            },
        };
        public static IEnumerable<object[]> WaterSourcesCommunity = new List<object[]>
        {
            new object[] {
                Data.Com5_1,
                new WaterSourcesCommunity {
                    Info = new List<WaterSourcesCommunityInfo> {
                        new WaterSourcesCommunityInfo {
                            Name = "อ่างห้วนริน (ข้างวัดบ้านโป่ง)",
                            Area_Code = "501601",
                            Capacity = 3*15*30
                        },
                        new WaterSourcesCommunityInfo {
                            Name = "อ่างห้วยริน (บนหมู่บ้าน)",
                            Area_Code = "501601",
                            Capacity = 4*20*40
                        },
                        new WaterSourcesCommunityInfo {
                            Name = "อ่างห้วยริน (บนดอย)",
                            Area_Code = "501601",
                            Capacity = 4*22*38
                        },
                    },
                    CubicMeter = (3*15*30)+(4*20*40)+(4*22*38)
                },
            },
            new object[] {
                Data.Com5_2,
                new WaterSourcesCommunity {
                    Info = new List<WaterSourcesCommunityInfo>(),
                    CubicMeter = 0
                },
            },
        };
        public static IEnumerable<object[]> CubicMeterGroundWater = new List<object[]>
        {
            new object[] {
                Data.Com5_1,
                new CubicMeterGroundWaterCommunity {
                    CubicMeterGroundWaterForAgriculture = 0,
                    CubicMeterGroundWaterForDrink = 0,
                    CubicMeterGroundWaterForUse = 0
                }
            },
            new object[] {
                Data.Com5_2,
                new CubicMeterGroundWaterCommunity {
                    CubicMeterGroundWaterForAgriculture = 0,
                    CubicMeterGroundWaterForDrink = 0,
                    CubicMeterGroundWaterForUse = 0
                }
            },
        };
        public static IEnumerable<object[]> CubicMeterSurfaceForAgriculture = new List<object[]>
        {
            new object[] {
                Data.Com5_1,
                0,
            },
            new object[] {
                Data.Com5_2,
                0,
            },
        };
        public static IEnumerable<object[]> CubicMeterSurfaceForDrink = new List<object[]>
        {
            new object[] {
                Data.Com5_1,
                20000*12,
            },
            new object[] {
                Data.Com5_2,
                0,
            },
        };
    }
}