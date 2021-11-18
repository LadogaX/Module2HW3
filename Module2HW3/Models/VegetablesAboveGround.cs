using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Module2HW3.Models
{
    public abstract class VegetablesAboveGround : Vegetables
    {
        public VegetablesAboveGround(string name, int calories, GrowthEnvironment growthEnvironment)
            : base(name, calories)
        {
                GrowthEnvironment = growthEnvironment;
        }

        public GrowthEnvironment GrowthEnvironment { get; set; }
    }
}