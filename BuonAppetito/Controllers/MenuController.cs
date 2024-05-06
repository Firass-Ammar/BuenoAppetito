using Microsoft.AspNetCore.Mvc;

namespace BuonAppetito.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
