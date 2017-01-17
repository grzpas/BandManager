using MySql.Data.Entity;
using System.Data.Entity;

namespace Band
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class BandDbContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
