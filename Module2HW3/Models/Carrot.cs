using System.Drawing;

namespace Module2HW3.Models
{
    public class Carrot : Root
    {
        public Carrot(string name, int calories, TypeGroundVegitables typeGroundVegitables, GrowthEnvironment growthEnvironment, bool isHighVitaminA)
            : base(name, calories, typeGroundVegitables, growthEnvironment)
        {
            IsHighVitaminA = isHighVitaminA;
        }

        public bool IsHighVitaminA { get; set; }
    }
}