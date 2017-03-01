using System;
using LibExtension;

namespace ConsExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 10;
            Console.WriteLine($"{number} is{(number.IsOdd() ? "" : "n't")} odd.");


            string line = "This is a line of text";
            char c = 'i';
            Console.WriteLine($"'{line}':  found '{c}' {line.CountChar(c)} time(s).");
            Console.ReadKey();
        }
    }
}
