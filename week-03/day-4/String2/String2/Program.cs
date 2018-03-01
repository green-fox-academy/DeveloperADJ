﻿using System;

namespace String2
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "xoxoxoxoxoxoxoxoxox";
            Console.WriteLine(RemoveAllXes(sentence));
            Console.ReadLine();   
        }

        public static string RemoveAllXes(string sentence)
        {
            if (sentence == "")
            {
                return sentence;
            }
            else
            {
                if (sentence[0] == 'x')
                {
                    return "" + RemoveAllXes(sentence.Substring(1));
                }
                else
                {
                    return sentence[0] + RemoveAllXes(sentence.Substring(1));
                }
            }
        }
    }
}
