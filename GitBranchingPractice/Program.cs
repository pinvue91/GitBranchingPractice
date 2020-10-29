using System;

namespace GitBranchingPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string[] names = { "Joey", "Juan", "Raymundo", "Rema" };
            foreach(string name in names)
            {
                Console.WriteLine(name + "is a a principal.");
            }
        }
    }
}
