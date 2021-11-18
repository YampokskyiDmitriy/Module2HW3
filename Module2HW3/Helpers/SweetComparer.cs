using System.Collections;
using Module2HW3.Models;

namespace Module2HW3.Helpers
{
    public class SweetComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            var firstSweet = x as Sweet;
            var secondSweet = y as Sweet;
            if (firstSweet.Calorie > secondSweet.Calorie)
            {
                return 1;
            }
            else if (firstSweet.Calorie < secondSweet.Calorie)
            {
                return -1;
            }

            return 0;
        }
    }
}
