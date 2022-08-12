using System;

namespace MethodsWithLoopsAndConditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintThousands();
        }

        public static void PrintThousands()
        {
            for (int i = 1000; i >= 1000; i--)
            {
                Console.WriteLine(i);

            }
        }
        public static void NumThree()
        {
            for (int t = 3; t <= 999; t += 3)

            {
                Console.WriteLine();
            }

        }
        public static bool IsEqual(int Getx, int Gety)
        {
            if (Getx == Gety)

            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void EvenOrOdd(int number)
        {
            if (number % 2 == 0)
            {
                Console.Write(number + " is an even number.");
            }
            else if (number % 2 == 1)
            {
                Console.Write(number + " is an odd number.");
            }

        }
    }
}


