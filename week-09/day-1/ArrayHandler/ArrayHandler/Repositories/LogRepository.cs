using LogEntries.Entities;
using LogEntries.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArrayHandler.Repositories
{
    public class LogRepository : ILogRepository
    {
        LogContext logContext;

        public LogRepository(LogContext logContext)
        {
            this.logContext = logContext;
        }

        public void Create(string endPoint, string data)
        {
            logContext.Logs.Add(new Log() {
                EndPoint = endPoint,
                Data = data,
            });

            logContext.SaveChanges();
        }

        public void Delete()
        {
        }

        public List<Log> Read()
        {
            return logContext.Logs.ToList();
        }

        public void Update()
        {
        }
    }
}
