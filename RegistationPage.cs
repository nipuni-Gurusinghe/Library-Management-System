using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Linq.Expressions;

namespace Course_Work
{
    public partial class RegistationPage : Form
    {
        private SqlConnection sqlConnection;
        public RegistationPage()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(@"Data Source=MSI; Initial Catalog=Library; Integrated Security=true");
        }

        private void textBoxName_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxRegName.Text == String.Empty)
            {
                e.Cancel = true;
                errorProviderName.SetError(textBoxRegName, "Please Enter Your Name");
            }
            else
            {
                e.Cancel = false;
                errorProviderName.SetError(textBoxRegName, "");
            }
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAge_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxAge.Text == String.Empty)
            {
                e.Cancel = true;
                errorProviderAge.SetError(textBoxAge, "Enter Your Age");

            }
            else
            {
                e.Cancel = false;
                errorProviderAge.SetError(textBoxAge, "");
            }
        }

        private void dateTimePickerDateOfBirth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerDateOfBirth_Validating(object sender, CancelEventArgs e)
        {
            if (dateTimePickerDateOfBirth.Text == String.Empty)
            {
                e.Cancel = true;
                errorProviderDateOfBirth.SetError(dateTimePickerDateOfBirth, "Select Your Birth Of Date");

            }
            else
            {
                e.Cancel = false;
                errorProviderDateOfBirth.SetError(dateTimePickerDateOfBirth, "");
            }
        }

       /* private void createAccountButton_Click(object sender, EventArgs e)
        {
            // Generate new MemberId
            int newMemberId = GenerateMemberId();
            textBoxIdNumber.Text = newMemberId.ToString();

            // Get user input
            string password = TextBoxRegPassword.Text;
            string fullName = textBoxRegName.Text;
            int age = int.Parse(textBoxAge.Text);
            string sex = comboBoxSex.SelectedItem.ToString();
            DateTime dateOfBirth = dateTimePickerDateOfBirth.Value;
            string address = textBoxAddress.Text;

            // Insert new member details into Register table
            string enableIdentityInsert = "SET IDENTITY_INSERT Register ON";
            string insertRegisterQuery = "INSERT INTO Register (MemberId, Password, FullName, Age, Sex, DateOfBirth, Address) VALUES (@MemberId, @Password, @FullName, @Age, @Sex, @DateOfBirth, @Address)";
            string disableIdentityInsert = "SET IDENTITY_INSERT Register OFF";

            SqlCommand enableCommand = new SqlCommand(enableIdentityInsert, sqlConnection);
            SqlCommand registerCommand = new SqlCommand(insertRegisterQuery, sqlConnection);
            SqlCommand disableCommand = new SqlCommand(disableIdentityInsert, sqlConnection);

            registerCommand.Parameters.AddWithValue("@MemberId", newMemberId);
            registerCommand.Parameters.AddWithValue("@Password", password);
            registerCommand.Parameters.AddWithValue("@FullName", fullName);
            registerCommand.Parameters.AddWithValue("@Age", age);
            registerCommand.Parameters.AddWithValue("@Sex", sex);
            registerCommand.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
            registerCommand.Parameters.AddWithValue("@Address", address);

            // Insert new member credentials into RegisteredAccount table
            string insertAccountQuery = "INSERT INTO RegisteredAccount (MemberId, Password) VALUES (@MemberId, @Password)";
            SqlCommand accountCommand = new SqlCommand(insertAccountQuery, sqlConnection);
            accountCommand.Parameters.AddWithValue("@MemberId", newMemberId);
            accountCommand.Parameters.AddWithValue("@Password", password);

            try
            {
                sqlConnection.Open();
                enableCommand.ExecuteNonQuery();
                registerCommand.ExecuteNonQuery();
                disableCommand.ExecuteNonQuery();
                accountCommand.ExecuteNonQuery();
                MessageBox.Show("Account created successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private int GenerateMemberId()
        {
            int newMemberId = 0;

            try
            {
                sqlConnection.Open();
                string query = "SELECT MAX(MemberId) FROM Register";
                SqlCommand command = new SqlCommand(query, sqlConnection);
                object result = command.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    newMemberId = Convert.ToInt32(result) + 1;
                }
                else
                {
                    newMemberId = 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating MemberId: " + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }

            return newMemberId;
        }*/

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            // Validate user input
            if (string.IsNullOrEmpty(TextBoxRegPassword.Text) || string.IsNullOrEmpty(textBoxAge.Text) || string.IsNullOrEmpty(textBoxAddress.Text))
            {
                MessageBox.Show("Password, Age, and Address must be entered before registering.");
                return;
            }

            if (string.IsNullOrEmpty(textBoxIdNumber.Text))
            {
                // Generate new MemberId 
                int newMemberId = GenerateMemberId();
                textBoxIdNumber.Text = newMemberId.ToString();
            }
            else
            {
                // Display message if MemberId is entered
                MessageBox.Show("MemberId should not be entered. It will be generated automatically.");
                return;
            }

            // Get user input
            string password = TextBoxRegPassword.Text;
            string fullName = textBoxRegName.Text;
            int age = int.Parse(textBoxAge.Text);
            string sex = comboBoxSex.SelectedItem.ToString();
            DateTime dateOfBirth = dateTimePickerDateOfBirth.Value;
            string address = textBoxAddress.Text;
            int memberId = int.Parse(textBoxIdNumber.Text);

            // Insert new member details into Register table
            string enableIdentityInsert = "SET IDENTITY_INSERT Register ON";
            string insertRegisterQuery = "INSERT INTO Register (MemberId, Password, FullName, Age, Sex, DateOfBirth, Address) VALUES (@MemberId, @Password, @FullName, @Age, @Sex, @DateOfBirth, @Address)";
            string disableIdentityInsert = "SET IDENTITY_INSERT Register OFF";

            SqlCommand enableCommand = new SqlCommand(enableIdentityInsert, sqlConnection);
            SqlCommand registerCommand = new SqlCommand(insertRegisterQuery, sqlConnection);
            SqlCommand disableCommand = new SqlCommand(disableIdentityInsert, sqlConnection);

            registerCommand.Parameters.AddWithValue("@MemberId", memberId);
            registerCommand.Parameters.AddWithValue("@Password", password);
            registerCommand.Parameters.AddWithValue("@FullName", fullName);
            registerCommand.Parameters.AddWithValue("@Age", age);
            registerCommand.Parameters.AddWithValue("@Sex", sex);
            registerCommand.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
            registerCommand.Parameters.AddWithValue("@Address", address);

            // Insert new member credentials into RegisteredAccount table
            string insertAccountQuery = "INSERT INTO RegisteredAccount (MemberId, Password) VALUES (@MemberId, @Password)";
            SqlCommand accountCommand = new SqlCommand(insertAccountQuery, sqlConnection);
            accountCommand.Parameters.AddWithValue("@MemberId", memberId);
            accountCommand.Parameters.AddWithValue("@Password", password);

            try
            {
                sqlConnection.Open();
                enableCommand.ExecuteNonQuery();
                registerCommand.ExecuteNonQuery();
                disableCommand.ExecuteNonQuery();
                accountCommand.ExecuteNonQuery();
                MessageBox.Show("Account created successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private int GenerateMemberId()
        {
            int newMemberId = 0;

            try
            {
                sqlConnection.Open();
                string query = "SELECT MAX(MemberId) FROM Register";
                SqlCommand command = new SqlCommand(query, sqlConnection);
                object result = command.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    newMemberId = Convert.ToInt32(result) + 1;
                }
                else
                {
                    newMemberId = 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating MemberId: " + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }

            return newMemberId;
        }

        private void buttonRegisterBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomePage x = new WelcomePage();
            x.Show();
        }
    }
    }

