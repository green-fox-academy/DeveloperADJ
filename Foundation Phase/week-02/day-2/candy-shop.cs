using System;
using System.Collections.Generic;
using System.Text;

namespace CandyShop
{
    public class Candyshop
    {
        public static void Main(string[] args)
        {
            var list = new List<object>();
            list.Add("Cupcake");
            list.Add(2);
            list.Add("Brownie");
            list.Add(false);

            // Accidentally we added "2" and "false" to the list.
            // Your task is to change from "2" to "Croissant" and change from "false" to "Ice cream"
            // No, don't just remove the lines
            // Create a method called Sweets() which takes the list as a parameter.

            Console.WriteLine(Sweets(list));
            Console.ReadLine();
            // Expected output: "Cupcake", "Croissant", "Brownie", "Ice cream"
        }

        public static StringBuilder Sweets(List<object> inputList)
        {
            StringBuilder outputString = new StringBuilder();

            for (int i = 0; i < inputList.Count; i++)
            {
                if (inputList[i].Equals(false))
                {
                    inputList[i] = "Ice Cream";
                } else if (inputList[i].Equals(2))
                {
                    inputList[i] = "Croissant";
                }
            }

            foreach (var word in inputList)
            {
                outputString.Append($"\"{word}\", ");
            }

            outputString = outputString.Remove(outputString.Length - 2, 2);

            return outputString;
        }

    }
}