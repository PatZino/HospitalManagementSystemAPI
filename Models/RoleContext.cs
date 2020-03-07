using HMS.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HMS.Models
{
    public class RoleContext: DbContext
    {
        public RoleContext(DbContextOptions<RoleContext> options)
          : base(options)
        {
        }

        public DbSet<User> users { get; set; }
    }
}
