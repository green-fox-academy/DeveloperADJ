using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogEntries.Models
{
    public class Log
    {
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public string EndPoint { get; set; }
        public string Data { get; set; }

        public Log()
        {
            CreatedAt = DateTime.Now;
        }
    }
}
