using System;

namespace String1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given a string, compute recursively (no loops) a new string where all the
            // lowercase 'x' chars have been changed to 'y' chars.

            string sentence = "xxxxxxxxxxxxxxxxxxxxx sdadlkasdkasld xxxxx";

            Console.WriteLine(ReplaceXwithY(sentence));
            Console.ReadLine();
        }

        public static string ReplaceXwithY(string sentence, string newSentence = "", int i = 0)
        {
            if (i == sentence.Length)
            {
                return newSentence;
            }
            else
            {
                if (sentence[i] == 'x')
                {
                    newSentence += 'y';
                }
                else
                {
                    newSentence += sentence[i];
                }
                return ReplaceXwithY(sentence, newSentence, i + 1);
            }
        }
    }
}
