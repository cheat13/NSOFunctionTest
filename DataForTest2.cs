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
                "test",
            },
            new object[] {
                Data.Com5_2,
                "test",
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