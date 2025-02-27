namespace Abstract_Factory;

abstract class Unit(IAbilitiesFactory factory, string name, int hitpoints = 100)
{
    public IMainAttack MainAttack = factory.CreateMainAttack();
    public ISecondAttack SecondAttack = factory.CreateSecondAttack();

    private readonly string _name = name;
    public string Name => _name;

    private int _hitpoints = hitpoints;
    public int HitPoints => _hitpoints;

    public int GotDamage(int dmg) => (_hitpoints -= dmg) > 0 ? _hitpoints : 0;

    public string UnitType => GetType().Name;

    public abstract string Replic { get; }
}

class Warrior(string name, int hitpoints = 150)
    : Unit(new PhysicsAbilitesFactory(), name, hitpoints)
{
    public override string Replic => "I'm strong Warrior! Zag-Zag!";
}

class Mage(string name, int hitpoints = 100) : Unit(new MagicAbilitiesFactory(), name, hitpoints)
{
    public override string Replic => "I'm smart mage! 3x^3 + const... What's next?";
}
