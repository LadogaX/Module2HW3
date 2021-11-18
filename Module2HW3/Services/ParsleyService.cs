using Module2HW3.Models;
using Module2HW3.Services.Abstractions;

namespace Module2HW3.Services
{
    public class ParsleyService : IVegetablesService
    {
        public ParsleyService()
        {
            Parsley = new Parsley("Parsly", 48, GrowthEnvironment.Air, TypePlantShoot.Leaves, CycleOfLife.Perennial);
        }

        public Parsley Parsley { get; set; }

        public int GetCalories()
        {
            return Parsley.Calories;
        }

        public Vegetables GetProduct()
        {
            return Parsley;
        }
    }
}