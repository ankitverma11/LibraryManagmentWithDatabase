using LibraryManagment.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagment.Data.Interfaces
{
    public interface IUserService
    {
        Task<User> Authenticate(string email, string password);

        Task<User> Add(string UserName, string email, String password);

        Task<User> AuthenticateExternal(string id);

        Task<User> AddExternal(string id, string UserName, string email);
    }
}
