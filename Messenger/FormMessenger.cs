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
        UserManager userManager;
        User activeUser;
        public FormMessenger(UserManager userManager, User activeUser)
        {
            InitializeComponent();

            this.userManager = userManager;
            this.activeUser = activeUser;

            FillComboBoxUserSearch();
            FillDataGridViewChatList();
        }

        public void FillComboBoxUserSearch()
        {
            List<string> logins = userManager.GetAllLogins();
            logins.Remove(activeUser.Login);
            foreach (var login in logins)
            {
                comboBoxUserSearch.Items.Add(login);
            }
        }
        public void FillDataGridViewChatList()
        {
            List<string> chatNames = activeUser.GetChatsNames();
            foreach (var chatName in chatNames)
            {
                dataGridViewChatList.Rows.Add(chatName);
            }
        }
    }
}
