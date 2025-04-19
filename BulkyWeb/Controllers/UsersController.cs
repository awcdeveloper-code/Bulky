using Microsoft.AspNetCore.Mvc;

namespace BulkyWeb.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
