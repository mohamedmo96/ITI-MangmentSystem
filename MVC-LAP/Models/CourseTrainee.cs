using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_LAP.Models
{
    public class CourseTrainee
    {
        [Key]
        public int TC_Id { get; set; }
        public int TC_Degree { get; set; }
        [ForeignKey("Course")]
        public int Crs_Id { get; set; }
        public Course Course { get; set; }
        [ForeignKey("Trainee")]

        public int Trn_Id { get; set; }
        public Trainee Trainee { get; set; }
    }
}
