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
using System.Reflection;
using System.Runtime.InteropServices;
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
            newTab.Padding = new Padding(0, 0, 0, 0);
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
            newTab.Text = Lang.GetLangData("Generic_Settings");
            newTab.Controls.Add(new SettingsTab(this, newTab));
            newTab.ContextMenuStrip = ContextMenu;
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
            newTab.ContextMenuStrip = ContextMenu;
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
            if (Properties.Settings.Default.ShowHometab)
            {
                CreateHometab();
            }
            else { CreateNewTab(); }
            AttachSidePanel();

            Text = "TNotepad " + Utils.GetVersion();
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
            /*
            SolidBrush fillBrush = new SolidBrush(Color.DimGray);



            //draw rectangle behind the tabs
            Rectangle lasttabrect = Tabs.GetTabRect(Tabs.TabPages.Count - 1);
            Rectangle background = new Rectangle();
            background.Location = new Point(lasttabrect.Right, 0);

            //pad the rectangle to cover the 1 pixel line between the top of the tabpage and the start of the tabs
            background.Size = new Size(Tabs.Right - background.Left, lasttabrect.Height + 3);
            e.Graphics.FillRectangle(fillBrush, background);
            */

            var tabPage = Tabs.TabPages[e.Index];
            var tabRect = Tabs.GetTabRect(e.Index);
            tabRect.Inflate(-2, -2);
            
            // Draw tab title
            //e.Graphics.DrawString(tabPage.Text, SystemFonts.DefaultFont, Brushes.Red, new Point(tabRect.X, tabRect.Y));

            var closeImage = new Bitmap(Properties.Resources.CloseTabMini);
            e.Graphics.DrawImage(closeImage,
                (tabRect.Right - 8),
                tabRect.Top + (tabRect.Height - 8) / 2, 8, 8);

            //TextRenderer.DrawText(e.Graphics, tabPage.Text, tabPage.Font,
            //    tabRect, Color.DarkBlue, TextFormatFlags.Left);

        }

        private void Tabs_MouseDown(object sender, MouseEventArgs e)
        {
            // Process MouseDown event only till (tabControl.TabPages.Count - 1) excluding the last TabPage
            for (var i = 0; i < Tabs.TabPages.Count; i++)
            {
                var tabRect = Tabs.GetTabRect(i);
                tabRect.Inflate(-2, -2);
                var imageRect = new Rectangle(tabRect.Right - 8, tabRect.Top + (tabRect.Height - 8) / 2, 8, 16);

                if (imageRect.IntersectsWith(new Rectangle(e.Location.X, e.Location.Y, 1, 1)))
                {
                    Tabs.TabPages.RemoveAt(i);
                    break;
                }
            }
        }
    }

    public partial class ApplicationTabs : TabControl
    {
        public ApplicationTabs()
        {
            //if (!DesignMode) Multiline = true;
            this.DrawMode = TabDrawMode.OwnerDrawFixed;
            this.Appearance = TabAppearance.Normal;

        }

        private const int TCM_ADJUSTRECT = 0x1328;

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {

            base.OnPaintBackground(pevent);
            pevent.Graphics.FillRectangle(Brushes.Red, new Rectangle(0, 0, Width, Height));


        }

        
        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            //base.OnDrawItem(e);
    
            Font fntTab;
            Brush bshBack;
            Brush bshFore;

            if (e.Index == this.SelectedIndex) // Selected Tab
            {
                fntTab = new Font(e.Font, FontStyle.Underline);
                bshFore = Brushes.White;
                bshBack = new SolidBrush(Color.FromArgb(255, 64, 64, 64));

            }
            else // Unselected Tab
            {
                fntTab = e.Font;
                bshBack = new SolidBrush(Color.FromArgb(255, 32, 32, 32));
                bshFore = new SolidBrush(Color.White);

            }

            // Draw Title Background
            e.Graphics.FillRectangle(bshBack, e.Bounds);


            // Draw Tab Title
            string tabName = this.TabPages[e.Index].Text;
            StringFormat sftTab = new StringFormat();
            Rectangle recTab = e.Bounds;
            recTab = new Rectangle(recTab.X, recTab.Y + 4, recTab.Width, recTab.Height - 4);
            
            e.Graphics.DrawString(tabName, fntTab, bshFore, recTab, sftTab);


            // Draw Background
            Rectangle r = this.GetTabRect(this.TabPages.Count - 1);

            RectangleF tf = new RectangleF(r.X + r.Width, r.Y - 5, this.Width - (r.X + r.Width) + 5, r.Height + 5);
            Brush b = new SolidBrush(Color.FromArgb(255, 32, 32, 32));

            e.Graphics.FillRectangle(b, tf);

        }

        protected override void WndProc(ref Message m)
        {
            // Hide all borders
            if (m.Msg == TCM_ADJUSTRECT)
            {
                RECT rect = (RECT)(m.GetLParam(typeof(RECT)));
                rect.Left = this.Left - 4;
                rect.Right = this.Right + 4;

                rect.Top = this.Top - 1;
                rect.Bottom = this.Bottom + 4;

                Marshal.StructureToPtr(rect, m.LParam, true);
                //m.Result = (IntPtr)1;
                //return;
            }
            //else
            // call the base class implementation
            base.WndProc(ref m);
        }

        private struct RECT
        {
            public int Left, Top, Right, Bottom;
        }
    }

}
