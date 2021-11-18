﻿using Module2HW3.Models;
using Module2HW3.Services.Abstractions;

namespace Module2HW3.Services
{
    public class BeetService : IVegetablesService
    {
        public BeetService()
        {
            Beet = new Beet("Beet", 77, System.Drawing.Color.Red);
        }

        public Beet Beet { get; set; }

        public int GetCalories()
        {
            return Beet.Calories;
        }

        public Vegetables GetProduct()
        {
            return Beet;
        }
    }
}