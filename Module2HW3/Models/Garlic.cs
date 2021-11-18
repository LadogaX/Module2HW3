using System.Drawing;

namespace Module2HW3.Models
{
    public class Garlic : Onions
    {
        public Garlic(string name, int calories, GrowthEnvironment growthEnvironment, TypePlantShoot typePlantShoot, bool antiBacterial)
            : base(name, calories, growthEnvironment, typePlantShoot)
        {
            AntiBacterial = antiBacterial;
        }

        public bool AntiBacterial { get; set; }
    }
}
