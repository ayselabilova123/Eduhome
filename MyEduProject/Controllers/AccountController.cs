using Business.ViewModels.Account;
using Microsoft.AspNetCore.Mvc;

namespace MyEduProject.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet(nameof(Register))]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost(nameof(Register))]
        public IActionResult Register(RegisterVM registerVM)
        {
            if (ModelState.IsValid)
            {
                return View(registerVM);
            }
            return Json(registerVM);
            return View();
        }
    }
}
