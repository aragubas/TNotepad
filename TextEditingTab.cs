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
        Form1 RootControl;
        DateTime dateTime;
        int LastUnsavedTime = 0;
        public string LastFileName = "";
        public bool DontSetUntitled = false;
        System.Text.Encoding CurrentEncoding;

        public TextEditingTab(TabPage pAssociatedTabPage, Form1 pRootControl)
        {
            InitializeComponent();
            AssociatedTabPage = pAssociatedTabPage;
            RootControl = pRootControl;
        }

        private void TextEditingTab_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
            if (!DontSetUntitled) { UpdateTitle(Lang.GetLangData("TextEditMain_UntitledTab")); }

            LastSavedTimer.Enabled = Properties.Settings.Default.UnsavedTime;
            LastSavedTimer.Interval = Properties.Settings.Default.UnsavedTimeInterval;
            
            TextEditingThing.WordWrap = Properties.Settings.Default.WordWrapEnabled;
            LoadLangStrings();

            // Set Default Encoding
            SetEncoding(Utils.EncodingNameToEncodingObject());


            TextEditingThing.SelectionIndent = TextEditingThing.GetThingWidth();

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
        }

        private void quickFindToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindExtraFuncPanel();
        }

        private void Updater_Tick(object sender, EventArgs e)
        {
            LineInfoLabel.Text = $"{Lang.GetLangData("TextEditMain_LineNumber")} { TextEditingThing.GetLineFromCharIndex(TextEditingThing.SelectionStart) + 1 }/{TextEditingThing.Lines.Length}";
            
            int index = TextEditingThing.SelectionStart;
            int line = TextEditingThing.GetLineFromCharIndex(index);

            // Get the column.
            int firstChar = TextEditingThing.GetFirstCharIndexFromLine(line);
            int column = index - firstChar;

            ColumnInfoLabel.Text = $"{Lang.GetLangData("TextEditMain_ColumnSelected")} {column}";

            // TextEditingThing.SelectionIndent = TextEditingThing.GetThingWidth();



        }

    }

    public class ExtendedRichTextBox : RichTextBox
    {

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(
              IntPtr hWnd,      // handle to destination window
              uint Msg,       // message
              IntPtr wParam,  // first message parameter
              IntPtr lParam   // second message parameter
        );

        const uint WM_MOUSEWHEEL = 0x20A;
        const uint WM_VSCROLL = 0x115;
        const uint SB_LINEUP = 0;
        const uint SB_LINEDOWN = 1;
        const uint SB_THUMBTRACK = 5;
        const uint WM_PAINT = 15;
         
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            Invalidate();
            SelectionIndent = GetThingWidth();

        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            Invalidate();
            SelectionIndent = GetThingWidth();

        }


        public void DrawLineNumbers(Graphics g)
        {
            // create & set Point pt to (0,0)    
            Point pt = new Point(0, 0);
            // get First Index & First Line from richTextBox1    
            int First_Index = GetCharIndexFromPosition(pt);
            int First_Line = GetLineFromCharIndex(First_Index);
            // set X & Y coordinates of Point pt to ClientRectangle Width & Height respectively    
            pt.Y = ClientRectangle.Width;
            pt.X = ClientRectangle.Height;
            // get Last Index & Last Line from richTextBox1    
            int Last_Index = GetCharIndexFromPosition(pt);
            int Last_Line = GetLineFromCharIndex(Last_Index);

            // Currently selected line number
            Point curPoint = GetPositionFromCharIndex(SelectionStart);
            curPoint.Offset(Left, Top - Font.Height * 2);

            int CurrentLineNumber = GetLineFromCharIndex(SelectionStart);

            // Draw current line
            g.DrawString("" + (CurrentLineNumber + 1), Font, Brushes.DarkRed, new Point(0, curPoint.Y + 5));


        }

        public int GetThingWidth()
        {
            int w = 25;
            // get total lines of richTextBox1    
            int line = Lines.Length;

            if (line <= 99)
            {
                w = 20 + (int)Font.Size;
            }
            else if (line <= 999)
            {
                w = 25 + (int)Font.Size;
            }
            else
            {
                w = 45 + (int)Font.Size;
            }

            return w;
        }

        protected override void WndProc(ref Message m)
        {
            switch ((uint)m.Msg)
            {
                case WM_PAINT:
                    Invalidate();
                    base.WndProc(ref m);
                    using (Graphics g = Graphics.FromHwnd(this.Handle))
                    {
                        DrawLineNumbers(g);
                    }
                    break;

                    default:
                    base.WndProc(ref m);
                    break;
            }
        }
    }


}
