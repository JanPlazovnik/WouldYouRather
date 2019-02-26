using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WouldYouRather
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            lblDesc.Text = 
                "Would You Rather is a game of preference, players are faced with questions from various topics." +
                "\n\nTheir answers are saved to calculate the statistics and display how many players opted for the same option.";
        }

        private void llblAuthor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.plazovnik.si/");
        }

        private void llblHomePage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/JanPlazovnik/WouldYouRather");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}