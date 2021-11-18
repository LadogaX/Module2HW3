using System;
using Module2HW3.Helpers;
using Module2HW3.Models;
using Module2HW3.Services;
using Module2HW3.Services.Abstractions;

namespace Module2HW3
{
    public class Starter
    {
        public void Run()
        {
            IDishService dishService = new DishService("vegetable salad");

            dishService.Add(new PotatoService(), 0.2);
            dishService.Add(new GarlicService(), 0.002);
            dishService.Add(new DillService(), 0.035);
            dishService.Add(new ParsleyService(), 0.2);
            dishService.Add(new OnienService(), 0.03);
            dishService.Add(new BeetService(), 0.045);
            dishService.Add(new CarrotService(), 0.025);
            dishService.Add(new JerusalemArtichokeService(), 0.078);

            DishHelper.Display(dishService.GetDish());
            dishService.SortName();
            DishHelper.Display(dishService.GetDish());
            dishService.SortCalories();
            DishHelper.Display(dishService.GetDish());

            var dishelement = dishService.FindForName(" dIlL ");

            if (dishelement != null)
            {
                Console.WriteLine("Product Found");
                DishHelper.DisplayDishElement(dishelement);
            }
            else
            {
                Console.WriteLine("Product not Found");
            }

            var summaryCalories = DishHelper.CalculateCalories(dishService.GetDish());
            Console.WriteLine($"Summary calories: {summaryCalories}");
        }
    }
}