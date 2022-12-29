using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.IO;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Typist.App
{
    public partial class SelectLanguage : Form
    {
        protected string register_language_resource = "Register.json";
        Models.RegisterLanguage registeredLanguage { get; }
        public SelectLanguage()
        {
            InitializeComponent();

            string resource = File.ReadAllText($"{Application.StartupPath}/Resources/{register_language_resource}");
            registeredLanguage = 
                JsonSerializer.Deserialize<Models.RegisterLanguage>(resource);

            cbmLanguage.Items.AddRange(registeredLanguage.Languages.Select(l => l.Name).ToArray());
        }

        private void SelectLanguage_Load(object sender, EventArgs e)
        {
            cbmLanguage.SelectedIndex = 0;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string name = cbmLanguage.SelectedItem.ToString();
            string directory = registeredLanguage.Languages.FirstOrDefault(l => l.Name == name).Directory;

            new Form1(directory).ShowDialog();
        }
    }
}
