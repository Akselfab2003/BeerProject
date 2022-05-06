using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Beer beer1 = new Beer("Carlsbaer", "Lux", BeerType.BOCK, 200, 4.39);
            Beer beer2 = new Beer("HarlsBerg", "Tux", BeerType.DOBBELBOCK, 400, 10.42);

            Beer beer3 = new Beer("Carlsbaerasd", "Luasdx", BeerType.LAGER, 300, 9.84);
            Beer beer4 = new Beer("HarlsBergda", "jajsx", BeerType.MÜNCHENER, 500, 7.93);
            Beer[] Beers = new Beer[4];

            Console.WriteLine("Before Change");
            Console.WriteLine("Bear1: "+beer1);
            Console.WriteLine("Bear2: "+beer2);
           ;
            Console.WriteLine("Bear3: " + beer3);
            Console.WriteLine("Bear4: " + beer4);

            Beers[0] = beer1;
            Beers[1] = beer2;
            Beers[2] = beer3;
            Beers[3] = beer4;


            Array.Sort(Beers,new SortingBeerBy(Sortby.VOLUME));

            Console.WriteLine("\nsorted");
            foreach (var item in Beers)
            {
                Console.WriteLine(item);
            }

            beer1.add(beer2);

            Console.WriteLine("\nAfter Change");
            Console.WriteLine("Bear1: " + beer1);
            Console.WriteLine("Bear2: " + beer2);

            Console.WriteLine("\nMix1");
            Console.WriteLine("Before Change");
            Console.WriteLine("Bear3: " + beer3);
            Console.WriteLine("Bear4: " + beer4);

            Beer NewbeerMix = beer3.Mix(beer4);

            Console.WriteLine("\nMix: " + NewbeerMix);
            Console.WriteLine("After Change");
            Console.WriteLine("Bear3: " + beer3);
            Console.WriteLine("Bear4: " + beer4);


            Console.WriteLine("\nMix2");
          
            Beer beerMix = Beer.Mix(beer3, beer4);
          

            Console.WriteLine("\nBearMix: " + beerMix);

            Console.WriteLine("After Change");
            Console.WriteLine("Bear1: " + beer3);
            Console.WriteLine("Bear2: " + beer4);
            Console.ReadKey();

        }
    }
}
