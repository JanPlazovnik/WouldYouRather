using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
    public partial class AddJSON : Form
    {
        string output;
        private List<Item> items;
        public AddJSON(List<Item> items)
        {
            this.items = items;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Item newChoice = new Item();
                if (redChoice.Text != "" && blueChoice.Text != "")
                {
                    newChoice.red = redChoice.Text;
                    newChoice.blue = blueChoice.Text;

                    items.Add(newChoice);

                    output = Newtonsoft.Json.JsonConvert.SerializeObject(items, Newtonsoft.Json.Formatting.Indented);

                    File.WriteAllText("../../Questions/questions.json", output);

                    redChoice.Text = blueChoice.Text = "";
                }
                else MessageBox.Show("Fields must not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception er)
            {
                MessageBox.Show(er.Message, "Napaka", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
