using System;
using System.Collections.Generic;
using System.Text;

namespace QuoteSwap
{
    public class QuoteSwap
    {
        public static void Main(string[] args)
        {
            var list = new List<string> { "What", "I", "do", "create,", "I", "cannot", "not", "understand." };

            // Accidentally I messed up this quote from Richard Feynman.
            // Two words are out of place
            // Your task is to fix it by swapping the right words with code
            // Create a method called QuoteSwap().

            // Also, print the sentence to the output with spaces in between.
            Console.WriteLine(SwapQuote(list));
            Console.ReadLine();
            // Expected output: "What I cannot create I do not understand." 
        }

        public static StringBuilder SwapQuote(List<string> inputList)
        {
            StringBuilder outputString = new StringBuilder();

            string b = inputList[5];
            string c = inputList[2];

            inputList[2] = b;
            inputList[5] = c;

            foreach (var word in inputList)
            {
                outputString.Append($"{word} ");
            }

            return outputString;
        }


    }
}