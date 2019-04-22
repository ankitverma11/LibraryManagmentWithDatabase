using LibraryManagment.Data.Model;
using LibraryManagmentWithDB.Entities;
using LibraryManagmentWithDB.Healper;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentWithDB.Services
{
    public interface IUserService
    {
        User Authenticate(string username, string password);
        IEnumerable<User> GetAll();
        User GetByID(int id);
    }

    public class UserService : IUserService
    {
        // // users hardcoded for simplicity, store in a db with hashed passwords in production applications

        private List<User> _users = new List<User>
            {
               new User { Id = 1, FirstName = "Admin", LastName = "User", UserName = "admin", Password = "admin", Role = Role.Admin },
               new User { Id = 2, FirstName = "Normal", LastName = "User", UserName = "user", Password = "user", Role = Role.User }
            };

        private readonly AppSetting _appsetting;

        public UserService (IOptions<AppSetting> appSetting)
        {
            _appsetting = appSetting.Value;
        }

        public User Authenticate(string username, string password)
        {
            var users = _users.SingleOrDefault(x => x.FirstName == username && x.Password == password);

            // return null if user not found
            if (users.Equals(null))
                return null;

            // authentication successful so generate jwt token
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appsetting.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name ,users.Id.ToString()),
                    new Claim(ClaimTypes.Role , users.Role)
                }),
                Expires = DateTime.Now.AddDays(2),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            users.Token = tokenHandler.WriteToken(token);

            // remove password before returning
            users.Password = null;

            return users;
        }

        public IEnumerable<User> GetAll()
        {
            // return users without passwords
            return _users.Select(x => { x.Password = null;
                return x;
            });
        }

        public User GetByID(int id)
        {
            var user = _users.FirstOrDefault(x => x.Id == id);

            // return user without password
            if (user != null)
                user.Password = null;
            return user;
        }
    }
}
