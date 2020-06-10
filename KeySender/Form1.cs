using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeySender
{
    public partial class frmKeyPresser : Form
    {
        private PressHandler _handler;
        public frmKeyPresser()
        {
            InitializeComponent();
            _handler = new PressHandler(Keys.I, Keys.Control, this);
        }

        private void HandleHotkey()
        {
            var data = rbClipboard.Checked
                ? Clipboard.GetText()
                : txtSpecified.Text;
            if (!string.IsNullOrWhiteSpace(data))
            {
                Thread.Sleep(200);
                SendKeys.SendWait(data);
            }
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == Constants.WM_HOTKEY_MSG_ID)
            {
                HandleHotkey();
                // var val = (int) m.WParam; // for future reference, tells us the id of the hotkey. Can be used later to build a more elaborate hotkey manager
            }
            base.WndProc(ref m);
        }
    }
}
