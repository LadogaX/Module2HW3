using System.Drawing;

namespace Module2HW3.Models
{
    public class Carrot : Root
    {
        public Carrot(string name, int calories, TypeGroundVegitables typeGroundVegitables, GrowthEnvironment growthEnvironment, bool сontainsСarotene)
            : base(name, calories, typeGroundVegitables, growthEnvironment)
        {
            СontainsСarotene = сontainsСarotene;
        }

        public bool СontainsСarotene { get; set; }
    }
}