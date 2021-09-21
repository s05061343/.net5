using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Model.HeroKuPostgreSQL
{
    public partial class TomzContext : DbContext
    {
        public TomzContext()
        {
        }

        public TomzContext(DbContextOptions<TomzContext> options)
            : base(options)
        {
        }

        public virtual DbSet<PRO2E_AUTH_LOGIN_USER> PRO2E_AUTH_LOGIN_USERs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("name=ConnectionStrings:Tomz");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "en_US.UTF-8");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
