using Anagram.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anagram.Models
{
    public class AnagramChecker : IAnagramCheckable
    {
        public string CheckWordForAnagram(string firstWord, string secondWord)
        {
            if (firstWord != null && secondWord != null)
            {
                string orderedFirstWord = String.Concat(firstWord.OrderBy(c => c)); ;
                string orderedSecondWord = String.Concat(secondWord.OrderBy(c => c));

                if (firstWord != secondWord)
                {
                    if (orderedFirstWord == orderedSecondWord)
                    {
                        return "The words are anagrams.";
                    }
                    else
                    {
                        return "The words are not anagrams.";
                    }
                }
                else
                {
                    return "The words are equal, not anagrams.";
                }
            }
            else
            {
                return "Some fields are left empty.";
            }
        }
    }
}
