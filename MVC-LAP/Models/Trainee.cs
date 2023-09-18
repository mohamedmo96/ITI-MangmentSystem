using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_LAP.Models
{
    public class Trainee
    {
        [Key]
        public int Trn_Id { get; set; }
        public string Trn_Name { get; set; }
        public string Trn_Img { get; set; }
        public string Trn_Address { get; set; }
        public string Trn_Grade { get; set; }
        [ForeignKey("Department")]
        public int Dept_Id { get; set; }
        public Department Department { get; set; }
        public virtual ICollection<CourseTrainee> CourseTrainees { get; set; }


    }
}
