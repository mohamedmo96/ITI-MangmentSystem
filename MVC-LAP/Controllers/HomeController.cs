using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_LAP.Models;
using System.Diagnostics;

namespace MVC_LAP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ITIdbcontext db = new ITIdbcontext();
            var ProModel = db.Instructors.Include(i=>i.Department).Include(i=>i.Course).ToList();
            var dept = db.Departments;
            ViewData["dept"] = dept;    
            


            return View(ProModel);
        }

        public IActionResult Privacy(int id)
        {
            ITIdbcontext db = new ITIdbcontext();
            
            var instracotr = db.Instructors.Where(e => e.Dept_Id == id);

            return View(instracotr);
        }
        //public IActionResult ProductCategory(int id)
        //{
        //    var Product = _context.Products.Where(c => c.CatId == id).ToList();
        //    return View(Product);
        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}