using System;
using Module2HW3.Models;
using Module2HW3.Services.Abstractions;
using Module2HW3.Services.Comparers;

namespace Module2HW3.Services
{
    public class DishService : IDishService
    {
        private readonly int _stepCapacity = 5;
        private Dish _dish;
        private DishElement[] _dishContent;
        private int _capacity;

        public DishService(string nameDish)
        {
            _capacity = _stepCapacity;

            _dish = new Dish { Name = nameDish, Products = new DishElement[_capacity] };
            _dishContent = _dish.Products;
        }

        public int CountElementsDish { get; set; }
        public void Add(IVegetablesService vegitable, double quontity)
        {
            if (CountElementsDish == _dishContent.Length)
            {
                _capacity += _stepCapacity;
                SetCapacity(_capacity);
            }

            for (var i = CountElementsDish; i < _dishContent.Length; i++)
            {
                if (_dishContent[i] == null)
                {
                    _dishContent[i] = new DishElement { Product = vegitable.GetVegetable(), Quontity = quontity };

                    CountElementsDish++;
                    break;
                }
            }
        }

        public void SortName()
        {
            SetCapacity(CountElementsDish);
            Array.Sort(_dishContent, new DishElementsNameComparer());
        }

        public void SortCalories()
        {
            SetCapacity(CountElementsDish);
            Array.Sort(_dishContent, new DishElementsCaloriesComparer());
        }

        public Dish GetDish()
        {
            return _dish;
        }

        public void SetCapacity(int capacity)
        {
            Array.Resize(ref _dishContent, capacity);
            _dish.Products = _dishContent;
        }
    }
}
