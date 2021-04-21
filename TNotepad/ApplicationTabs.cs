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
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TNotepad
{
    
    
    public partial class ApplicationTabs : TabControl
    {
        int LastSelectedTab = -1;
        private const int WM_PAINT = 0xF;
        public delegate void dCreateNewTabEvent();
        public delegate void dCreateDefaultTabEvent();
        public event dCreateNewTabEvent CreateNewTabEvent;
        public event dCreateDefaultTabEvent CreateDefaultTabEvent;
        private TabPage NewTabButton;
        private int LastSelectedWax = 0;

        public ApplicationTabs()
        {
            this.DrawMode = TabDrawMode.OwnerDrawFixed;

            // Make the tab buttons work
            this.MouseUp += ApplicationTabs_MouseUp;

            if (Properties.Settings.Default.ForceDoubleBuffer)
            {

                this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
                this.UpdateStyles();

            }

            this.ControlAdded += ApplicationTabs_ControlAdded;
            CreateNewTabButton();

        }

        public void CreateNewTabButton()
        {
            // Create Tab object
            TabPage newTab = new TabPage();
            newTab.Tag = "NEWTAB";
            newTab.Text += "+";

            NewTabButton = newTab;
            TabPages.Add(newTab);

        }


        void ApplicationTabs_ControlAdded(object sender, ControlEventArgs e)
        {
            int Index = TabPages.IndexOf(NewTabButton);

            if (Index != TabPages.Count - 1)
            {
                TabPages.Remove(NewTabButton);
                TabPages.Add(NewTabButton);
            }

        }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            // Fill background with FormBackgroundColor key
            Brush b = new SolidBrush(ThemeLoader.GetThemeData("Form_BackgroundColor"));
            pevent.Graphics.FillRectangle(b, pevent.ClipRectangle);

        }        

        private void DrawTabHeader(Graphics e)
        {
            Rectangle tf = this.ClientRectangle;

            // Make the NEWTAB Button Tab Unselectable
            try
            {
                if (SelectedTab.Tag.ToString() == "NEWTAB")
                {
                    SelectedIndex = LastSelectedWax;
                }
                else
                {
                    LastSelectedWax = SelectedIndex;
                }

            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Got NullReferenceError when checking if current tab is NEWTAB.");

            }

            // Render All Pages
            for (var i = 0; i < TabPages.Count; i++)
            {   
                // Set some variables
                Font fntTab = Font;
                Brush bshBack;
                Brush bshFore;
                Rectangle TabRect = GetTabRect(i);
                string TabTitle = TabPages[i].Text;

                string TabType = TabPages[i].Tag.ToString();

                // Set SmoothingMode
                if (Properties.Settings.Default.SmoothVisualElements)
                {
                    e.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    e.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;

                }

                // ################
                // Set Colors
                // ################
                // Selected Tab
                if (i == this.SelectedIndex)
                {
                    bshFore = new SolidBrush(ThemeLoader.GetThemeData("TabControl_HeaderSelected_ForegroundColor"));
                    bshBack = new SolidBrush(ThemeLoader.GetThemeData("TabControl_HeaderSelected_BackgroundColor"));

                    if (TabPages[i].Tag.ToString().Split(';')[0] == "PERSISTENT")
                    {
                        bshFore = new SolidBrush(ThemeLoader.GetThemeData("TabControl_PersistentHeaderSelected_ForegroundColor"));
                        bshBack = new SolidBrush(ThemeLoader.GetThemeData("TabControl_PersistentHeaderSelected_BackgroundColor"));

                    }

                    // Make the selected tab a bit higher
                    TabRect = new Rectangle(TabRect.X, TabRect.Y - 1, TabRect.Width, TabRect.Height + 1);

                }
                else // Unselected Tab
                {
                    bshFore = new SolidBrush(ThemeLoader.GetThemeData("TabControl_HeaderUnselected_ForegroundColor"));
                    bshBack = new SolidBrush(ThemeLoader.GetThemeData("TabControl_HeaderUnselected_BackgroundColor"));

                    if (TabPages[i].Tag.ToString().Split(';')[0] == "PERSISTENT")
                    {
                        bshFore = new SolidBrush(ThemeLoader.GetThemeData("TabControl_PersistentHeaderUnselected_ForegroundColor"));
                        bshBack = new SolidBrush(ThemeLoader.GetThemeData("TabControl_PersistentHeaderUnselected_BackgroundColor"));

                    }

                }

                StringFormat sftTab = new StringFormat();

                // ################
                // Render NewTab Button
                // ################
                if (TabType == "NEWTAB")
                {
                    TabRect = new Rectangle(TabRect.X + 5, TabRect.Y + 3, 20, TabRect.Height - 5);
                    Rectangle PosRect = new Rectangle(TabRect.X, TabRect.Y, 16, 16);
                    sftTab.Alignment = StringAlignment.Center;
                    

                    e.FillRectangle(bshBack, TabRect);
                    e.DrawImage(Properties.Resources.TabNew, new Point(PosRect.X + 5, PosRect.Y + 3));

                    continue;
                }

                // ################
                // Draw Tab Background
                // ################
                e.FillRectangle(bshBack, TabRect);

                // ################
                // Draw Tab Title
                // ################
                Rectangle recTab = TabRect;
                recTab = new Rectangle(recTab.X, recTab.Y, recTab.Width, recTab.Height);

                e.DrawString(TabTitle, fntTab, bshFore, new Rectangle(recTab.X + 1, recTab.Y + 4, recTab.Width, recTab.Height), sftTab);

                // ################
                // Draw Tab Close Button
                // ################
                var CloseButtonRect = new Rectangle(recTab.Right - 15, recTab.Top + (recTab.Height - 8) / 2, 10, 10);
                // If current tab is not a persistent one
                if (TabType != "PERSISTENT")
                {
                    // If current tab is the selected one, draw a red circle
                    if (SelectedIndex == i)
                    {
                        e.FillEllipse(Brushes.Red, new Rectangle(CloseButtonRect.X - 1, CloseButtonRect.Y - 1, CloseButtonRect.Width + 2, CloseButtonRect.Height + 2));
                    }
                    e.DrawImage(Properties.Resources.TabClose, new Point(CloseButtonRect.X, CloseButtonRect.Y));

                    // Add spacing to title text
                    if (!TabPages[i].Text.EndsWith("  "))
                    {
                        TabPages[i].Text += " ";

                    }

                }

                // #########################
                // Draw Tab Separation Line
                // #########################
                // Left Line
                e.FillRectangle(new SolidBrush(ThemeLoader.GetThemeData("TabControl_SeparatorLineColor")), new Rectangle(TabRect.X - 1, TabRect.Y, 1, TabRect.Height));

                // Right Line
                if (i == TabPages.Count - 1)
                {
                    e.FillRectangle(new SolidBrush(ThemeLoader.GetThemeData("TabControl_SeparatorLineColor")), new Rectangle(TabRect.X + TabRect.Width, TabRect.Y, 1, TabRect.Height));

                }
            }

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            DrawTabHeader(e.Graphics);

        }

        public void ClosePageAt(int i)
        {
            // Dispose all constrols present on that page before closing it 
            foreach (Control wax in TabPages[i].Controls)
            {
                wax.Dispose();
            }
            TabPages.RemoveAt(i);
            Refresh();

        }

        void ApplicationTabs_MouseUp(object sender, MouseEventArgs e)
        {
            this.Capture = true;

            for (var i = 0; i < TabPages.Count; i++)
            {
                var tabRect = GetTabRect(i);
                tabRect.Inflate(-2, -2);
                var imageRect = new Rectangle(tabRect.Right - 15, tabRect.Top + (tabRect.Height - 8) / 2, 10, 10);

                if (imageRect.IntersectsWith(new Rectangle(e.Location.X, e.Location.Y, 1, 1)))
                {
                    // Don't close tabs with tag PERSISTENT
                    if (TabPages[i].Tag.ToString() != "PERSISTENT" && TabPages[i].Tag.ToString() != "NEWTAB")
                    {
                        // Close tab 
                        ClosePageAt(i);

                        // Call Create Default Tab if tab has been closed
                        if (TabPages.Count == 0)
                        {
                            if (CreateNewTabEvent != null)
                            {
                                CreateDefaultTabEvent.Invoke();
                            }

                        }

                        
                    }

                    return;
                }
            }

            // Add Tab Button
            if (TabPages.Count > 1)
            {
                Rectangle LastPageRect = GetTabRect(TabPages.Count - 1);
                Rectangle PosRect = new Rectangle(LastPageRect.X + 5, LastPageRect.Y, 16, 16);

                if (PosRect.IntersectsWith(new Rectangle(e.Location.X, e.Location.Y, 1, 1)))
                {
                    SelectedIndex = 0;
                    if (CreateNewTabEvent != null)
                    {
                        CreateNewTabEvent.Invoke();
                        
                    }
                }

            }

        }

        private const int TCM_ADJUSTRECT = 0x1328;

        protected override void WndProc(ref Message m)
        { 
            // Hide undesirable borders
            if (m.Msg == TCM_ADJUSTRECT)
            {
                RECT rect = (RECT)(m.GetLParam(typeof(RECT)));
                rect.Left = this.Left - 4;
                rect.Right = this.Right + 4;

                rect.Top = this.Top;
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
