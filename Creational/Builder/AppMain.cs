
using System;

namespace Builder
{
    static class AppMain
    {
        static void Main()
        {
            BurgerSeller director = new();
            McDonaldsWorker builder = new();
            director.Builder = builder;

            Console.WriteLine("Cheese burger:");
            director.BuildCheeseBurger();
            builder.GetBurger().PrintProps();

            Console.WriteLine("Tomato burger:");
            director.BuildTomatoBurger();
            builder.GetBurger().PrintProps();

            Console.WriteLine("Full burger:");
            director.BuildFullBurger();
            builder.GetBurger().PrintProps();

            Console.WriteLine("Custom burger:");
            builder.SetSize(15.4f);
            builder.AddCheese(2);
            builder.AddTomato();
            builder.AddLettuce(2);
            builder.GetBurger().PrintProps();

            _ = Console.ReadKey(true);
        }
    }
}

