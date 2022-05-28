using Kw.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kw.Data
{
    public class KwDbContext : DbContext
    {
        public KwDbContext(DbContextOptions<KwDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
