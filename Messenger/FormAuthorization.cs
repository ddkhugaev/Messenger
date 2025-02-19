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
    public partial class FormAuthorization : Form
    {
        public FormAuthorization()
        {
            InitializeComponent();
        }
        // прохождение валидации при авторизации
        private void buttonApply_Click(object sender, EventArgs e)
        {
            UserManager userManager = new UserManager();
            Tuple<bool, string> validation = userManager.UserAuthorizeValidation(textBoxLogin.Text.ToLower(), textBoxPassword.Text);
            labelError.Text = validation.Item2;
            if (validation.Item1)
            {
                Close();
                FormMessenger formMessenger = new FormMessenger(userManager, userManager.GetUserByLogin(textBoxLogin.Text.ToLower()));
                formMessenger.ShowDialog();
            }
        }
    }
}
