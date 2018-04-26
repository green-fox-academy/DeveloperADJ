using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Todos.Services;

namespace Todos.Models
{
    public class Repository : IRepository
    {
       private TodoContext context;

        public Repository(TodoContext context)
        {
            this.context = context;
        }

        public void Create(Todo todo)
        {
            context.Add(todo);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            Todo todo = context.Todos.FirstOrDefault(x => x.Id == id);
            context.Remove(todo);
            context.SaveChanges();
        }

        public List<Todo> Read()
        {
           return context.Todos.ToList();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
