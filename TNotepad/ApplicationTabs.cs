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

            this.MouseUp += ApplicationTabs_MouseUp;

        }

        void ApplicationTabs_MouseUp(object sender, MouseEventArgs e)
        {
            // Process MouseDown event only till (tabControl.TabPages.Count - 1) excluding the last TabPage
            for (var i = 0; i < TabPages.Count; i++)
            {
                var tabRect = GetTabRect(i);
                tabRect.Inflate(-2, -2);
                var imageRect = new Rectangle(tabRect.Right - 15, tabRect.Top + (tabRect.Height - 16) / 2, 10, 10);

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

                    }

                    break;
                }
            }

            if (TabPages.Count == 0)
            {
                CreateHometab();
            }


        }

        private const int TCM_ADJUSTRECT = 0x1328;

        public virtual void CreateHometab()
        {

        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            base.OnDrawItem(e);

            Font fntTab;
            Brush bshBack;
            Brush bshFore;

            // Set SmoothingMode
            if (Properties.Settings.Default.SmoothVisualElements)
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;

            }

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
            string tabName = TabPages[e.Index].Text;
            StringFormat sftTab = new StringFormat();
            Rectangle recTab = e.Bounds;
            recTab = new Rectangle(recTab.X, recTab.Y + 4, recTab.Width, recTab.Height - 4);

            e.Graphics.DrawString(tabName, fntTab, bshFore, recTab, sftTab);

            // Draw Red Close Circle
            var CloseButtonRect = new Rectangle(recTab.Right - 15, recTab.Top + (recTab.Height - 16) / 2, 10, 10);
            if (TabPages[e.Index].Tag != "PERSISTENT")
            {
                if (SelectedIndex == e.Index)
                {
                    e.Graphics.FillEllipse(Brushes.Red, new Rectangle(CloseButtonRect.X - 1, CloseButtonRect.Y - 1, CloseButtonRect.Width + 2, CloseButtonRect.Height + 2));
                }
                e.Graphics.DrawImage(Properties.Resources.TabClose, new Point(CloseButtonRect.X, CloseButtonRect.Y));

                // Add spacing to title text
                if (!TabPages[e.Index].Text.EndsWith("   "))
                {
                    TabPages[e.Index].Text += "   ";

                }

            }
            else
            {
                // Add spacing to title text
                if (!TabPages[e.Index].Text.EndsWith(" "))
                {
                    TabPages[e.Index].Text += " ";

                }

            }

            // Draw Background
            Rectangle r = GetTabRect(this.TabPages.Count - 1);

            RectangleF tf = new RectangleF(r.X + r.Width, r.Y - 5, this.Width - (r.X + r.Width) + 5, r.Height + 5);
            Brush b = new SolidBrush(Color.FromArgb(255, 32, 32, 32));

            e.Graphics.FillRectangle(b, tf);

        }

        protected override void WndProc(ref Message m)
        {
            // Hide undesirable borders
            if (m.Msg == TCM_ADJUSTRECT)
            {
                RECT rect = (RECT)(m.GetLParam(typeof(RECT)));
                rect.Left = this.Left - 4;
                rect.Right = this.Right + 4;

                rect.Top = this.Top - 6;
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
