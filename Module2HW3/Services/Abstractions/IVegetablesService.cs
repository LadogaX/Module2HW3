using Module2HW3.Models;

namespace Module2HW3.Services.Abstractions
{
    public interface IVegetablesService
    {
        int GetCalories();

        string GetName();

        Vegetables GetVegetable();
    }
}
