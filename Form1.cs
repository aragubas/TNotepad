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
using System.Drawing;
using System.Windows.Forms;

namespace TNotepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void CreateHometab()
        {
            // Create Tab object
            TabPage newTab = new TabPage();
            newTab.Controls.Add(new HomescreenTab(this));
            newTab.Text = "TNotepad";
            newTab.Padding = new Padding(0, 0, 0, 0);
            newTab.Tag = "PERSISTENT";

            Tabs.TabPages.Add(newTab);

            // Set selected tab to the newly created one
            Tabs.SelectedIndex = Tabs.TabPages.IndexOf(newTab);
            Refresh();


        }

        public void CreateNewTab()
        {
            // Create Tab object
            TabPage newTab = new TabPage();
            newTab.Controls.Add(new TextEditingTab(newTab, this));
            Tabs.TabPages.Add(newTab);

            // Set selected tab to the newly created one
            Tabs.SelectedIndex = Tabs.TabPages.IndexOf(newTab);
            Refresh();

        }

        public void CreateSettingsTab()
        {
            // Create Tab object
            TabPage newTab = new TabPage();
            newTab.Text = Lang.GetLangData("Generic_Settings");
            newTab.Controls.Add(new SettingsTab(this, newTab));
            newTab.Padding = new Padding(0, 0, 0, 0);

            Tabs.TabPages.Add(newTab);

            // Set selected tab to the newly created one
            Tabs.SelectedIndex = Tabs.TabPages.IndexOf(newTab);
            Refresh();

        }


        public void CreateNewTabWithOpenDocument(string FileName)
        {
            // Create Tab object
            TabPage newTab = new TabPage();
            TextEditingTab TextEdtTab = new TextEditingTab(newTab, this);
            
            // Open the File
            TextEdtTab.DontSetUntitled = true;
            TextEdtTab.OpenFile(FileName);

            // Add the control
            newTab.Controls.Add(TextEdtTab);
            newTab.Padding = new Padding(0, 0, 0, 0);

            Tabs.TabPages.Add(newTab);

            // Set selected tab to the newly created one
            Tabs.SelectedIndex = Tabs.TabPages.IndexOf(newTab);
            Refresh();

        }

        public void AttachSidePanel()
        {
            SidePanelView.Controls.Clear();

            SidePanel panelSide = new SidePanel(this, SidePanelView);

            SidePanelView.Controls.Add(panelSide);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Create Initial Tab
            CreateHometab();
            AttachSidePanel();

            Text = "TNotepad " + Utils.GetVersion();

        }

        public void CloseSelectedTab()
        {
            // Create new tab if there is no one left
            if (Tabs.SelectedTab.Tag != "PERSISTENT")
            {
                Tabs.TabPages.RemoveAt(Tabs.SelectedIndex);
            }

        }
       
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Properties.Settings.Default.SaveChangesWhenExiting)
            {
                Properties.Settings.Default.Save();
            }

            Environment.Exit(0);
        }

        private void Tabs_DrawItem(object sender, DrawItemEventArgs e)
        {
            //var tabPage = Tabs.TabPages[e.Index];
            var tabRect = Tabs.GetTabRect(e.Index);
            tabRect.Inflate(-2, -2);

            var closeImage = new Bitmap(Properties.Resources.CloseTabMini);
            e.Graphics.DrawImage(closeImage,
                (tabRect.Right - 8),
                tabRect.Top + (tabRect.Height - 8) / 2, 8, 8);

        }

        private void Tabs_MouseUp(object sender, MouseEventArgs e)
        {
            // Process MouseDown event only till (tabControl.TabPages.Count - 1) excluding the last TabPage
            for (var i = 0; i < Tabs.TabPages.Count; i++)
            {
                var tabRect = Tabs.GetTabRect(i);
                tabRect.Inflate(-2, -2);
                var imageRect = new Rectangle(tabRect.Right - 13, tabRect.Top + (tabRect.Height - 12) / 2, 10, 10);

                if (imageRect.IntersectsWith(new Rectangle(e.Location.X, e.Location.Y, 1, 1)))
                {
                    if (Tabs.TabPages[i].Tag != "PERSISTENT")
                    {
                        Tabs.TabPages.RemoveAt(i);
                    }

                    break;
                }
            }

            if (Tabs.TabPages.Count == 0)
            {
                CreateHometab();
            }

        }
    }


}
