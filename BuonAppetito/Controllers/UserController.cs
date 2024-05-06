using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BuonAppetito.Models;

namespace BuonAppetito.Controllers
{
    public class UserController : Controller
    {
        private readonly BuonContext _context;

        public UserController(BuonContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(User user)
        {
            if (ModelState.IsValid)
            {
                _context.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction("Login", "User");
            }
            return View(user);
        }

        [HttpGet] // GET request for rendering the login form
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(User user)
        {
            if (ModelState.IsValid)
            {
                var existingUser = await _context.Users
                    .FirstOrDefaultAsync(u => u.Email == user.Email && u.Password == user.Password);

                if (existingUser != null)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid login attempt.");
                    return View(user);
                }
            }
            return View(user);
        }

        public IActionResult Logout()
        {
            // Implement logout logic here
            return RedirectToAction("Index", "Home");
        }
    }
}
