
using Microsoft.EntityFrameworkCore;

namespace DotnetBoilerplate.Infra.Context
{
    public class BoilerplateContext : DbContext
    {
        public BoilerplateContext(DbContextOptions<BoilerplateContext> options)
            : base(options)
        {
        }

        // Define DbSets for your entities here
        // public DbSet<YourEntity> YourEntities { get; set; }
    }

}