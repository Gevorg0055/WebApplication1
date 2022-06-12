using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class TaskContext : DbContext
    {
        public DbSet<Employee> employees { get; set; }
        public DbSet<HRDataget> Hrdatas { get; set; }
        public TaskContext(DbContextOptions options) : base(options)
        {

        }
    }
}
