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
    public partial class Historical : Form
    {
        public Historical()
        {
            InitializeComponent();
        }

        private void Historical_Load(object sender, EventArgs e)
        {

        }

        private void labelHistorical_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpdateListHistorical_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"Data Source=MSI; Initial Catalog=Library; Integrated Security=true";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT BookId, BookName, Author FROM Historical";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            labelHistorical.Text = ""; // Clear the label before adding new data
                            while (reader.Read())
                            {
                                int bookId = reader.GetInt32(0);
                                string bookName = reader.GetString(1);
                                string author = reader.GetString(2);
                                labelHistorical.Text += $"{bookId:D3}-{bookName} - {author}\r\n";
                            }
                        }
                        connection.Close();
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

        private void buttonHistoricalBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserPortal d = new UserPortal();
            d.Show();
        }
    }
}
