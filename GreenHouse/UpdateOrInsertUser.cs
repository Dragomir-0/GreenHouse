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
    public partial class UpdateOrInsertUser : Form
    {
        User userLoggedIn;
        string choice;

        public UpdateOrInsertUser(User userLoggedIn, string choice)
        {
            this.userLoggedIn = userLoggedIn;
            this.choice = choice;
            InitializeComponent();
        }

        private void btnUpdateOrInsert_Click(object sender, EventArgs e)
        {
            string username = txtUsernameUpdateOrInsert.Text;
            string password = txtPasswordUpdateOrInsert.Text;
            string confirmPassword = txtConfirmPasswordUpdateOrInsert.Text;
            if (password.Equals(confirmPassword))
            {
                if (choice.Equals("Update"))
                {
                    User user = new User(userLoggedIn.UserID, username, password, userLoggedIn.UserPlantID);
                    user.UpdateUser(user);
                    MessageBox.Show("User successfully updated", "Updated", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
                else
                {
                    User user = new User(username, password, userLoggedIn.UserPlantID);
                    user.InsertUser(user);
                    MessageBox.Show("User successfully inserted", "Inserted", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Passwords does not match", "Password", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            
        }

        private void UpdateOrInsertUser_Load(object sender, EventArgs e)
        {
            
            if (choice.Equals("Update"))
            {
                lblUpdateOrInsertUser.Text = "Update User";
                btnUpdateOrInsert.Text = "Update User";
                txtUsernameUpdateOrInsert.Text = userLoggedIn.Username;
            }
            else
            {
                lblUpdateOrInsertUser.Text = "Insert User";
                btnUpdateOrInsert.Text = "Insert User";
            }
        }

        private void btnBackUpdateOrInsert_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage(userLoggedIn);
            this.Hide();
            mainPage.Show();
        }
    }
}
