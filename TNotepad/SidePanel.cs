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
using TaiyouUI;

namespace TNotepad
{
    public partial class SidePanel : taiyouUserControl
    {
        MainForm RootControl;
        Panel RootPanel;
        int HideToggle = 0;
        int DefaultWidth;
        
        public SidePanel(MainForm pRootControl, Panel pRootPanel)
        {
            InitializeComponent();
            RootControl = pRootControl;
            RootPanel = pRootPanel;

            Dock = DockStyle.Fill;
            DefaultWidth = RootPanel.Width;
            HideShowButton.PerformClick();

            LoadLangs();

        }

        public void LoadLangs()
        {
            // Buttons
            NewTabButton.Text = Lang.GetLangData("SidePanel_NewFileButton");
            OpenFileButton.Text = Lang.GetLangData("SidePanel_OpenFileButton");
            SettingsButton.Text = Lang.GetLangData("SidePanel_SettingsButton");
            AboutButton.Text = Lang.GetLangData("SidePanel_AboutButton");

        }
        private void SidePanel_Load(object sender, EventArgs e)
        {
            PluginManager.LoadPlugins(null);

        }

        private void NewTabButton_Click(object sender, EventArgs e)
        {
            RootControl.CreateNewTab();

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string FileName = openFileDialog1.FileName;

            RootControl.CreateNewTabWithOpenDocument(FileName);

        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void HideShowButton_Click(object sender, EventArgs e)
        {
            HideToggle += 1;

            switch (HideToggle)
            {
                case 1:
                    // Suspend layout to erradicate slowdown
                    RootPanel.Parent.SuspendLayout();

                    ProgramNameLabel.Text = "";
                    HideShowButton.Text = ">";
                    HideToggle = -1;
                    QuickSettings.Visible = true;
                    ProgramNameLabel.Visible = false;
                    RootPanel.Width = HideShowButton.Width + 4;

                    // Resume layout
                    RootPanel.Parent.ResumeLayout();
                    break;

                case 0: 
                    // Suspend layout to erradicate slowdown
                    RootPanel.Parent.SuspendLayout();
                     
                    ProgramNameLabel.Text = "TabNotepad";
                    HideShowButton.Text = "<";
                    ProgramNameLabel.Visible = true;
                    QuickSettings.Visible = false;
                    RootPanel.Width = DefaultWidth;
                    
                    // Resume layout
                    RootPanel.Parent.ResumeLayout();
                    break;

            }


        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            Utils.CreateWindow(new About(), ShowAsDialog: true);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RootControl.CreateSettingsTab();
        }

        private void SidePanel_DragOver(object sender, DragEventArgs e)
        {

        }

        private void SidePanel_DragDrop(object sender, DragEventArgs e)
        {
            string[] FilesDropped = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            if (FilesDropped.Count<string>() > 1)
            {
                if (MessageBox.Show(Lang.GetLangData("DragDrop_OpenMultipleFiles_Text"), Lang.GetLangData("DragDrop_OpenMultipleFiles_Title"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
            }

            foreach (var File in FilesDropped)
            {
                RootControl.CreateNewTabWithOpenDocument(File);
            }

        }

        private void SidePanel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }


    }
}
