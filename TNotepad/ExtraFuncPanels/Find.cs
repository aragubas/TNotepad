using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TNotepad.ExtraFuncPanels
{
    public partial class Find : UserControl
    {
        TextEditingTab RootControl;
        public Find(TextEditingTab pRootControl)
        {
            InitializeComponent();

            RootControl = pRootControl;
        }

        public void LoadLangs()
        {
            FindButton.Text = Lang.GetLangData("QuickFind_FindButton");
        }

        private void Find_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;

            LoadLangs();
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            RootControl.TextEditingThing.Find(textBox1.Text);
            //RootControl.TextEditingThing.SelectedText = RootControl.TextEditingThing.Text.Substring(Pos, 2);
            RootControl.TextEditingThing.Focus();
            RootControl.QuitExtraFuncPanel();


        }

        private void Find_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                RootControl.QuitExtraFuncPanel();

            }
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                RootControl.QuitExtraFuncPanel();

            }

            if (e.KeyCode == Keys.Enter)
            {
                FindButton.PerformClick();
            }
        }
    }
}
