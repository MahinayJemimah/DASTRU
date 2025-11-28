using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mahinay2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ============================
            // OUTPUT 1
            // ============================

            // Ask user for a number
            Console.Write("Enter a number between 1 and 10: ");
            int num1 = int.Parse(Console.ReadLine());

            // Check if number is valid for the expected range
            if (num1 >= 1 && num1 <= 10)
            {
                Console.WriteLine("\nRange of numbers from 1 up to your number:");
                for (int i = 1; i <= num1; i++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine("Invalid number! Program ending...");
                return; // Ends program if first number is irrelevant
            }


            // ============================
            // OUTPUT 2
            // ============================

            // Ask user again for another number
            Console.Write("Try again. Enter another number between 1 and 10: ");
            int num2 = int.Parse(Console.ReadLine());

            // Check if second number is valid
            if (num2 >= 1 && num2 <= 10)
            {
                Console.WriteLine("\nRange of numbers from 1 up to your second number:");
                for (int i = 1; i <= num2; i++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine("Invalid number! Program ending...");
                return;
            }


            // ============================
            // OUTPUT 3
            // ============================

            // Final input — must be irrelevant to end the program
            Console.Write("Enter any number outside the 1-10 range to end the program: ");
            int num3 = int.Parse(Console.ReadLine());

            // If irrelevant, show message and end
            if (num3 < 1 || num3 > 10)
            {
                Console.WriteLine("\nYou entered an irrelevant number. Program will now end.");
            }
            else
            {
                // If user still enters a valid number, we still stop the program
                Console.WriteLine("\nThat is still a valid number, but this is the last attempt. Program ending...");
            }

            Console.WriteLine("\nThank you for using the program!");
        
        }
    }
}
