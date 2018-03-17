using System;
using System.Collections.Generic;
using System.Text;

namespace CountLetters
{
    public class Letters
    {

        public Dictionary<string, int> CountInDictionary(string word)
        {
            var wordCounter = new Dictionary<string, int>();

            foreach (var ch in word)
            {
                string character = Convert.ToString(ch);

                if (wordCounter.ContainsKey(character))
                {
                    wordCounter[character]++;
                }
                else
                {
                    wordCounter.Add(character, 1);
                }
            }

            return wordCounter;
        }
    }
}
