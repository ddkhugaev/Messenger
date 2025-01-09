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
        public List<string> GetChatsFilesNames()
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
        public List<string> GetChatsNames()
        {
            List<string> chatsNames = new List<string>();
            List<string> chatsFilesNames = GetChatsFilesNames();

            foreach (var s in chatsFilesNames)
            {
                List<string> chatFileName = s.TrimEnd('t').TrimEnd('x').TrimEnd('t').TrimEnd('.').Split('~').ToList();
                chatFileName.Remove(Login);
                chatsNames.Add(chatFileName[0]);
            }

            return chatsNames;
        }
        public string GetChatFileNameByChatName(string chatName)
        {
            List<string> chatsFilesNames = GetChatsFilesNames();

            foreach (var item in chatsFilesNames)
            {
                if (item.Contains(chatName))
                {
                    return item;
                }
            }
            return null;
        }
    }
}
