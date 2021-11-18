using System;
using System.Collections.Generic;
using Module2HW3.Models;
namespace Module2HW3.Services.Comparers
{
    public class VegetablesNameComparer : IComparer<Vegetables>
    {
        public int Compare(Vegetables vegetable1, Vegetables vegetable2)
        {
            if (vegetable1.Name.Length > vegetable2.Name.Length)
            {
                return 1;
            }
            else if (vegetable1.Name.Length < vegetable2.Name.Length)
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