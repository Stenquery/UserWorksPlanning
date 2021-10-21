using Microsoft.EntityFrameworkCore;
using UserProject.Entity;

namespace UserProject.DataAccess.Concrete.EfCore
{
    public class WorkContext:DbContext
    {
        public DbSet<Work> works {get;set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-NL4M9P0;Initial Catalog=WORKING;Integrated Security=SSPI");
        }
    }
}