using System;

namespace PalindromeSearcher
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Exercise
            Create a function named search palindrome following your current language's style guide. 
            It should take a string, search for palindromes that at least 3 characters long and 
            return a list with the found palindromes.

            Examples
            input   output
            "dog goat dad duck doodle never"["og go", "g g", " dad ", "dad", "d d", "dood", "eve"]
            "apple"[]
            "racecar"["racecar", "aceca", "cec"]
            ""[]
            */
            string inputSentence = "dog goat dad duck doodle never";

            SearchPalindrome(inputSentence);
            
            Console.ReadLine();
        }

        public static string reverseString(string words)
        {
            string reverseWords = "";
            for (int i = words.Length-1; i >= 0; i--)
            {
                reverseWords += words[i];   
            }
            return reverseWords;
        }

        public static void SearchPalindrome(string sentence) {
            int arrayLength = 0;
            for (int start = 0; start < sentence.Length; start++)
            {
                if (start <= sentence.Length)
                {
                    for (int end = 3; end + start <= sentence.Length; end++)
                    {
                        string sliceOfSentence = sentence.Substring(start, end);

                        if (sliceOfSentence == reverseString(sliceOfSentence))
                        {
                            Console.Write(sliceOfSentence + ", ");
                            arrayLength += 1;
                        }
                    }
                }
            }
        }
    }
}