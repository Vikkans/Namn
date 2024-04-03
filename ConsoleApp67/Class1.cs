using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp67
{
   class Namn
   {
        public string Förnamn;
        public string Efternamn;

        public void metod()
        {
            Namn Namn = new Namn();

            Console.WriteLine("vad är ditt förnamn");
            Namn.Förnamn = Console.ReadLine();

            Console.WriteLine("vad är ditt efternamn");
            Namn.Efternamn = Console.ReadLine();

            Console.WriteLine("Hej " + Namn.Förnamn + " " +  Namn.Efternamn);

        }


   }
}
