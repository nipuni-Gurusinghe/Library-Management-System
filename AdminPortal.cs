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
    public partial class AdminPortal : Form
    {
        public AdminPortal()
        {
            InitializeComponent();
        }

        private void buttonAPHandOver_Click(object sender, EventArgs e)
        {
            this.Hide();
            HandOver H = new HandOver();
            H.Show();
        }

        private void buttonAPAddRemove_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddRemoveBooks A = new AddRemoveBooks();
            A.Show();
        }

        private void buttonBackAdminPoetral_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserPortal r = new UserPortal();
            r.Show();
        }
    }
}
