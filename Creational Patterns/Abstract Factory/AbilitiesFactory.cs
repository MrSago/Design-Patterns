
namespace Abstract_Factory
{
    interface IAbilitiesFactory
    {
        IMainAttack CreateMainAttack();
        ISecondAttack CreateSecondAttack();
    }

    class MagicAbilitiesFactory : IAbilitiesFactory
    {
        public IMainAttack CreateMainAttack()
        {
            return new Fireball();
        }
        public ISecondAttack CreateSecondAttack()
        {
            return new Frostball();
        }
    }

    class PhysicsAbilitesFactory : IAbilitiesFactory
    {
        public IMainAttack CreateMainAttack()
        {
            return new Sword();
        }
        public ISecondAttack CreateSecondAttack()
        {
            return new Shieldbash();
        }
    }
}

