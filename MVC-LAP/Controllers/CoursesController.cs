using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_LAP.Models;
using MVC_LAP.ViewModel;

namespace MVC_LAP.Controllers
{
    public class CoursesController : Controller
    {
        ITIdbcontext db = new ITIdbcontext();

        public IActionResult Index()
        {
            var model = db.Courses.ToList();
            return View(model); ;
        }
        public IActionResult CourseDetails(int id)
        {
            var Model = new List<CourseTraineeViewModel>();

            ITIdbcontext db = new ITIdbcontext();

            var Course = db.Courses.Include(t => t.CourseTrainees).ThenInclude(p => p.Trainee).FirstOrDefault(p => p.Crs_Id == id);
            var cour = db.Courses.FirstOrDefault(p => p.Crs_Id == id);
            foreach (var item in Course.CourseTrainees)
            {
                Model.Add(
                    new CourseTraineeViewModel
                    {

                        StudentName = item.Trainee.Trn_Name,
                        CourseName = item.Course.Crs_Name,
                        StudentDegree = item.TC_Degree,
                        

                    }
                );
            }
            ViewBag.coursename = Course.Crs_Name;

            return View(Model); ;
        }


        public IActionResult NewCourse()
        {
            var dept = db.Departments.ToList();
            ViewData["dept"] = dept;
            return View(); ;
        }
        public IActionResult CreateNewCourse (Course course)
        {
            //save 
            if (course != null)
            {
                db.Courses.Add(course);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            var dept = db.Departments.ToList();
            ViewData["dept"] = dept;
            return View("NewCourse"); 
        }


    }
}
