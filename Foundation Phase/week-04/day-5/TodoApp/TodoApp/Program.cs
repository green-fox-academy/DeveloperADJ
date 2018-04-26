using System;
using System.IO;

namespace TodoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskList.tasks.Add(new Task("Cheese"));
            TaskList.tasks.Add(new Task("Apples"));
            TaskList.tasks.Add(new Task("Bread"));
            TaskList.tasks.Add(new Task("Milk"));

            //string[] args = {"-c", "2"};
            var commandHandler = new CommandHandler();

            if (args.Length == 0)
            {
                PrintCommands();
            }
            else
            {
                commandHandler.ProcessArgs(args);
            }

            if (args[0] != "-l")
            {
                TaskList.PrintTaskList();

            }
        }

        public static void PrintCommands()
        {
            string[] commandList = File.ReadAllLines("CommandList.txt");

            foreach (var line in commandList)
            {
                Console.WriteLine(line);
            }
        }
    }
}
