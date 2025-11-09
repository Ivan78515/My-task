using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class AppContext(DbContextOptions<AppContext> options):DbContext(options)
    {
        public DbSet<Note> Notes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Note>().HasKey(e => e.Id);
            modelBuilder.Entity<Note>().Property(e => e.Text).HasMaxLength(140);
            base.OnModelCreating(modelBuilder);
        }
    }
}
