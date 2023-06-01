using DataLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Data
{
    public class AmuseDbContext : DbContext
    {
        public AmuseDbContext(DbContextOptions<AmuseDbContext> options) : base(options) { }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Attraction> Attractions { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
