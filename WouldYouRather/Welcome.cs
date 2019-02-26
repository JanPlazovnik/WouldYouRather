using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WouldYouRather
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void btnLoginPanel_Click(object sender, EventArgs e)
        {
            pnlRegister.Visible = false;
            pnlLogin.Visible = true;
            this.Text = "Welcome - Login";
        }

        private void btnRegisterPanel_Click(object sender, EventArgs e)
        {
            pnlLogin.Visible = false;
            pnlRegister.Visible = true;
            this.Text = "Welcome - Register";
        }

        private void btnLoginBack_Click(object sender, EventArgs e)
        {
            pnlLogin.Visible = false;
            pnlRegister.Visible = false;
            this.Text = "Welcome";
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection("data source=database.db"))
                {
                    conn.Open();
                    using (SQLiteCommand sql = new SQLiteCommand("INSERT INTO users(username, password, admin) VALUES(?, ?, ?)", conn))
                    {
                        sql.Parameters.AddWithValue("username", tbRegisterUsername.Text);
                        sql.Parameters.AddWithValue("password", tbRegisterPassword.Text);
                        sql.Parameters.AddWithValue("admin", 0);
                        if (sql.ExecuteNonQuery() == 0)
                        {
                            MessageBox.Show("Error updating database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            WouldYouRather mainForm = new WouldYouRather(tbRegisterUsername.Text, 0);
                            mainForm.Show();
                            this.Hide();
                        }
                        sql.Dispose();
                    }
                    conn.Close();
                }
            }
            catch (SQLiteException er)
            {
                if (er.ErrorCode == 19)
                    MessageBox.Show("Username already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection("data source=database.db"))
                {
                    conn.Open();
                    using (SQLiteCommand sql = new SQLiteCommand(conn))
                    {
                        sql.CommandText = $"SELECT * FROM users WHERE (username = '{tbLoginUsername.Text}') AND (password = '{tbLoginPassword.Text}')";

                        SQLiteDataReader reader = sql.ExecuteReader();
                        var count = 0;
                        int admin = 0;
                        while (reader.Read())
                        {
                            count++;
                            admin = reader.GetInt32(3);
                        }
                        if (count == 0)
                        {
                            MessageBox.Show("Credentials do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            sql.Dispose();
                            conn.Close();
                            return;
                        }
                        WouldYouRather mainForm = new WouldYouRather(tbLoginUsername.Text, admin);
                        mainForm.Show();
                        this.Hide();


                        sql.Dispose();
                    }
                    conn.Close();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
    }
}
