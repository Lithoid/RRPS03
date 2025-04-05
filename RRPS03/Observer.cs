using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRPS03
{
    public static class Observer
    {
        public static void Test()
        {
            IObservable king = new King();
            IObserver commander = new ForceCommander();
            IObserver priest = new SupremePatriarch();
            IObserver minister = new FinaceMinister();


            king.AddCounselor(commander);
            king.AddCounselor(priest);
            king.AddCounselor(minister);

            king.NotifyCounselers();


            Console.ReadLine();
        }
    }

    interface IObservable
    {
        void AddCounselor(IObserver o);
        void RemoveCounselor(IObserver o);
        void NotifyCounselers();
    }
    class King : IObservable
    {
        private List<IObserver> council;
        public King()
        {
            council = new List<IObserver>();
        }
        public void AddCounselor(IObserver o)
        {
            council.Add(o);
        }

        public void RemoveCounselor(IObserver o)
        {
            council.Remove(o);
        }

        public void NotifyCounselers()
        {
            foreach (IObserver counselor in council)
                counselor.Update();
        }
    }

    interface IObserver
    {
        void Update();
    }
    class ForceCommander : IObserver
    {
        public void Update()
        {
            Console.WriteLine("As force commander I command move");
        }
    }
    class SupremePatriarch : IObserver
    {
        public void Update()
        {
            Console.WriteLine("We ll pray for your highnes");
        }
    }
    class FinaceMinister : IObserver
    {
        public void Update()
            
        {
            Console.WriteLine("Hope this order wonthit our economy");
        }
    }
}
