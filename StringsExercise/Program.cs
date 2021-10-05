using System;

namespace StringsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string helloworld = "Hello world!";
            Console.WriteLine(helloworld[0]);
            int length = helloworld.Length;
            Console.WriteLine(helloworld[length - 1]);
        }
    }
}
