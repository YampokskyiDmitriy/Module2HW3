using System;
using Module2HW3.Models;

namespace Module2HW3.Helpers
{
    public static class SweetArrayExtension
    {
        public static Sweet[] Find(this Sweet[] array, double weight, double calorie)
        {
            var result = new Sweet[0];
            foreach (var sweet in array)
            {
                if (sweet.Weight == weight && sweet.Calorie == calorie)
                {
                    Array.Resize(ref result, result.Length + 1);
                    result[result.Length - 1] = sweet;
                }
            }

            return result;
        }
    }
}
