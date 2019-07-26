using System.Collections.Generic;
using NSOWater.HotMigration.Models;

namespace NSOFunctionTest.Models
{
    public class Survey
    {
        public BuildingSample Building { get; set; }
        public HouseHoldSample Unit { get; set; }
        public List<CommunitySample> Communities { get; set; }
    }
}