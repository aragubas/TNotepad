﻿using System;
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
    public partial class TabNotepadForm : Form
    {
        public bool ResizeableForm = true;
        public bool MinimizeableForm = true;
        public bool CloseableForm = true;

        public TabNotepadForm()
        {
            InitializeComponent();
            this.ResizeRedraw = true;

            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.CacheText | ControlStyles.UserPaint | ControlStyles.DoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();

            LoadTheme();

            

        }


        public void LoadTheme()
        {
            BackColor = ThemeLoader.GetThemeData("Form_BackgroundColor");
            ForeColor = ThemeLoader.GetThemeData("Form_ForegroundColor");

        }

        public bool ResizeMode = false;
        public bool DisableResizeMode = false;
        bool ScreenWaxTaken = false;
        Bitmap Wax;


        private void TabNotepadForm_Load(object sender, EventArgs e)
        {
            // Set FormTitlebar Wax
            FormTitlebar.FormHandle = this.Handle;
            FormTitlebar.RootControlReference = this;
            

            this.Shown += TabNotepadForm_Shown;

        }

        private bool FocusAfterMinimizing = false;

        void TabNotepadForm_Shown(object sender, EventArgs e)
        {
            if (!ResizeableForm)
            {
                FormMaximizeButton.Visible = false;
            }

            if (!MinimizeableForm)
            {
                FormMinimizeButton.Visible = false;
            }
            if (!CloseableForm)
            {
                FormCloseButton.Visible = false;
            }


        }

        // Make the form resizeable
        protected override void WndProc(ref Message m)
        {
            const int RESIZE_HANDLE_SIZE = 50;

            switch (m.Msg)
            {
                case 0x0084/*NCHITTEST*/ :
                    base.WndProc(ref m);
                    if (!this.ResizeableForm) { return; }
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
                
                // Makes the form Flicker-Free by enabling compositing
                // I don't know exatcly how this works but it makes the form flicker-free and layout
                // draws much faster
                cp.ExStyle |= 0x2000000;


                return cp;
            }
        }

        public virtual void FormMaximizeButton_Click(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.UpdateStyles();
            UpdateProperties = true;

            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                
                return;
            }
            this.WindowState = FormWindowState.Normal;

           

        }

        public virtual void FormCloseButton_Click(object sender, EventArgs e)
        {

        }

        private void TabNotepadForm_ResizeBegin(object sender, EventArgs e)
        {
            if (DisableResizeMode || !Properties.Settings.Default.StrechWindowContentsWhenResizing) { return; }
            TakeScreenWax();

            ResizeMode = true;

            // Hide controls
            TitlebarPanel.Visible = false;
            FormControls.Visible = false;

            this.SuspendLayout();

        }

        private void TabNotepadForm_ResizeEnd(object sender, EventArgs e)
        {
            if (DisableResizeMode || !Properties.Settings.Default.StrechWindowContentsWhenResizing) { return; }
            this.ResumeLayout();

            // ReShow hidden controls
            TitlebarPanel.Visible = true;
            FormControls.Visible = true;
            
            // Clear some junk that can be left on window borders
            Invalidate();

            ResizeMode = false;
            ScreenWaxTaken = false;

        }

        private void TakeScreenWax()
        {
            if (!ScreenWaxTaken)
            {
                ScreenWaxTaken = true;
                Rectangle bounds = this.Bounds;
                using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
                {
                    using (Graphics g = Graphics.FromImage(bitmap))
                    {
                        g.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size);
                    }
                    Wax = new Bitmap(bitmap);
                }

            }

        }

        private void DrawStrechedWindow(PaintEventArgs e)
        {
            if (ResizeMode)
            {
                e.Graphics.DrawImage(Wax, 0, 0, ClientRectangle.Width, ClientRectangle.Height);
            }

        }

        private void FormTitlebar_MouseLeave(object sender, EventArgs e)
        {
            DisableResizeMode = false;

        }

        private bool UpdateProperties;

        private void TabNotepadForm_Paint(object sender, PaintEventArgs e)
        {
            if (UpdateProperties)
            {
                UpdateProperties = false;
                this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.CacheText | ControlStyles.UserPaint | ControlStyles.DoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
                this.UpdateStyles();

            }
            FormTitlebar.Text = this.Text;
            if (FocusAfterMinimizing)
            {
                FocusAfterMinimizing = false;
                this.SetStyle(ControlStyles.ResizeRedraw, true);
                this.UpdateStyles();
                UpdateProperties = true;
            
            }
            if (DisableResizeMode || !ScreenWaxTaken || !Properties.Settings.Default.StrechWindowContentsWhenResizing) { return; }

            // Draw Resizing Image
            e.Graphics.DrawImage(Wax, 0, 0, Width, Height);

        }

        private void FormMinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            
        }

        private void FormControls_Validated(object sender, EventArgs e)
        {
         
        }

        private void TabNotepadForm_Activated(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.UpdateStyles();
            UpdateProperties = true;

        }  





    }

    public class MoveWindowLabel : Label
    {
        public IntPtr FormHandle;
        public TabNotepadForm RootControlReference;

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            RootControlReference.DisableResizeMode = true;
            this.Capture = false;
            Message msg = Message.Create(FormHandle, 0XA1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref msg);
        }

    }

}
