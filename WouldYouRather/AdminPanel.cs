using Newtonsoft.Json;
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
    public partial class AdminPanel : Form
    {
        private List<Item> items;
        public AdminPanel(List<Item> items)
        {
            this.items = items;
            InitializeComponent();
        }

        private BindingSource _gridSource;

        private BindingSource GridSource
        {
            get
            {
                if (_gridSource == null)
                    _gridSource = new BindingSource();
                return _gridSource;
            }
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            GridSource.DataSource = items;
            dataGridView1.DataSource = GridSource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string output = JsonConvert.SerializeObject(this.dataGridView1.DataSource, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText("../../Questions/questions.json", output);
        }
    }
}