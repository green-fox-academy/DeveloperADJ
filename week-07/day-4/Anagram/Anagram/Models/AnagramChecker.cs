using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anagram.Models
{
    public class AnagramChecker
    {
        public string Message { get; set; }

        public AnagramChecker(string message = "The word is not an anagram")
        {
            Message = message;
        }

        public static string CheckWordForAnagram(string word) => $"{word} is an Anagram.";
    }
}
