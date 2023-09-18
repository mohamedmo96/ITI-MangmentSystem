using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_LAP.Models;
using System.Linq;
using MVC_LAP.ViewModel;

namespace MVC_LAP.Controllers
{
    public class TraineeController : Controller
    {
        public IActionResult Index()
        {
            ITIdbcontext db = new ITIdbcontext();
            var model = db.Trainees.Include(p => p.Department).ToList();
            return View(model);
        }

        public IActionResult TraineDetails(int id)
        {
            ITIdbcontext db = new ITIdbcontext();
            
            var Details = db.Trainees.Include(i => i.Department).Include(tc => tc.CourseTrainees).ThenInclude(c=>c.Course).FirstOrDefault(i => i.Trn_Id == id);
            var coler = db.Courses.Include(t=>t.CourseTrainees).ToList();

            return View(Details);

        }
    }
}
