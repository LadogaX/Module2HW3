using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3.Models
{
    public abstract class Tuber : VegetablesInGroung
    {
        public Tuber(string name, int calories)
            : base(name, calories)
        {
            TypeGroundVegitables = TypeGroundVegitables.TuberVegetable;
        }

        public TypeGroundVegitables TypeGroundVegitables { get; set; }
    }
}
