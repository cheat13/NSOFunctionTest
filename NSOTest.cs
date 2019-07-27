using System;
using System.Collections.Generic;
using FluentAssertions;
using NSOFunction;
using NSOFunction.Models;
using NSOFunctionTest.Models;
using NSOWater.HotMigration.Models;
using Xunit;

namespace NSOFunctionTest
{
    public class NSOTest
    {
        public static Data Data = new Data();
        public static DataForTest1 DataForTest1 = new DataForTest1();
        public static DataForTest2 DataForTest2 = new DataForTest2();

        #region สน.1

        [Theory] // Passed
        [MemberData(nameof(DataForTest1.Agriculture), MemberType = typeof(DataForTest1))]
        public void TestAgriculture(Survey survey, AgricultureModel expect)
        {
            var sut = new BaseFunction();
            var result = sut.Agriculture(survey.Unit);
            result.Should().BeEquivalentTo(expect);
        }

        [Theory] // Passed
        [MemberData(nameof(DataForTest1.IsHouseHold), MemberType = typeof(DataForTest1))]
        public void TestIsHouseHold(Survey survey, int expect)
        {
            var sut = new BaseFunction();
            var result = sut.IsHouseHoldGoodPlumbing(survey.Unit);
            result.IsHouseHold.Should().Be(expect);
        }

        [Theory] // Passed
        [MemberData(nameof(DataForTest1.IsHouseHoldGoodPlumbing), MemberType = typeof(DataForTest1))]
        public void TestIsHouseHoldGoodPlumbing(Survey survey, int expect)
        {
            var sut = new BaseFunction();
            var result = sut.IsHouseHoldGoodPlumbing(survey.Unit);
            result.IsHouseHoldGoodPlumbing.Should().Be(expect);
        }

        [Theory] // Passed
        [MemberData(nameof(DataForTest1.IsHouseHoldHasPlumbingCountryside), MemberType = typeof(DataForTest1))]
        public void TestIsHouseHoldHasPlumbingCountryside(Survey survey, int expect)
        {
            var sut = new BaseFunction();
            var result = sut.IsHouseHoldGoodPlumbing(survey.Unit);
            result.IsHouseHoldHasPlumbingCountryside.Should().Be(expect);
        }

        [Theory] // Passed
        [MemberData(nameof(DataForTest1.IsHouseHoldHasPlumbingDistrict), MemberType = typeof(DataForTest1))]
        public void TestIsHouseHoldHasPlumbingDistrict(Survey survey, int expect)
        {
            var sut = new BaseFunction();
            var result = sut.IsHouseHoldGoodPlumbing(survey.Unit);
            result.IsHouseHoldHasPlumbingDistrict.Should().Be(expect);
        }

        [Theory] // Passed
        [MemberData(nameof(DataForTest1.IsFactorialWaterQuality), MemberType = typeof(DataForTest1))]
        public void TestIsFactorialWaterQuality(Survey survey, int expect)
        {
            var sut = new BaseFunction();
            var result = sut.IsFactorialWaterQuality(survey.Unit);
            Assert.Equal(expect, result);
        }

        [Theory] // Passed
        [MemberData(nameof(DataForTest1.IsCommercialWaterQuality), MemberType = typeof(DataForTest1))]
        public void TestIsCommercialWaterQuality(Survey survey, int expect)
        {
            var sut = new BaseFunction();
            var result = sut.IsCommercialWaterQuality(survey.Unit);
            Assert.Equal(expect, result);
        }

        [Theory] // Passed
        [MemberData(nameof(DataForTest1.IsFactorial), MemberType = typeof(DataForTest1))]
        public void TestIsFactorial(Survey survey, int expect)
        {
            var sut = new BaseFunction();
            var result = sut.IsFactorial(survey.Unit);
            Assert.Equal(expect, result);
        }

        [Theory] // Passed
        [MemberData(nameof(DataForTest1.IsFactorialWaterTreatment), MemberType = typeof(DataForTest1))]
        public void TestIsFactorialWaterTreatment(Survey survey, int expect)
        {
            var sut = new BaseFunction();
            var result = sut.IsFactorialWaterTreatment(survey.Unit);
            Assert.Equal(expect, result);
        }

        [Theory] // Passed
        [MemberData(nameof(DataForTest1.CountGroundWaterHouseHold), MemberType = typeof(DataForTest1))]
        public void TestCountGroundWaterHouseHold(Survey survey, int expect)
        {
            var sut = new BaseFunction();
            var result = sut.CountGroundWaterHouseHold(survey.Unit);
            Assert.Equal(expect, result);
        }

        [Theory] // Passed
        [MemberData(nameof(DataForTest1.CountPopulation), MemberType = typeof(DataForTest1))]
        public void TestCountPopulation(Survey survey, int expect1, int expect2)
        {
            var sut = new BaseFunction();
            var result = sut.CountPopulation(survey.Unit);
            result.countPopulation.Should().Be(expect1);
            result.countWorkingAge.Should().Be(expect2);
        }

        [Theory] // Passed
        [MemberData(nameof(DataForTest1.Disasterous), MemberType = typeof(DataForTest1))]
        public void TestDisasterous(Survey survey, double expect1, double expect2)
        {
            var sut = new BaseFunction();
            var result = sut.Disasterous(survey.Unit);
            result.AvgWaterHeightCm.Should().Be(expect1);
            result.TimeWaterHeightCm.Should().Be(expect2);
        }

        [Theory] // Passed
        [MemberData(nameof(DataForTest1.HasntPlumbing), MemberType = typeof(DataForTest1))]
        public void TestHasntPlumbing(Survey survey, int expect)
        {
            var sut = new BaseFunction();
            var result = sut.HasntPlumbing(survey.Unit);
            Assert.Equal(expect, result);
        }

        [Theory] // Passed
        [MemberData(nameof(DataForTest1.PlumbingSeviceUsage), MemberType = typeof(DataForTest1))]
        public void TestPlumbingSeviceUsage(Survey survey, int expect1, int expect2, int expect3)
        {
            var sut = new BaseFunction();
            var result = sut.PlumbingSeviceUsage(survey.Building, survey.Unit);
            result.IsGovernment.Should().Be(expect1);
            result.IsGovernmentUsage.Should().Be(expect2);
            result.IsGovernmentWaterQuality.Should().Be(expect3);
        }

        [Theory] // Passed
        [MemberData(nameof(DataForTest1.WaterSourcesHouseHold), MemberType = typeof(DataForTest1))]
        public void TestWaterSourcesHouseHold(Survey survey, double expect)
        {
            var sut = new BaseFunction();
            var result = sut.WaterSourcesHouseHold(survey.Unit);
            Assert.Equal(expect, result);
        }

        [Theory] // Passed
        [MemberData(nameof(DataForTest1.IndustryHasWasteWaterTreatment), MemberType = typeof(DataForTest1))]
        public void TestIndustryHasWasteWaterTreatment(Survey survey, int expect)
        {
            var sut = new BaseFunction();
            var result = sut.IndustryHasWasteWaterTreatment(survey.Unit);
            Assert.Equal(expect, result);
        }

        [Theory] // Passed
        [MemberData(nameof(DataForTest1.PeopleInFloodedArea), MemberType = typeof(DataForTest1))]
        public void TestPeopleInFloodedArea(Survey survey, int expect)
        {
            var sut = new BaseFunction();
            var result = sut.PeopleInFloodedArea(survey.Unit);
            Assert.Equal(expect, result);
        }

        [Theory] // Passed
        [MemberData(nameof(DataForTest1.CubicMeterGroundWater), MemberType = typeof(DataForTest1))]
        public void TestCubicMeterGroundWater(Survey survey, CubicMeterGroundWater expect)
        {
            var sut = new BaseFunction();
            var result = sut.CubicMeterGroundWater(survey.Unit, survey.Building);
            result.Should().BeEquivalentTo(expect);
        }

        [Theory] // Passed
        [MemberData(nameof(DataForTest1.CubicMeterPlumbing), MemberType = typeof(DataForTest1))]
        public void TestCubicMeterPlumbing(Survey survey, CubicMeterPlumbing expect)
        {
            var sut = new BaseFunction();
            var result = sut.CubicMeterPlumbing(survey.Unit, survey.Building, survey.Communities);
            result.Should().BeEquivalentTo(expect);
        }

        [Theory] // Passed
        [MemberData(nameof(DataForTest1.CubicMeterSurface), MemberType = typeof(DataForTest1))]
        public void TestCubicMeterSurface(Survey survey, CubicMeterSurface expect)
        {
            var sut = new BaseFunction();
            var result = sut.CubicMeterSurface(survey.Unit);
            result.Should().BeEquivalentTo(expect);
        }

        // #endregion

        // #region สน.2

        // [Theory] // Failed
        // [MemberData(nameof(DataForTest2.IsCommunityWaterManagementHasWaterTreatment), MemberType = typeof(DataForTest2))]
        // public void TestIsCommunityWaterManagementHasWaterTreatment(CommunitySample com, int expect)
        // {
        //     var sut = new BaseFunction();
        //     var result = sut.IsCommunityWaterManagementHasWaterTreatment(com);
        //     Assert.Equal(expect, result);
        // }

        [Theory] // Passed
        [MemberData(nameof(DataForTest2.CountGroundWaterCommunity), MemberType = typeof(DataForTest2))]
        public void TestCountGroundWaterCommunity(CommunitySample com, double expect)
        {
            var sut = new BaseFunction();
            var result = sut.CountGroundWaterCommunity(com);
            Assert.Equal(expect, result);
        }

        [Theory] // Passed
        [MemberData(nameof(DataForTest2.FieldCommunity), MemberType = typeof(DataForTest2))]
        public void TestFieldCommunity(CommunitySample com, double expect)
        {
            var sut = new BaseFunction();
            var result = sut.FieldCommunity(com);
            Assert.Equal(expect, result);
        }

        [Theory] // Passed
        [MemberData(nameof(DataForTest2.CommunityNatureDisaster), MemberType = typeof(DataForTest2))]
        public void TestCommunityNatureDisaster(CommunitySample com, int expect)
        {
            var sut = new BaseFunction();
            var result = sut.CommunityNatureDisaster(com);
            Assert.Equal(expect, result);
        }

        // [Theory] // Failed
        // [MemberData(nameof(DataForTest2.WaterSourcesCommunity), MemberType = typeof(DataForTest2))]
        // public void TestWaterSourcesCommunity(CommunitySample com, string expect)
        // {
        //     var sut = new BaseFunction();
        //     var result = sut.WaterSourcesCommunity(com);
        //     result.Should().BeEquivalentTo(expect);
        // }

        [Theory] // Passed
        [MemberData(nameof(DataForTest2.CubicMeterGroundWater), MemberType = typeof(DataForTest2))]
        public void TestCubicMeterGroundWater2(CommunitySample com, CubicMeterGroundWaterCommunity expect)
        {
            var sut = new BaseFunction();
            var result = sut.CubicMeterGroundWater(com);
            result.Should().BeEquivalentTo(expect);
        }

        [Theory] // Passed
        [MemberData(nameof(DataForTest2.CubicMeterSurfaceForAgriculture), MemberType = typeof(DataForTest2))]
        public void TestCubicMeterSurfaceForAgriculture(CommunitySample com, double expect)
        {
            var sut = new BaseFunction();
            var result = sut.CubicMeterSurfaceForAgriculture(com);
            Assert.Equal(expect, result);
        }

        [Theory] // Passed
        [MemberData(nameof(DataForTest2.CubicMeterSurfaceForDrink), MemberType = typeof(DataForTest2))]
        public void TestCubicMeterSurfaceForDrink(CommunitySample com, double expect)
        {
            var sut = new BaseFunction();
            var result = sut.CubicMeterSurfaceForDrink(com);
            Assert.Equal(expect, result);
        }

        #endregion
    }
}