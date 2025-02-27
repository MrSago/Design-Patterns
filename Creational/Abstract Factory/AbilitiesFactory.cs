namespace Abstract_Factory;

interface IAbilitiesFactory
{
    IMainAttack CreateMainAttack();
    ISecondAttack CreateSecondAttack();
}

class MagicAbilitiesFactory : IAbilitiesFactory
{
    public IMainAttack CreateMainAttack() => new Fireball();

    public ISecondAttack CreateSecondAttack() => new Frostball();
}

class PhysicsAbilitesFactory : IAbilitiesFactory
{
    public IMainAttack CreateMainAttack() => new Sword();

    public ISecondAttack CreateSecondAttack() => new Shieldbash();
}
