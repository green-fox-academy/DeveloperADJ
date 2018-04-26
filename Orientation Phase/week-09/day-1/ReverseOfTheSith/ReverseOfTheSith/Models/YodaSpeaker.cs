using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReverseOfTheSith.Models
{
    public class YodaSpeaker
    {
        public string Text { get; set; }

        public string TransformSentence()
        {
            List<string> switchedWords = new List<string>();

            Text = Text.ToLower();

            string sentence = "";

            List<string> sentences = Text.Split(".").ToList();
            List<string> words = sentences[0].Split(" ").ToList();

            for (int i = 1; i < words.Count; i+=2)
            {
                if (i + 2 > words.Count) 
                {
                    switchedWords.Add(words[words.Count]);
                }
                else
                {
                    switchedWords.Add(words[i]);
                    switchedWords.Add(words[i - 1]);
                }
            }

            foreach (var word in switchedWords)
            {
                sentence += word + " ";
            }

            sentence += ".";

            return sentence;
        }
    }
}
