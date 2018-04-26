using System;
using System.Collections.Generic;

namespace Calculator
{
    public class Calculator
    {
        public static void Main(string[] args)
        {
            // Create a simple calculator application which reads the parameters from the prompt
            // and prints the result to the prompt.
            // It should support the following operations,
            // reate a method named "Calculate()":
            // +, -, *, /, % and it should support two operands.
            // The format of the expressions must be: {operation} {operand} {operand}.
            // Examples: "+ 3 3" (the result will be 6) or "* 4 4" (the result will be 16)

            // You can use the Scanner class
            // It should work like this:

            // Start the program
            // It prints: "Please type in the expression:"
            // Waits for the user input
            // Print the result to the prompt
            // Exit

            while (true)
            {
                Console.WriteLine("Please type in the expression:");
                string userExpression = Console.ReadLine();
                Console.WriteLine(Calculate(userExpression));
            }
        }

        public static double Calculate(string expression)
        {
            var operationsList = new List<string> {"+", "-", "*", "/", "%"};

            double result = 0;

            string selectedOperation = "";

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression.Contains(operationsList[i]))
                {
                    selectedOperation = operationsList[i];
                }
            }

            var listOfValues = new List<double>();

            string[] splitExpression = expression.Split(' ');

            switch (selectedOperation)
            {
                case "+":
                    result = double.Parse(splitExpression[1]) + double.Parse(splitExpression[2]);
                    break;

                case "-":
                    result = double.Parse(splitExpression[1]) - double.Parse(splitExpression[2]);
                    break;

                case "*":
                    result = double.Parse(splitExpression[1]) * double.Parse(splitExpression[2]);
                    break;

                case "/":
                    result = double.Parse(splitExpression[1]) / double.Parse(splitExpression[2]);
                    break;

                case "%":
                    result = double.Parse(splitExpression[1]) % double.Parse(splitExpression[2]);
                    break;

                default:
                    break;
            }
            return result;
        }

    }
}