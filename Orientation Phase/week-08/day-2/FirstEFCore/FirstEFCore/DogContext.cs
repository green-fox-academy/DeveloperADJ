using FirstEFCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstEFCore
{
    public class DogContext : DbContext
    {
        public DbSet<Dog> Dogs{ get; set; }

        public DogContext(DbContextOptions options):base(options)
        {
        }
    }
}
