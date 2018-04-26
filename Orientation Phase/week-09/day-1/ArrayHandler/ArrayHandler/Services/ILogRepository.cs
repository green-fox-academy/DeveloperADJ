using LogEntries.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArrayHandler.Repositories
{
    public interface ILogRepository
    {
        void Create(string endPoint, string data);
        List<Log> Read();
        void Update();
        void Delete();
    }
}
