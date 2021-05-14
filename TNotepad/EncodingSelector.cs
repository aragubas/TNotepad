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
using TaiyouUI;

namespace TNotepad
{
    public partial class EncodingSelector : taiyouUserControl
    {
        TextEditingTab RootControl;
        public EncodingSelector(TextEditingTab pRootControl)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            RootControl = pRootControl;

            LoadLangString();
            LoadValues();
            SetAsDefaultEncodingCheckbox.Checked = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string SelectedEncoding = comboBox1.Items[comboBox1.SelectedIndex].ToString();
            if (SetAsDefaultEncodingCheckbox.Checked)
            {
                Properties.Settings.Default.DefaultEncoding = SelectedEncoding;
                Properties.Settings.Default.Save();
            } 
            RootControl.SetEncoding(Utils.EncodingNameToEncodingObject(SelectedEncoding), true);
            RootForm.Close();

        }

        public void LoadLangString()
        {
            EncodingInfoLabel.Text = Lang.GetLangData("EncodingSelector_EncodingInfosLabel");
            SetAsDefaultEncodingCheckbox.Text = Lang.GetLangData("EncodingSelector_SetSelectedEncodingRadioButton");
            button1.Text = Lang.GetLangData("EncodingSelector_ExitSaveButton");

        }

        private void EncodingSelector_Load(object sender, EventArgs e)
        {
            RootForm.Size = new Size(410, 180);
            RootForm.ResizeableForm = false;
            RootForm.MinimizeableForm = false;
            RootForm.Text = Lang.GetLangData("EncodingSelected_WindowTitle");
            // Set Icon
            RootForm.Icon = Properties.Resources.Icon;



            RootForm.FormCloseButton.Click += FormCloseButton_Click;

        }

        void FormCloseButton_Click(object sender, EventArgs e)
        {
            RootForm.Close();

        }

        private void LoadValues()
        {
            comboBox1.SelectedIndex = comboBox1.Items.IndexOf(Properties.Settings.Default.DefaultEncoding);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetAsDefaultEncodingCheckbox.Checked = false;

        }
    }
}
