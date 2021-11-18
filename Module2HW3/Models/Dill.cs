using System.Drawing;

namespace Module2HW3.Models
{
    public class Dill : Spicy
    {
        public Dill(string name, int calories, GrowthEnvironment growthEnvironment, TypePlantShoot typePlantShoot, CycleOfLife cycleOfLife)
            : base(name, calories, growthEnvironment, typePlantShoot)
        {
            CycleOfLife = cycleOfLife;
        }

        public CycleOfLife CycleOfLife { get; set; }
    }
}
