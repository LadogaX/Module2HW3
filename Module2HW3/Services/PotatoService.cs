using Module2HW3.Models;
using Module2HW3.Services.Abstractions;

namespace Module2HW3.Services
{
   public class PotatoService : IVegetablesService
    {
        public PotatoService()
        {
            Potato = new Potato("potato", 77, System.Drawing.Color.Brown);
        }

        public Potato Potato { get; set; }

        public int GetCalories()
        {
            return Potato.Calories;
        }

        public Vegetables GetProduct()
        {
            return Potato;
        }
    }
}
