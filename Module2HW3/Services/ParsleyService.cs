﻿using Module2HW3.Models;
using Module2HW3.Services.Abstractions;

namespace Module2HW3.Services
{
    public class ParsleyService : IVegetablesService
    {
        public ParsleyService()
        {
            Parsley = new Parsley("Parsly", 48, System.Drawing.Color.Brown);
        }

        public Parsley Parsley { get; set; }

        public int GetCalories()
        {
            return Parsley.Calories;
        }

        public Vegetables GetProduct()
        {
            return Parsley;
        }
    }
}