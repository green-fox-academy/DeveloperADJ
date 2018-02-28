using System;
using System.Collections.Generic;

namespace Domino
{
    public class Dominoes
    {
        public static void Main(string[] args)
        {
            List<Domino> dominoes = InitializeDominoes();
            // You have the list of Dominoes
            // Order them into one snake where the adjacent dominoes have the same numbers on their adjacent sides
            // Create a function to write the dominous to the console in the following format
            // eg: [2, 4], [4, 3], [3, 5] ...
            CompareDominoes(InitializeDominoes());
            Console.ReadLine();
        }

        public static void CompareDominoes(List<Domino> listOfDominoes)
        {
            for (int i = 0; i < listOfDominoes.Count; i++)
            {
                Console.WriteLine(ArePairs(listOfDominoes, i)); 
            }
        }

        public static bool ArePairs(List<Domino> listOfDominoes, int i)
        {
            if (i+1 < listOfDominoes.Count)
            {
                int firstDominoRightNumber = listOfDominoes[i].GetValues()[1];
                int secondDominoLeftNumber = listOfDominoes[i + 1].GetValues()[0];

                return firstDominoRightNumber == secondDominoLeftNumber;
            }
            else
            {
                return false;
            } 
        }

        public static List<Domino> InitializeDominoes()
        {
            var dominoes = new List<Domino>();
            dominoes.Add(new Domino(5, 2));
            dominoes.Add(new Domino(4, 6));
            dominoes.Add(new Domino(1, 5));
            dominoes.Add(new Domino(6, 7));
            dominoes.Add(new Domino(2, 4));
            dominoes.Add(new Domino(7, 1));
            return dominoes;
        }
    }
}