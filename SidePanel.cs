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
    public partial class SidePanel : UserControl
    {
        Form1 RootControl;
        Panel RootPanel;
        int HideToggle = 0;
        int DefaultWidth;
        int HideAnimationMode = 0;
        int AnimationMultiplier = 0;
        int AnimationMultiplierValue = 15;

        public SidePanel(Form1 pRootControl, Panel pRootPanel)
        {
            InitializeComponent();
            RootControl = pRootControl;
            RootPanel = pRootPanel;

        }

        private void SidePanel_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
            DefaultWidth = RootPanel.Width;
            HideShowButton.PerformClick();
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
                    HideShowButton.Text = ">";
                    HideToggle = -1;
                    HideShowAnimation.Enabled = true;
                    label1.Text = "";
                    break;

                case 0:
                    HideShowButton.Text = "<";
                    HideShowAnimation.Enabled = true;
                    label1.Text = "TabNotepad";
                    QuickSettings.Visible = false;
                    break;

            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Hide Animation
            if (HideAnimationMode == 0)
            {
                AnimationMultiplier += AnimationMultiplierValue;
                RootPanel.Width -= AnimationMultiplier;

                if (RootPanel.Width <= HideShowButton.Width + 4)
                {
                    HideAnimationMode = 1;
                    HideShowAnimation.Enabled = false;
                    //AnimationMultiplier = 0;
                    QuickSettings.Visible = true;


                }
                RootPanel.Width = HideShowButton.Width + 4;

            }
            else
            {
                AnimationMultiplier += AnimationMultiplierValue;

                if (RootPanel.Width >= DefaultWidth)
                {
                    HideAnimationMode = 0;
                    RootPanel.Width = DefaultWidth;
                    HideShowAnimation.Enabled = false;
                    AnimationMultiplier = 0;

                }
                RootPanel.Width += AnimationMultiplier;

            }


        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            About abt = new About();
            abt.ShowDialog();

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
                if (MessageBox.Show("Are you sure you want to open multiple files?", "Drag-Drop File Opening", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
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

        private void NewFileMiniButton_MouseDown(object sender, MouseEventArgs e)
        {
            NewFileMiniButton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;

        }


        private void NewFileMiniButton_MouseUp(object sender, MouseEventArgs e)
        {
            NewFileMiniButton.BorderStyle = System.Windows.Forms.BorderStyle.None;

        }

        private void OpenFileMiniButton_MouseDown(object sender, MouseEventArgs e)
        {
            OpenFileMiniButton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;

        }

        private void OpenFileMiniButton_MouseUp(object sender, MouseEventArgs e)
        {
            OpenFileMiniButton.BorderStyle = System.Windows.Forms.BorderStyle.None;

        }

        private void SettingsMiniButton_Click(object sender, EventArgs e)
        {
            SettingsButton.PerformClick();
        }

        private void OpenFileMiniButton_Click(object sender, EventArgs e)
        {
            OpenFileButton.PerformClick();

        }

        private void NewFileMiniButton_Click(object sender, EventArgs e)
        {
            NewTabButton.PerformClick();
        }

        private void SettingsMiniButton_MouseUp(object sender, MouseEventArgs e)
        {
            SettingsMiniButton.BorderStyle = System.Windows.Forms.BorderStyle.None;

        }

        private void SettingsMiniButton_MouseDown(object sender, MouseEventArgs e)
        {
            SettingsMiniButton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;

        }

        private void CloseMiniButton_Click(object sender, EventArgs e)
        {
            RootControl.CloseSelectedTab();
        }

        private void CloseMiniButton_MouseUp(object sender, MouseEventArgs e)
        {
            CloseMiniButton.BorderStyle = System.Windows.Forms.BorderStyle.None;

        }

        private void CloseMiniButton_MouseDown(object sender, MouseEventArgs e)
        {
            CloseMiniButton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;

        }
    }
}
