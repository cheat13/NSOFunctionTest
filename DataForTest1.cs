using System.Collections.Generic;
using NSOFunction.Models;
using NSOWater.HotMigration.Models;

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
                new CubicMeterGroundWater {
                    PrivateDoing = false,
                    AllCount = 0,
                    PrivateWaterResourceCount = 0,
                    PrivateGroundWaterInfo = new List<GroundWaterInfo>(),
                    PublicDoing = false,
                    PublicWaterResourceCount = 0,
                    Package = new List<Package>(),
                    PublicWaterGroundWaterInfo = new List<GroundWaterInfo>(),
                    CanComputeCubicMeterGroundWaterForAgriculture = true,
                    CubicMeterGroundWaterForAgriculture = 0,
                    CanComputeCubicMeterGroundWaterForService = true,
                    CubicMeterGroundWaterForService = 0,
                    CanComputeCubicMeterGroundWaterForProduct = true,
                    CubicMeterGroundWaterForProduct = 0,
                    CanComputeCubicMeterGroundWaterForDrink = true,
                    CubicMeterGroundWaterForDrink = 0,
                    CanComputeCubicMeterGroundWaterForUse = true,
                    CubicMeterGroundWaterForUse = 0
                }
            },
            new object[] {
                SurveyData.Data2,
                new CubicMeterGroundWater {
                    PrivateDoing = false,
                    AllCount = 0,
                    PrivateWaterResourceCount = 0,
                    PrivateGroundWaterInfo = new List<GroundWaterInfo>(),
                    PublicDoing = false,
                    PublicWaterResourceCount = 0,
                    Package = new List<Package>(),
                    PublicWaterGroundWaterInfo = new List<GroundWaterInfo>(),
                    CanComputeCubicMeterGroundWaterForAgriculture = true,
                    CubicMeterGroundWaterForAgriculture = 0,
                    CanComputeCubicMeterGroundWaterForService = true,
                    CubicMeterGroundWaterForService = 0,
                    CanComputeCubicMeterGroundWaterForProduct = true,
                    CubicMeterGroundWaterForProduct = 0,
                    CanComputeCubicMeterGroundWaterForDrink = true,
                    CubicMeterGroundWaterForDrink = 0,
                    CanComputeCubicMeterGroundWaterForUse = true,
                    CubicMeterGroundWaterForUse = 0
                }
            },
            new object[] {
                SurveyData.Data3,
                new CubicMeterGroundWater {
                    PrivateDoing = false,
                    AllCount = 0,
                    PrivateWaterResourceCount = 0,
                    PrivateGroundWaterInfo = new List<GroundWaterInfo>(),
                    PublicDoing = false,
                    PublicWaterResourceCount = 0,
                    Package = new List<Package>(),
                    PublicWaterGroundWaterInfo = new List<GroundWaterInfo>(),
                    CanComputeCubicMeterGroundWaterForAgriculture = true,
                    CubicMeterGroundWaterForAgriculture = 0,
                    CanComputeCubicMeterGroundWaterForService = true,
                    CubicMeterGroundWaterForService = 0,
                    CanComputeCubicMeterGroundWaterForProduct = true,
                    CubicMeterGroundWaterForProduct = 0,
                    CanComputeCubicMeterGroundWaterForDrink = true,
                    CubicMeterGroundWaterForDrink = 0,
                    CanComputeCubicMeterGroundWaterForUse = true,
                    CubicMeterGroundWaterForUse = 0
                }
            },
            new object[] {
                SurveyData.Data4,
                new CubicMeterGroundWater {
                    PrivateDoing = false,
                    AllCount = 0,
                    PrivateWaterResourceCount = 0,
                    PrivateGroundWaterInfo = new List<GroundWaterInfo>(),
                    PublicDoing = false,
                    PublicWaterResourceCount = 0,
                    Package = new List<Package>(),
                    PublicWaterGroundWaterInfo = new List<GroundWaterInfo>(),
                    CanComputeCubicMeterGroundWaterForAgriculture = true,
                    CubicMeterGroundWaterForAgriculture = 0,
                    CanComputeCubicMeterGroundWaterForService = true,
                    CubicMeterGroundWaterForService = 0,
                    CanComputeCubicMeterGroundWaterForProduct = true,
                    CubicMeterGroundWaterForProduct = 0,
                    CanComputeCubicMeterGroundWaterForDrink = true,
                    CubicMeterGroundWaterForDrink = 0,
                    CanComputeCubicMeterGroundWaterForUse = true,
                    CubicMeterGroundWaterForUse = 0
                }
            },
            new object[] {
                SurveyData.Data5,
                new CubicMeterGroundWater {
                    PrivateDoing = false,
                    AllCount = 0,
                    PrivateWaterResourceCount = 0,
                    PrivateGroundWaterInfo = new List<GroundWaterInfo>(),
                    PublicDoing = false,
                    PublicWaterResourceCount = 0,
                    Package = new List<Package> {
                        new Package(),
                        new Package(),
                        new Package(),
                        new Package {
                            Name = "4. ขวด",
                            Size = 1000.0,
                            Drink = 20,
                            Agriculture = null,
                            Factory = 0,
                            Service = 0
                        },
                        new Package(),
                        new Package(),
                        new Package(),
                        new Package(),
                        new Package(),
                    },
                   PublicWaterGroundWaterInfo = new List<GroundWaterInfo>(),
                    CanComputeCubicMeterGroundWaterForAgriculture = true,
                    CubicMeterGroundWaterForAgriculture = 0,
                    CanComputeCubicMeterGroundWaterForService = true,
                    CubicMeterGroundWaterForService = 0,
                    CanComputeCubicMeterGroundWaterForProduct = true,
                    CubicMeterGroundWaterForProduct = 0,
                    CanComputeCubicMeterGroundWaterForDrink = true,
                    CubicMeterGroundWaterForDrink = 1000.0*20*12/1000000,
                    CanComputeCubicMeterGroundWaterForUse = true,
                    CubicMeterGroundWaterForUse = 1000.0*20*12/1000000
                }
            },
        };
        public static IEnumerable<object[]> CubicMeterPlumbing = new List<object[]>
        {
            new object[] {
                SurveyData.Data1,
                new CubicMeterPlumbing{
                    DoingMWA = false,
                    CubicMeterPerMonthMWA = 0,
                    WaterBillMWA = 0,
                    TurbidWaterMWA = false,
                    SaltWaterMWA = false,
                    SmellMWA = false,
                    FilmOfOilMWA = false,
                    FogWaterMWA = false,
                    HardWaterMWA = false,
                    AgricultureMWA = 0,
                    ServiceMWA = 0,
                    ProductMWA = 0,
                    DrinkMWA = 0,
                    PlantMWA = 0,
                    DoingPWA = false,
                    CubicMeterPerMonthPWA = 0,
                    WaterBillPWA = 0,
                    TurbidWaterPWA = false,
                    SaltWaterPWA = false,
                    SmellPWA = false,
                    FilmOfOilPWA = false,
                    FogWaterPWA = false,
                    HardWaterPWA = false,
                    AgriculturePWA = 0,
                    ServicePWA = 0,
                    ProductPWA = 0,
                    DrinkPWA = 0,
                    PlantPWA = 0,
                    DoingOther = true,
                    CubicMeterPerMonthOther = 0,
                    WaterBillOther = 200,
                    TurbidWaterOther = true,
                    SaltWaterOther = false,
                    SmellOther = false,
                    FilmOfOilOther = false,
                    FogWaterOther = false,
                    HardWaterOther = false,
                    AgricultureOther = 0,
                    ServiceOther = 0,
                    ProductOther = 0,
                    DrinkOther = 100,
                    PlantOther = 0,
                    MeterRentalFee = 0,
                    PlumbingPrice = 5,
                    CanComputeCubicMeterPlumbingForAgriculture = true,
                    CubicMeterPlumbingForAgriculture = 0,
                    CanComputeCubicMeterPlumbingForService = true,
                    CubicMeterPlumbingForService = 0,
                    CanComputeCubicMeterPlumbingForProduct = true,
                    CubicMeterPlumbingForProduct = 0,
                    CanComputeCubicMeterPlumbingForDrink = true,
                    CubicMeterPlumbingForDrink = 40
                },
            },
            new object[] {
                SurveyData.Data2,
                new CubicMeterPlumbing{
                    DoingMWA = true,
                    CubicMeterPerMonthMWA = 0,
                    WaterBillMWA = 200,
                    TurbidWaterMWA = false,
                    SaltWaterMWA = false,
                    SmellMWA = false,
                    FilmOfOilMWA = false,
                    FogWaterMWA = false,
                    HardWaterMWA = false,
                    AgricultureMWA = 0,
                    ServiceMWA = 0,
                    ProductMWA = 0,
                    DrinkMWA = 90,
                    PlantMWA = 10,
                    DoingPWA = false,
                    CubicMeterPerMonthPWA = 0,
                    WaterBillPWA = 0,
                    TurbidWaterPWA = false,
                    SaltWaterPWA = false,
                    SmellPWA = false,
                    FilmOfOilPWA = false,
                    FogWaterPWA = false,
                    HardWaterPWA = false,
                    AgriculturePWA = 0,
                    ServicePWA = 0,
                    ProductPWA = 0,
                    DrinkPWA = 0,
                    PlantPWA = 0,
                    DoingOther = false,
                    CubicMeterPerMonthOther = 0,
                    WaterBillOther = 0,
                    TurbidWaterOther = false,
                    SaltWaterOther = false,
                    SmellOther = false,
                    FilmOfOilOther = false,
                    FogWaterOther = false,
                    HardWaterOther = false,
                    AgricultureOther = 0,
                    ServiceOther = 0,
                    ProductOther = 0,
                    DrinkOther = 0,
                    PlantOther = 0,
                    MeterRentalFee = 0,
                    PlumbingPrice = 5,
                    CanComputeCubicMeterPlumbingForAgriculture = true,
                    CubicMeterPlumbingForAgriculture = 0,
                    CanComputeCubicMeterPlumbingForService = true,
                    CubicMeterPlumbingForService = 0,
                    CanComputeCubicMeterPlumbingForProduct = true,
                    CubicMeterPlumbingForProduct = 0,
                    CanComputeCubicMeterPlumbingForDrink = true,
                    CubicMeterPlumbingForDrink = (200*12/10.5)*(90.0/100)
                },
            },
            new object[] {
                SurveyData.Data3,
                new CubicMeterPlumbing{
                    DoingMWA = true,
                    CubicMeterPerMonthMWA = 0,
                    WaterBillMWA = 1800,
                    TurbidWaterMWA = false,
                    SaltWaterMWA = false,
                    SmellMWA = false,
                    FilmOfOilMWA = false,
                    FogWaterMWA = false,
                    HardWaterMWA = false,
                    AgricultureMWA = 0,
                    ServiceMWA = 0,
                    ProductMWA = 0,
                    DrinkMWA = 100,
                    PlantMWA = 0,
                    DoingPWA = false,
                    CubicMeterPerMonthPWA = 0,
                    WaterBillPWA = 0,
                    TurbidWaterPWA = false,
                    SaltWaterPWA = false,
                    SmellPWA = false,
                    FilmOfOilPWA = false,
                    FogWaterPWA = false,
                    HardWaterPWA = false,
                    AgriculturePWA = 0,
                    ServicePWA = 0,
                    ProductPWA = 0,
                    DrinkPWA = 0,
                    PlantPWA = 0,
                    DoingOther = false,
                    CubicMeterPerMonthOther = 0,
                    WaterBillOther = 0,
                    TurbidWaterOther = false,
                    SaltWaterOther = false,
                    SmellOther = false,
                    FilmOfOilOther = false,
                    FogWaterOther = false,
                    HardWaterOther = false,
                    AgricultureOther = 0,
                    ServiceOther = 0,
                    ProductOther = 0,
                    DrinkOther = 0,
                    PlantOther = 0,
                    MeterRentalFee = 0,
                    PlumbingPrice = 5,
                    CanComputeCubicMeterPlumbingForAgriculture = true,
                    CubicMeterPlumbingForAgriculture = 0,
                    CanComputeCubicMeterPlumbingForService = true,
                    CubicMeterPlumbingForService = 0,
                    CanComputeCubicMeterPlumbingForProduct = true,
                    CubicMeterPlumbingForProduct = 0,
                    CanComputeCubicMeterPlumbingForDrink = true,
                    CubicMeterPlumbingForDrink = (1800*12/10.5)*(100.0/100)
                },
            },
            new object[] {
                SurveyData.Data4,
                new CubicMeterPlumbing{
                    DoingMWA = true,
                    CubicMeterPerMonthMWA = 24,
                    WaterBillMWA = 0,
                    TurbidWaterMWA = false,
                    SaltWaterMWA = false,
                    SmellMWA = false,
                    FilmOfOilMWA = false,
                    FogWaterMWA = false,
                    HardWaterMWA = false,
                    AgricultureMWA = 0,
                    ServiceMWA = 0,
                    ProductMWA = 0,
                    DrinkMWA = 80,
                    PlantMWA = 20,
                    DoingPWA = false,
                    CubicMeterPerMonthPWA = 0,
                    WaterBillPWA = 0,
                    TurbidWaterPWA = false,
                    SaltWaterPWA = false,
                    SmellPWA = false,
                    FilmOfOilPWA = false,
                    FogWaterPWA = false,
                    HardWaterPWA = false,
                    AgriculturePWA = 0,
                    ServicePWA = 0,
                    ProductPWA = 0,
                    DrinkPWA = 0,
                    PlantPWA = 0,
                    DoingOther = false,
                    CubicMeterPerMonthOther = 0,
                    WaterBillOther = 0,
                    TurbidWaterOther = false,
                    SaltWaterOther = false,
                    SmellOther = false,
                    FilmOfOilOther = false,
                    FogWaterOther = false,
                    HardWaterOther = false,
                    AgricultureOther = 0,
                    ServiceOther = 0,
                    ProductOther = 0,
                    DrinkOther = 0,
                    PlantOther = 0,
                    MeterRentalFee = 0,
                    PlumbingPrice = 5,
                    CanComputeCubicMeterPlumbingForAgriculture = true,
                    CubicMeterPlumbingForAgriculture = 0,
                    CanComputeCubicMeterPlumbingForService = true,
                    CubicMeterPlumbingForService = 0,
                    CanComputeCubicMeterPlumbingForProduct = true,
                    CubicMeterPlumbingForProduct = 0,
                    CanComputeCubicMeterPlumbingForDrink = true,
                    CubicMeterPlumbingForDrink =  (24*12)*(80.0/100)
                },
            },
            new object[] {
                SurveyData.Data5,
                new CubicMeterPlumbing{
                    DoingMWA = false,
                    CubicMeterPerMonthMWA = 0,
                    WaterBillMWA = 0,
                    TurbidWaterMWA = false,
                    SaltWaterMWA = false,
                    SmellMWA = false,
                    FilmOfOilMWA = false,
                    FogWaterMWA = false,
                    HardWaterMWA = false,
                    AgricultureMWA = 0,
                    ServiceMWA = 0,
                    ProductMWA = 0,
                    DrinkMWA = 0,
                    PlantMWA = 0,
                    DoingPWA = true,
                    CubicMeterPerMonthPWA = 0,
                    WaterBillPWA = 119.20,
                    TurbidWaterPWA = true,
                    SaltWaterPWA = false,
                    SmellPWA = false,
                    FilmOfOilPWA = false,
                    FogWaterPWA = false,
                    HardWaterPWA = false,
                    AgriculturePWA = 50,
                    ServicePWA = 0,
                    ProductPWA = 0,
                    DrinkPWA = 40,
                    PlantPWA = 10,
                    DoingOther = false,
                    CubicMeterPerMonthOther = 0,
                    WaterBillOther = 0,
                    TurbidWaterOther = false,
                    SaltWaterOther = false,
                    SmellOther = false,
                    FilmOfOilOther = false,
                    FogWaterOther = false,
                    HardWaterOther = false,
                    AgricultureOther = 0,
                    ServiceOther = 0,
                    ProductOther = 0,
                    DrinkOther = 0,
                    PlantOther = 0,
                    MeterRentalFee = 0,
                    PlumbingPrice = 6,
                    CanComputeCubicMeterPlumbingForAgriculture = true,
                    CubicMeterPlumbingForAgriculture = (119.20*12/26)*(50.0/100),
                    CanComputeCubicMeterPlumbingForService = true,
                    CubicMeterPlumbingForService = 0,
                    CanComputeCubicMeterPlumbingForProduct = true,
                    CubicMeterPlumbingForProduct = 0,
                    CanComputeCubicMeterPlumbingForDrink = true,
                    CubicMeterPlumbingForDrink = (119.20*12/26)*(40.0/100)
                },
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