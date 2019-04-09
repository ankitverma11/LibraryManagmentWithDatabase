using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagment.Data.Model
{
    /// <summary>
    ///  I have created an object class for my store procedure returning data.
    /// </summary>
    public partial class LoginByUsernamePassword
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
