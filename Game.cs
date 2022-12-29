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
        protected string WordResource = "Words.txt";
        protected string Lang{ get; set; }
        protected List<string> Words { get; set; }
        protected int count_word;
        protected int score = 0;
        protected int minute = 1;
        protected int second = 0;
        protected int gift = 0;
        protected List<int> SelectedWords { get; set; }
        public Game()
        {
            Lang = "Fa";
            DataSet(Lang);
        }
        public Game(string lang)
        {
            Lang = lang;
            DataSet(Lang);
        }

        protected void DataSet(string Lang)
        {
            InitializeComponent();

            string resource = File.ReadAllText($"{Application.StartupPath}/Resources/{Lang}/{ResourceFile}");
            _FormModel model = JsonSerializer.Deserialize<_FormModel>(resource);

            Words = File.ReadAllLines($"{Application.StartupPath}/Resources/{Lang}/{WordResource}").ToList();

            count_word = Words.Count;

            this.Text = model.Text;
            lblScore.Text = model.Labels.Score.Text;
            btnNext.Text = model.Buttons.Next.Text;

            SelectedWords = new List<int>();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            ChangeText();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time_set();
        }

        private void time_set()
        {
            if (second == 0)
            {
                if (minute == 0)
                {
                    timer1.Enabled = false;
                    string resource = File.ReadAllText($"{Application.StartupPath}/Resources/{Lang}/MessageBoxes.json");
                    Models.MessageBox.MessageBoxes mbx = JsonSerializer.Deserialize<Models.MessageBox.MessageBoxes>(resource);

                    mbx.FinishGame.Message = mbx.FinishGame.Message.Replace("{score}", score.ToString("00"));
                    mbx.FinishGame.Show();

                    txtAnswer.Enabled = txtTest.Enabled = btnNext.Enabled = false;
                    return;
                }

                second = 60;
                minute--;
            }

            second--;

            lblMinute.Text = minute.ToString("00");
            lblSecound.Text = second.ToString("00");

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // Your text is correct
            if (txtAnswer.Text.Trim().ToUpper() == txtTest.Text.ToUpper())
            {
                score++;
                /*
                gift++;
                if (gift % 3 == 0)
                {
                    second++;
                }
                */
                lblScoreValue.Text = score.ToString("00");
                ChangeText();
                txtAnswer.Text = String.Empty;
                txtAnswer.Focus();
            }
            txtAnswer.SelectAll();
            txtAnswer.Focus();
        }

        private void ChangeText()
        {
            int index = 0;
            Random random = new Random();
            do
            {
                index = random.Next(0, count_word - 1);
            } while (selectedBefore(index));

            SelectedWords.Add(index);

            txtTest.Text = Words[index];
        }
        
        private bool selectedBefore(int index)
        {
            return SelectedWords.Contains(index);
        }
    }
}
