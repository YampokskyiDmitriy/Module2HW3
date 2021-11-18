using Module2HW3.Models;

namespace Module2HW3.Services.Abstractions
{
    public interface IGiftBoxService
    {
        public void Put(Sweet[] gifts);
        public double TotalWeight();
        public void SortByCalorie();
        public Sweet[] Find(double weight, double calorie);
    }
}
