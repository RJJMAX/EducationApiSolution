using Microsoft.EntityFrameworkCore;

namespace Education.Models {
    public class EducationDBContext : DbContext {
        public DbSet<Major> Majors { get; set; } = null!; // = null!; removes the 'could be null' green line under EducationDBContext
        public DbSet<Student> Students { get; set; } = null!; // but it is not necessary

    public EducationDBContext(DbContextOptions<EducationDBContext> options) : base(options) { }
    }
}
