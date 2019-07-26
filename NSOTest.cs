using System;
using System.Collections.Generic;
using FluentAssertions;
using NSOFunction;
using NSOWater.HotMigration.Models;
using Xunit;

namespace NSOFunctionTest
{
    public class NSOTest
    {
        public static Data Data = new Data();
        public static SurveyData SurveyData = new SurveyData();

        [Theory]
        [MemberData(nameof(GetSurveyData))]
        public void TestFunc(CommunitySample community, int expected)
        {
            var sut = new BaseFunction();
            var result = sut.IsCommunityWaterManagementHasWaterTreatment(community);
            result.Should().Be(expected);
        }

        public static IEnumerable<object[]> GetSurveyData = new List<object[]>
        {
            new object[] {
                Data.Com5_1,
                0
            },
            new object[] {
                Data.Com5_2,
                0
            }
        };
    }
}