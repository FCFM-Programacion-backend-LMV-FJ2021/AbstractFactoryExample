using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FornitureFactory
{
    class Program
    {

        public static void SelectFactory(FornitureFactory factory)
        {
            var chair = factory.createChair();
            Console.WriteLine("--------FACTORY NAME: " + factory.FornitureFactoryName() + "-------");
            Console.WriteLine("************CREATED CHAIR************");
            chair.GetFeature();
            chair.GetColor();

            var sofa = factory.createSofa();
            Console.WriteLine("************CREATED SOFA************");
            sofa.GetFeature();
            sofa.GetColor();

            var table = factory.createTable();
            Console.WriteLine("************CREATED TABLE************");
            table.GetFeature();
            table.GetColor();
        }
        static void Main(string[] args)
        {

           // FornitureFactory factory = new ModernFurnitureFactory();
           // var chair = factory.createChair();
           // chair.GetColor();
           // chair.GetFeature();
           // var table = factory.createTable();
           // table.GetColor();
           // table.GetFeature();


           // var anotherFactory = new ArtDecoFactory();
           // var anotherChair = anotherFactory.createChair();
           // anotherChair.GetColor();

           // var lastFactory = new VictorianFurnitureFactory();
           // var lastChair = lastFactory.createChair();
           // lastChair.GetColor();


           //// SelectFactory(anotherFactory);
            SelectFactory(new ArtDecoFactory());

            //Console.ReadKey();

        }
    }
}
