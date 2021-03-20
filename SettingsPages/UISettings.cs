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

namespace TNotepad.SettingsPages
{
    public partial class UISettings : UserControl
    {
        Form1 RootControl;

        public UISettings(Form1 pRootControl)
        {
            InitializeComponent();
            RootControl = pRootControl;

        }

        public void LoadLangStrings()
        {
            // Group Box
            HometabSettingGroupBox.Text = Lang.GetLangData("Settings_UISettings_Hometab");
            SaveWarningGroupBox.Text = Lang.GetLangData("Settings_UISettings_SaveWarning");
            LanguageSettingGroupBox.Text = Lang.GetLangData("Settings_UISettings_LanguageSetting");

            // Labels
            SaveWarningIntervalInfo.Text = Lang.GetLangData("Settings_UISettings_SaveWarningIntervalInfoLabel");
            LanguageSettingsInfoLabel.Text = Lang.GetLangData("Settings_UISettings_LanguageSettingsInfoLabel");

            // Checkboxes
            SaveWarningCheckBox.Text = Lang.GetLangData("Settings_UISettings_SaveWarningCheckbox");
            CheckHometabOpt.Text = Lang.GetLangData("Settings_UISettings_HometabAsDefaultCheckbox");


        }
        private void UISettingscs_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
            LoadLangStrings();
            LoadValues();

        }

        public void LoadValues()
        {
            SaveWarningTextBox.Text = Convert.ToString(Properties.Settings.Default.UnsavedTimeInterval);
            SaveWarningCheckBox.Checked = Properties.Settings.Default.UnsavedTime;
            CheckHometabOpt.Checked = Properties.Settings.Default.ShowHometab;

        }

        public void SaveSettings()
        {
            Properties.Settings.Default.UnsavedTime = SaveWarningCheckBox.Checked;
            Properties.Settings.Default.ShowHometab = CheckHometabOpt.Checked;

            // Unsaved Time Interval
            try
            {
                Properties.Settings.Default.UnsavedTimeInterval = Convert.ToInt32(SaveWarningTextBox.Text);

            }
            catch (Exception)
            {
                Properties.Settings.Default.UnsavedTimeInterval = Properties.Settings.Default.DefaultUnsavedTimeInterval;
                Console.WriteLine("Invalid value at UnsavedTimeInterval");
            }



        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OpenLanguageSettingsButton_Click(object sender, EventArgs e)
        {
            LanguageSettings languageSettings = new LanguageSettings();
            languageSettings.ShowDialog();
        }
    }
}
