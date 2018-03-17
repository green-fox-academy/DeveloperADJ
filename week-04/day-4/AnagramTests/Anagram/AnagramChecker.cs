using System;
using System.Collections.Generic;
using System.Text;

namespace Anagram
{
    public class AnagramChecker
    {
        public bool Compare(string firstWord, string secondWord)
        {
            firstWord = firstWord.ToLower();
            secondWord = secondWord.ToLower();

            List<char> firstList = WordToCharList(firstWord);
            List<char> secondList = WordToCharList(secondWord);

            firstList.Sort();
            secondList.Sort();
            
            return CharsToString(firstList) == CharsToString(secondList)
        }

        public List<char> WordToCharList(string word)
        {
            List<char> charsFromWord = new List<char>();

            foreach (var ch in word)
            {
                charsFromWord.Add(ch);
            }

            return charsFromWord;
        }

        public string CharsToString(List<char> chars)
        {
            string word = "";
            foreach (var ch in chars)
            {
                word += ch;
            }
            return word;
        }
    }
}
