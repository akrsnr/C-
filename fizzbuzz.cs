using System;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i < 101; ++i)
            {
                Console.WriteLine(
                    (i % 15 == 0) ? "FizzBuzz" : (i % 5 == 0) ? "Buzz" : (i % 3 == 0) ? "Fizz" : $"{i}"
                );
            }
            Console.ReadKey();
            }
    }
}
