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
        //public List<Chat> UserChats { get; set; } = new List<Chat>();
        public User(string login, string password)
        {
            Login = login;
            Password = password;
        }
        public void CreateNewUserChatsFile()
        {
            using (StreamWriter SW = new StreamWriter($"Data/UserChats/{Login}.txt"))
            {
                SW.Write("");
            }
        }
        public List<string> GetUserChatsFiles()
        {
            List<string> chatsFiles = new List<string>();
            using (StreamReader SR = new StreamReader($"Data/UserChats/{Login}.txt"))
            {
                while (!SR.EndOfStream)
                {
                    string s = SR.ReadLine();
                    chatsFiles.Add(s);
                }
            }
            return chatsFiles;
        }
    }
}
