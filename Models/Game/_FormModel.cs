using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Typist.App.Models.Game
{
    public class _FormModel
    {
        public string Text { get; set; }
        public Lable Labels { get; set; }
        public Button Buttons { get; set; }
    }
    public class Lable
    {
        public HaveText Score { get; set; }
    }

    public class Button
    {
        public HaveText Next { get; set; }
    }
    public class HaveText
    {
        public string Text { get; set; }
    }
}
