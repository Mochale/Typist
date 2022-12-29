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
using System.IO;

namespace Typist.App
{
    public partial class Form1 : Form
    {
        protected string ResourceFile = "Forms/Main.json";
        public string Lang { get; set; }
        public Form1()
        {
            InitializeComponent();

            if (Lang == null || Lang == String.Empty)
                Lang = "Fa";
            string resource = File.ReadAllText($"{Application.StartupPath}/Resources/{Lang}/{ResourceFile}");
            Model model = JsonSerializer.Deserialize<Model>(resource);

            this.Text = model.Text;

            btnStart.Text = model.Buttons.Start.Text;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            new Game().ShowDialog();
        }
    }

    class Model
    {
        public string Text { get; set; }
        public Button Buttons { get; set; }
    }

    class Button
    {
        public Start Start { get; set; }
    }
    class Start
    {
        public string Text { set; get; }
    }
}
