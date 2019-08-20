using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Effective Program Logic");
        for (int i = 1; i < 255; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (i % 3 == 0 && i % 5 != 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (i % 3 != 0 && i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
            
        }
    }

}

