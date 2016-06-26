using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTGDeckCreator
{
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        public string Server { get; private set; }
        public string Login { get; private set; }
        public string Password { get; private set; }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (tBLogin.Text == "" || tBServer.Text == "")
            {
                MessageBox.Show("Server and/or login fields cannot be empty!", "Error");
                return;
            }

            Server = tBServer.Text;
            Login = tBLogin.Text;
            Password = tBPass.Text;
            this.Close();
        }
    }
}
