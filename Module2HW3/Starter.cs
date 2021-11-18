using Module2HW3.Models;
using Module2HW3.Models.Candy.Caramel;
using Module2HW3.Models.Candy.Chocolate;
using Module2HW3.Models.Gum.Chewing;
using Module2HW3.Models.Gum.Jelly;
using Module2HW3.Services;
using Module2HW3.Services.Abstractions;

namespace Module2HW3
{
    public class Starter
    {
        public void Run()
        {
            var giftBoxService = new GiftBoxService();
            var giftBox = new Sweet[]
            {
                new GlazedCandy() { Name = "Red poppy", Calorie = 123.434, Weight = 0.23, CaramelType = CaramelType.Solid, GlazeType = GlazeType.Sugar },
                new Lollipop() { Name = "Natursept", Calorie = 321.43, Weight = 1.23, CaramelType = CaramelType.Liquid, Medical = true },
                new RoastedNutsCandy() { Name = "Bear nuts", Calorie = 452.421, Weight = 32.32, ChocolateType = ChocolateType.Milk, NutType = NutType.Hazelnut },
                new SuffleCandy() { Name = "Birds milk", Calorie = 123.434, Weight = 0.23, ChocolateType = ChocolateType.Black, SuffleType = SuffleType.Frozen },
                new HubbaBubba() { Name = "Hubba Bubba", Calorie = 732.53, Weight = 82.52, Sugared = true, HubbaBubbaType = HubbaBubbaType.Ouch },
                new Orbit() { Name = "Dirol)", Calorie = 85.22, Weight = 72.82, OrbitType = OrbitType.Classic },
                new Haribo() { Name = "Gold bears", Calorie = 123.434, Weight = 0.23, Eatable = true, JellyType = JellyType.Jelly, HariboType = HariboType.Bears },
                new Trolli() { Name = "Trolli", Calorie = 78123.912, Weight = 7.008, Eatable = true, JellyType = JellyType.Fruit, TrolliType = TrolliType.Dracula }
            };
            giftBoxService.Put(giftBox);
            giftBoxService.SortByCalorie();
            System.Console.WriteLine(giftBoxService.TotalWeight());
            var searchResult = giftBoxService.Find(0.23, 123.434);
        }
    }
}
