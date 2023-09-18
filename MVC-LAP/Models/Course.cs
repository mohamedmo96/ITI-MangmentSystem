using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_LAP.Models
{
    public class Course
    {
        [Key]
        public int Crs_Id { get; set; }
        public string Crs_Name { get; set; }
        public int Crs_Degree { get; set; }
        public int Crs_MinDegree { get; set; }
        [ForeignKey("Department")]
        public int Dept_Id { get; set; }
        public Department Department { get; set; }  
        public virtual ICollection<CourseTrainee> CourseTrainees { get; set; }
        public virtual ICollection<Instructor> Instructors { get; set; }

    }
}
