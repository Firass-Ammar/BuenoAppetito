using Microsoft.AspNetCore.Mvc;

namespace BuonAppetito.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
