using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagment.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagment.Controllers
{
    [Route("auth")]
    public class AuthController : Controller
    {
        private readonly IUserService_Demo _userService;

        public AuthController(IUserService_Demo userService)
        {
            _userService = userService;
        }
        [Route("login")]
        public IActionResult Login()
        {
            return View();
        }

        [Route("register")]
        public IActionResult Register()
        {
            return View();
        }

        //[Route("register")]
        //[ValidateAntiForgeryToken]
        //[HttpPost]
        //public async Task<IActionResult> Register(RegisterModel model)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View(model);
        //    }
        //    var user = await _userService.Add(model.UserName, model.Email, model.Password);
        //    registe
        //}
    }
}