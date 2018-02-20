using System;
using System.Collections.Generic;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberOfPeople = 41;

            JosephusProblem(numberOfPeople);

            Console.ReadLine();
        }

        public static string JosephusProblem(double numberOfPeople)
        {
            int survivingNumber;

            var participants = new List<int>();

            for (int i = 0; i < numberOfPeople; i++)
            {
                participants.Add(1);
            }

            Console.WriteLine(participants.Count);
            
            for (int i = 0; i < participants.Count; i++)
            {
                if (i % 2 != 0)
                {
                    participants[i] = 0;
                }
                else
                {
                    
                }

                if (participants.Count % 2 != 0)
                {
                    participants[0] = 0;
                }


                    if (participants[i].Equals(1))
                    {
                        
                    }
                    
                    
                }

            }

            //participants.RemoveAll();

            //INFO
            Console.Write("[");
            foreach (var participant in participants)
            {

                Console.Write(participant + ", ");
            }
            Console.Write("]");
            //INFO

            return "";
        }

        public static void showParticipants()
        {

        }

    }
}