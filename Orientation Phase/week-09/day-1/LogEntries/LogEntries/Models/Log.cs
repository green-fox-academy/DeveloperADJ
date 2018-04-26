using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogEntries.Models
{
    public class Log
    {
        public int Id { get; set; }

        private DateTime CreatedAt;
        private string endPoint;
        private string data;
    }
}
