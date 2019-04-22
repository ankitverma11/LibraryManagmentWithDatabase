using LibraryManagment.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagment.Data.Interfaces
{
    public interface IUserService_Demo
    {
        Task<User_Demo> Authenticate(string email, string password);

        Task<User_Demo> Add(string UserName, string email, String password);

        Task<User_Demo> AuthenticateExternal(string id);

        Task<User_Demo> AddExternal(string id, string UserName, string email);
    }
}
