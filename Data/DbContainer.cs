using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tagroba1000.API.Data;
using tagroba1000.API.Models;

namespace tagroba1000.API.Data
{
    public class DbContainer : IdentityDbContext<ApplicationUser>
    {
        public DbContainer(DbContextOptions<DbContainer> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; }
    }
}
