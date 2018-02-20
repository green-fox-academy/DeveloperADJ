using System;

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

            Console.WriteLine("This calculator takes one operation and two operands\n");
            Console.Write("Use which operation? (+, -, *, /, %): ");
            string operation = Console.ReadLine();

            Console.Write("Enter the value for the first operand: ");
            double operand1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the value for the second operand: ");
            double operand2 = double.Parse(Console.ReadLine());
            
            Console.WriteLine(Calculate(operation, operand1, operand2));
            Console.ReadLine();


            /*Console.WriteLine("Please type in the expression:");
            string Console.ReadLine();*/

        }

        public static double Calculate(string operation, double firstOperand, double secondOperand)
        {

            double result = 0;

            switch (operation)
            {
                case "+":
                    result = firstOperand + secondOperand;
                    break;

                case "-":
                    result = firstOperand - secondOperand;
                    break;

                case "*":
                    result = firstOperand * secondOperand;
                    break;

                case "/":
                    result = firstOperand / secondOperand;
                    break;

                case "%":
                    result = firstOperand % secondOperand;
                    break;

                default:
                    break;
            }
            return result;
        }

    }
}