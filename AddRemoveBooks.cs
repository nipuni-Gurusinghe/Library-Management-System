using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_Work
{
    public partial class AddRemoveBooks : Form
    {
        public AddRemoveBooks()
        {
            InitializeComponent();

        }

        private void textBoxAddBookId_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (ValidateAddBookForm())
            {
                try
                {
                    int bookId = int.Parse(textBoxAddBookId.Text);
                    string bookName = textBoxAddBookName.Text;
                    string author = textBoxAddAuthor.Text;
                    string category = comboBoxCategory.SelectedItem.ToString();

                    // Determine the table to insert into
                    string tableName = GetTableName(category);

                    if (string.IsNullOrEmpty(tableName))
                    {
                        MessageBox.Show("Invalid category selected.");
                        return;
                    }

                    // Insert book details into the appropriate table
                    InsertBookDetails(bookId, bookName, author, tableName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private bool ValidateAddBookForm()
        {
            if (string.IsNullOrWhiteSpace(textBoxAddBookId.Text))
            {
                MessageBox.Show("Book ID is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxAddBookId.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxAddBookName.Text))
            {
                MessageBox.Show("Book Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxAddBookName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxAddAuthor.Text))
            {
                MessageBox.Show("Author is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxAddAuthor.Focus();
                return false;
            }

            if (comboBoxCategory.SelectedItem == null)
            {
                MessageBox.Show("Category must be selected.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxCategory.Focus();
                return false;
            }

            return true;
        }

        // Method to determine the table name based on category
        private string GetTableName(string category)
        {
            switch (category)
            {
                case "Novel":
                    return "Novel";
                case "Childrens":
                    return "Childrens";
                case "Poetry":
                    return "Poetry";
                case "Historical":
                    return "Historical";
                default:
                    return string.Empty;
            }
        }

        // Method to insert book details into the database
        private void InsertBookDetails(int bookId, string bookName, string author, string tableName)
        {
            try
            {
                string connectionString = @"Data Source=MSI; Initial Catalog=Library; Integrated Security=true";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = $"INSERT INTO {tableName} (BookId, BookName, Author) VALUES (@BookId, @BookName, @Author)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BookId", bookId);
                        command.Parameters.AddWithValue("@BookName", bookName);
                        command.Parameters.AddWithValue("@Author", author);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        connection.Close();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Book details added successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No rows affected. The book details were not added.");
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("SQL error occurred: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (ValidateRemoveBookForm())
            {
                try
                {
                    int bookId = int.Parse(textBoxAddBookId.Text);
                    string category = comboBoxCategory.SelectedItem.ToString();

                    // Determine the table to delete from
                    string tableName = GetTableName1(category);

                    if (string.IsNullOrEmpty(tableName))
                    {
                        MessageBox.Show("Invalid category selected.");
                        return;
                    }

                    // Remove book details from the appropriate table
                    RemoveBookDetails(bookId, tableName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private bool ValidateRemoveBookForm()
        {
            if (string.IsNullOrWhiteSpace(textBoxAddBookId.Text))
            {
                MessageBox.Show("Book ID is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxAddBookId.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxAddBookName.Text))
            {
                MessageBox.Show("Book Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxAddBookName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxAddAuthor.Text))
            {
                MessageBox.Show("Author is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxAddAuthor.Focus();
                return false;
            }

            if (comboBoxCategory.SelectedItem == null)
            {
                MessageBox.Show("Category must be selected.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxCategory.Focus();
                return false;
            }

            return true;
        }

        private string GetTableName1(string category)
        {
            switch (category)
            {
                case "Novel":
                    return "Novel";
                case "Childrens":
                    return "Childrens";
                case "Poetry":
                    return "Poetry";
                case "Historical":
                    return "Historical";
                default:
                    return string.Empty;
            }
        }

        private void RemoveBookDetails(int bookId, string tableName)
        {
            try
            {
                string connectionString = @"Data Source=MSI; Initial Catalog=Library; Integrated Security=true";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = $"DELETE FROM {tableName} WHERE BookId = @BookId";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BookId", bookId);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        connection.Close();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Book details removed successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No rows affected. The book details were not removed.");
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("SQL error occurred: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

            private void buttonBackAddRemoveBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserPortal w = new UserPortal();
            w.Show();
        }

        private void textBoxAddBookId_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelAddBookId_Click(object sender, EventArgs e)
        {

        }
    }
}
