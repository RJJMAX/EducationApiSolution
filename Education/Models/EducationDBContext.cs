using Microsoft.EntityFrameworkCore;

namespace Education.Models {
    public class EducationDBContext : DbContext {
        public DbSet<Major> Majors { get; set; }
        public DbSet<Student> Students { get; set; }

    public EducationDBContext(DbContextOptions<EducationDBContext> options) : base(options) { }
    }
}
