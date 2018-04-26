using System;
using System.Collections.Generic;

namespace IsInList
{
    public class IsInList
    {
        public static void Main(string[] args)
        {
            var list = new List<int> { 2, 4, 6, 8, 10, 12, 14, 16 };

            // Check if list contains all of the following elements: 4,8,12,16
            // Create a method that accepts list as an input
            // it should return "true" if it contains all, otherwise "false"
            Console.WriteLine(CheckNums(list));
            Console.ReadLine();

        }

        public static bool CheckNums(List<int> inputList)
        {
            bool containsAllElements = false;

            var checkList = new List<int> { 4, 8, 12, 16 };
            int checklistItemsDone = 0;

            for (int i = 0; i < checkList.Count; i++)
            {
                for (int j = 0; j < inputList.Count; j++)
                {
                    if (checkList[i] == inputList[j])
                    {
                        checklistItemsDone += 1;
                    }
                }
            }

            if (checklistItemsDone == checkList.Count)
            {
                containsAllElements = true;
            }

            return containsAllElements;
        }



    }
}