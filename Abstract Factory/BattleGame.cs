
using System;
using System.Threading;

namespace Abstract_Factory
{
    class BattleGame
    {
        private Unit player, enemy;
        public BattleGame()
        {
            SetupPlayerClass();
            SetupEnemy();
        }
        public void Start()
        {
            PrintWelcomeMessage();
            
            while (true)
            {
                Console.Write('\n');
                PrintUnitInfo(player);
                PrintUnitInfo(enemy);
                Console.WriteLine("Your turn!");
                string attackType = "";
                int dmg = 0;
                bool turn = false;
                while (!turn)
                {
                    switch (Console.ReadKey(true).KeyChar)
                    {
                        case '1':
                            dmg = player.MainAttack.Damage(enemy);
                            attackType = player.MainAttack.GetAttackType();
                            turn = true;
                        break;

                        case '2':
                            dmg = player.SecondAttack.Damage(enemy);
                            attackType = player.SecondAttack.GetAttackType();
                            turn = true;
                        break;

                        default:
                        break;
                    }
                }
                Console.WriteLine($"Dealing damage by {attackType}: {dmg}");
                Thread.Sleep(1000);
                if (enemy.GetHP() <= 0)
                {
                    PrintEndGameMessage("You are winner!");
                    return;
                }

                switch (RandomWrapper.random.Next(1, 2))
                {
                    case 1:
                        dmg = enemy.MainAttack.Damage(player);
                        attackType = enemy.MainAttack.GetAttackType();
                        break;

                    case 2:
                        dmg = enemy.SecondAttack.Damage(player);
                        attackType = enemy.SecondAttack.GetAttackType();
                        break;

                    default:
                        throw new Exception("What the hell with random?!");
                }
                Console.WriteLine($"Got damage by {attackType}: {dmg}");
                Thread.Sleep(1000);
                if (player.GetHP() <= 0)
                {
                    PrintEndGameMessage("You are dead!");
                    return;
                }
            }
        }

        private string SetPlayerName()
        {
            Console.Write("Write your player name: ");
            string name = Console.ReadLine();
            return string.IsNullOrEmpty(name) ? "NoName" : name;
        }
        private void SetupPlayerClass()
        {
            string name = SetPlayerName();
            Console.WriteLine($"Ok. Your name is {name}");

            Console.WriteLine("Choose Your Class:");
            Console.WriteLine("1.Warrior");
            Console.WriteLine("2.Mage");
            bool choose = false;
            while (!choose)
            {
                switch (Console.ReadKey(true).KeyChar)
                {
                    case '1':
                        player = new Warrior(name);
                        choose = true;
                    break;

                    case '2':
                        player = new Mage(name);
                        choose = true;
                    break;

                    default:
                    break;
                }
            }

            Console.WriteLine($"Ok. Your Class is {player.GetUnitType()} (HP: {player.GetHP()})");
            Console.WriteLine($"{player.GetReplic()}\n");
        }
        private void SetupEnemy()
        {
            enemy = RandomWrapper.random.Next(1, 2) switch
            {
                1 => new Warrior("Aleshka Popovich"),
                2 => new Mage("Robin Bobin"),
                _ => throw new Exception("What the hell with random?!"),
            };
        }
        private void PrintWelcomeMessage()
        {
            Thread.Sleep(3000);
            PrintEnemyInfo();
            Thread.Sleep(3000);
            PrintHelp();
            Thread.Sleep(3000);
            Console.WriteLine("Prepare for Battle!");
            Thread.Sleep(5000);
        }
        private void PrintEnemyInfo()
        {
            Console.WriteLine($"Your enemy is {enemy.GetName()}");
            Console.WriteLine($"Class is {enemy.GetUnitType()} (HP: {enemy.GetHP()})");
            Console.WriteLine($"{enemy.GetReplic()}\n");
        }
        private void PrintHelp()
        {
            Console.WriteLine("Your attack abilities:");
            Console.WriteLine($"1.{player.MainAttack.GetAttackType()}");
            Console.WriteLine($"2.{player.SecondAttack.GetAttackType()}");
            Console.WriteLine("Press the same key to use it!");
        }
        private void PrintUnitInfo(Unit unit)
        {
            Console.WriteLine($"{unit.GetName()} | {unit.GetUnitType()} | {unit.GetHP()}");
        }
        private void PrintEndGameMessage(string msg)
        {
            Console.WriteLine(msg);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}

