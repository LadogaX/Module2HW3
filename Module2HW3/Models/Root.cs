using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3.Models
{
    public abstract class Root : VegetablesInGroung
    {
        public Root(string name, int calories)
           : base(name, calories)
        {
            TypeGroundVegitables = TypeGroundVegitables.RootVegetable;
        }

        public TypeGroundVegitables TypeGroundVegitables { get; set; }
    }
}
