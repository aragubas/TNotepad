using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TNotepad.ExtraFuncPanels
{
    public partial class GotoLine : UserControl
    {
        TextEditingTab RootControl;

        public GotoLine(TextEditingTab pRootControl)
        {
            InitializeComponent();

            RootControl = pRootControl;
            Dock = DockStyle.Fill;

            LoadLang();

        }

        public void LoadLang()
        {
            GoButton.Text = Lang.GetLangData("QuickGotoLine_GoButton");

        }

        private void GotoLine_Load(object sender, EventArgs e)
        {
            
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            int LineNumber = 0;

            try
            {
                LineNumber = Convert.ToInt32(LineThingTextbox.Text);

                RootControl.TextEditingThing.GotoLine(LineNumber);

            }
            catch (Exception) { }

            RootControl.TextEditingThing.Focus();
            RootControl.QuitExtraFuncPanel();

        }

        private void LineThingTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                RootControl.QuitExtraFuncPanel();

            }

            if (e.KeyCode == Keys.Enter)
            {
                GoButton.PerformClick();
            }

        }

        private void GoButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                RootControl.QuitExtraFuncPanel();

            }

        }
    }
}
