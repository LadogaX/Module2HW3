using Module2HW3.Models;

namespace Module2HW3.Services.Abstractions
{
    public interface IDishService
    {
        public int CountElementsDish { get; set; }
        public void Add(IVegetablesService vegitable, double quontity);

        public void SortName();
        public void SortCalories();

        public Dish GetDish();

        public void SetCapacity(int capacity);
    }
}
