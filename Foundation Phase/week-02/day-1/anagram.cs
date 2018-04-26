using System;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(IsAnagram());
            }

            

        }

        public static bool IsAnagram()
        {
            string firstWord;
            string secondWord;

            bool isAnagram = false;
            do
            {
                Console.WriteLine("Please enter two words; the computer will check if they are anagrams: ");

                firstWord = Console.ReadLine();
                secondWord = Console.ReadLine();
            } while (firstWord.Length != secondWord.Length);

            int wordLength = firstWord.Length;
            int numberOfMatchingCharacters = 0;

            bool foundLetter = false;

            for (int i = 0; i < wordLength; i++)
            {
                for (int j = 0; j < wordLength; j++)
                {
                    if (firstWord[i] == secondWord[j])
                    {
                        numberOfMatchingCharacters += 1;
                        Console.WriteLine("Found a matching character: " + secondWord[j]);
                        break;
                    }
                    else
                    {
                        numberOfMatchingCharacters += 0;
                    }

                }

            }
            if (wordLength == numberOfMatchingCharacters) { 
                Console.WriteLine("The words are anagrams");
                isAnagram = true;
            }
            else
            {
                Console.WriteLine("The words are not anagrams");
                isAnagram = false;
            }

            return isAnagram;

        }
    }
}