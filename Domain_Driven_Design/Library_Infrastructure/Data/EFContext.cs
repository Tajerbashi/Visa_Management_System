using Microsoft.EntityFrameworkCore;

namespace Domain_Driven_Design_Solution.Library_Infrastructure.Data
{
    public class EFContext : DbContext
    {
        public EFContext(DbContextOptions options) : base(options)
        {
        }
    }
}
