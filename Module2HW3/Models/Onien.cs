using System.Drawing;

namespace Module2HW3.Models
{
    public class Onien : Onions
    {
        public Onien(string name, int calories, GrowthEnvironment growthEnvironment, TypePlantShoot typePlantShoot, bool hightMineralSalt)
            : base(name, calories, growthEnvironment, typePlantShoot)
        {
            HightMineralSalt = hightMineralSalt;
        }

        public bool HightMineralSalt { get; set; }
    }
}