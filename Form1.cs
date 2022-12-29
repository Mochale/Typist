using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using Typist.App.Models.Main;
using System.IO;

namespace Typist.App
{
    public partial class Form1 : Form
    {
        protected string ResourceFile = "Forms/Main.json";
        public string Lang { get; set; }
        public Form1()
        {
            DataSet("Fa");
        }

        public Form1(string lang)
        {
            DataSet(lang);
        }

        protected void DataSet(string lang)
        {
            InitializeComponent();

            Lang = lang;
            string resource = File.ReadAllText($"{Application.StartupPath}/Resources/{Lang}/{ResourceFile}");
            _FormModel model = JsonSerializer.Deserialize<_FormModel>(resource);

            this.Text = model.Text;
            rchTextDescription.Text = model.Description;

            btnStart.Text = model.Buttons.Start.Text;
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            new Game(this.Lang).ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
