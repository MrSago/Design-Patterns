using System;
using Builder;

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
builder.SetSize(15.4f).AddCheese(2).AddTomato().AddLettuce(2).GetBurger().PrintProps();
