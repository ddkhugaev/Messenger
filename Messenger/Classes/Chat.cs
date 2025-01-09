using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger
{
    public class Chat
    {
        public string ChatFileName { get; set; }
        public User ActiveUser { get; set; }
        public List<Message> Messages { get; set; } = new List<Message>();
        public Chat(string chatFileName, User activeUser)
        {
            ChatFileName = chatFileName;
            ActiveUser = activeUser;
            RefreshMessages();
        }
        public void RefreshMessages()
        {
            using (StreamReader SR = new StreamReader($"Data/Chats/{ChatFileName}"))
            {
                while (!SR.EndOfStream)
                {
                    string[] s = SR.ReadLine().Split('~');
                    Messages.Add(new Message(s[0], s[1], s[2]));
                }
            }
        }
        public void AddNewMessage(string senderLogin, string time, string text)
        {
            Messages.Add(new Message(senderLogin, time, text));

            using(StreamWriter SW = new StreamWriter($"Data/Chats/{ChatFileName}", true))
            {
                SW.WriteLine($"{senderLogin}~{time}~{text}");
            }
        }
    }
}
