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
    public partial class Game : Form
    {
        protected string ResourceFile = "Forms/Game.json";
        public Game()
        {
            InitializeComponent();
        }
        public Game(string Lang)
        {
            InitializeComponent();

            string resource = File.ReadAllText($"{Application.StartupPath}/Resources/{Lang}/{ResourceFile}");

        }
    }

    class GameModel
    {
        public string Text { get; set; }
    }
}
