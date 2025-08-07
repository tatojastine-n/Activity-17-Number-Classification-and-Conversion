using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Classification_and_Conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[8];

            Console.WriteLine("Enter 8 whole numbers:");

            for (int i = 0; i < 8; i++)
            {
                Console.Write($"Number {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out numbers[i]))
                {
                    Console.WriteLine("Invalid input. Please enter a whole number.");
                    Console.Write($"Number {i + 1}: ");
                }
            }

            Console.WriteLine("\nAnalysis Results:");
            Console.WriteLine("Number | Prime? | Binary  | Even/Odd");

            foreach (int num in numbers)
            {
                bool isPrime = IsPrime(num);
                string binary = Convert.ToString(num, 2);
                string evenOdd = (num % 2 == 0) ? "Even" : "Odd";

                Console.WriteLine($"{num,6} | {(isPrime ? "Yes" : "No"),6} | {binary,7} | {evenOdd}");
            }
        }
        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            for (int i = 3; i * i <= number; i += 2)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
    }
}
