using Microsoft.EntityFrameworkCore;

namespace InstructorCourseExample
{
    public class MyDbContext : DbContext
    {
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=localhost;Port=3306;Database=relationshipexample;Uid=root;Pwd=parolagelecek;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().Property(course => course.Title).HasMaxLength(50);
            modelBuilder.Entity<Instructor>().Property(instructor => instructor.FirstName).HasMaxLength(50);
            modelBuilder.Entity<Instructor>().Property(instructor => instructor.LastName).HasMaxLength(50);
            modelBuilder.Entity<Instructor>().Property(instructor => instructor.Email).HasMaxLength(120);
               
        }
    }
}