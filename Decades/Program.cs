using System;

namespace Decades
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (input.Length < 2)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(input[input.Length - 2]);
            }
            Console.ReadKey();
        }
    }
}
