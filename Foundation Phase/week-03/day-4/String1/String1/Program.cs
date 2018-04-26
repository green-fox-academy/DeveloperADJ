using System;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReplaceXWithY("xoxoxoxooxoxoxo"));
            Console.ReadLine();
        }

        public static string ReplaceXWithY(string sentence)
        {
            if (sentence == "")
            {
                return sentence;
            }
            else
            {
                if (sentence[0] == 'x')
                {
                    return 'y' + ReplaceXWithY(sentence.Substring(1));
                }
                else
                {
                    return sentence[0] + ReplaceXWithY(sentence.Substring(1));
                }
            }
        }
    }
}
