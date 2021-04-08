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

        public ApplicationTabs()
        {
            this.DrawMode = TabDrawMode.OwnerDrawFixed;

            // Make the tab buttons work
            this.MouseUp += ApplicationTabs_MouseUp;

            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint | ControlStyles.DoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();

            this.ControlAdded += ApplicationTabs_ControlAdded;
            this.ControlRemoved += ApplicationTabs_ControlRemoved;


        }

        void ApplicationTabs_ControlRemoved(object sender, ControlEventArgs e)
        {
            Graphics ceira = this.CreateGraphics();
            ceira.FillRectangle(new SolidBrush(ThemeLoader.GetThemeData("Form_BackgroundColor")), this.ClientRectangle);
            DrawTabHeader(ceira);

        }  

        void ApplicationTabs_ControlAdded(object sender, ControlEventArgs e)
        {
            Graphics ceira = this.CreateGraphics();
            ceira.FillRectangle(new SolidBrush(ThemeLoader.GetThemeData("Form_BackgroundColor")), this.ClientRectangle);
            DrawTabHeader(ceira);

        }

        protected override void NotifyInvalidate(Rectangle invalidatedArea)
        {
            Graphics ceira = this.CreateGraphics();
            DrawTabHeader(ceira);

        }


        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            //base.OnPaintBackground(pevent);

            Brush b = new SolidBrush(ThemeLoader.GetThemeData("Form_BackgroundColor"));
            pevent.Graphics.FillRectangle(b, this.ClientRectangle);

            DrawTabHeader(pevent.Graphics);
        }

        private void DrawTabHeader(Graphics e)
        {
            Rectangle tf = this.ClientRectangle;

            for (var i = 0; i < TabPages.Count; i++)
            {
                // Set some variables
                Font fntTab = Font;
                Brush bshBack;
                Brush bshFore;
                Rectangle TabRect = GetTabRect(i);

                // Set SmoothingMode
                if (Properties.Settings.Default.SmoothVisualElements)
                {
                    e.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    e.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;

                }

                // ################
                // Draw Background
                // ################
                // Selected Tab
                if (i == this.SelectedIndex)
                {
                    bshFore = new SolidBrush(ThemeLoader.GetThemeData("TabControl_HeaderSelected_ForegroundColor"));
                    bshBack = new SolidBrush(ThemeLoader.GetThemeData("TabControl_HeaderSelected_BackgroundColor"));

                    if (TabPages[i].Tag == "PERSISTENT")
                    {
                        bshFore = new SolidBrush(ThemeLoader.GetThemeData("TabControl_PersistentHeaderSelected_ForegroundColor"));
                        bshBack = new SolidBrush(ThemeLoader.GetThemeData("TabControl_PersistentHeaderSelected_BackgroundColor"));

                    }

                }
                else // Unselected Tab
                {
                    bshFore = new SolidBrush(ThemeLoader.GetThemeData("TabControl_HeaderUnselected_ForegroundColor"));
                    bshBack = new SolidBrush(ThemeLoader.GetThemeData("TabControl_HeaderUnselected_BackgroundColor"));

                    if (TabPages[i].Tag == "PERSISTENT")
                    {
                        bshFore = new SolidBrush(ThemeLoader.GetThemeData("TabControl_PersistentHeaderUnselected_ForegroundColor"));
                        bshBack = new SolidBrush(ThemeLoader.GetThemeData("TabControl_PersistentHeaderUnselected_BackgroundColor"));

                    }

                }


                // Draw Background
                e.FillRectangle(bshBack, TabRect);

                // Draw Tab Title
                string tabName = TabPages[i].Text;
                StringFormat sftTab = new StringFormat();
                Rectangle recTab = TabRect;
                recTab = new Rectangle(recTab.X, recTab.Y, recTab.Width, recTab.Height);

                e.DrawString(tabName, fntTab, bshFore, new Rectangle(recTab.X + 1, recTab.Y + 4, recTab.Width, recTab.Height), sftTab);

                // Draw Red Close Circle
                var CloseButtonRect = new Rectangle(recTab.Right - 15, recTab.Top + (recTab.Height - 8) / 2, 10, 10);
                // If current tab is not a persistent one
                if (TabPages[i].Tag != "PERSISTENT")
                {
                    // If current tab is the selected one
                    if (SelectedIndex == i)
                    {
                        e.FillEllipse(Brushes.Red, new Rectangle(CloseButtonRect.X - 1, CloseButtonRect.Y - 1, CloseButtonRect.Width + 2, CloseButtonRect.Height + 2));
                    }
                    e.DrawImage(Properties.Resources.TabClose, new Point(CloseButtonRect.X, CloseButtonRect.Y));

                    // Add spacing to title text
                    if (!TabPages[i].Text.EndsWith(" "))
                    {
                        TabPages[i].Text += " ";

                    }

                }
                else
                {
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

        void ApplicationTabs_MouseUp(object sender, MouseEventArgs e)
        {
            // Process MouseDown event only till (tabControl.TabPages.Count - 1) excluding the last TabPage
            for (var i = 0; i < TabPages.Count; i++)
            {
                var tabRect = GetTabRect(i);
                tabRect.Inflate(-2, -2);
                var imageRect = new Rectangle(tabRect.Right - 15, tabRect.Top + (tabRect.Height - 8) / 2, 10, 10);

                if (imageRect.IntersectsWith(new Rectangle(e.Location.X, e.Location.Y, 1, 1)))
                {
                    // Don't close tabs with tag PERSISTENT
                    if (TabPages[i].Tag != "PERSISTENT")
                    {
                        // Dispose all constrols present on that page
                        foreach (Control wax in TabPages[i].Controls)
                        {
                            wax.Dispose();
                        }

                        // Remove page
                        TabPages.RemoveAt(i);
                        //TabPages[i].CloseTab();

                    }

                    break;
                }
            }

            if (TabPages.Count == 0)
            {
                CreateDefaultTab();
            }


        }

        private const int TCM_ADJUSTRECT = 0x1328;

        public virtual void CreateDefaultTab()
        {

        }

        protected override void WndProc(ref Message m)
        {
            // Hide undesirable borders
            if (m.Msg == TCM_ADJUSTRECT)
            {
                RECT rect = (RECT)(m.GetLParam(typeof(RECT)));
                rect.Left = this.Left - 4;
                rect.Right = this.Right + 4;

                rect.Top = this.Top - 2;
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
