using Blazor_Domain_Library.Entities.Security;
using Microsoft.EntityFrameworkCore;

namespace Blazor_Infrastructure_Library.DatabaseContext
{
    public class DbContextApplication : DbContext
    {
        public DbContextApplication(DbContextOptions<DbContextApplication> options) : base(options)
        {
        }

        public DbSet<UserEntity> Users{ get; set; }









        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
