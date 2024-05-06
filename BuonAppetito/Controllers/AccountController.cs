using Microsoft.AspNetCore.Mvc;

namespace BuonAppetito.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
