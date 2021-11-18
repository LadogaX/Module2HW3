using System.Drawing;

namespace Module2HW3.Models
{
    public class JerusalemArtichoke : Tuber
    {
        public JerusalemArtichoke(string name, int calories, TypeGroundVegitables typeGroundVegitables, GrowthEnvironment growthEnvironment, double quontityVitaminC)
            : base(name, calories, typeGroundVegitables, growthEnvironment)
        {
            QuontityVitaminC = quontityVitaminC;
        }

        public double QuontityVitaminC { get; set; }
    }
}
