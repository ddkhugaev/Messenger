using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// git
namespace Messenger
{
    public class UserManager
    {
        public List<User> Users { get; } = new List<User>();
        public event EventHandler<UserRegisteredEventArgs> UserRegisteredHandler;
        public UserManager()
        {
            using (StreamReader SR = new StreamReader("Data/Users/Users.txt"))
            {
                while (!SR.EndOfStream)
                {
                    string[] arr = SR.ReadLine().Split('~');
                    Users.Add(new User(arr[0], arr[1]));
                }
            }
        }
        public Tuple<bool, string> UserRegisterValidation(string login, string password)
        {
            login = login.ToLower();
            char[] alpha = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] nums = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            if (login.Length < 1)
            {
                return new Tuple<bool, string>(false, "Введите логин");
            }
            if (login.Length > 20)
            {
                return new Tuple<bool, string>(false, "Максимальная длина логина 20 символов");
            }
            foreach (var c in login)
            {
                if (!alpha.Contains(c))
                {
                    return new Tuple<bool, string>(false, "В логине допустимы только латинские буквы");
                }
            }
            if (password.Length < 1)
            {
                return new Tuple<bool, string>(false, "Введите пароль");
            }
            if (password.Length > 20)
            {
                return new Tuple<bool, string>(false, "Максимальная длина пароля 20 символов");
            }
            foreach (var c in password)
            {
                if (!(alpha.Contains(c) || nums.Contains(c)))
                {
                    return new Tuple<bool, string>(false, "В логине допустимы только цифры и латинские буквы");
                }
            }
            if (IsUserExist(login))
            {
                return new Tuple<bool, string>(false, "Пользователем с таким логином уже существует");
            }
            return new Tuple<bool, string>(true, "");
        }
        public Tuple<bool, string> UserAuthorizeValidation(string login, string password)
        {
            login = login.ToLower();
            if (login.Length < 1)
            {
                return new Tuple<bool, string>(false, "Введите логин");
            }
            if (password.Length < 1)
            {
                return new Tuple<bool, string>(false, "Введите пароль");
            }
            if (!IsUserExist(login))
            {
                return new Tuple<bool, string>(false, "Пользователя с таким логином не существует");
            }
            foreach(var user in Users)
            {
                if (login == user.Login)
                {
                    if (password != user.Password)
                    {
                        return new Tuple<bool, string> (false, "Неправильный пароль");
                    }
                }
            }
            return new Tuple<bool, string>(true, "");
        }
        public bool IsUserExist(string login)
        {
            foreach (var user in Users)
            {
                if (login == user.Login)
                {
                    return true;
                }
            }
            return false;
        }
        public void Register(User user)
        {
            Users.Add(user);

            using (StreamWriter SW = new StreamWriter("Data/Users/Users.txt"))
            {
                foreach (var u in Users)
                {
                    SW.WriteLine($"{u.Login}~{u.Password}");
                }
            }

            UserRegisteredHandler?.Invoke(this, new UserRegisteredEventArgs(user.Login, user.Password));
        }
    }
    public class UserRegisteredEventArgs : EventArgs
    {
        public string Login { get; }
        public string Password { get; }
        public UserRegisteredEventArgs(string login, string password)
        {
            Login = login;
            Password = password;
        }
    }
}
