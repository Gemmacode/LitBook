using Microsoft.AspNetCore.Mvc;

namespace LitBook.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
