using System;

namespace Fundamentals1
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 255; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            for(int i = 1; i <= 100; i++)
            {
                if(i % 5 == 0 ^ i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine();
            for(int i = 1; i <= 100; i++)
            {
                if(i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if(i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if(i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
            }
            Console.WriteLine();
            for(int i = 1; i <= 100; i++)
            {
                if(i / 5 == i / 5.0 && i / 3 == i / 3.0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if(i / 3 == i / 3.0)
                {
                    Console.WriteLine("Fizz");
                }
                else if(i / 5 == i / 5.0)
                {
                    Console.WriteLine("Buzz");
                }
            }
            Console.WriteLine();
            Random r = new Random();
            int gen;
            for(int i = 0; i < 10; i++)
            {
                gen = r.Next(1, 100);
                Console.Write(gen + ", ");
                if(gen % 3 == 0 && gen % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if(gen % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if(gen % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
