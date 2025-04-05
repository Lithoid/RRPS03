namespace RRPS03
{
    public static class ChainOfResponsibility
    {
        public static void Test()
        {
            Dragon dragon = new Dragon(false, false, true);



            AttackHandler waterAttackHandler = new WaterAttackHandler();
            AttackHandler fireAttackHandler = new FireAttackHandler();
            AttackHandler lightningAttackHandler = new LightningAttackHandler();

            waterAttackHandler.Successor = fireAttackHandler;
            fireAttackHandler.Successor = lightningAttackHandler;

            waterAttackHandler.Attack(dragon);

            Console.ReadLine();
        }
    }

    class Dragon
    {
        public bool WaterAttack { get; set; }
        public bool FireAttack { get; set; }
        public bool LightningAttack { get; set; }
        public Dragon(bool wa, bool fa, bool la)
        {
            WaterAttack = wa;
            FireAttack = fa;
            LightningAttack = la;
        }
    }
    abstract class AttackHandler
    {
        public AttackHandler Successor { get; set; }
        public abstract void Attack(Dragon dragon);
    }

    class WaterAttackHandler : AttackHandler
    {
        public override void Attack(Dragon dragon)
        {
            if (dragon.WaterAttack == true)
                Console.WriteLine("Hit him with water");
            else if (Successor != null)
                Successor.Attack(dragon);
        }
    }

    class FireAttackHandler : AttackHandler
    {
        public override void Attack(Dragon dragon)
        {
            if (dragon.FireAttack == true)
                Console.WriteLine("Hit him with fire");
            else if (Successor != null)
                Successor.Attack(dragon);
        }
    }

    class LightningAttackHandler : AttackHandler
    {
        public override void Attack(Dragon dragon)
        {
            if (dragon.LightningAttack == true)
                Console.WriteLine("Hit him with lightning");
            else if (Successor != null)
                Successor.Attack(dragon);
        }
    }
}
