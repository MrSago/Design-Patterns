
using System;

namespace Abstract_Factory
{
    static class AppMain
    {
        static void Main(string[] args)
        {
            BattleGame game = new();
            game.Start();
        }
    }
}

