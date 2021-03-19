using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TNotepad.SettingsPages
{
    public partial class TextEditorTab : UserControl
    {
        Form1 RootControl;

        public TextEditorTab(Form1 pRootControl)
        {
            InitializeComponent();
            RootControl = pRootControl;
        }

        private void TextEditorTab_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
        }
    }
}
