using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using clearwox.Models;

namespace clearwox.Data
{
    public class clearwoxContext : DbContext
    {
        public clearwoxContext (DbContextOptions<clearwoxContext> options)
            : base(options)
        {
        }

        public DbSet<clearwox.Models.Blog> Blog { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>().ToTable("Blog");
           
        }
    }
}
