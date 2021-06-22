using Harris.net.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Harris.net.Data
{
    public class HarrisDbContext : DbContext
    {
        public HarrisDbContext(DbContextOptions<HarrisDbContext> options) : base(options)
        {
        }

        public DbSet<personalcontact> PersonalContacts { get; set; }

        public DbSet<businesscontact> businesscontacts { get; set; }
    }
}
