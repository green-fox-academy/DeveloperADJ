using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoList_DI.Models
{
    public class Todo
    {
        public string Name { get; set; }
        public bool IsUrgent { get; set; }

        public Todo(string name, bool isUrgent = false)
        {
            Name = name;
            IsUrgent = isUrgent;
        }
    }
}
