using System;
using System.Collections.Generic;
using Module2HW3.Models;

namespace Module2HW3.Services.Comparers
{
    public class DishElementsNameComparer : IComparer<DishElement>
    {
        public int Compare(DishElement dishElement1, DishElement dishElement2)
        {
            if (string.Compare(dishElement1.Product.Name, dishElement2.Product.Name) > 0)
            {
                return 1;
            }
            else if (string.Compare(dishElement1.Product.Name, dishElement2.Product.Name) < 0)
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
