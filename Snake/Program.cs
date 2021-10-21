using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int H = int.Parse(Console.ReadLine());
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int output = 1;
            int progress = 0;
            while(progress + A < H)
            {
                progress += A - B;
                output++;
            }
            Console.WriteLine(output);
            Console.ReadKey();
        }
    }
}
