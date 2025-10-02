using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Number Pattern Generator");
            Console.WriteLine("Enter an odd number to generate pattern:");

            while (true)
            {
                Console.Write("Enter number (or 'quit' to exit): ");
                string input = Console.ReadLine();

                if (input?.ToLower() == "quit")
                    break;

                if (int.TryParse(input, out int n))
                {
                    GeneratePattern(n);
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }

                Console.WriteLine();
            }
        }

        static void GeneratePattern(int n)
        {
            if (n <= 0)
            {
                Console.WriteLine("Please enter a positive number.");
                return;
            }

            if (n % 2 == 0)
            {
                Console.WriteLine($"If n={n} Invalid");
                return;
            }

            Console.WriteLine($"If n={n}");

            int midPoint = (n + 1) / 2;

            for (int row = 1; row <= n; row++)
            {
                int numElements;
                if (row <= midPoint)
                {
                    numElements = 2 * row - 1;
                }
                else
                {
                    numElements = 2 * (n - row + 1) - 1;
                }
                for (int i = 0; i < numElements; i++)
                {
                    if (i > 0) Console.Write(" ");
                    Console.Write(row + i * 2);
                }
                Console.WriteLine();
            }
        }
    }
}
