using Microsoft.EntityFrameworkCore;
using PaytrackAppTesting.API.Models;

namespace PaytrackAppTesting.API.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Organisation> Organisations { get; set; }
        public DbSet<PolicyTemplate> PolicyTemplates { get; set; }
        public DbSet<Npi> Npis { get; set; }
        public DbSet<NpiPolicyRule> NpiPolicyRules { get; set; }
        public DbSet<NpiAmount> NpiAmounts { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
