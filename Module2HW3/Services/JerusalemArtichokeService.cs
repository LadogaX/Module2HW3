using Module2HW3.Models;
using Module2HW3.Services.Abstractions;

namespace Module2HW3.Services
{
   public class JerusalemArtichokeService : IVegetablesService
    {
        public JerusalemArtichokeService()
        {
            JerusalemArtichoke = new JerusalemArtichoke("Jerusalem Artichoke", 77, TypeGroundVegitables.TuberVegetable, GrowthEnvironment.Soil, 225.59);
        }

        public JerusalemArtichoke JerusalemArtichoke { get; set; }

        public int GetCalories()
        {
            return JerusalemArtichoke.Calories;
        }

        public Vegetables GetProduct()
        {
            return JerusalemArtichoke;
        }
    }
}