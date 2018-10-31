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
        string json, output;
        private List<Item> items;
        public AddJSON(List<Item> items)
        {
            this.items = items;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Item newChoice = new Item();
            newChoice.red = redChoice.Text;
            newChoice.blue = blueChoice.Text;

            items.Add(newChoice);

            output = Newtonsoft.Json.JsonConvert.SerializeObject(items, Newtonsoft.Json.Formatting.Indented);

            File.WriteAllText("../../Questions/questions.json", output);
        }
    }
}
