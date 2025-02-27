namespace Abstract_Factory;

interface IMainAttack
{
    int Damage(Unit unit);
    string AttackType { get; }
}

interface ISecondAttack
{
    int Damage(Unit unit);
    string AttackType { get; }
}

class Sword : IMainAttack
{
    public int Damage(Unit unit)
    {
        int dmg = RandomWrapper.Random.Next(20, 30);
        _ = unit.GotDamage(dmg);
        return dmg;
    }

    public string AttackType => nameof(Sword);
}

class Fireball : IMainAttack
{
    public int Damage(Unit unit)
    {
        int dmg = RandomWrapper.Random.Next(35, 50);
        _ = unit.GotDamage(dmg);
        return dmg;
    }

    public string AttackType => nameof(Fireball);
}

class Shieldbash : ISecondAttack
{
    public int Damage(Unit unit)
    {
        int dmg = RandomWrapper.Random.Next(17, 22);
        _ = unit.GotDamage(dmg);
        return dmg;
    }

    public string AttackType => nameof(Shieldbash);
}

class Frostball : ISecondAttack
{
    public int Damage(Unit unit)
    {
        int dmg = RandomWrapper.Random.Next(20, 28);
        _ = unit.GotDamage(dmg);
        return dmg;
    }

    public string AttackType => nameof(Frostball);
}
