using Microsoft.AspNetCore.Mvc;
using MVC_LAP.Models;

namespace MVC_LAP.Controllers
{
    public class ProductController : Controller
    {
       
        public IActionResult AllProducts()
        {
            List<Products> ProModel = ListofProducts.productss;
            
            return View("Product" , ProModel);
        }

       
		public IActionResult ID(int id)
		{
			Products prodetiils = ListofProducts.productss.FirstOrDefault(p => p.id == id);

			return View("ID", prodetiils);

		}
        public IActionResult GellPestSeller()
        {
            var PestSell = ListofProducts.productss.Select(s=>s).Where(s=>s.price>5000);

            return View("PestSeller", PestSell);

        }
        public IActionResult Add()
        {
            var PestSell = ListofProducts.productss.Select(s => s).Where(s => s.price > 5000);

            return View("Add", PestSell);

        }
    }
}
