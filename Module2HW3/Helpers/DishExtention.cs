using Module2HW3.Models;
using Module2HW3.Services;

namespace Module2HW3.Helpers
{
    public static class DishExtention
    {
        public static Result FindProductForName(this Dish dish, string name)
        {
            DishElement foundElement = null;
            var dishContent = dish.Products;

            for (var i = 0; i < dishContent.Length; i++)
            {
                if (dishContent[i] != null && (string.Compare(dishContent[i].Product.Name, name.Trim(), true) == 0))
                {
                    foundElement = dishContent[i];
                    break;
                }
            }

            return new Result
            {
                Status = foundElement != null,
                Message = foundElement != null ? $"Found {DishHelper.GetStringDishElement(foundElement)}" :
                                                                                             $"{name} Not found "
            };
        }
    }
}
