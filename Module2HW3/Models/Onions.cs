using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Module2HW3.Models
{
    public abstract class Onions : VegetablesAboveGround
    {
        public Onions(string name, int calories)
                   : base(name, calories)
        {
        }
    }
}