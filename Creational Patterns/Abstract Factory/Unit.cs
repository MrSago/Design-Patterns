
namespace Abstract_Factory
{
    abstract class Unit
    {
        private readonly string name;
        private int hitpoints;
        public IMainAttack MainAttack;
        public ISecondAttack SecondAttack;
        public Unit(IAbilitiesFactory _factory, string _name, int _hp = 100)
        {
            MainAttack = _factory.CreateMainAttack();
            SecondAttack = _factory.CreateSecondAttack();
            name = _name;
            hitpoints = _hp;
        }
        public string Name
        {
            get => name;
        }
        public int HitPoints
        {
            get => hitpoints;
        }
        public int GotDamage(int dmg)
        {
            return (hitpoints -= dmg) > 0 ? hitpoints : 0;
        }
        public string GetUnitType()
        {
            return GetType().Name;
        }
        public abstract string GetReplic();
    }

    class Warrior : Unit
    {
        public Warrior(string _name, int _hp = 150) :
            base(new PhysicsAbilitesFactory(), _name, _hp) {}
        public override string GetReplic()
        {
            return "I'm strong Warrior! Zag-Zag!";
        }
    }

    class Mage : Unit
    {
        public Mage(string _name, int _hp = 100) :
            base(new MagicAbilitiesFactory(), _name, _hp) {}
        public override string GetReplic()
        {
            return "I'm smart mage! 2x2=4!";
        }
    }
}

