﻿
using System;

namespace Chain_of_Responsibility
{
    static class AppMain
    {
        static void Main()
        {
            Client client = new();

            MonkeyHandler monkey = new();
            SquirrelHandler squirrel = new();
            DogHandler dog = new();

            monkey.SetNext(squirrel).SetNext(dog);

            Console.WriteLine("Chain: Monkey > Squirrel > Dog\n");
            Client.ClientCode(monkey);
            Console.WriteLine();

            Console.WriteLine("Subchain: Squirrel > Dog\n");
            Client.ClientCode(squirrel);

            _ = Console.ReadKey(true);
        }
    }
}

