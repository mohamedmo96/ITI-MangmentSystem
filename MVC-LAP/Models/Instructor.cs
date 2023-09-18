using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_LAP.Models
{
    public class Instructor
    {
        [Key]
        public int Ins_Id { get; set; }
        public string Ins_Name { get; set; }
        public string Ins_Image { get; set; }
        public int Salary { get; set; }
        public string Ins_Address { get; set; }
        [ForeignKey("Department")]
        public int Dept_Id { get; set; }
        public Department Department { get; set; }
        [ForeignKey("Course")]
        public int Crs_Id { get; set; }
        public Course Course { get; set; }
    }
}
