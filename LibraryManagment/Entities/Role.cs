using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagmentWithDB.Entities
{
    //The role entity class defines all the roles in the example application, I created it to use like an enum to avoid passing roles around as strings,
    //so instead of 'Admin' we can use Role.Admin. I used a static class with string properties rather than an enum type because the [Authorize] attribute requires roles to be passed as strings.
    public static class Role
    {
        public const string Admin = "Admin";
        public const string User = "User";
    }
}
