using System;
using Module2HW3.Helpers;
using Module2HW3.Services;
using Module2HW3.Services.Abstractions;

namespace Module2HW3
{
    public class Starter
    {
        public void Run()
        {
            var dishService = new DishService("vegetable salad");

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

            var result = dishService.FindProductForName(" dIlL ");
            Console.WriteLine(result.Message);

            var summaryCalories = dishService.CalculateCalories();
            Console.WriteLine($"Summary calories: {summaryCalories}");
        }
    }
}