using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Typist.App.Models.Main
{
    public class _FormModel
    {
        public string Text { get; set; }
        public string Description { get; set; }
        public Button Buttons { get; set; }
    }

    public class Button
    {
        public StartButton Start { get; set; }
    }
    public class StartButton
    {
        public string Text { get; set; }
    }
}
