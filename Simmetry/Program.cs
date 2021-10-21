using System;

namespace Simmetry
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] array = new char[input.Length];
            int counter = 0;
            foreach (char i in input)
            {
                array[input.Length-counter-1] = i;
                counter++;
            }
            foreach (char i in array)
            {
                Console.Write(i);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
