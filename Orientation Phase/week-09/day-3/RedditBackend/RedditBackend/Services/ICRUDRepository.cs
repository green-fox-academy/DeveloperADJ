using RedditBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditBackend.Services
{
    public interface ICRUDRepository<T>
    {
        T Create(T post);
        List<T> Read();
        T Update(int id, T updatedClass);
        T Delete(int id);

    }
}
