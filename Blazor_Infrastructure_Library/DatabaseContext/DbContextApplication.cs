using Blazor_Domain_Library.Entities.Security;
using Microsoft.EntityFrameworkCore;

namespace Blazor_Infrastructure_Library.DatabaseContext
{
    public class DbContextApplication : DbContext
    {
        public DbContextApplication(DbContextOptions<DbContextApplication> options) : base(options)
        {
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


        public DbSet<UserEntity> Users { get; set; }

    }
}
