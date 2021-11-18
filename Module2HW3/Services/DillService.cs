using Module2HW3.Models;
using Module2HW3.Services.Abstractions;

namespace Module2HW3.Services
{
    public class DillService : IVegetablesService
    {
        public DillService()
        {
            Dill = new Dill("Dill", 35, System.Drawing.Color.Green);
        }

        public Dill Dill { get; set; }

        public int GetCalories()
        {
            return Dill.Calories;
        }

        public Vegetables GetProduct()
        {
            return Dill;
        }
    }
}
