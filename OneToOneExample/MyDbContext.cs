using Microsoft.EntityFrameworkCore;

namespace OneToOneExample
{
    public class MyDbContext : DbContext
    {
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<InstructorDetail> InstructorDetails { get; set; }
          protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=localhost;Port=3306;Database=onetooneexample;Uid=root;Pwd=parolagelecek;");
        }
    }
}