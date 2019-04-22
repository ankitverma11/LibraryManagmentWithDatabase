using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagmentWithDB.Entities;
using LibraryManagmentWithDB.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagmentWithDB.Controllers
{
    // The ASP.NET Core users controller defines and handles all routes / endpoints for the api that relate to users, this includes authentication and standard CRUD operations. 
    //Within each route the controller calls the user service to perform the action required, this enables the controller to stay 'lean' and completely separated from the business logic and data access code.

    //The controller actions are secured with JWT using the [Authorize] attribute, with the exception of the Authenticate method which allows 
    //public access by overriding the[Authorize] attribute on the controller with[AllowAnonymous] attribute on the action method.I chose this approach so any new action methods added to
    //the controller will be secure by default unless explicitly made public.

    //If the roles are specified in the authorize attribute(e.g. [Authorize(Roles = Role.Admin)]) then the route is restricted to users in the specified role / roles.

    //The GetById(int id) action method contains some extra custom authorization logic which allows admin users to access any user record, but only allows normal users to access their own record.

    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody]User userparam)
        {
            var user = _userService.Authenticate(userparam.UserName, userparam.Password);
            if(user == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(user);
        }

        [Authorize(Roles = Role.Admin)]
        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _userService.GetAll();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public IActionResult GetByID(int id)
        {
            var user = _userService.GetByID(id);

            if (user == null)
            {
                return NotFound();
            }

            // only allow admins to access other user records
            var currentUserId = int.Parse(User.Identity.Name);
            if (id != currentUserId && !User.IsInRole(Role.Admin))
            {
                return Forbid();
            }

            return Ok(user);
        }
    }
}