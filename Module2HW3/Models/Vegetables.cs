using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3.Models
{
    public abstract class Vegetables
    {
        public Vegetables(string name)
        {
            Name = name;
        }

        public Vegetables(string name, int calories)
            : this(name)
        {
            Calories = calories;
        }

        public string Name { get; set; }

        public int Calories { get; set; }
    }
}
