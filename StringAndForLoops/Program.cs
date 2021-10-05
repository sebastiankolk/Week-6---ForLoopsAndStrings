using System;

namespace StringAndForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma eesnimi");
            string name = Console.ReadLine();

            for (int i = 0; i < name.Length ; i++)
            {
                Console.WriteLine(name[i]);
            }
        }
    }
}
