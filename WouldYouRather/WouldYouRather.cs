using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WouldYouRather
{
    public partial class WouldYouRather : Form
    {
        Random rnd = new Random();
        private List<Item> items;
        int random, tempRand, currentIndex, total = 0;
        int seconds = 5;
        int user_id = 0;
        string json, output;
        double bluePercent, redPercent;

        public WouldYouRather(int id, string username, int admin)
        {
            InitializeComponent();
            user_id = id;
            lblUser.Text = $"Playing as: {username} ({(admin == 1 ? "Admin" : "User")})";
            if (admin == 1) adminPanelToolStripMenuItem.Visible = true;
            else if (admin == 0) adminPanelToolStripMenuItem.Visible = false;
    }

        public void loadJson()
        {
            using (StreamReader r = new StreamReader("../../Questions/questions.json"))
            {
                json = r.ReadToEnd();
                items = JsonConvert.DeserializeObject<List<Item>>(json);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadJson();
            changeQuestion();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About abtForm = new About();
            abtForm.Show();
        }

        private void addChoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddJSON f1 = new AddJSON(items);
            f1.Show();
        }

        private void WouldYouRather_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Welcome welcomeForm = (Welcome)Application.OpenForms["Welcome"];
            this.Hide();
            welcomeForm.Show();
        }

        private void adminPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel(items);
            adminPanel.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds--;
            countdown.Text = seconds.ToString();
            if(seconds == 0)
            {
                timer1.Enabled = false;
                seconds = 5;
                countdown.Text = "";
                changeQuestion();
            }
        }

        private void button1_Click(object sender, EventArgs e) //red
        {
            buttonMechanics((Button)sender, (item) => item.redclicks++);
            saveHistory(0); // 0 = red, 1 = blue
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserHistory historyForm = new UserHistory(user_id);
            historyForm.Show();
        }

        private void button2_Click(object sender, EventArgs e) //blue
        {
            buttonMechanics((Button)sender, (item) => item.blueclicks++);
            saveHistory(1); // 0 = red, 1 = blue
        }

        void buttonMechanics(Button btn, Action<Item> color)
        {
            button1.Enabled = button2.Enabled = false;
            btn.FlatAppearance.BorderSize = 5;
            color(items[currentIndex]);
            redCount.Visible = blueCount.Visible = true;

            output = Newtonsoft.Json.JsonConvert.SerializeObject(items, Newtonsoft.Json.Formatting.Indented);

            File.WriteAllText("../../Questions/questions.json", output);
            if (items[currentIndex].redclicks != 0 && items[currentIndex].blueclicks != 0)
            {
                total = items[currentIndex].redclicks + items[currentIndex].blueclicks;
                bluePercent = ((double)items[currentIndex].blueclicks / total) * 100;
                redPercent = ((double)items[currentIndex].redclicks / total) * 100;
                redCount.Text = Math.Round(redPercent) + "%";
                blueCount.Text = Math.Round(bluePercent) + "%";
            }
            else if (items[currentIndex].redclicks > 0 && items[currentIndex].blueclicks == 0)
            {
                redCount.Text = "100%";
                blueCount.Text = "0%";
            }
            else
            {
                redCount.Text = "0%";
                blueCount.Text = "100%";
            }

            timer1.Enabled = true;
        }

        void saveHistory(int choice)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection("data source=database.db"))
                {
                    conn.Open();
                    using (SQLiteCommand sql = new SQLiteCommand("INSERT INTO history(user_id, option_red, option_blue, choice) VALUES(?, ?, ?, ?)", conn))
                    {
                        sql.Parameters.AddWithValue("user_id", user_id);
                        sql.Parameters.AddWithValue("option_red", button1.Text);
                        sql.Parameters.AddWithValue("option_blue", button2.Text);
                        sql.Parameters.AddWithValue("choice", choice); 
                        if (sql.ExecuteNonQuery() == 0)
                        {
                            MessageBox.Show("Error updating database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            Console.Write("work");
                        }
                        sql.Dispose();
                    }
                    conn.Close();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void changeQuestion()
        {
            do
            {
                random = rnd.Next(items.Count);
            } while (random == tempRand);
            button1.Enabled = button2.Enabled = true;
            redCount.Visible = blueCount.Visible = false;
            button1.FlatAppearance.BorderSize = button2.FlatAppearance.BorderSize = 0;
            button1.Text = items[random].red;
            button2.Text = items[random].blue;
            currentIndex = random;
            tempRand = random;
            redCount.Text = blueCount.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(timer1.Enabled)
            {
                timer1.Enabled = false;
                seconds = 5;
                countdown.Text = "";
            }
            changeQuestion();
        }
    }
}