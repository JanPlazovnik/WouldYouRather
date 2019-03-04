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
    public partial class UserHistory : Form
    {
        int user_id;
        public UserHistory(int id)
        {
            InitializeComponent();
            user_id = id;
        }

        private void UserHistory_Load(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection("data source=database.db"))
                {
                    conn.Open();
                    using (SQLiteCommand sql = new SQLiteCommand(conn))
                    {
                        sql.CommandText = $"SELECT * FROM history WHERE (user_id = '{user_id}')";

                        SQLiteDataReader reader = sql.ExecuteReader();
                        var count = 0;

                        while (reader.Read())
                        {
                            string red = reader.GetString(2);
                            string blue = reader.GetString(3);
                            int choice = reader.GetInt32(4);

                            Button wrapperRed = new Button();
                            wrapperRed.FlatStyle = FlatStyle.Flat;
                            wrapperRed.Height = 50;
                            wrapperRed.Width = (this.Width / 2) - 30;
                            wrapperRed.BackColor = Color.LightCoral;
                            wrapperRed.Text = red;
                            wrapperRed.Enabled = false;

                            Button wrapperBlue = new Button();
                            wrapperBlue.FlatStyle = FlatStyle.Flat;
                            wrapperBlue.Height = 50;
                            wrapperBlue.Width = (this.Width / 2) - 30;
                            wrapperBlue.BackColor = SystemColors.ActiveCaption;
                            wrapperBlue.Text = blue;
                            wrapperBlue.Enabled = false;

                            if (choice == 0)
                            {
                                wrapperRed.FlatAppearance.BorderSize = 5;
                                wrapperBlue.FlatAppearance.BorderSize = 0;
                            }
                            else if(choice == 1)
                            {
                                wrapperRed.FlatAppearance.BorderSize = 0;
                                wrapperBlue.FlatAppearance.BorderSize = 5;
                            }
                            flpContainer.Controls.Add(wrapperRed);
                            flpContainer.Controls.Add(wrapperBlue);
                           
                            //MessageBox.Show($"{red} | {blue} | {choice}");
                            count++;
                        }
                        if (count == 0)
                        {
                            flpContainer.Visible = false;
                            lblNoHistory.Visible = true;
                        }
                        if (count > 0)
                        {
                            flpContainer.Visible = true;
                            lblNoHistory.Visible = false;
                        }
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
