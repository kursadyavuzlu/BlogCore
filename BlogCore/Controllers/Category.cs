using Microsoft.AspNetCore.Mvc;

namespace BlogCore.Controllers
{
    public class Category : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
