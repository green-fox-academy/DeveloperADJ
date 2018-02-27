using System;
using System.Collections.Generic;
using System.IO;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a function that takes a filename as string,
            // open and read it. The file data represents a tic-tac-toe
            // game result. Return 'X'/'O'/'draw' based on which player
            // has winning situation.
            Console.WriteLine(ticTacResult("win-o.txt"));
            Console.WriteLine(ticTacResult("win-x.txt"));
            Console.WriteLine(ticTacResult("draw.txt"));
            // should print O

            Console.ReadLine();
        }

        public static string ticTacResult(string file)
        {
            
            string[] resultLines = File.ReadAllLines(file);
            List<char> resultChars = new List<char>();
            string gameResult = "";

            //Creates a character list
            for (int i = 0; i < resultLines.Length; i++)
            {
                foreach (var ch in resultLines[i])
                {
                    resultChars.Add(ch);
                }
            }

            //Top row
            if (resultChars[0] == resultChars[1] && resultChars[1] == resultChars[2])
            {
                gameResult = Convert.ToString(resultChars[0]);
                
            }
            //Mid row
            else if (resultChars[3] == resultChars[4] && resultChars[4] == resultChars[5])
            {
                gameResult = Convert.ToString(resultChars[3]);
            }
            //Bottom row
            else if (resultChars[6] == resultChars[7] && resultChars[7] == resultChars[8])
            {
                gameResult = Convert.ToString(resultChars[6]);
            }
            //Left column
            else if (resultChars[0] == resultChars[3] && resultChars[3] == resultChars[6])
            {
                gameResult = Convert.ToString(resultChars[0]);
            }
            //Middle column
            else if (resultChars[1] == resultChars[4] && resultChars[4] == resultChars[7])
            {
                gameResult = Convert.ToString(resultChars[1]);
            }
            //Right column
            else if (resultChars[2] == resultChars[5] && resultChars[5] == resultChars[8])
            {
                gameResult = Convert.ToString(resultChars[2]);
            }
            //Top left to bottom right
            else if (resultChars[0] == resultChars[4] && resultChars[4] == resultChars[8])
            {
                gameResult = Convert.ToString(resultChars[0]);
            }
            //Bottom left to top right
            else if (resultChars[6] == resultChars[4] && resultChars[4] == resultChars[2])
            {
                gameResult = Convert.ToString(resultChars[6]);
            }
            else
            {
                gameResult = "Draw";
            }

            return gameResult;

        }
    }
}