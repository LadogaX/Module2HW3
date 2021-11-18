using Module2HW3.Models;
using Module2HW3.Services.Abstractions;

namespace Module2HW3.Services
{
    public class GarlicService : IVegetablesService
    {
        public GarlicService()
        {
            Garlic = new Garlic("Garlic", 56, GrowthEnvironment.Soil, TypePlantShoot.Arrows, true);
        }

        public Garlic Garlic { get; set; }

        public int GetCalories()
        {
            return Garlic.Calories;
        }

        public Vegetables GetProduct()
        {
            return Garlic;
        }
    }
}
