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
            newTab.Tag = "TEXT_EDITOR";


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

            Text = "TNotepad v" + Utils.GetVersion();
            FormTitlebar.FormHandle = this.Handle;
            this.ResizeRedraw = true;

        }

        protected override void WndProc(ref Message m)
        {
            const int RESIZE_HANDLE_SIZE = 50;

            switch (m.Msg)
            {
                case 0x0084/*NCHITTEST*/ :
                    base.WndProc(ref m);

                    if ((int)m.Result == 0x01/*HTCLIENT*/)
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32());
                        Point clientPoint = this.PointToClient(screenPoint);
                        if (clientPoint.Y <= RESIZE_HANDLE_SIZE)
                        {
                            if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                                m.Result = (IntPtr)13/*HTTOPLEFT*/ ;
                            else if (clientPoint.X < (this.Size.Width - RESIZE_HANDLE_SIZE))
                                m.Result = (IntPtr)12/*HTTOP*/ ;
                            else
                                m.Result = (IntPtr)14/*HTTOPRIGHT*/ ;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - RESIZE_HANDLE_SIZE))
                        {
                            if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                                m.Result = (IntPtr)10/*HTLEFT*/ ;
                            else if (clientPoint.X < (this.Size.Width - RESIZE_HANDLE_SIZE))
                                m.Result = (IntPtr)2/*HTCAPTION*/ ;
                            else
                                m.Result = (IntPtr)11/*HTRIGHT*/ ;
                        }
                        else
                        {
                            if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                                m.Result = (IntPtr)16/*HTBOTTOMLEFT*/ ;
                            else if (clientPoint.X < (this.Size.Width - RESIZE_HANDLE_SIZE))
                                m.Result = (IntPtr)15/*HTBOTTOM*/ ;
                            else
                                m.Result = (IntPtr)17/*HTBOTTOMRIGHT*/ ;
                        }
                    }
                    return;
            }
            base.WndProc(ref m);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x20000; // <--- use 0x20000
                
                // Add shadow
                if (Properties.Settings.Default.WindowShadow)
                {
                    const int CS_DROPSHADOW = 0x20000;
                    cp.ClassStyle |= CS_DROPSHADOW;

                }

                // Should fix flickering when resizing, but it mess up with tab header rendering
                // Temporaly Disabled.
                //cp.ExStyle = cp.ExStyle | 0x2000000;


                return cp;
            }
        }

        public void CloseSelectedTab()
        {
            // Create new tab if there is no one left
            if (Tabs.SelectedTab.Tag != "PERSISTENT")
            {
                // Clear controls before closing tab
                foreach (Control wax in Tabs.TabPages[Tabs.SelectedIndex].Controls)
                {
                    wax.Dispose();
                }
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
                    // Don't close tabs with tag PERSISTENT
                    if (Tabs.TabPages[i].Tag != "PERSISTENT")
                    {
                        // Dispose all constrols present on that page
                        foreach (Control wax in Tabs.TabPages[i].Controls)
                        {
                            wax.Dispose();
                        }

                        // Remove page
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

        private void FormCloseButton_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.SaveChangesWhenExiting)
            {
                Properties.Settings.Default.Save();
            }

            System.Threading.Thread.CurrentThread.Abort();
            Environment.Exit(0);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                FormMaximizeButton.Text = "\\/";

                return;
            }
            this.WindowState = FormWindowState.Normal;
                FormMaximizeButton.Text = "/\\";

        }

    }
    

    class MoveWindowLabel : Label
    {
        public IntPtr FormHandle;

        protected override void OnMouseDown(MouseEventArgs e)
        {
        base.OnMouseDown(e);
        this.Capture = false;
        Message msg = Message.Create(FormHandle, 0XA1, new IntPtr(2), IntPtr.Zero);
        WndProc(ref msg);
        }

    }


}
