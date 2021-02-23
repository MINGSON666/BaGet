using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BaGet.Hosting.BasicAuthentication
{
    public interface IUserService
    {
        Task<User> Authenticate(string username, string password);
    }
}
