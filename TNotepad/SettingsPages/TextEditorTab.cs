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

namespace TNotepad.SettingsPages
{
    public partial class TextEditorTab : UserControl
    {
        TabNotepadForm RootControl;

        public TextEditorTab(TabNotepadForm pRootControl)
        {
            InitializeComponent();
            RootControl = pRootControl;

            Dock = DockStyle.Fill;

            LoadValues();
            LoadLangStrings();

        }

        public void LoadLangStrings()
        {
            // WordWrap Settings
            WordWrapGroupBox.Text = Lang.GetLangData("Settings_TextEditor_WordWrapGroupBoxTitle");
            WordWrapCheckbox.Text = Lang.GetLangData("Settings_TextEditor_WordWrapCheckbox");

            // Font Settings
            FontSettingPreview.Text = Lang.GetLangData("Settings_TextEditor_FontSettings_PreviewText");
            FontSettingChangeFontButton.Text = Lang.GetLangData("Settings_TextEditor_FontSettings_ChangeFontButton");
            FontSettingGroupBox.Text = Lang.GetLangData("Settings_TextEditor_FontSettings_GroupBoxTitle");

        }

        private void TextEditorTab_Load(object sender, EventArgs e)
        {
        }

        public void LoadValues()
        {
            WordWrapCheckbox.Checked = Properties.Settings.Default.WordWrapEnabled;
            FontSettingPreview.Font = Properties.Settings.Default.TextEditorFont;

        }

        public void SaveSettings()
        {
            Properties.Settings.Default.WordWrapEnabled = WordWrapCheckbox.Checked;
            Properties.Settings.Default.TextEditorFont = FontSettingPreview.Font;

        }

        private void FontSettingChangeFontButton_Click(object sender, EventArgs e)
        {
            TextEditorFont.ShowDialog();
            FontSettingPreview.Font = TextEditorFont.Font;

        }


    }
}
