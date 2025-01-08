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
    public partial class FormWelcome : Form
    {
        public FormWelcome()
        {
            InitializeComponent();
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            FormRegistration formRegistration = new FormRegistration();
            formRegistration.ShowDialog();
        }

        private void buttonAuthorization_Click(object sender, EventArgs e)
        {
            FormAuthorization formAuthorization = new FormAuthorization();
            formAuthorization.ShowDialog();
        }
    }
}
