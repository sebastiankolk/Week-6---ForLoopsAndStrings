using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Mis su eesnimi on?");
            string nimi = Console.ReadLine();
            Console.WriteLine(nimi[0]);
            int length = nimi.Length;
            Console.WriteLine($"Teie nimi on {length} sümbolit pikk");
            Console.WriteLine(nimi[length - 1]); */
            Console.WriteLine("Mis su eesnimi on?");
            string nimi = Console.ReadLine();
            int length = nimi.Length;
            Console.WriteLine("Mis su perekonna nimi on ?");
            string nimi2 = Console.ReadLine();
            int length2 = nimi2.Length;
            if(length > length2)
            {
                Console.WriteLine("Su eesnimi on pikem.");
            }
            else if (length < length2)
            {
                Console.WriteLine("Su perekonna nimi on pikem.");
            }


        }
    }
}