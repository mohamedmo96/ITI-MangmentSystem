using Microsoft.EntityFrameworkCore;

namespace MVC_LAP.Models
{
    public class ITIdbcontext:DbContext
    {

        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Trainee> Trainees { get; set; }
        public DbSet<CourseTrainee> CourseTrainees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=ITIDATABASE;Integrated Security=True;Encrypt=False;");
        }
    }
   
    
}
