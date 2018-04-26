using System;
using System.Collections.Generic;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            What is Armstrong number ?
            An Armstrong number is an n - digit number that is equal to the sum of the nth powers of its digits.

            Let's demonstrate this for a 4-digit number: 1634 is a 4-digit number, raise each digit to the fourth power, 
            and add: 1^4 + 6^4 + 3^4 + 4^4 = 1634, so it is an Armstrong number.

            For a 3 - digit number: 153 is a 3 - digit number, raise each digit to the third power, 
            and add: 1 ^ 3 + 5 ^ 3 + 3 ^ 3 = 153, so it is an Armstrong number.
            
            Write a simple program to check if a given number is an armstrong number.The program should ask for a number.
            E.g. if we type 371, the program should print out: The 371 is an Armstrong number.*/

            double armstrongNumber1 = 1634;
            double armstrongNumber2 = 153;

            //CheckArmstrongNumber(armstrongNumber1);

            Console.WriteLine(CheckArmstrongNumber(armstrongNumber1));
            Console.WriteLine(CheckArmstrongNumber(armstrongNumber2));
            Console.ReadLine();
        }

        public static string CheckArmstrongNumber(double number)
        {
            string outputMessage;

            string numberToString = Convert.ToString(number);

            int numberOfDigits = numberToString.Length;

            var listOfNumbers = new List<double>();

            double raisedDigitsTotal = 0;

            Console.WriteLine("The number being checked is: " + number);
            Console.WriteLine("The string length is: " + numberToString.Length);

            for (int i = 0; i < numberToString.Length; i++)
            {
                raisedDigitsTotal += Math.Pow((int)Char.GetNumericValue(numberToString[i]), numberOfDigits);
            }

            Console.WriteLine($"raisedDigitsTotal = {raisedDigitsTotal}");

            if (raisedDigitsTotal == number)
                outputMessage = $"The number {raisedDigitsTotal} is an Armstrong number.";
            else
                outputMessage = $"The number {raisedDigitsTotal} is not an Armstrong number.";

            outputMessage += "\n";
            
            return outputMessage;
        }
    }
}
