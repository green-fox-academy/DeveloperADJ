using System;
using System.Collections.Generic;
using System.Text;

namespace TodoApp
{
    public class CommandHandler
    {
        public void ProcessArgs(string[] args)
        {
            if (args[0] == "-l")
            {
                List();
            }
            else if (args[0] == "-a")
            {
                Add(args);
            }
            else if (args[0] == "-r")
            {
                Remove(args);

            }
            else if (args[0] == "-c")
            {
                Complete(args);
            }
        }

        void List()
        {
            TaskList.PrintTaskList();
        }

        void Add(string[] args)
        {
            try
            {
                if (TaskList.tasks.Count == 1)
                {
                    throw new Exception("Unable to add: no task provided");
                }
                else if (TaskList.IsDuplicate(args[1]))
                {
                    Console.WriteLine("This task already exists");
                }
                else
                {
                    TaskList.tasks.Add(new Task($"{args[1]}"));
                    Console.WriteLine("Added the task: " + args[1]);
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }

        void Remove(string[] args)
        {
            try
            {
                int index;

                if (args.Length < 2)
                {
                    throw new Exception("Unable to remove: no index provided");
                }
                else
                {
                    index = Convert.ToInt32(args[1]);
                    if (TaskList.tasks.Count < index + 1)
                    {
                        throw new Exception("Unable to remove: index out of range");
                    }
                    else
                    {
                        TaskList.tasks.RemoveAt(index-1);
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }

        void Complete(string[] args)
        {
            try
            {
                int index;

                if (args.Length < 2)
                {
                    throw new Exception("Unable to mark as Completed: no index provided");
                }
                else
                {
                    index = Convert.ToInt32(args[1]);
                    if (TaskList.tasks.Count < index)
                    {
                        throw new Exception("Unable to mark as Completed: index out of range");
                    }
                    else
                    {
                        TaskList.tasks[index-1].isCompleted = true;
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }
    }
}

