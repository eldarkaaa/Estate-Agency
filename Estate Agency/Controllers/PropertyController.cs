using Microsoft.AspNetCore.Mvc;

namespace Estate_Agency.Controllers
{
    public class PropertyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
