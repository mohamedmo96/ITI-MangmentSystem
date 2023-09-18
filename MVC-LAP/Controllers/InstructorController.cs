using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_LAP.Models;

namespace MVC_LAP.Controllers
{
    public class InstructorController : Controller
    {
        ITIdbcontext db = new ITIdbcontext();

        public IActionResult Index()
        {
           

            List<Instructor> instModel = db.Instructors.Include(p => p.Department).Include(p => p.Course).ToList();




            return View(instModel);
        }
        public IActionResult InstDetails(int id)
        {

            Instructor Details = db.Instructors.Include(i => i.Course).Include(i => i.Department).FirstOrDefault(i => i.Ins_Id == id);
            return View(Details);
        }


        public IActionResult AddNewInstrucore()
        {
            List<Department> dept = db.Departments.ToList();

            ViewData["deptname"] = dept;
            List<Course> Cour = db.Courses.ToList();

            ViewData["Cour"] =  Cour;
            return View();
        }
        public IActionResult CreateNewUser(Instructor instructor)
        {
           List<Department> dept = db.Departments.ToList();

            ViewData["deptname"] = dept;

            //add new user 
            if (instructor != null) 
            { 
                db.Instructors.Add(instructor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Index");
        }
        public IActionResult Editeinstructor(int id)
        {
            var model = db.Instructors.FirstOrDefault(i => i.Ins_Id == id);
            var dept = db.Departments.ToList();
            ViewData["dept"] = dept;
            var Course = db.Courses.ToList();
            ViewData["course"] = Course;

            return View(model);
        }

        public IActionResult SaveEdit(Instructor inst )
        {

            ITIdbcontext db = new ITIdbcontext();


            if (inst != null)
            {
                db.Update(inst);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            var dept = db.Departments.ToList();
            ViewData["dept"] = dept;

            var Course = db.Courses.ToList();
            ViewData["course"] = Course;

            return View("Editeinstructor", inst);
        }


    }
}
