
namespace Abstract_Factory
{
    abstract class Unit
    {
        public IMainAttack MainAttack;
        public ISecondAttack SecondAttack;
        private readonly string _name;
        public string Name => _name;
        private int _hitpoints;
        public int HitPoints => _hitpoints;

        public Unit(IAbilitiesFactory factory, string name, int hitpoints = 100)
        {
            MainAttack = factory.CreateMainAttack();
            SecondAttack = factory.CreateSecondAttack();
            _name = name;
            _hitpoints = hitpoints;
        }

        public int GotDamage(int dmg) => (_hitpoints -= dmg) > 0 ? _hitpoints : 0;
        public string UnitType => GetType().Name;
        public abstract string Replic { get; }
    }

    class Warrior : Unit
    {
        public Warrior(string name, int hitpoints = 150) :
            base(new PhysicsAbilitesFactory(), name, hitpoints) {}
        public override string Replic => "I'm strong Warrior! Zag-Zag!";
    }

    class Mage : Unit
    {
        public Mage(string name, int hitpoints = 100) :
            base(new MagicAbilitiesFactory(), name, hitpoints) {}
        public override string Replic => "I'm smart mage! 2x2=4!";
    }
}

