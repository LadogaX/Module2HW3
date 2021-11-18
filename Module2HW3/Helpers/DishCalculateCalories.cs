using Module2HW3.Services;

namespace Module2HW3.Helpers
{
   public static class DishCalculateCalories
    {
        public static double CalculateCalories(this DishService dishService)
        {
            var dishContent = dishService.GetDish().Products;
            double summaryCalories = 0;
            for (var i = 0; i < dishContent.Length; i++)
            {
                var product = dishContent[i];
                if (product != null)
                {
                    summaryCalories += product.Quontity * product.Product.Calories / 1000;
                }
            }

            return summaryCalories;
        }
    }
}
