using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger
{
    public class Message
    {
        public User FromUser { get; set; }
        public User ToUser { get; set; }
        public string Text { get; set; }
        public DateTime Time { get; set; }
        public Message(User fromUser, User toUser, string text, DateTime time)
        {
            FromUser = fromUser;
            ToUser = toUser;
            Text = text;
            Time = time;
        }

    }
}
