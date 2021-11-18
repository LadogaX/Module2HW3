using System;
using Module2HW3.Models;

namespace Module2HW3.Helpers
{
    public class DishHelper
    {
        public static void Display(Dish dish)
        {
            Console.WriteLine($"{dish.Name.ToUpper()}:");
            for (var i = 0; i < dish.Products.Length; i++)
            {
                var product = dish.Products[i];
                if (product != null)
                {
                    DisplayDishElement(product);
                }
            }

            Console.WriteLine();
        }

        public static void DisplayDishElement(DishElement dishElement)
        {
            Console.WriteLine(GetStringDishElement(dishElement));
        }

        public static string GetStringDishElement(DishElement dishElement)
        {
            return $"Product: {dishElement.Product.Name.PadRight(25)} Calories {dishElement.Product.Calories,4} kkal Quontity {dishElement.Quontity,4}kg";
        }

        public static double CalculateCalories_(Dish dish)
        {
            double summaryCalories = 0;
            for (var i = 0; i < dish.Products.Length; i++)
            {
                var product = dish.Products[i];
                if (product != null)
                {
                    summaryCalories += product.Quontity * product.Product.Calories / 1000;
                }
            }

            return summaryCalories;
        }
    }
}
