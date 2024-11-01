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
    public partial class BookDetails : Form
    {
        public BookDetails()
        {
            InitializeComponent();
        }

        private void BookDetails_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonChildren_Click(object sender, EventArgs e)
        {
            this.Hide();
            Children C = new Children();
            C.Show();
        }

        private void buttonPoetry_Click(object sender, EventArgs e)
        {
            this.Hide();
            Poetry P = new Poetry();
            P.Show();
        }

        private void buttonNovel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Novel N = new Novel();
            N.Show();
        }

        private void buttonHistorical_Click(object sender, EventArgs e)
        {
            this.Hide();
            Historical h = new Historical();
            h.Show();
        }

        private void buttonBackBookDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserPortal v = new UserPortal();
            v.Show();
        }
    }
}
