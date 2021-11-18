using System.Drawing;

namespace Module2HW3.Models
{
    public class Potato : Tuber
    {
        public Potato(string name, int calories, TypeGroundVegitables typeGroundVegitables, GrowthEnvironment growthEnvironment, double quontitystarch)
            : base(name, calories, typeGroundVegitables, growthEnvironment)
        {
            QuontityStarch = quontitystarch;
        }

        public double QuontityStarch { get; set; }
    }
}
