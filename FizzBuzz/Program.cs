using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzzRunner.FizzBuzz(20);
        }
    }

    class FizzBuzzRunner
    {
        public static void FizzBuzz(int x) 
        {
            if ( x < 0) return;
            for (int i = 1; i <= x; i++) {
                if ( i % 5 == 0 && i % 3 == 0 ) {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 5 == 0) {
                    Console.WriteLine("Fizz");
                }
                else if (i % 3 == 0) {
                    Console.WriteLine("Buzz");
                }
                else {
                    Console.WriteLine($"{i}");
                }
            }
        }
    }
}
