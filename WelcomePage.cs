using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Course_Work
{
    public partial class WelcomePage : Form
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        private void labelClickThis_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            RegistationPage Registation = new RegistationPage();
            Registation.Show();
            this.Hide();


        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Welcome to E-Library!");

            string username = textBoxUserName.Text;
            string password = textBoxPassword.Text;

            // Validate if both fields are entered
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter your username.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter your password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Here you would typically check the username and password against your data store
            // For demonstration purposes, we'll just show a success message
           // MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Add your logic here for what happens after successful login
        
    



    string connectionString =
                 @"Data Source=MSI; 
                Initial Catalog = Library;
                Integrated Security = true";
            string query = "SELECT COUNT(1) FROM RegisteredAccount WHERE MemberID=@MemberID AND Password=@Password";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MemberID", textBoxUserName.Text);
                    cmd.Parameters.AddWithValue("@Password", textBoxPassword.Text);
                    conn.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    conn.Close();

                    if (count == 1)
                    {
                        MessageBox.Show("Login Successful!");
                        this.Hide();
                        UserPortal u = new UserPortal();
                        u.Show();
                    }
                    else
                    {
                        MessageBox.Show("Username or Password is incorrect.");
                    }
                }
            }
        }
    

private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUserName_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void LabelLibraryName_Click(object sender, EventArgs e)
        {

        }

        private void LableInstruction_Click(object sender, EventArgs e)
        {

        }

        private void buttonWPRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistationPage R= new RegistationPage();
            R.Show();
        }

        private void buttonLogin_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void pictureBoxWelcome_Click(object sender, EventArgs e)
        {

        }

        private void buttonBackWelcome_Click(object sender, EventArgs e)
        {
            HomePage g = new HomePage();
            this.Hide();
            g.Show();
        }

        private void WelcomePage_Load(object sender, EventArgs e)
        {

        }
    }
    }

