using Microsoft.AspNetCore.Mvc;

namespace BuonAppetito.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
