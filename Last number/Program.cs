using System;

namespace Last_number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(input[input.Length-1]);
            Console.ReadKey();
        }
    }
}
