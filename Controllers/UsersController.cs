using Microsoft.AspNetCore.Mvc;
using Task_Auth.Data;
using Task_Auth.Models;

namespace Task_Auth.Controllers
{
    public class UsersController : Controller
    {
        private readonly ApplicationDbContext context;

        public UsersController(ApplicationDbContext context) {
            this.context = context;
        }
        public IActionResult Index()
        {
            var users = context.Users.Where(user=>user.isActive==false).ToList();
            return View(users);
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
            return RedirectToAction(nameof(Login));
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Login(User user)
        {
            var CheckUser = context.Users.Where(auth => auth.UserName == user.UserName && auth.Password==user.Password);

            if (CheckUser.Any())
            {
                return RedirectToAction(nameof(Index));
            }

            ViewBag.Error = "invalid username or password";

            return View();
        }

        public IActionResult Update(Guid UserId)
        {
            var user = context.Users.Find(UserId);

            
                user.isActive = true;
            

            context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

    }
}
