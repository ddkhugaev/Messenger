using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Messenger
{
    public partial class FormMessenger : Form
    {
        public FormMessenger()
        {
            InitializeComponent();
            dataGridViewChatList.Rows.Add("Стас");
            dataGridViewChatList.Rows.Add("Геор");
            dataGridViewChatList.Rows.Add("Давид\ndddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd");
            dataGridViewChatList.Rows.Add("Заур");
            dataGridViewChat.Rows.Add("dамшвfsdfsdfdfgdfgdfgdfgdfgdfgfffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffd", "fgfdgggggggggggggggggggggggggggdf");
            
        }
    }
}
