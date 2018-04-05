using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anagram.Services
{
    public interface IAnagramCheckable
    {
        string CheckWordForAnagram(string firstWord, string secondWord);
    }
}
