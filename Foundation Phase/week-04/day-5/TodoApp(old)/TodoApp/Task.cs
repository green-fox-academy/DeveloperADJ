using System;
using System.Collections.Generic;
using System.Text;

namespace TodoApp
{
    public class Task
    {
        public string text;
        public bool isCompleted;

        public Task(string text, bool isCompleted = false)
        {
            this.text = text;
            this.isCompleted = isCompleted;
        }
    }
}
