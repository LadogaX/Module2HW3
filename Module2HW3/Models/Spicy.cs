using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Module2HW3.Models
{
    public abstract class Spicy : VegetablesAboveGround
    {
        public Spicy(string name, int calories)
            : base(name, calories)
        {
        }
    }
}