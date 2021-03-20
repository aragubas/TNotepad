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
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TNotepad
{
    public partial class SettingsTab : UserControl
    {
        TabPage AssociatedTabPage;
        Form1 RootControl;
        dynamic SelectedTab;

        public SettingsTab(Form1 pRootControl, TabPage pAssociatedTabPage)
        {
            InitializeComponent();

            RootControl = pRootControl;
            AssociatedTabPage = pAssociatedTabPage;
        }

        public void CreateSettingsTab(int SettingTabID)
        {
            SettingsPanel.Controls.Clear();

            if (SettingTabID == 0)
            {
                SettingsPages.UISettings Set = new SettingsPages.UISettings(RootControl);
                SelectedTab = Set;
                SettingsPanel.Controls.Add(Set);

            } else if (SettingTabID == 1)
            {
                SettingsPages.TextEditorTab Set = new SettingsPages.TextEditorTab(RootControl);
                SelectedTab = Set;
                SettingsPanel.Controls.Add(Set);

            }


        }

        public void LoadLangs()
        {
            ApplyChangesButton.Text = Lang.GetLangData("SettingsTab_ApplyButton");
            button1.Text = Lang.GetLangData("SettingsTab_UISettingsLabel");
            button2.Text = Lang.GetLangData("SettingsTab_TextEditorLabel");

        }

        private void SettingsTab_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
            CreateSettingsTab(0);

            LoadLangs();

        }

        // Apply all settings
        private void ApplyChangesButton_Click(object sender, EventArgs e)
        {
            // Save
            SelectedTab.SaveSettings();
            // Save Settings Key
            Properties.Settings.Default.Save();
            // Load Values
            SelectedTab.LoadValues();

            MessageBox.Show("Sucefully saved", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateSettingsTab(0);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateSettingsTab(1);

        }
    }
}
