using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Messenger
{
    public class User
    {
        public string Login { get; }
        public string Password { get; }
        public List<Chat> UserChats { get; set; } = new List<Chat>();
        public User(string login, string password)
        {
            Login = login;
            Password = password;
            CreateNewChatFile();
        }
        public void CreateNewChatFile()
        {
            using (StreamWriter SR = new StreamWriter($"Data/Chats/{Login}.txt"))
            {
                SR.Write("");
            }
        }
    }
}
