using System;

namespace PalindromeBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please enter a word and the program will turn it into a palindrome: ");
                string userWord = Console.ReadLine();

                CreatePalindrome(userWord);
            }
        }

        public static void CreatePalindrome(string word)
        {
            string flippedWord = "";

            for (int i = word.Length; i > 0; i--)
            {
                flippedWord += word[i -1];
            }

            Console.WriteLine(word + flippedWord);
        }


    }
}