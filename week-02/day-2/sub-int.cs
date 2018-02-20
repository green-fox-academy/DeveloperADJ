using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Create a function that takes a string and a list of string as a parameter
            //  Returns the index of the string in the list where the first string is part of
            //  Only need to find the first occurence and return the index of that
            //  Returns `-1` if the string is not part any of the strings in the list

            //  Example
            string[] searchArr = { "this", "is", "what", "I'm", "searching", "in" };

            Console.WriteLine(Substrlist("ching", searchArr));
            //  should print: `4`
            Console.WriteLine(Substrlist("not", searchArr));
            //  should print: `-1`  

            Console.ReadLine();
        }

        public static int Substrlist(string word, string[] arrayOfWords)
        {
            int indexOfString = -1;

            for (int i = 0; i < arrayOfWords.Length; i++)
            {

                if (arrayOfWords[i].Contains(word))
                {
                    indexOfString = i;
                }
            }

            

            return indexOfString;
        }



    }
using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Create a function that takes a string and a list of string as a parameter
            //  Returns the index of the string in the list where the first string is part of
            //  Only need to find the first occurence and return the index of that
            //  Returns `-1` if the string is not part any of the strings in the list

            //  Example
            string[] searchArr = { "this", "is", "what", "I'm", "searching", "in" };

            Console.WriteLine(Substrlist("ching", searchArr));
            //  should print: `4`
            Console.WriteLine(Substrlist("not", searchArr));
            //  should print: `-1`  

            Console.ReadLine();
        }

        public static int Substrlist(string word, string[] arrayOfWords)
        {
            int indexOfString = -1;

            for (int i = 0; i < arrayOfWords.Length; i++)
            {

                if (arrayOfWords[i].Contains(word))
                {
                    indexOfString = i;
                }
            }

            

            return indexOfString;
        }



    }
}