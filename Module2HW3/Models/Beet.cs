using System.Drawing;

namespace Module2HW3.Models
{
    public class Beet : Root
    {
        public Beet(string name, int calories, TypeGroundVegitables typeGroundVegitables, GrowthEnvironment growthEnvironment, bool colorant)
            : base(name, calories, typeGroundVegitables, growthEnvironment)
        {
            Colorant = colorant;
        }

        public bool Colorant { get; set; }
    }
}
