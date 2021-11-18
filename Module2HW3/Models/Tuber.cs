using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3.Models
{
    public abstract class Tuber : VegetablesInGroung
    {
        public Tuber(string name, int calories, TypeGroundVegitables typeGroundVegitables, GrowthEnvironment growthEnvironment)
            : base(name, calories, growthEnvironment)
        {
            TypeGroundVegitables = typeGroundVegitables;
        }

        public TypeGroundVegitables TypeGroundVegitables { get; set; }
    }
}
