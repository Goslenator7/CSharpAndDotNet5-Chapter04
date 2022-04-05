using System;

namespace Chapter04
{
    class Program
    {
        static void TimesTable (byte number)
        {
            Console.WriteLine($"This is the {number} times table: ");

            for (int row = 1; row <= 12; row++)
            {
                Console.WriteLine(
                    $"{row} x {number} = {row * number}");
            }
            Console.WriteLine();
        }

        static void RunTimesTable()
        {
            bool isNumber;
            do
            {
                Console.Write("Enter a number between 0 and 255: ");

                isNumber = byte.TryParse(
                    Console.ReadLine(), out byte number);

                if (isNumber)
                {
                    TimesTable(number);
                }
                else
                {
                    Console.WriteLine("You did not enter a valid number!");
                }
            }
            while (isNumber);
        }

        static int Factorial (int number)
        {
            if (number < 1)
            {
                return 0;
            }
            else if (number == 1) {
                return 1;
            }
            checked
            {
                return number * Factorial(number - 1);
            }
        }

        static void RunFactorial()
        {
            for (int i = 1; i < 15; i++)
            {
                try
                {
                    Console.WriteLine($"{i}! = {Factorial(i):N0}");

                }
                catch (System.OverflowException)
                {
                    Console.WriteLine($"{i}! is too big for a 32-bit integer.");
                }
            }
        }

        static void Main(string[] args)
        {
            //RunTimesTable();
            RunFactorial();
        }
    }
}
