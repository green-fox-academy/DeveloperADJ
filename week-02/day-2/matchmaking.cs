using System;
using System.Collections.Generic;
using System.Text;

namespace Matchmaking
{
    public class Matchmaking
    {
        public static void Main(string[] args)
        {
            var girls = new List<string> { "Eve", "Ashley", "Bözsi", "Kat", "Jane" };
            var boys = new List<string> { "Joe", "Fred", "Béla", "Todd", "Neef", "Jeff" };

            // Write a method that joins the two lists by matching one girl with one boy into a new list
            // Exepected output: "Eve", "Joe", "Ashley", "Fred"...

            Console.WriteLine(MakingMatches(girls, boys));
            Console.ReadLine();
        }

        public static StringBuilder MakingMatches(List<string> onlyGirls, List<string> onlyBoys)
        {
            StringBuilder girlsAndBoys = new StringBuilder();

            for (int i = 0; i < onlyGirls.Count; i++)
            {
                girlsAndBoys.Append($"\"{onlyGirls[i]}\", ");
                girlsAndBoys.Append($"\"{onlyBoys[i]}\", ");

            }

            girlsAndBoys = girlsAndBoys.Remove(girlsAndBoys.Length - 2, 2);

            return girlsAndBoys;
        }
    }
}