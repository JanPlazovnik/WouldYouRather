using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WouldYouRather
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        // TO DO:
        // SQLite DB for User Login and Registration
        // History saved in DB
        private void button1_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text != "")
            {
                WouldYouRather mainForm = new WouldYouRather(tbUsername.Text);
                mainForm.Show();
                this.Hide();
            }
            else MessageBox.Show("Username must not be empty!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void tbUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
    }
}
