﻿using System;
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
        Chat activeChat;
        List<string> chatNames = new List<string>();
        bool isNewChat = false;
        public FormMessenger(UserManager userManager, User activeUser)
        {
            InitializeComponent();

            this.userManager = userManager;
            this.activeUser = activeUser;

            FillComboBoxUserSearch();
            FillDataGridViewChatList();
            textBoxNewMessage.Enabled = false;
            buttonSendMessage.Enabled = false;

            labelSendMessageForNewChat.Hide();
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
            chatNames = activeUser.GetChatsNames();
            foreach (var chatName in chatNames)
            {
                dataGridViewChatList.Rows.Add(chatName);
            }
        }
        public void HideStartChatMessage()
        {
            labelStartChatMessage.Hide();
        }
        public void FillDataGridViewChat(Chat chat)
        {
            dataGridViewChat.Rows.Clear();
            foreach(var item in chat.Messages)
            {
                if (item.SenderLogin == activeUser.Login)
                {
                    dataGridViewChat.Rows.Add("", $"{item.Time}\n{item.Text}");
                }
                else
                {
                    dataGridViewChat.Rows.Add($"{item.Time}\n{item.Text}", "");
                }
            }
            if (dataGridViewChat.Rows.Count > 0)
            {
                dataGridViewChat.FirstDisplayedScrollingRowIndex = dataGridViewChat.Rows.Count - 1;
            }
            
        }
        private void dataGridViewChatList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HideStartChatMessage();
            string chatName = dataGridViewChatList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            activeChat = new Chat(activeUser.GetChatFileNameByChatName(chatName), activeUser);
            FillDataGridViewChat(activeChat);
            textBoxNewMessage.Enabled = true;
            buttonSendMessage.Enabled = true;

            labelSendMessageForNewChat.Hide();
            isNewChat = false;
        }

        private void buttonSendMessage_Click(object sender, EventArgs e)
        {
            string textMessage = textBoxNewMessage.Text;
            if (!string.IsNullOrEmpty(textMessage))
            {
                if (!isNewChat)
                {
                    activeChat.AddNewMessage(activeUser.Login, DateTime.Now.ToString(), textMessage);
                    FillDataGridViewChat(activeChat);
                    textBoxNewMessage.Text = "";
                }
                else
                {
                    isNewChat = false;

                    activeUser.CreateNewChatFile(comboBoxUserSearch.Text);
                    chatNames.Add(comboBoxUserSearch.Text);
                    activeChat = new Chat(activeUser.GetChatFileNameByChatName(comboBoxUserSearch.Text), activeUser);

                    activeChat.AddNewMessage(activeUser.Login, DateTime.Now.ToString(), textMessage);
                    FillDataGridViewChat(activeChat);
                    textBoxNewMessage.Text = "";
                    labelSendMessageForNewChat.Hide();
                }
            }
        }

        private void comboBoxUserSearch_SelectedValueChanged(object sender, EventArgs e)
        {
            HideStartChatMessage();
            MessageBox.Show("выбрано");
            if (chatNames.Contains(comboBoxUserSearch.Text))
            {
                activeChat = new Chat(activeUser.GetChatFileNameByChatName(comboBoxUserSearch.Text), activeUser);
                labelSendMessageForNewChat.Hide();
                FillDataGridViewChat(activeChat);
                isNewChat = false;
            }
            else
            {
                dataGridViewChat.Rows.Clear();
                labelSendMessageForNewChat.Show();
                isNewChat = true;
            }
            textBoxNewMessage.Enabled = true;
            buttonSendMessage.Enabled = true;
        }
    }
}
