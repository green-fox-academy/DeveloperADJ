using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Todos.Models;

namespace Todos.Services
{
    public interface IRepository
    {
        void Create(Todo todo);
        List<Todo> Read();
        void Update();
        void Delete(int id);
    }
}
