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
            var dishService = new DishService("vegetable salad");

            dishService.Add(new VegetableService(new Potato("potato", 77, TypeGroundVegitables.TuberVegetable, GrowthEnvironment.Soil, 170.53)), 0.2);
            dishService.Add(new VegetableService(new Garlic("Garlic", 56, GrowthEnvironment.Soil, TypePlantShoot.Arrows, true)), 0.002);
            dishService.Add(new VegetableService(new Dill("Dill", 35, GrowthEnvironment.Air, TypePlantShoot.Leaves, CycleOfLife.Annual)), 0.035);
            dishService.Add(new VegetableService(new Parsley("Parsly", 48, GrowthEnvironment.Air, TypePlantShoot.Leaves, CycleOfLife.Perennial)), 0.2);
            dishService.Add(new VegetableService(new Onien("Onien", 6, GrowthEnvironment.Soil, TypePlantShoot.Arrows, true)), 0.03);
            dishService.Add(new VegetableService(new Beet("Beet", 77, TypeGroundVegitables.RootVegetable, GrowthEnvironment.Soil, true)), 0.045);
            dishService.Add(new VegetableService(new Carrot("Carrot", 80, TypeGroundVegitables.RootVegetable, GrowthEnvironment.Soil, true)), 0.025);
            dishService.Add(new VegetableService(new JerusalemArtichoke("Jerusalem Artichoke", 77, TypeGroundVegitables.TuberVegetable, GrowthEnvironment.Soil, 225.59)), 0.078);

            DishHelper.Display(dishService.GetDish());
            dishService.SortName();
            DishHelper.Display(dishService.GetDish());
            dishService.SortCalories();
            DishHelper.Display(dishService.GetDish());

            var result = dishService.GetDish().FindProductForName(" dIlL ");
            Console.WriteLine(result.Message);

            var summaryCalories = dishService.CalculateCalories();
            Console.WriteLine($"Summary calories: {summaryCalories}");
        }
    }
}