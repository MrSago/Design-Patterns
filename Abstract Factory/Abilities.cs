
using System;

namespace Abstract_Factory
{
    interface IMainAttack
    {
        int Damage(Unit unit);
        string GetAttackType();
    }
    interface ISecondAttack
    {
        int Damage(Unit unit);
        string GetAttackType();
    }

    class Sword : IMainAttack
    {
        private readonly Random rand = new();
        public int Damage(Unit unit)
        {
            int dmg = rand.Next(20, 30);
            unit.GotDamage(dmg);
            return dmg;
        }
        public string GetAttackType()
        {
            return this.GetType().Name;
        }
    }

    class Fireball : IMainAttack
    {
        private readonly Random rand = new();
        public int Damage(Unit unit)
        {
            int dmg = rand.Next(35, 50);
            unit.GotDamage(dmg);
            return dmg;
        }
        public string GetAttackType()
        {
            return this.GetType().Name;
        }
    }
    class Shieldbash : ISecondAttack
    {
        private readonly Random rand = new();
        public int Damage(Unit unit)
        {
            int dmg = rand.Next(17, 22);
            unit.GotDamage(dmg);
            return dmg;
        }
        public string GetAttackType()
        {
            return this.GetType().Name;
        }
    }
    class Frostball : ISecondAttack
    {
        private readonly Random rand = new();
        public int Damage(Unit unit)
        {
            int dmg = rand.Next(20, 28);
            unit.GotDamage(dmg);
            return dmg;
        }
        public string GetAttackType()
        {
            return this.GetType().Name;
        }
    }
}

