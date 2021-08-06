
using System;
using System.Threading;

namespace Abstract_Factory
{
    class BattleGame
    {
        private Unit _player, _enemy;

        public BattleGame()
        {
            SetupPlayerClass();
            SetupEnemy();
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
                        _player = new Warrior(name);
                        choose = true;
                        break;

                    case '2':
                        _player = new Mage(name);
                        choose = true;
                        break;

                    default:
                        break;
                }
            }

            Console.WriteLine($"Ok. Your Class is {_player.UnitType} (HP: {_player.HitPoints})");
            Console.WriteLine($"{_player.Replic}\n");
        }

        private void SetupEnemy()
        {
            _enemy = RandomWrapper.Random.Next(1, 3) switch
            {
                1 => new Warrior("Aleshka Popovich"),
                2 => new Mage("Robin Bobin"),
                _ => throw new Exception("What the hell with random?!"),
            };
        }

        public void Start()
        {
            PrintWelcomeMessage();
            while (true)
            {
                Console.Write('\n');
                PrintUnitInfo(_player);
                PrintUnitInfo(_enemy);

                string attackType = string.Empty;
                int dmg = 0;

                bool turn = false;
                Console.WriteLine("Your turn!");
                while (!turn)
                {
                    switch (Console.ReadKey(true).KeyChar)
                    {
                        case '1':
                            dmg = _player.MainAttack.Damage(_enemy);
                            attackType = _player.MainAttack.AttackType;
                            turn = true;
                        break;

                        case '2':
                            dmg = _player.SecondAttack.Damage(_enemy);
                            attackType = _player.SecondAttack.AttackType;
                            turn = true;
                        break;

                        default:
                        break;
                    }
                }
                Console.WriteLine($"Dealing damage by {attackType}: {dmg}");
                Thread.Sleep(1000);
                if (_enemy.HitPoints <= 0)
                {
                    PrintEndGameMessage("You are winner!");
                    return;
                }

                switch (RandomWrapper.Random.Next(1, 3))
                {
                    case 1:
                        dmg = _enemy.MainAttack.Damage(_player);
                        attackType = _enemy.MainAttack.AttackType;
                    break;

                    case 2:
                        dmg = _enemy.SecondAttack.Damage(_player);
                        attackType = _enemy.SecondAttack.AttackType;
                    break;

                    default:
                    throw new Exception("What the hell with random?!");
                }
                Console.WriteLine($"Got damage by {attackType}: {dmg}");
                Thread.Sleep(1000);
                if (_player.HitPoints <= 0)
                {
                    PrintEndGameMessage("You are dead!");
                    return;
                }
            }
        }
        
        private void PrintWelcomeMessage()
        {
            Thread.Sleep(3000);
            PrintEnemyInfo();
            Thread.Sleep(3000);
            PrintHelp();
            Console.WriteLine("Prepare for Battle!");
            Thread.Sleep(5000);
        }

        private void PrintEnemyInfo()
        {
            Console.WriteLine($"Your enemy is {_enemy.Name}");
            Console.WriteLine($"Class is {_enemy.UnitType} (HP: {_enemy.HitPoints})");
            Console.WriteLine($"{_enemy.Replic}\n");
        }

        private void PrintHelp()
        {
            Console.WriteLine("Your attack abilities:");
            Console.WriteLine($"1.{_player.MainAttack.AttackType}");
            Console.WriteLine($"2.{_player.SecondAttack.AttackType}");
            Console.WriteLine("Press the same key to use it!");
        }

        private void PrintUnitInfo(Unit unit)
        {
            Console.WriteLine($"{unit.Name} | {unit.UnitType} | {unit.HitPoints}");
        }

        private void PrintEndGameMessage(string msg)
        {
            Console.WriteLine(msg);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}

