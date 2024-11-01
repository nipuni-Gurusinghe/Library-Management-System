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
    public partial class Novel : Form
    {
        public Novel()
        {
            InitializeComponent();
        }

        private void buttonNovelBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserPortal x = new UserPortal();
            x.Show();
        }

        private void buttonUpdatedListNovel_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"Data Source=MSI; Initial Catalog=Library; Integrated Security=true";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT BookId, BookName, Author FROM Novel";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            labelNovel.Text = ""; // Clear the label before adding new data
                            while (reader.Read())
                            {
                                int bookId = reader.GetInt32(0);
                                string bookName = reader.GetString(1);
                                string author = reader.GetString(2);
                                labelNovel.Text += $"{bookId:D3}-{bookName} - {author}\r\n";
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
    }
}
