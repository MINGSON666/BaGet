using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BaGet.Hosting.BasicAuthentication
{
    public class UserService : IUserService
    {
        public Task<User> Authenticate(string username, string password)
        {
            if (username == "test" && password == "test")
                return Task.FromResult(new User { Username = username, Id = password });
            
            return null;
        }
    }
}
