using System;
using Module2HW3.Models;
using Module2HW3.Helpers;
using Module2HW3.Services.Abstractions;

namespace Module2HW3.Services
{
    public class GiftBoxService : IGiftBoxService
    {
        public Sweet[] GiftBox { get; private set; }

        public Sweet[] Find(double weight, double calorie)
        {
            return GiftBox.Find(weight, calorie);
        }

        public void Put(Sweet[] gifts)
        {
            GiftBox = gifts;
        }

        public void SortByCalorie()
        {
            var comparer = new SweetComparer();
            Array.Sort(GiftBox, comparer);
        }

        public double TotalWeight()
        {
            var result = 0d;
            foreach (var gift in GiftBox)
            {
                result += gift.Weight;
            }

            return result;
        }
    }
}
