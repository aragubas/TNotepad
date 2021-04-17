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
        TabNotepadForm RootControl;

        public UISettings(TabNotepadForm pRootControl)
        {
            InitializeComponent();
            RootControl = pRootControl;

            Dock = DockStyle.Fill;
            LoadLangStrings();
            LoadValues();

        }

        public void LoadLangStrings()
        {
            // Group Box
            SaveWarningGroupBox.Text = Lang.GetLangData("Settings_UISettings_SaveWarning");
            LanguageSettingGroupBox.Text = Lang.GetLangData("Settings_UISettings_LanguageSetting");
            WindowShadowGroupBox.Text = Lang.GetLangData("Settings_UISettings_WindowShadow");
            SmoothVisualElementsGroupBox.Text = Lang.GetLangData("Settings_UISettings_SmoothVisualElementsGroupbox");
            StretchResizeGroupbox.Text = Lang.GetLangData("Settings_UISettings_StretchResizeGroupbox");
            ThemeSettingsGroupBox.Text = Lang.GetLangData("Settings_UISettings_ThemeSettingsGroupbox");
            DeFlickerGroupBox.Text = Lang.GetLangData("Settings_UISettings_DeflickerGroupbox");

            // Labels
            SaveWarningIntervalInfo.Text = Lang.GetLangData("Settings_UISettings_SaveWarningIntervalInfoLabel");
            LanguageSettingsInfoLabel.Text = Lang.GetLangData("Settings_UISettings_LanguageSettingsInfoLabel");
            ThemeSettingsInfoLabel.Text = Lang.GetLangData("Settings_UISettings_ThemeSettingsInfoLabel");

            // Checkboxes
            SaveWarningCheckBox.Text = Lang.GetLangData("Settings_UISettings_SaveWarningCheckbox");
            WindowShadowCheckBox.Text = Lang.GetLangData("Settings_UISettings_WindowShadowCheckbox");
            SmoothVisualElementsCheckbox.Text = Lang.GetLangData("Settings_UISettings_SmoothVisualElementsCheckbox");
            StretchResizeCheckbox.Text = Lang.GetLangData("Settings_UISettings_StretchResizeCheckbox");
            DeFlickerCheckBox.Text = Lang.GetLangData("Settings_UISettings_DeflickerCheckBox");

            // Buttons
            OpenLanguageSettingsButton.Text = Lang.GetLangData("Settings_UISettings_OpenLanguageSettingsButton");
            OpenThemeSettingsButton.Text = Lang.GetLangData("Settings_UISettings_OpenThemeSettingsButton");


        }
        private void UISettingscs_Load(object sender, EventArgs e)
        {

        }

        public void LoadValues()
        {
            SaveWarningTextBox.Text = Convert.ToString(Properties.Settings.Default.UnsavedTimeInterval);
            SaveWarningCheckBox.Checked = Properties.Settings.Default.UnsavedTime;
            WindowShadowCheckBox.Checked = Properties.Settings.Default.WindowShadow;
            SmoothVisualElementsCheckbox.Checked = Properties.Settings.Default.SmoothVisualElements;
            StretchResizeCheckbox.Checked = Properties.Settings.Default.StrechWindowContentsWhenResizing;
            DeFlickerCheckBox.Checked = Properties.Settings.Default.ForceDoubleBuffer;

        }

        public void SaveSettings()
        {
            Properties.Settings.Default.UnsavedTime = SaveWarningCheckBox.Checked;
            Properties.Settings.Default.WindowShadow = WindowShadowCheckBox.Checked;
            Properties.Settings.Default.SmoothVisualElements = SmoothVisualElementsCheckbox.Checked;
            Properties.Settings.Default.StrechWindowContentsWhenResizing = StretchResizeCheckbox.Checked;
            Properties.Settings.Default.ForceDoubleBuffer = DeFlickerCheckBox.Checked;

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
            Utils.CreateWindow(new LanguageSettings(), ShowAsDialog: true);

        }

        private void WindowShadowCheckButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void OpenThemeSettingsButton_Click(object sender, EventArgs e)
        {
            Utils.CreateWindow(new ThemeSettings(), ShowAsDialog: true);
        }

    }
}
