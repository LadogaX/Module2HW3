using Module2HW3.Models;
using Module2HW3.Services.Abstractions;

namespace Module2HW3.Services
{
    public class CarrotService : IVegetablesService
    {
        public CarrotService()
        {
            Carrot = new Carrot("Carrot", 80, System.Drawing.Color.Orange);
        }

        public Carrot Carrot { get; set; }

        public int GetCalories()
        {
            return Carrot.Calories;
        }

        public Vegetables GetProduct()
        {
            return Carrot;
        }
    }
}
