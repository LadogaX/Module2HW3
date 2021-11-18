using System.Drawing;

namespace Module2HW3.Models
{
    public class Onien : Onions
    {
        public Onien(string name, int calories, GrowthEnvironment growthEnvironment, TypePlantShoot typePlantShoot, bool isNaturalAntibiotic)
            : base(name, calories, growthEnvironment, typePlantShoot)
        {
            IsNaturalAntibiotic = isNaturalAntibiotic;
        }

        public bool IsNaturalAntibiotic { get; set; }
    }
}