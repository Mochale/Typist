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
using Typist.App.Models.Game;

namespace Typist.App
{
    public partial class Game : Form
    {
        protected string ResourceFile = "Forms/Game.json";
        public Game()
        {
            InitializeComponent();

            string resource = File.ReadAllText($"{Application.StartupPath}/Resources/Fa/{ResourceFile}");
            _FormModel model = JsonSerializer.Deserialize<_FormModel>(resource);

            this.Text = model.Text;
            lblScore.Text = model.Labels.Score.Text;
            btnNext.Text = model.Buttons.Next.Text;
        }
        public Game(string Lang)
        {
            InitializeComponent();

            string resource = File.ReadAllText($"{Application.StartupPath}/Resources/{Lang}/{ResourceFile}");
            _FormModel model = JsonSerializer.Deserialize<_FormModel>(resource);

            this.Text = model.Text;
            lblScore.Text = model.Labels.Score.Text;
            btnNext.Text = model.Buttons.Next.Text;
        }
    }
}
