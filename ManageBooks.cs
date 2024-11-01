using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_Work
{
    public partial class ManageBooks : Form
    {
        public ManageBooks()
        {
            InitializeComponent();
            textBoxAdminPassword.PasswordChar = '*';
        }

        private void buttonManageBookLogin_Click(object sender, EventArgs e)
        {
            string adminId = textBoxAdminUserId.Text;
            string password = textBoxAdminPassword.Text;

            // Validate inputs
            if (string.IsNullOrEmpty(adminId) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both Admin ID and Password.");
                return;
            }

            if (adminId == "200360101039" && password == "nipuni")
            {
                MessageBox.Show("Login successful!");
                this.Hide();
                AdminPortal P = new AdminPortal();
                P.Show();
            }
            else
            {
                MessageBox.Show("Invalid Admin ID or Password. Please try again.");
            }

        }
    


        private void buttonManageHandOver_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonManageAddRemove_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonBackManageBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserPortal n = new UserPortal();
            n.Show();
        }
    }
}
