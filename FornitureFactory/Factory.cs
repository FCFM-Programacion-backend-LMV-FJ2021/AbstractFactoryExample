using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FornitureFactory
{
    public abstract class FornitureFactory
    {
        public abstract IChair createChair();
        public abstract ITable createTable();
        public abstract ISofa createSofa();

        public abstract string FornitureFactoryName();
    }

    public class VictorianFurnitureFactory : FornitureFactory
    {
        public override IChair createChair()
        {
            return new VictorianChair();
        }

        public override ISofa createSofa()
        {
            return new VictorianSofa();
        }

        public override ITable createTable()
        {
            return  new VictorianTable();
        }

        public override string FornitureFactoryName()
        {
            return "Victorian Factory";
        }
    }

    public class ModernFurnitureFactory : FornitureFactory
    {
        public override IChair createChair()
        {
            return new ModernChair();
        }

        public override ISofa createSofa()
        {
            return new ModernSofa();
        }

        public override ITable createTable()
        {
            return new ModernTable();
        }

        public override string FornitureFactoryName()
        {
            return "Modern Factory";
        }
    }

    public class ArtDecoFactory : FornitureFactory
    {
        public override IChair createChair()
        {
            return new ArtDecoChair();
        }

        public override ISofa createSofa()
        {
            return new ArdDecoSofa();
        }

        public override ITable createTable()
        {
            return new ArtDecoTable();
        }

        public override string FornitureFactoryName()
        {
            return "Art Deco";
        }
    }


}
