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
using System.IO;
using System.Runtime.InteropServices;

namespace TNotepad
{
    public partial class TextEditingTab : UserControl
    {
        TabPage AssociatedTabPage;
        MainForm RootControl;
        DateTime dateTime;
        int LastUnsavedTime = 0;
        public string LastFileName = "";
        public bool DontSetUntitled = false;
        System.Text.Encoding CurrentEncoding;

        public TextEditingTab(TabPage pAssociatedTabPage, MainForm pRootControl)
        {
            InitializeComponent();
            AssociatedTabPage = pAssociatedTabPage;
            RootControl = pRootControl;


            Dock = DockStyle.Fill;
            if (!DontSetUntitled) { UpdateTitle(Lang.GetLangData("TextEditMain_UntitledTab")); }

            LastSavedTimer.Enabled = Properties.Settings.Default.UnsavedTime;
            LastSavedTimer.Interval = Properties.Settings.Default.UnsavedTimeInterval;

            LoadLangStrings();

            // Set Default Encoding
            SetEncoding(Utils.EncodingNameToEncodingObject());

            TextEditingThing.WordWrap = Properties.Settings.Default.WordWrapEnabled;

            LoadTheme();

        }

        public void LoadTheme()
        {
            // Menu Item
            copyToolStripMenuItem.LoadTheme();
            cutToolStripMenuItem.LoadTheme();
            encodingToolStripMenuItem.LoadTheme();
            PasteToolStripMenuItem.LoadTheme();
            pinDocumentToolStripMenuItem.LoadTheme();
            quickFindToolStripMenuItem.LoadTheme();
            runToolStripMenuItem.LoadTheme();
            savePathToolStripMenuItem.LoadTheme();
            settingsToolStripMenuItem.LoadTheme();

            // ToolStripButton
            OpenFileButton.LoadTheme();
            SaveButton.LoadTheme();
            SaveAsButton.LoadTheme();
            NewPage.LoadTheme();
            
            // ToolStrip
            Toolbar.LoadTheme();

            // ToolStripDropDownButton
            ExtraMenu.LoadTheme();

            // StatusStrip
            StatusBar.LoadTheme();


            // ExtraFuncPanel
            ExtraFuncPanel.BackColor = ThemeLoader.GetThemeData("ExtraFuncPanel_BackgroundColor");
            ExtraFuncPanel.ForeColor = ThemeLoader.GetThemeData("ExtraFuncPanel_ForegroundColor");

            // Text Editor
            TextEditingThing.BackColor = ThemeLoader.GetThemeData("TextEditor_BackgroundColor");
            TextEditingThing.ForeColor = ThemeLoader.GetThemeData("TextEditor_ForegroundColor");


            // UserControl Colors
            this.BackColor = ThemeLoader.GetThemeData("Form_BackgroundColor");
            this.ForeColor = ThemeLoader.GetThemeData("Form_ForegroundColor");


        }

        private void TextEditingTab_Load(object sender, EventArgs e)
        {
            
        }

        private void SetTextEditorProperties()
        {
            TextEditingThing.WordWrap = Properties.Settings.Default.WordWrapEnabled;

        }

        public void LoadLangStrings()
        {
            // Buttons
            NewPage.Text = Lang.GetLangData("TextEditMain_NewPageButton");
            SaveAsButton.Text = Lang.GetLangData("TextEditMain_SaveFileAs");
            SaveButton.Text = Lang.GetLangData("TextEditMain_SaveFile");
            OpenFileButton.Text = Lang.GetLangData("TextEditMain_OpenFile");

            // Menus
            ExtraMenu.Text = Lang.GetLangData("TextEditMain_ExtraMenu");
            pinDocumentToolStripMenuItem.Text = Lang.GetLangData("TextEditMain_ExtraMenu_PinDocument");
            savePathToolStripMenuItem.Text = Lang.GetLangData("TextEditMain_ExtraMenu_SavePath");
            settingsToolStripMenuItem.Text = Lang.GetLangData("TextEditMain_ExtraMenu_Settings");
            encodingToolStripMenuItem.Text = Lang.GetLangData("TextEditMain_ExtraMenu_Encoding");
            runToolStripMenuItem.Text = Lang.GetLangData("TextEditMain_ExtraMenu_Run");
            quickFindToolStripMenuItem.Text = Lang.GetLangData("TextEditMain_ExtraMenu_QuickFind");

            // Labels
            SaveStatusText.Text = Lang.GetLangData("TextEditMain_UnsavedStatus");
            EncodingInfoLabel.Text = Lang.GetLangData("TextEditMain_EncodingNotSetStatus");

            // Drop Down
            copyToolStripMenuItem.Text = Lang.GetLangData("TextEditMain_TextEditDropDown_Copy");
            cutToolStripMenuItem.Text = Lang.GetLangData("TextEditMain_TextEditDropDown_Cut");
            PasteToolStripMenuItem.Text = Lang.GetLangData("TextEditMain_TextEditDropDown_Paste");


        }

        private void NewPage_Click(object sender, EventArgs e)
        {
            RootControl.CreateNewTab();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }


        public void SetEncoding(Encoding newEncoding)
        {
            CurrentEncoding = newEncoding;
            EncodingInfoLabel.Text = Utils.GetCurrentEncodingName(newEncoding);
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            SaveFile(saveFileDialog1.FileName);

        }

        public void SaveFile(string FileName)
        {
            if (FileName == "")
            {
                return;
            }
            LastFileName = FileName;
            File.WriteAllText(FileName, TextEditingThing.Text, CurrentEncoding);
            SaveStatusText.Text = Lang.GetLangData("TextEditMain_SavedStatus");
            UpdateTitle(Path.GetFileName(FileName));
            ResetLastUnsavedTime();
            pinDocumentToolStripMenuItem.Enabled = true;

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            OpenFile(openFileDialog1.FileName);

        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void ResetLastUnsavedTime()
        {
            LastUnsavedTime = 0;

        }

        public void UpdateTitle(string NewTitle)
        {
            AssociatedTabPage.Text = NewTitle;

        }

        public void ReopenFileInEncodingChange()
        {
            if (MessageBox.Show(Lang.GetLangData("TextEditMain_ReloadAfterEncodingChange_Text"), Lang.GetLangData("TextEditMain_ReloadAfterEncodingChange_Title"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (LastFileName == "")
                { 
                    saveFileDialog1.ShowDialog();
                }
                SaveFile(LastFileName);

                TextEditingThing.Text = "";

                OpenFile(LastFileName);
            }

        }

        // Open a File
        public void OpenFile(string FileName)
        {
            if (FileName == "") { return; }
            // Set to default encoding, if encoding is null
            if (CurrentEncoding == null) { SetEncoding(Utils.EncodingNameToEncodingObject()); }

            TextEditingThing.Text = File.ReadAllText(FileName, CurrentEncoding);

            SaveStatusText.Text = Lang.GetLangData("TextEditMain_UnsavedStatus");
            ResetLastUnsavedTime();
            LastFileName = FileName;
            pinDocumentToolStripMenuItem.Enabled = true;

            UpdateTitle(Path.GetFileName(FileName));
        }

        // Last saved time timer
        private void LastSavedTimer_Tick(object sender, EventArgs e)
        {
            LastUnsavedTime += LastSavedTimer.Interval;

            TimeSpan TimePassedAway = TimeSpan.FromMilliseconds(LastUnsavedTime);
            dateTime = DateTime.Today.Add(TimePassedAway);

            string LastTimeInString = dateTime.ToString("HH:mm:ss");

            SaveStatusText.Text = Lang.GetLangData("TextEditMain_UnsavedStatusInLast").Replace("$1", LastTimeInString);

        }


        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        public void SaveDocument()
        {
            if (LastFileName == "")
            {
                saveFileDialog1.ShowDialog();
                return;
            }
            File.WriteAllText(LastFileName, TextEditingThing.Text);
            SaveStatusText.Text = Lang.GetLangData("TextEditMain_SavedStatus");
            ResetLastUnsavedTime();
        }


        private void SaveStatusText_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Lang.GetLangData("TextEditMain_UnsavedStatusTimeFormatInfo_Text"), Lang.GetLangData("TextEditMain_UnsavedStatusTimeFormatInfo_Title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RootControl.CreateSettingsTab();
        }

        private void encodingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EncodingSelector Ecd = new EncodingSelector(this);
            Ecd.ShowDialog();
        }

        private void pinDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PinDocumentWizard Pin = new PinDocumentWizard(this);
            Pin.ShowDialog();

        }

        private void SaveButton_Click_1(object sender, EventArgs e)
        {
            SaveDocument();
        }

        private void SaveAsButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void savePathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LastFileName == "")
            {
                MessageBox.Show(Lang.GetLangData("TextEditMain_CantShowCurrentSavingPath_Text"), Lang.GetLangData("TextEditMain_CurrentSavingPath_Title"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            MessageBox.Show(LastFileName, Lang.GetLangData("TextEditMain_CurrentSavingPath_Title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TextEditingTab_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        public void QuitExtraFuncPanel()
        {
            ExtraFuncPanel.Controls.Clear();
            ExtraFuncPanel.Visible = false;
        }

        public void FindExtraFuncPanel()
        {
            ExtraFuncPanel.Visible = true;
            // Remove all previus controls
            ExtraFuncPanel.Controls.Clear();

            ExtraFuncPanels.Find Ceira = new ExtraFuncPanels.Find(this);
            ExtraFuncPanel.Controls.Add(Ceira);

            Ceira.Focus();
        }

        private void Text_KeyDown(object sender, KeyEventArgs e)
        {
            // Find Shortcut
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.F)
            {
                FindExtraFuncPanel();
            }

            // Save Shortcut
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.S)
            {
                SaveButton.PerformClick();

            }else if (e.KeyCode == Keys.S && (e.Control && e.Shift)) // Save As Shortcut
            {
                SaveAsButton.PerformClick();
            }

            // Open Shortcut
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.O)
            {
                OpenFileButton.PerformClick();
            }

            // New Page Shortcut
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.N)
            {
                NewPage.PerformClick();
            }

            // Close Shortcut
            if (e.KeyCode == Keys.E && (e.Control && e.Shift))
            {
                RootControl.CloseSelectedTab();
            }


        }

        private void quickFindToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindExtraFuncPanel();
        }

        private void Updater_Tick(object sender, EventArgs e)
        {
            
            int DivisionWax = 0;
            try
            {
                DivisionWax = TextEditingThing.GetLineFromCharIndex(TextEditingThing.SelectionStart) + 1 / TextEditingThing.Lines.Length;
            }
            catch (DivideByZeroException) { DivisionWax = 1; }

            LineInfoLabel.Text = Lang.GetLangData("TextEditMain_LineNumber") + DivisionWax;
            
            int index = TextEditingThing.SelectionStart;
            int line = TextEditingThing.GetLineFromCharIndex(index);

            // Get the column.
            int firstChar = TextEditingThing.GetFirstCharIndexFromLine(line);
            int column = index - firstChar;

            ColumnInfoLabel.Text = Lang.GetLangData("TextEditMain_ColumnSelected") + column;


        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextEditingThing.SelectionLength = 0;
            TextEditingThing.SelectedText = Clipboard.GetText();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(TextEditingThing.SelectedText);
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(TextEditingThing.SelectedText);
            TextEditingThing.SelectedText = "";

        }

    }

    public class ExtendedRichTextBox : RichTextBox
    {
        public ExtendedRichTextBox()
        {
            this.AllowDrop = false;

        }

    }


}
