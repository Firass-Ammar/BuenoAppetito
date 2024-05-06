using Microsoft.AspNetCore.Mvc;

namespace BuonAppetito.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
