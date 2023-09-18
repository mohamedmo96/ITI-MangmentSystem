using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_LAP.Models;
using MVC_LAP.ViewModel;

namespace MVC_LAP.Controllers
{
    public class TraineeCourseController : Controller
    {
        //public IActionResult Index(int Trn_ID , int Cr_Id)
        //{
        //    ITIdbcontext db = new ITIdbcontext();
        //   var traine = db.CourseTrainees.Where(t => t.TC_Id == Trn_ID && t.Crs_Id==Cr_Id).ToList();
        //    viewModelTC.TrnId = 
        //    return View();
        //}

        public IActionResult Index(int tr_id, int cr_id)
        {

            ITIdbcontext db = new ITIdbcontext();

            var trainee = db.Trainees.FirstOrDefault(t=>t.Trn_Id==tr_id);
            var course = db.Courses.FirstOrDefault(c=>c.Crs_Id==cr_id);

            var TrainCourse = db.CourseTrainees.FirstOrDefault(p => p.Trn_Id == tr_id && p.Crs_Id == cr_id);

            var Vmodel = new TraineeAndCourseNameViewModel();

            Vmodel.TrnName = trainee.Trn_Name;
            Vmodel.CRid = course.Crs_Id;
            Vmodel.TraineeImage = trainee.Trn_Img;
            Vmodel.CrsName = course.Crs_Name;
            Vmodel.TCDegree = TrainCourse.TC_Degree;
            Vmodel.DegTosucces = course.Crs_MinDegree;
            Vmodel.Coler = TrainCourse.TC_Degree < course.Crs_MinDegree ? "red" : "Green";

            return View(Vmodel);

        }
    }
}
