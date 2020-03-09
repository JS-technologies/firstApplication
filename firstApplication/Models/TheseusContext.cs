using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace firstApplication.Models
{
    public partial class TheseusContext : DbContext
    {
        public TheseusContext()
        {
        }

        public TheseusContext(DbContextOptions<TheseusContext> options)
            : base(options)
        {
        }

        public virtual DbSet<User> Users { get; set; }
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=laredouteosp,9004;Database=Theseus;User Id= anthony borg; Password=rem;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Users", "cms");
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
