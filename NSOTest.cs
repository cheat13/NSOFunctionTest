using System;
using System.Collections.Generic;
using FluentAssertions;
using NSOFunction;
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

        [Theory]
        [MemberData(nameof(DataForTest1.Agriculture))]
        public void TestAgriculture(Survey survey, string expect)
        {
            var sut = new BaseFunction();
            var result = sut.Agriculture(survey.Unit);
            result.Should().BeEquivalentTo(expect);
        }

        [Theory]
        [MemberData(nameof(DataForTest1.IsHouseHoldGoodPlumbing))]
        public void TestIsHouseHoldGoodPlumbing(Survey survey, string expect)
        {
            var sut = new BaseFunction();
            var result = sut.IsHouseHoldGoodPlumbing(survey.Unit);
            result.Should().BeEquivalentTo(expect);
        }

        [Theory]
        [MemberData(nameof(DataForTest1.IsFactorialWaterQuality))]
        public void TestIsFactorialWaterQuality(Survey survey, string expect)
        {
            var sut = new BaseFunction();
            var result = sut.IsFactorialWaterQuality(survey.Unit);
            Assert.Equal(expect, result);
        }

        [Theory]
        [MemberData(nameof(DataForTest1.IsCommercialWaterQuality))]
        public void TestIsCommercialWaterQuality(Survey survey, string expect)
        {
            var sut = new BaseFunction();
            var result = sut.IsCommercialWaterQuality(survey.Unit);
            Assert.Equal(expect, result);
        }

        [Theory]
        [MemberData(nameof(DataForTest1.IsFactorial))]
        public void TestIsFactorial(Survey survey, string expect)
        {
            var sut = new BaseFunction();
            var result = sut.IsFactorial(survey.Unit);
            Assert.Equal(expect, result);
        }

        [Theory]
        [MemberData(nameof(DataForTest1.IsFactorialWaterTreatment))]
        public void TestIsFactorialWaterTreatment(Survey survey, string expect)
        {
            var sut = new BaseFunction();
            var result = sut.IsFactorialWaterTreatment(survey.Unit);
            Assert.Equal(expect, result);
        }

        [Theory]
        [MemberData(nameof(DataForTest1.CountGroundWaterHouseHold))]
        public void TestCountGroundWaterHouseHold(Survey survey, string expect)
        {
            var sut = new BaseFunction();
            var result = sut.CountGroundWaterHouseHold(survey.Unit);
            Assert.Equal(expect, result);
        }

        [Theory]
        [MemberData(nameof(DataForTest1.CountPopulation))]
        public void TestCountPopulation(Survey survey, string expect)
        {
            var sut = new BaseFunction();
            var result = sut.CountPopulation(survey.Unit);
            result.Should().BeEquivalentTo(expect);
        }

        [Theory]
        [MemberData(nameof(DataForTest1.Disasterous))]
        public void TestDisasterous(Survey survey, string expect)
        {
            var sut = new BaseFunction();
            var result = sut.Disasterous(survey.Unit);
            result.Should().BeEquivalentTo(expect);
        }

        [Theory]
        [MemberData(nameof(DataForTest1.HasntPlumbing))]
        public void TestHasntPlumbing(Survey survey, string expect)
        {
            var sut = new BaseFunction();
            var result = sut.HasntPlumbing(survey.Unit);
            Assert.Equal(expect, result);
        }

        [Theory]
        [MemberData(nameof(DataForTest1.PlumbingSeviceUsage))]
        public void TestPlumbingSeviceUsage(Survey survey, string expect)
        {
            var sut = new BaseFunction();
            var result = sut.PlumbingSeviceUsage(survey.Building, survey.Unit);
            result.Should().BeEquivalentTo(expect);
        }

        [Theory]
        [MemberData(nameof(DataForTest1.WaterSourcesHouseHold))]
        public void TestWaterSourcesHouseHold(Survey survey, string expect)
        {
            var sut = new BaseFunction();
            var result = sut.WaterSourcesHouseHold(survey.Unit);
            Assert.Equal(expect, result);
        }

        [Theory]
        [MemberData(nameof(DataForTest1.IndustryHasWasteWaterTreatment))]
        public void TestIndustryHasWasteWaterTreatment(Survey survey, string expect)
        {
            var sut = new BaseFunction();
            var result = sut.IndustryHasWasteWaterTreatment(survey.Unit);
            Assert.Equal(expect, result);
        }

        [Theory]
        [MemberData(nameof(DataForTest1.PeopleInFloodedArea))]
        public void TestPeopleInFloodedArea(Survey survey, string expect)
        {
            var sut = new BaseFunction();
            var result = sut.PeopleInFloodedArea(survey.Unit);
            Assert.Equal(expect, result);
        }

        [Theory]
        [MemberData(nameof(DataForTest1.CubicMeterGroundWater))]
        public void TestCubicMeterGroundWater(Survey survey, string expect)
        {
            var sut = new BaseFunction();
            var result = sut.CubicMeterGroundWater(survey.Unit, survey.Building);
            result.Should().BeEquivalentTo(expect);
        }

        [Theory]
        [MemberData(nameof(DataForTest1.CubicMeterPlumbing))]
        public void TestCubicMeterPlumbing(Survey survey, string expect)
        {
            var sut = new BaseFunction();
            var result = sut.CubicMeterPlumbing(survey.Unit);
            result.Should().BeEquivalentTo(expect);
        }

        [Theory]
        [MemberData(nameof(DataForTest1.CubicMeterSurface))]
        public void TestCubicMeterSurface(Survey survey, string expect)
        {
            var sut = new BaseFunction();
            var result = sut.CubicMeterSurface(survey.Unit);
            result.Should().BeEquivalentTo(expect);
        }

        #endregion

        #region สน.2

        [Theory]
        [MemberData(nameof(DataForTest2.IsCommunityWaterManagementHasWaterTreatment))]
        public void TestIsCommunityWaterManagementHasWaterTreatment(CommunitySample com, string expect)
        {
            var sut = new BaseFunction();
            var result = sut.IsCommunityWaterManagementHasWaterTreatment(com);
            Assert.Equal(expect, result);
        }

        [Theory]
        [MemberData(nameof(DataForTest2.CountGroundWaterCommunity))]
        public void TestCountGroundWaterCommunity(CommunitySample com, string expect)
        {
            var sut = new BaseFunction();
            var result = sut.CountGroundWaterCommunity(com);
            Assert.Equal(expect, result);
        }

        [Theory]
        [MemberData(nameof(DataForTest2.FieldCommunity))]
        public void TestFieldCommunity(CommunitySample com, string expect)
        {
            var sut = new BaseFunction();
            var result = sut.FieldCommunity(com);
            Assert.Equal(expect, result);
        }

        [Theory]
        [MemberData(nameof(DataForTest2.CommunityNatureDisaster))]
        public void TestCommunityNatureDisaster(CommunitySample com, string expect)
        {
            var sut = new BaseFunction();
            var result = sut.CommunityNatureDisaster(com);
            Assert.Equal(expect, result);
        }

        [Theory]
        [MemberData(nameof(DataForTest2.WaterSourcesCommunity))]
        public void TestWaterSourcesCommunity(CommunitySample com, string expect)
        {
            var sut = new BaseFunction();
            var result = sut.WaterSourcesCommunity(com);
            result.Should().BeEquivalentTo(expect);
        }

        [Theory]
        [MemberData(nameof(DataForTest2.CubicMeterGroundWater))]
        public void TestCubicMeterGroundWater2(CommunitySample com, string expect)
        {
            var sut = new BaseFunction();
            var result = sut.CubicMeterGroundWater(com);
            result.Should().BeEquivalentTo(expect);
        }

        [Theory]
        [MemberData(nameof(DataForTest2.CubicMeterSurfaceForAgriculture))]
        public void TestCubicMeterSurfaceForAgriculture(CommunitySample com, string expect)
        {
            var sut = new BaseFunction();
            var result = sut.CubicMeterSurfaceForAgriculture(com);
            Assert.Equal(expect, result);
        }

        [Theory]
        [MemberData(nameof(DataForTest2.CubicMeterSurfaceForDrink))]
        public void TestCubicMeterSurfaceForDrink(CommunitySample com, string expect)
        {
            var sut = new BaseFunction();
            var result = sut.CubicMeterSurfaceForDrink(com);
            Assert.Equal(expect, result);
        }

        #endregion
    }
}