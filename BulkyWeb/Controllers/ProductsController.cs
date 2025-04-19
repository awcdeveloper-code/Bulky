using Microsoft.AspNetCore.Mvc;

namespace BulkyWeb.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
