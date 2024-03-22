using Microsoft.EntityFrameworkCore;
using TestRegister.Models;

namespace TestRegister.Data
{
    public class ApplicationDbContext : DbContext
    {

       public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<ManagerData> ManagerDatas { get; set; }
        public DbSet<Facility> Facilities { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Award> Awards { get; set; }
        public DbSet<Attraction> Attractions { get; set; }
    }
}
