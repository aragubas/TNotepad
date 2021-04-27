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
    public partial class TabSwitcher : taiyouUserControl
    {
        Size OriginalSize;
        ApplicationTabs RootTabControl;

        public TabSwitcher(ApplicationTabs pRootTabControl)
        {
            InitializeComponent();

            OriginalSize = Size;
            RootTabControl = pRootTabControl;
        }

        private void TabSwitcher_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
            
            // Set Form Properties
            RootForm.Borderless = true;
            RootForm.ResizeableForm = true;
            RootForm.MinimumSize = OriginalSize;
            RootForm.Size = OriginalSize;

            // Make the window moveable
            WindowTitle.RootControlReference = RootForm;
            WindowTitle.FormHandle = RootForm.Handle;

            // Load the tab list
            LoadTabList();

            // Focus the tab list button
            TabList.Focus();

            // Load Language
            LoadLang();

        }

        private void LoadLang()
        {
            HowToSwitchInfoLabel.Text = Lang.GetLangData("TabSwitcher_SwitchLabelInfos");
            WindowTitle.Text = Lang.GetLangData("TabSwitcher_Title");
            RootForm.Text = Lang.GetLangData("TabSwitcher_Title");
            CloseTabButton.Text = Lang.GetLangData("TabSwitcher_CloseButton");

        }

        private void LoadTabList()
        {
            foreach(TabPage tab in RootTabControl.TabPages)
            {
                if (tab.Tag.Equals("NEWTAB")) { continue; }
                TabList.Items.Add(tab.Text);

            }

        }

        private void CloseTabButton_Click(object sender, EventArgs e)
        {
            RootForm.Close();
        }

        // not working for some reason
        private void TabSwitcher_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                RootForm.Close();

            }

        }

        private void SwitchTab()
        {
            RootTabControl.SelectedIndex = TabList.SelectedIndex;
            CloseTabButton.PerformClick();

        }

        private void TabList_KeyUp(object sender, KeyEventArgs e)
        {
            // Switch Tab Key
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space)
            {
                SwitchTab();

            }

            // Close Tab Key
            if (e.KeyCode == Keys.Escape)
            {
                CloseTabButton.PerformClick();
            }
        }

        private void WindowTitle_Click(object sender, EventArgs e)
        {

        }

        private void TabList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SwitchTab();
        }
    }
}
