using Module2HW3.Models;

namespace Module2HW3.Services.Abstractions
{
    public interface IDishService
    {
        int CountElementsDish { get; set; }
        void Add(IVegetablesService vegitable, double quontity);

        void SortName();
        void SortCalories();

        Dish GetDish();

        void SetCapacity(int capacity);
    }
}
