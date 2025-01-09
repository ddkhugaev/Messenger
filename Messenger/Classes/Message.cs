using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger
{
    // класс сообщения
    public class Message
    {
        public string SenderLogin { get; set; }
        public string Time { get; set; }
        public string Text { get; set; }
        //public DateTime Time { get; set; }
        public Message(string senderLogin, string time, string text)
        {
            SenderLogin = senderLogin;
            Time = time;
            Text = text;
        }

    }
}
