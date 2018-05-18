using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180131_1._3_Homework_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "20180131_1._3_Homework_Console";

            Console.Write("Enter your first number - ");

            decimal firstNumber;
            firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your second number - ");

            decimal secondNumber;
            secondNumber = Convert.ToInt32(Console.ReadLine());

            //using String interpolation - $
            //String interpolation lets you piece together strings in a more concise and readable way.
            // \r\n - NewLine is typically two characters, a \r - carriage return and a \n - line feed.

            Console.WriteLine($"You entered {firstNumber} and {secondNumber}\r\n");
            Console.WriteLine($"Enter 1 - to add {firstNumber} + {secondNumber}\r\n" +
                              $"Enter 2 - to subtract {firstNumber} from {secondNumber}\r\n" +
                              $"Enter 3 - to subtract {secondNumber} from {firstNumber}\r\n" +
                              $"Enter 4 - to multiply {firstNumber} * {secondNumber}\r\n" +
                              $"Enter 5 - to divide {firstNumber} by {secondNumber}\r\n" +
                              $"Enter 6 - to divide {secondNumber} by {firstNumber}\r\n");

            string optionChoice = Console.ReadLine();

            Console.WriteLine("And your answer is - ");

            if (optionChoice == "1")
            {
                // three different options for displaying text - 
                // the resulting text is the same for all three examples -

                //Console.WriteLine(firstNumber + " + " + secondNumber + " = " + (firstNumber + secondNumber));
                //Console.WriteLine("{0} + {1} = {2}", firstNumber, secondNumber, (firstNumber + secondNumber));
                Console.WriteLine($"{firstNumber} + {secondNumber} = " + (firstNumber + secondNumber));
            }
            else if (optionChoice == "2")
            {
                Console.WriteLine($"{secondNumber} - {firstNumber} = " + (secondNumber - firstNumber));
            }
            else if (optionChoice == "3")
            {
                Console.WriteLine($"{firstNumber} - {secondNumber} = " + (firstNumber - secondNumber));
            }
            else if (optionChoice == "4")
            {
                Console.WriteLine($"{firstNumber} * {secondNumber} = " + (firstNumber * secondNumber));
            }
            else if (optionChoice == "5")
            {
                Console.WriteLine($"{firstNumber} / {secondNumber} = " + (firstNumber / secondNumber));
            }
            else // optionChoice == 6
            {
                Console.WriteLine($"{secondNumber} / {firstNumber} = " + (secondNumber / firstNumber));
            }

            Console.ReadLine();
        }
    }
}
