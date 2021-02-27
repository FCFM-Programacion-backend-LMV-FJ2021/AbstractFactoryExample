using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FornitureFactory
{
    public abstract class IChair
    {
        public abstract void GetFeature();
        public abstract void GetColor();
    }

    public abstract class ITable
    {
        public abstract void GetFeature();
        public abstract void GetColor();
    }

    public abstract class ISofa
    {
        public abstract void GetFeature();
        public abstract void GetColor();
    }

    public class VictorianChair : IChair
    {
        public override void GetColor()
        {
            Console.WriteLine("Victorian chair is red");
        }

        public override void GetFeature()
        {
            Console.WriteLine("Victorian chair is 2kg weight and 1.50mts tall");
        }
    }

    public class VictorianTable : ITable
    {
        public override void GetColor()
        {
            Console.WriteLine("This is a red victorian table");
        }

        public override void GetFeature()
        {
            Console.WriteLine("Victorian Red table with four legs, big size");
        }
    }

    public class VictorianSofa : ISofa
    {
        public override void GetColor()
        {
            Console.WriteLine("This is a red victorian Sofa");
        }

        public override void GetFeature()
        {
            Console.WriteLine("Victorian Red sofa with four legs, very confortable");
        }
    }

    public class ModernChair : IChair
    {
        public override void GetColor()
        {
            Console.WriteLine("Modern chair is blue");
        }

        public override void GetFeature()
        {
            Console.WriteLine("Modern chair is 2kg weight and 1.40mts tall");
        }
    }



    public class ModernTable : ITable
    {
        public override void GetColor()
        {
            Console.WriteLine("This is a red Modern table");
        }

        public override void GetFeature()
        {
            Console.WriteLine("Modern Red table with four legs, big size");
        }
    }

    public class ModernSofa : ISofa
    {
        public override void GetColor()
        {
            Console.WriteLine("This is a red Modern Sofa");
        }

        public override void GetFeature()
        {
            Console.WriteLine("Modern Red sofa with four legs, very confortable");
        }
    }



    public class ArtDecoChair : IChair
    {
        public override void GetColor()
        {
            Console.WriteLine("ArtDeco chair is white minimalist");
        }

        public override void GetFeature()
        {
            Console.WriteLine("ArtDeco chair is 2.5kg weight and 1.60mts tall");
        }
    }

    public class ArtDecoTable : ITable

    {
        public override void GetColor()
        {
            Console.WriteLine("ArtDeco table is white");
        }

        public override void GetFeature()
        {
            Console.WriteLine("ArtDeco table is 2.5kg weight and 1.60mts tall");
        }
    }

    public class ArdDecoSofa : ISofa
    {
        public override void GetColor()
        {
            Console.WriteLine("ArtDeco sofa is brown");

        }

        public override void GetFeature()
        {
            Console.WriteLine("ArtDeco table is 3.5kg weight and 1.50mts tall");
        }
    }

}
