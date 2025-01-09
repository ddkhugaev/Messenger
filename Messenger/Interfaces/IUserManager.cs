using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger
{
    interface IUserManager
    {
        List<User> Users { get; }
        Tuple<bool, string> UserRegisterValidation(string login, string password);
        Tuple<bool, string> UserAuthorizeValidation(string login, string password);
        bool IsUserExist(string login);
        void Register(User user);
        User GetUserByLogin(string login);
        List<string> GetAllLogins();
    }
}
