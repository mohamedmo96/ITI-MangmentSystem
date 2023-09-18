using System.ComponentModel.DataAnnotations;

namespace MVC_LAP.Models
{
    public class Department
    {
        [Key]

        public int Dept_Id { get; set; }
        public string Dept_Name { get; set; }
        public string Dept_Manger { get; set; }

        public virtual  ICollection<Instructor> Instructors { get; set; }
        public virtual ICollection<Trainee> Trainees { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}
