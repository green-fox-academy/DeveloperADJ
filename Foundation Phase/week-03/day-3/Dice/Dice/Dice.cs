using System;
using System.Text;

namespace Dice
{
    public class Dice
    {
        //    You have a Dice class which has 6 dice
        //    You can roll all of them with Roll()
        //    Check the current rolled numbers with GetCurrent()
        //    You can reroll with Reroll()
        //    Your task is to get where all dice is a 6
        static Random RandomValue;
        static int[] Dices = new int[6];

        public int[] Roll()
        {
            for (int i = 0; i < Dices.Length; i++)
            {
                Dices[i] = RandomValue.Next(1, 7);
            }
            return Dices;
        }

        public int[] GetCurrent()
        {
            return Dices;
        }

        public int GetCurrent(int i)
        {
            return Dices[i];
        }

        public void Reroll()
        {
            for (int i = 0; i < Dices.Length; i++)
            {
                Dices[i] = RandomValue.Next(1, 7);
            }
        }

        public void Reroll(int k)
        {
            Dices[k] = new Random().Next(1, 7);
        }

        public void RollTillSix()
        {
            int[] ArrayOfSixes = new int[6];

            for (int i = 0; i < Dices.Length; i++)
            {
                
                while (Dices[i] != 6)
                {
                    Reroll();
                    Console.WriteLine("Dice Roll: " + Dices[i]);
                }

                if (Dices[i] == 6)
                {
                    ArrayOfSixes[i] = Dices[i];
                    Console.WriteLine("Added 6 to the Array");
                }
            }

            StringBuilder ArrayOfSixesContents = new StringBuilder();

            ArrayOfSixesContents.Append("ArrayOfSixes: [");
            for (int i = 0; i < ArrayOfSixes.Length; i++)
            {
                ArrayOfSixesContents.Append(ArrayOfSixes[i]);

                if (i < ArrayOfSixes.Length-1)
                {
                    ArrayOfSixesContents.Append(", ");
                }
            }
            ArrayOfSixesContents.Append("]");

            Console.WriteLine(ArrayOfSixesContents);
            Console.ReadLine();
        }

        public static void Main(string[] args)
        {
            RandomValue = new Random();
            Dice myDice = new Dice();

            myDice.RollTillSix();
        }
    }
}