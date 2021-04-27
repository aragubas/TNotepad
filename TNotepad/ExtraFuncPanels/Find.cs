/*
   Copyright 2021 Aragubas/Paulo Otávio de Lima

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License. 
  
 */

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

            Dock = DockStyle.Fill;

            LoadLangs();

        }

        public void LoadLangs()
        {
            FindButton.Text = Lang.GetLangData("QuickFind_FindButton");
        }

        private void Find_Load(object sender, EventArgs e)
        {

        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            RootControl.TextEditingThing.Find(textBox1.Text);
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
