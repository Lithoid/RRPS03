namespace RRPS03
{
    public static class FactoryMethod
    {
        public static void Test()
        {
            Craftsman craftsman = new Smith();
            craftsman.Craft();

            craftsman = new Archer();
            craftsman.Craft();


            Console.ReadLine();

        }
    }

    public abstract class Product
    {
        public double Price { get; set; }
    }

    public class Sword : Product
    {
        public Sword()
        {
            Console.WriteLine("Sword is crafted");
        }
    }

    public class Bow : Product
    {
        public Bow()
        {
            Console.WriteLine("Bow is crafted");
        }
    }

    public abstract class Craftsman
    {
        public string Name { get; set; }

        public abstract Product Craft();
    }

    public class Smith : Craftsman
    {
        public override Product Craft() { return new Sword(); }
    }

    public class Archer : Craftsman
    {
        public override Product Craft() { return new Bow(); }
    }
}