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

namespace TNotepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        public void CreateHometab()
        {
            // Create Tab object
            TabPage newTab = new TabPage();
            newTab.Controls.Add(new HomescreenTab(this));
            newTab.ContextMenuStrip = ContextMenu;
            newTab.Text = "TNotepad";
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
            newTab.ContextMenuStrip = ContextMenu;
            Tabs.TabPages.Add(newTab);

            // Set selected tab to the newly created one
            Tabs.SelectedIndex = Tabs.TabPages.IndexOf(newTab);
            Refresh();

        }

        public void CreateSettingsTab()
        {
            // Create Tab object
            TabPage newTab = new TabPage();
            newTab.Text = "Settings";
            newTab.Controls.Add(new SettingsTab(this, newTab));
            newTab.ContextMenuStrip = ContextMenu;
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
            newTab.ContextMenuStrip = ContextMenu;
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
            if (Properties.Settings.Default.ShowHometab)
            {
                CreateHometab();
            }
            else { CreateNewTab(); }
            AttachSidePanel();

        }

        public void CloseSelectedTab()
        {
            // Dispose current tab
            Tabs.SelectedTab.Dispose();

            // Create new tab if there is no one left
            if (Tabs.TabPages.Count == 0) { CreateHometab(); }

            // Select the Last Tab
            Tabs.SelectedTab = Tabs.TabPages[Tabs.TabPages.Count - 1];

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseSelectedTab();

        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            Console.WriteLine(e.Data);
        }

    }
}
