using Microsoft.EntityFrameworkCore;

namespace CraftU.Models
{
    public class CraftUContext : DbContext
    {
        public DbSet<CraftCourse> CraftCourses { get; set; }
        public DbSet<Supply> Supplies { get; set; }
        public DbSet<Student> Students { get; set; }

        public CraftUContext(DbContextOptions options) : base(options) { }
    }
}
