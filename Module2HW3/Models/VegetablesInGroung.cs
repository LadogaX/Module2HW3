using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3.Models
{
    public abstract class VegetablesInGroung : Vegetables
    {
        public VegetablesInGroung(string name, int calories, GrowthEnvironment growthEnvironment)
            : base(name, calories)
        {
            GrowthEnvironment = growthEnvironment;
        }

        public GrowthEnvironment GrowthEnvironment { get; set; }
    }
}
