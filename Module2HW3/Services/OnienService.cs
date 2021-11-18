using Module2HW3.Models;
using Module2HW3.Services.Abstractions;

namespace Module2HW3.Services
{
    public class OnienService : IVegetablesService
    {
        public OnienService()
        {
            Onien = new Onien("Onien", 6, System.Drawing.Color.Brown);
        }

        public Onien Onien { get; set; }

        public int GetCalories()
        {
            return Onien.Calories;
        }

        public Vegetables GetProduct()
        {
            return Onien;
        }
    }
}
