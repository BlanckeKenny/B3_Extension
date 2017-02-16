using System;
using System.Linq;

namespace ConsExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] animals = { "monkey", "bear", "rabbit", "wolf" };
            Func<string, int> lambda1 = a => a.Length;
            Func<string, bool> lambda2 = a => a.Length == 4;

            var lengthOfAnimals = animals.Select(lambda1);
            var fourLetterAnimals = animals.Where(lambda2);
            foreach (int length in lengthOfAnimals)
            {
                Console.WriteLine($"length: {length}");
            }
            foreach (string animal in fourLetterAnimals)
            {
                Console.WriteLine($"{animal} has 4 letters.");
            }
            Console.ReadKey();
        }
    }
}
