using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoList_DI.Services
{
    public interface ICreatable
    {
        void Create(string task);
        void Delete(int taskIndex);
        void Order();
    }
}
