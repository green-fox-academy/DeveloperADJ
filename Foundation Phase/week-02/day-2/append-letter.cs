using System;
using System.Collections.Generic;
using System.Text;

namespace AppendLetter
{
    public class AppendLetter
    {
        public static void Main(string[] args)
        {
            var far = new List<string> { "kuty", "macsk", "kacs", "rók", "halacsk" };
            // Create a method called AppendA() that adds "a" to every string in the far list.
            // The parameter should be a list.

            Console.WriteLine(AppendA(far));
            Console.ReadLine();
            // Expected output: "kutya", "macska", "kacsa", "róka", "halacska"
        }


        public static StringBuilder AppendA(List<string> list) {

            StringBuilder appendedList = new StringBuilder();

            for (int i = 0; i < list.Count; i++)
            {
                list[i] += "a";
            }

            foreach (var item in list)
            {
                appendedList.Append($"\"{item}\", ");
            }

            appendedList.Remove(appendedList.Length - 2, 2);

            return appendedList;

        }



    }
}