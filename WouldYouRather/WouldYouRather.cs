using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        string json, output;
        double bluePercent, redPercent;

        public WouldYouRather(string username)
        {
            InitializeComponent();
            lblUser.Text = "Playing as: " + username;
        }

        public void loadJson()
        {
            using (StreamReader r = new StreamReader("../../Questions/questions.json"))
            {
                json = r.ReadToEnd();
                items = JsonConvert.DeserializeObject<List<Item>>(json);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddJSON f1 = new AddJSON(items);
            f1.Show();
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
            button1.Enabled = button2.Enabled = false;
            button1.FlatAppearance.BorderSize = 5;
            items[currentIndex].redclicks += 1;
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

        private void button2_Click(object sender, EventArgs e) //blue
        {
            button1.Enabled = button2.Enabled = false;
            button2.FlatAppearance.BorderSize = 5;
            items[currentIndex].blueclicks += 1;
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
            else if(items[currentIndex].redclicks > 0 && items[currentIndex].blueclicks == 0)
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