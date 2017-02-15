using System;
using LibExtension;

namespace ConsExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] animals = { "monkey", "bear", "rabbit", "wolf" };
            if ("bear".In(animals))
                Console.WriteLine($"Found the animal!");
            else
                Console.WriteLine("No such animal.");
            Console.ReadKey();
        }
    }
}
