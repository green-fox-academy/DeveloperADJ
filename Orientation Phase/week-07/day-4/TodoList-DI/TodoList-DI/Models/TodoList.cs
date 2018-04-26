using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoList_DI.Services;

namespace TodoList_DI.Models
{
    public class TodoList : ICreatable
    {
        public List<Todo> todos = new List<Todo>
        {
            new Todo("Grocery shopping"),
            new Todo("Cinema"),
            new Todo("Eat"),
            new Todo("Go out"),
            new Todo("Finish exercise")
        };

        public void Create(string task)
        {
            if (task != null)
            {
                todos.Add(new Todo(task));
            }
        }

        public void Delete(int taskIndex)
        {
            todos.RemoveAt(taskIndex);
        }

        public void Order()
        {
            todos.OrderBy(x=>x.IsUrgent);
        }
    }
}
