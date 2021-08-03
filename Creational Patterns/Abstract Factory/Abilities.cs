
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
        public int Damage(Unit unit)
        {
            int dmg = RandomWrapper.random.Next(20, 30);
            unit.GotDamage(dmg);
            return dmg;
        }
        public string GetAttackType()
        {
            return GetType().Name;
        }
    }

    class Fireball : IMainAttack
    {
        public int Damage(Unit unit)
        {
            int dmg = RandomWrapper.random.Next(35, 50);
            unit.GotDamage(dmg);
            return dmg;
        }
        public string GetAttackType()
        {
            return GetType().Name;
        }
    }
    class Shieldbash : ISecondAttack
    {
        public int Damage(Unit unit)
        {
            int dmg = RandomWrapper.random.Next(17, 22);
            unit.GotDamage(dmg);
            return dmg;
        }
        public string GetAttackType()
        {
            return GetType().Name;
        }
    }
    class Frostball : ISecondAttack
    {
        public int Damage(Unit unit)
        {
            int dmg = RandomWrapper.random.Next(20, 28);
            unit.GotDamage(dmg);
            return dmg;
        }
        public string GetAttackType()
        {
            return GetType().Name;
        }
    }
}

