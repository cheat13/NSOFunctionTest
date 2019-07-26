using System.Collections.Generic;
using NSOFunctionTest.Models;
using NSOWater.HotMigration.Models;

namespace NSOFunctionTest
{
    public class SurveyData
    {
        public Survey Data1 { get; set; }
        public Survey Data2 { get; set; }
        public Survey Data3 { get; set; }
        public Survey Data4 { get; set; }
        public Survey Data5 { get; set; }

        public SurveyData()
        {
            var data = new Data();
            Data1 = new Survey
            {
                Unit = data.Unt1,
                Building = data.Bld1
            };
            Data2 = new Survey
            {
                Unit = data.Unt2,
                Building = data.Bld2
            };
            Data3 = new Survey
            {
                Unit = data.Unt3,
                Building = data.Bld3
            };
            Data4 = new Survey
            {
                Unit = data.Unt4,
                Building = data.Bld4
            };
            Data5 = new Survey
            {
                Unit = data.Unt5,
                Building = data.Bld5,
                Communities = new List<CommunitySample> { data.Com5_1, data.Com5_2 }
            };
        }
    }
}