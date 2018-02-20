using System;
using System.Text;

namespace Reverse
{
    public class Reverse
    {
        public static void Main(string[] args)
        {
            string reversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";

            // Create a method that can reverse a String, which is passed as the parameter
            // Use it on this reversed string to check it!

            Console.WriteLine(ReverseString(reversed));
            Console.ReadLine();
        }

        public static string ReverseString(string sentence) {

                string reverseWords = "";

                for (int i = sentence.Length - 1; i >= 0; i--)
                {
                    reverseWords += sentence[i];
                }
                return reverseWords;
        }

    }
}