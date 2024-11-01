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
    public partial class BorrowPage : Form
    {
        public BorrowPage()
        {
            InitializeComponent();
        }

        private void textBoxBorrowBookId_Validating(object sender, CancelEventArgs e)
        {

           /* if (textBoxBorrowBookId.Text == String.Empty)
            {
                e.Cancel = true;
                errorProviderBBookId.SetError(textBoxBorrowBookId, "Enter a book Id");

            }
            else
            {
                e.Cancel = false;
                errorProviderBBookId.SetError(textBoxBorrowBookId, "");
            }*/
        }

        private void textBoxBorrowBookName_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void textBoxMemberId_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void buttonBorrow_Click(object sender, EventArgs e)
        {



            try
            {
                string bookIdText = textBoxBorrowBookId.Text;
                string bookName = textBoxBorrowBookName.Text;
                string memberIdText = textBoxMemberId.Text;
                string durationText = textBoxDuration.Text;

                // Validate inputs
                if (string.IsNullOrEmpty(bookIdText) || string.IsNullOrEmpty(bookName) ||
                    string.IsNullOrEmpty(memberIdText) || string.IsNullOrEmpty(durationText))
                {
                    MessageBox.Show("Please fill in all required fields: Book ID, Book Name, Member ID, and Duration.");
                    return;
                }

                if (!int.TryParse(bookIdText, out int bookId) ||
                    !int.TryParse(memberIdText, out int memberId) ||
                    !int.TryParse(durationText, out int duration))
                {
                    MessageBox.Show("Please enter valid integer values for Book ID, Member ID, and Duration.");
                    return;
                }

                DateTime borrowDate = dateTimePickerBorrowDate.Value;

                string connectionString = @"Data Source=MSI; Initial Catalog=Library; Integrated Security=true";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Borrow (BookId, BookName, MemberId, BorrowDate, Duration) VALUES (@BookId, @BookName, @MemberId, @BorrowDate, @Duration)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@BookId", bookId);
                        cmd.Parameters.AddWithValue("@BookName", bookName);
                        cmd.Parameters.AddWithValue("@MemberId", memberId);
                        cmd.Parameters.AddWithValue("@BorrowDate", borrowDate);
                        cmd.Parameters.AddWithValue("@Duration", duration);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Book borrowed successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void buttonBorrowBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserPortal q = new UserPortal();
            q.Show();
        }

        private void BorrowPage_Load(object sender, EventArgs e)
        {

        }
    }
}

