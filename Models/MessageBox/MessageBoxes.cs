using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Typist.App.Models.MessageBox
{
    public abstract class MessageBoxBase
    {
        protected abstract MessageBoxIcon Icon { get; }
        protected virtual MessageBoxButtons Button => MessageBoxButtons.OK;

        public string Header { get; set; }
        public string Message { get; set; }

        public void Show()
        {
            System.Windows.Forms.MessageBox.Show(Message, Header, Button, Icon);
        }

    }
    public class MessageBoxes
    {
        public Success Success { get; set; }
        public Error Error { get; set; }
        public FinishGame FinishGame { get; set; }
    }

    public class Success : MessageBoxBase
    {
        protected override MessageBoxIcon Icon => MessageBoxIcon.Information;
    }

    public class Error : MessageBoxBase
    {
        protected override MessageBoxIcon Icon => MessageBoxIcon.Error;
    }

    public class FinishGame : MessageBoxBase
    {
        protected override MessageBoxIcon Icon => MessageBoxIcon.Asterisk;
    }
}
