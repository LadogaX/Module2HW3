using System;
using System.Collections.Generic;
using Module2HW3.Models;

namespace Module2HW3.Services.Comparers
{
    public class DishElementsCaloriesComparer : IComparer<DishElement>
    {
        public int Compare(DishElement dishElement1, DishElement dishElement2)
        {
            if (dishElement1.Product.Calories > dishElement2.Product.Calories)
            {
                return 1;
            }
            else if (dishElement1.Product.Calories < dishElement2.Product.Calories)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}