using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Messenger
{
    // класс пользователя
    public class User
    {
        public string Login { get; }
        public string Password { get; }
        public User(string login, string password)
        {
            Login = login;
            Password = password;
        }
        // создает текстовоый файл, хранящий названия всех текстовых файлов, содержащих чаты пользователя
        public void CreateNewUserChatsFile()
        {
            using (StreamWriter SW = new StreamWriter($"Data/UserChats/{Login}.txt"))
            {
                SW.Write("");
            }
        }
        // получение названий всех текстовых файлов, содержащих чаты пользователя
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
        // получение названий чатов (логин собеседника) с помощью названия каждого текстового файла
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
        // получение названия текстового файла чата с помощью названия чата (логин собеседника)
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
        // создание нового текстового файла чата
        public void CreateNewChatFile(string toUser)
        {
            string fromUser = Login;
            string fileName = $"{fromUser}~{toUser}.txt";

            using (StreamWriter SR = new StreamWriter($"Data/UserChats/{fromUser}.txt", true))
            {
                SR.WriteLine(fileName);
            }

            using (StreamWriter SR = new StreamWriter($"Data/UserChats/{toUser}.txt", true))
            {
                SR.WriteLine(fileName);
            }

            using (StreamWriter SR = new StreamWriter($"Data/Chats/{fileName}", true))
            {
                SR.Write("");
            }
        }
    }
}
