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
    public partial class UserPortal : Form
    {
        public UserPortal()
        {
            InitializeComponent();
        }

        private void buttonPortalBookDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            BookDetails b = new BookDetails();
            b.Show();
        }

       

        private void buttonportalBorrow_Click(object sender, EventArgs e)
        {
            this.Hide();
            BorrowPage B = new BorrowPage();
            B.Show();
        }

        private void buttonportalManageBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageBooks M = new ManageBooks();
            M.Show();
        }

        private void buttonUserPortralBack_Click(object sender, EventArgs e)
        {
            WelcomePage i = new WelcomePage();
            this.Hide();
            i.Show();
        }
    }
}
