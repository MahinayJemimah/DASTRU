using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahinay_review1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Message displayed to the user
            Console.WriteLine("This program will determine what type of number and display its range.");
            Console.WriteLine();


            // Output 1
            do
            {
                Console.Write("Enter a number between 1 and 10: ");
                int number1 = int.Parse(Console.ReadLine());
                if (number1 >= 1 && number1 <= 10)
                {
                    Console.WriteLine("You entered: " + number1);
                    Console.WriteLine("Numbers in range: " + (number1 - 1) + ", " + number1 + ", "
                    + (number1 + 1));
                }
                else
                {
                    Console.WriteLine("Invalid number! Please enter a number between 1 and 10.");
                }
                Console.WriteLine();
                Console.Write("Do you want to try again? (Y/N): ");
            } while (Console.ReadLine().ToUpper() == "Y");
            Console.WriteLine();


            // Output 2
            do
            {
                Console.Write("Enter a number between 5 and 15: ");
                int number2 = int.Parse(Console.ReadLine());
                if (number2 >= 5 && number2 <= 15)
                {
                    Console.WriteLine("You entered: " + number2);
                    Console.WriteLine("Numbers in range: " + (number2 - 2) + ", " + number2 + ", "
                    + (number2 + 2));
                }
                else
                {
                    Console.WriteLine("Invalid number! Please enter a number between 5 and 15.");
                }
                Console.WriteLine();
                Console.Write("Do you want to try again? (Y/N): ");
            } while (Console.ReadLine().ToUpper() == "Y");
            Console.WriteLine();


            // Output 3
            do
            {
                Console.Write("Enter an irrelevant number (outside 1-100): ");
                int number3 = int.Parse(Console.ReadLine());
                if (number3 < 1 || number3 > 100) // Valid Range
                {
                    Console.WriteLine("This number is considered irrelevant.");
                }
                else
                {
                    Console.WriteLine("This number is valid, but we need an irrelevant number.");
                }
                Console.WriteLine();
                Console.Write("Do you want to try again? (Y/N): ");
            } while (Console.ReadLine().ToUpper() == "Y");
            Console.WriteLine();
            Console.WriteLine("Thank you for using the Number Range Program!"); // Closing
            Console.ReadKey();
        }
    }
}
