using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Module2HW3.Models
{
    public abstract class VegetablesAboveGround : Vegetables
    {
        public VegetablesAboveGround(string name, int calories)
            : base(name, calories)
        {
                GrowthEnvironment = GrowthEnvironment.Soil;
        }

        public GrowthEnvironment GrowthEnvironment { get; set; }
    }
}