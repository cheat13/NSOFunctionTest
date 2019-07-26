using System.Collections.Generic;
using NSOFunction.Models;

namespace NSOFunctionTest
{
    public class DataForTest1
    {
        public static SurveyData SurveyData = new SurveyData();
        public static IEnumerable<object[]> Agriculture = new List<object[]>
        {
            new object[] {
                SurveyData.Data1,
                new AgricultureModel{
                    IsAgriculture = 0,
                    IsAgricultureHasIrrigationField = 0
                },
            },
            new object[] {
                SurveyData.Data2,
                new AgricultureModel{
                    IsAgriculture = 0,
                    IsAgricultureHasIrrigationField = 0
                },
            },
            new object[] {
                SurveyData.Data3,
                new AgricultureModel{
                    IsAgriculture = 0,
                    IsAgricultureHasIrrigationField = 0
                },
            },
            new object[] {
                SurveyData.Data4,
                new AgricultureModel{
                    IsAgriculture = 0,
                    IsAgricultureHasIrrigationField = 0
                },
            },
            new object[] {
                SurveyData.Data5,
                new AgricultureModel{
                    IsAgriculture = 1,
                    IsAgricultureHasIrrigationField = 0
                },
            },
        };
        public static IEnumerable<object[]> IsHouseHoldGoodPlumbing = new List<object[]>
        {
            new object[] {
                SurveyData.Data1,
                "test",
            },
            new object[] {
                SurveyData.Data2,
                "test",
            },
            new object[] {
                SurveyData.Data3,
                "test",
            },
            new object[] {
                SurveyData.Data4,
                "test",
            },
            new object[] {
                SurveyData.Data5,
                "test",
            },
        };
        public static IEnumerable<object[]> IsFactorialWaterQuality = new List<object[]>
        {
            new object[] {
                SurveyData.Data1,
                "test",
            },
            new object[] {
                SurveyData.Data2,
                "test",
            },
            new object[] {
                SurveyData.Data3,
                "test",
            },
            new object[] {
                SurveyData.Data4,
                "test",
            },
            new object[] {
                SurveyData.Data5,
                "test",
            },
        };
        public static IEnumerable<object[]> IsCommercialWaterQuality = new List<object[]>
        {
            new object[] {
                SurveyData.Data1,
                "test",
            },
            new object[] {
                SurveyData.Data2,
                "test",
            },
            new object[] {
                SurveyData.Data3,
                "test",
            },
            new object[] {
                SurveyData.Data4,
                "test",
            },
            new object[] {
                SurveyData.Data5,
                "test",
            },
        };
        public static IEnumerable<object[]> IsFactorial = new List<object[]>
        {
            new object[] {
                SurveyData.Data1,
                "test",
            },
            new object[] {
                SurveyData.Data2,
                "test",
            },
            new object[] {
                SurveyData.Data3,
                "test",
            },
            new object[] {
                SurveyData.Data4,
                "test",
            },
            new object[] {
                SurveyData.Data5,
                "test",
            },
        };
        public static IEnumerable<object[]> IsFactorialWaterTreatment = new List<object[]>
        {
            new object[] {
                SurveyData.Data1,
                "test",
            },
            new object[] {
                SurveyData.Data2,
                "test",
            },
            new object[] {
                SurveyData.Data3,
                "test",
            },
            new object[] {
                SurveyData.Data4,
                "test",
            },
            new object[] {
                SurveyData.Data5,
                "test",
            },
        };
        public static IEnumerable<object[]> CountGroundWaterHouseHold = new List<object[]>
        {
            new object[] {
                SurveyData.Data1,
                "test",
            },
            new object[] {
                SurveyData.Data2,
                "test",
            },
            new object[] {
                SurveyData.Data3,
                "test",
            },
            new object[] {
                SurveyData.Data4,
                "test",
            },
            new object[] {
                SurveyData.Data5,
                "test",
            },
        };
        public static IEnumerable<object[]> CountPopulation = new List<object[]>
        {
            new object[] {
                SurveyData.Data1,
                "test",
            },
            new object[] {
                SurveyData.Data2,
                "test",
            },
            new object[] {
                SurveyData.Data3,
                "test",
            },
            new object[] {
                SurveyData.Data4,
                "test",
            },
            new object[] {
                SurveyData.Data5,
                "test",
            },
        };
        public static IEnumerable<object[]> Disasterous = new List<object[]>
        {
            new object[] {
                SurveyData.Data1,
                "test",
            },
            new object[] {
                SurveyData.Data2,
                "test",
            },
            new object[] {
                SurveyData.Data3,
                "test",
            },
            new object[] {
                SurveyData.Data4,
                "test",
            },
            new object[] {
                SurveyData.Data5,
                "test",
            },
        };
        public static IEnumerable<object[]> HasntPlumbing = new List<object[]>
        {
            new object[] {
                SurveyData.Data1,
                "test",
            },
            new object[] {
                SurveyData.Data2,
                "test",
            },
            new object[] {
                SurveyData.Data3,
                "test",
            },
            new object[] {
                SurveyData.Data4,
                "test",
            },
            new object[] {
                SurveyData.Data5,
                "test",
            },
        };
        public static IEnumerable<object[]> PlumbingSeviceUsage = new List<object[]>
        {
            new object[] {
                SurveyData.Data1,
                "test",
            },
            new object[] {
                SurveyData.Data2,
                "test",
            },
            new object[] {
                SurveyData.Data3,
                "test",
            },
            new object[] {
                SurveyData.Data4,
                "test",
            },
            new object[] {
                SurveyData.Data5,
                "test",
            },
        };
        public static IEnumerable<object[]> WaterSourcesHouseHold = new List<object[]>
        {
            new object[] {
                SurveyData.Data1,
                "test",
            },
            new object[] {
                SurveyData.Data2,
                "test",
            },
            new object[] {
                SurveyData.Data3,
                "test",
            },
            new object[] {
                SurveyData.Data4,
                "test",
            },
            new object[] {
                SurveyData.Data5,
                "test",
            },
        };
        public static IEnumerable<object[]> IndustryHasWasteWaterTreatment = new List<object[]>
        {
            new object[] {
                SurveyData.Data1,
                "test",
            },
            new object[] {
                SurveyData.Data2,
                "test",
            },
            new object[] {
                SurveyData.Data3,
                "test",
            },
            new object[] {
                SurveyData.Data4,
                "test",
            },
            new object[] {
                SurveyData.Data5,
                "test",
            },
        };
        public static IEnumerable<object[]> PeopleInFloodedArea = new List<object[]>
        {
            new object[] {
                SurveyData.Data1,
                "test",
            },
            new object[] {
                SurveyData.Data2,
                "test",
            },
            new object[] {
                SurveyData.Data3,
                "test",
            },
            new object[] {
                SurveyData.Data4,
                "test",
            },
            new object[] {
                SurveyData.Data5,
                "test",
            },
        };
        public static IEnumerable<object[]> CubicMeterGroundWater = new List<object[]>
        {
            new object[] {
                SurveyData.Data1,
                "test",
            },
            new object[] {
                SurveyData.Data2,
                "test",
            },
            new object[] {
                SurveyData.Data3,
                "test",
            },
            new object[] {
                SurveyData.Data4,
                "test",
            },
            new object[] {
                SurveyData.Data5,
                "test",
            },
        };
        public static IEnumerable<object[]> CubicMeterPlumbing = new List<object[]>
        {
            new object[] {
                SurveyData.Data1,
                "test",
            },
            new object[] {
                SurveyData.Data2,
                "test",
            },
            new object[] {
                SurveyData.Data3,
                "test",
            },
            new object[] {
                SurveyData.Data4,
                "test",
            },
            new object[] {
                SurveyData.Data5,
                "test",
            },
        };
        public static IEnumerable<object[]> CubicMeterSurface = new List<object[]>
        {
            new object[] {
                SurveyData.Data1,
                "test",
            },
            new object[] {
                SurveyData.Data2,
                "test",
            },
            new object[] {
                SurveyData.Data3,
                "test",
            },
            new object[] {
                SurveyData.Data4,
                "test",
            },
            new object[] {
                SurveyData.Data5,
                "test",
            },
        };
    }
}