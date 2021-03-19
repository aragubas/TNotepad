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

            LoadValues();
        }

        public void LoadValues()
        {
            WordWrap_Enable.Checked = Properties.Settings.Default.WordWrapEnabled;
        }

        public void SaveSettings()
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.WordWrapEnabled)
            {
                Properties.Settings.Default.WordWrapEnabled = false;
            }
            else
            {
                Properties.Settings.Default.WordWrapEnabled = true;
            }

            LoadValues();
        }
    }
}
