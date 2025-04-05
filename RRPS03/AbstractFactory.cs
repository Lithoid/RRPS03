

namespace RRPS03
{
    public static class AbstractFactory
    {
        public static void Test()
        {
            Warrior knight = new Warrior(new KnightFactory());
            knight.Attack();
            knight.Defend();

            Warrior rogue = new Warrior(new RogueFactory());
            rogue.Attack();
            rogue.Defend();


            Console.ReadLine();

        }
    }

    abstract class WarriorFactory
    {
        public abstract Weapon CreateWeapon();
        public abstract Armor CreateArmor();
    }
    class KnightFactory : WarriorFactory
    {
        public override Weapon CreateWeapon()
        {
            return new GreatSword();
        }

        public override Armor CreateArmor()
        {
            return new IronArmor();
        }
    }
    class RogueFactory : WarriorFactory
    {
        public override Weapon CreateWeapon()
        {
            return new Dagger();
        }

        public override Armor CreateArmor()
        {
            return new LeatherArmor();
        }
    }

    abstract class Weapon
    {
        public abstract void Attack();
    }

    abstract class Armor
    {
        public abstract void Defend();

    }

    class GreatSword : Weapon
    {
        public override void Attack()
        {
            Console.WriteLine("Great sword attack");
        }

    }

    class IronArmor : Armor
    {
        public override void Defend()
        {
            Console.WriteLine("Full iron protection");
        }
    }

    class Dagger : Weapon
    {
        public override void Attack()
        {
            Console.WriteLine("Sneaky dagger attack");
        }
    }

    class LeatherArmor : Armor
    {
        public override void Defend()
        {
            Console.WriteLine("Light leather protection");
        }
    }

    class Warrior
    {
        private Weapon weapon;
        private Armor armor;

        public Warrior(WarriorFactory factory)
        {
            weapon = factory.CreateWeapon();
            armor = factory.CreateArmor();
        }
        public void Attack()
        {
            weapon.Attack();
        }
        public void Defend()
        {
            armor.Defend();
        }
    }


}
