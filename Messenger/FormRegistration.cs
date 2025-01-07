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
    public partial class FormRegistration : Form
    {
        public FormRegistration()
        {
            InitializeComponent();
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            UserManager userManager = new UserManager();
            Tuple<bool, string> validation = userManager.UserRegisterValidation(textBoxLogin.Text, textBoxPassword.Text);
            labelError.Text = validation.Item2;
            if (validation.Item1)
            {
                userManager.Register(new User(textBoxLogin.Text, textBoxPassword.Text));
                MessageBox.Show("Вы зарегистрировались");
                Close();
            }
        }
    }
}
