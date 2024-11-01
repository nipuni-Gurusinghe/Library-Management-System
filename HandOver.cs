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
    public partial class HandOver : Form
    {
        public HandOver()
        {
            InitializeComponent();
        }

        private void buttonHandOver_Click(object sender, EventArgs e)
        {
            // Validate user input
            if (string.IsNullOrEmpty(textBoxBookIdH.Text) || string.IsNullOrEmpty(textBoxMemberIdH.Text))
            {
                MessageBox.Show("BookId and MemberId must be entered before recording the handover.");
                return;
            }
            

            string bookId = textBoxBookIdH.Text;
            string memberId = textBoxMemberIdH.Text;
            string bookName = textBoxBNameH.Text;
            int overdueDays = int.Parse(textBoxOverdueDates.Text);
            int penaltyPay = int.Parse(textBoxPenalty.Text);
            string paymentStatus = textBoxPaymentStatus.Text;
            string connectionString =
                @"Data Source=MSI; 
        Initial Catalog=Library;
        Integrated Security=true";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO HandOver(BookId, MemberId, BookName, OverdueDays, PenaltyPay, PaymentStatus) " +
                               "VALUES (@BookId, @MemberId, @BookName, @OverdueDays, @PenaltyPay, @PaymentStatus)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@BookId", bookId);
                cmd.Parameters.AddWithValue("@MemberId", memberId);
                cmd.Parameters.AddWithValue("@BookName", bookName);
                cmd.Parameters.AddWithValue("@OverdueDays", overdueDays);
                cmd.Parameters.AddWithValue("@PenaltyPay", penaltyPay);
                cmd.Parameters.AddWithValue("@PaymentStatus", paymentStatus);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Book handover recorded successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to record book handover.");
                }
            }
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            // Validate user input
            if (string.IsNullOrEmpty(textBoxBookIdH.Text) || string.IsNullOrEmpty(textBoxMemberIdH.Text))
            {
                MessageBox.Show("BookId and MemberId must be entered before calculating the penalty.");
                return;
            }

            string bookId = textBoxBookIdH.Text;
            string memberId = textBoxMemberIdH.Text;
            string connectionString =
                @"Data Source=MSI; 
        Initial Catalog=Library;
        Integrated Security=true";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT BorrowDate, Duration FROM Borrow WHERE BookId = @BookId AND MemberId = @MemberId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@BookId", bookId);
                cmd.Parameters.AddWithValue("@MemberId", memberId);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    DateTime borrowDate = reader.GetDateTime(0);
                    int duration = reader.GetInt32(1);

                    // Use the system date as the handover date
                    DateTime handOverDate = DateTime.Now;

                    int overdueDays = (handOverDate - borrowDate).Days - duration;
                    textBoxOverdueDates.Text = overdueDays.ToString();

                    // Calculate penalty payment based on overdue days
                    int penaltyPerDay = 10; // Example penalty per day
                    int penaltyPayment = overdueDays * penaltyPerDay;
                    textBoxPenalty.Text = penaltyPayment.ToString();
                }
                else
                {
                    MessageBox.Show("No borrow details found for the given BookId and MemberId.");
                }
                reader.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPortal k = new AdminPortal();
            k.Show();
        }
    }
}
