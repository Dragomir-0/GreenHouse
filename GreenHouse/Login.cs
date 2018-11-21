using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLogicLayer;

namespace GreenHouse
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsernameLogin.Text;
            string password = txtPasswordLogin.Text;
            User user = new User();
            bool verified = user.VerifyUser(username, password);
            if (verified)
            {
                MainPage mainPage = new MainPage();
                this.Hide();
                mainPage.Show();
            }
            else
            {
                MessageBox.Show("Incorrect login credentials", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
