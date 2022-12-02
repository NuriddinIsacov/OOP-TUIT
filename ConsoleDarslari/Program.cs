using ConsoleDarslari.Classes;
using System;
using System.Collections.Generic;

namespace ConsoleDarslari
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Kitob> ListKitob = new List<Kitob>
            {
                new Kitob(1, "Diqqat", "Mark Menson"),
                new Kitob(2, "Sherlock Holmes", "Artur Konan Doyl"),
                new Kitob(3, "Blabla bla", "asdasdsa"),
                new Kitob(4, "Beparvolikning noyob san'ati", "Mark Menson")
            };

            Kutubxona KitobMarket = new Kutubxona();

            KitobMarket.SetObjects(ListKitob);

            Console.WriteLine("---------Update`dan oldin---------");

            foreach (var item in KitobMarket.Kitoblar)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine("-------------------------------------------");
            }

            Console.WriteLine("\n\n\n\n--------============------------\n\n\n\n");

            var newKitob = new Kitob(3, "Yangi Kitob", "Kamina))");

            KitobMarket.Update(newKitob, 4);

            Console.WriteLine("-------Update`dan so'ng---------");

            foreach (var item in KitobMarket.Kitoblar)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine("-------------------------------------------");
            }
        }
    }
}
