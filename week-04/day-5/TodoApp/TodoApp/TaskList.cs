using System;
using System.Collections.Generic;
using System.Text;

namespace TodoApp
{
    public class TaskList
    {
        public static List<Task> tasks = new List<Task>();

        public static void PrintTaskList()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("No todos for today! :)");
            }
            else
            {
                for (int i = 0; i < tasks.Count; i++)
                {
                    Console.Write($"{i+1} - ");
                    Console.Write(tasks[i].text);
                    Console.WriteLine(tasks[i].isCompleted ? "[X]":"[ ]");
                }
            }
        }

        public static bool IsDuplicate(string userText)
        {
            foreach (var task in tasks)
            {
                if (task.text == userText)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
