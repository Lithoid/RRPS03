using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRPS03    
{
    public static class Builder
    {
        public static void Test()
        {

            AbstractBuilder builder = new KingsBuildingCompany();
            Architect architect = new Architect(builder);
            architect.Construct();
            Citadel citadel = builder.GetResult();


            Console.ReadLine();

        }
    }
    class Architect
    {
        AbstractBuilder builder;
        public Architect(AbstractBuilder builder)
        {
            this.builder = builder;
        }
        public void Construct()
        {
            builder.BuildWalls();
            builder.BuildCastle();
            builder.BuildDungeon();
        }
    }

    abstract class AbstractBuilder
    {
        public abstract void BuildWalls();
        public abstract void BuildCastle();
        public abstract void BuildDungeon();
        public abstract Citadel GetResult();
    }

    class Citadel
    {
        List<string> parts = new List<string>();
        public void Add(string part)
        {
            parts.Add(part);
        }
        public void Info()
        {
            foreach (var part in parts)
            {
                Console.WriteLine(part);
            }
        }

    }

    class KingsBuildingCompany : AbstractBuilder
    {
        Citadel citadel = new Citadel();
        public override void BuildWalls()
        {
            citadel.Add("Walls");
            Console.WriteLine("Building walls");
        }
        public override void BuildCastle()
        {
            citadel.Add("Castle");
            Console.WriteLine("Building castle");
        }
        public override void BuildDungeon()
        {
            citadel.Add("Dungeon");
            Console.WriteLine("Building dungeon");
        }
        public override Citadel GetResult()
        {
            return citadel;
        }
    }




}
