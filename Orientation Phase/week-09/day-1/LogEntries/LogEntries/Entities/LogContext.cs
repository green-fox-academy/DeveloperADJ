using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogEntries.Entities
{
    public class LogContext : DbContext
    {
        public DbSet<Models.Log> logs;
    }
}
