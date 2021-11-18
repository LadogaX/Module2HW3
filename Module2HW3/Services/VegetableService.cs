using Module2HW3.Models;
using Module2HW3.Services.Abstractions;

namespace Module2HW3.Services
{
    public class VegetableService : IVegetablesService
    {
        public VegetableService(Vegetables vegetables)
        {
            Vegetable = vegetables;
        }

        public Vegetables Vegetable { get; set; }

        public int GetCalories()
        {
            return Vegetable.Calories;
        }

        public string GetName()
        {
            return Vegetable.Name;
        }

        public Vegetables GetVegetable()
        {
            return Vegetable;
        }
    }
}
