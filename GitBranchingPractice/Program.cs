using System;

namespace GitBranchingPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string[] names = { "Joey", "Juan", "Raymundo", "Stacy" };
            foreach(string name in names)
            {
                Console.WriteLine(name + "is a teacher.");
            }
        }
    }
}
