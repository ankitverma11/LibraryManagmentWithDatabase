using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Security;

namespace LibraryManagment.Controllers
{
    public class SecurityController : Controller
    {
        public IActionResult Login()
        {
            return View("Login");
        }

        public IActionResult CheckUser()
        {
            // In this we will do form authentication
            // check if username or password is proper or not

            if ((Request.Form["UserName"] == "Ankit") && (Request.Form["Password"] == "Ankit"))
            {
                // use form Authentication class to set the cookies
                //FormsAuthentication.
                // redirect the home page
            }
            else
            {
                // redirect to login view
            }
            return View("Login");
        }
    }
}