using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TNotepad
{
    class taiyouButton : Button
    {
        public taiyouButton()
        {
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 1;
            this.FlatAppearance.BorderColor = Color.Black;

        }

        public void LoadTheme()
        {
            if (!ThemeLoader.ThemeLoaded) { return; }
            BackColor = ThemeLoader.GetThemeData("Button_BackgroundColor");
            ForeColor = ThemeLoader.GetThemeData("Button_ForegroundColor");
            FlatAppearance.MouseOverBackColor = ThemeLoader.GetThemeData("Button_MouseOverColor");
            FlatAppearance.MouseDownBackColor = ThemeLoader.GetThemeData("Button_MouseDownColor");
            this.FlatAppearance.BorderSize = 0;

        }

        // Load theme after being added to user layout
        private bool ThemeLoaded = false;
        protected override void OnLayout(LayoutEventArgs e)
        {
            base.OnLayout(e);

            if (!ThemeLoaded)
            {
                ThemeLoaded = true;
                LoadTheme();
            }
        }

    }

    class taiyouListView : ListView
    { 
        public taiyouListView()
        {
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OwnerDraw = true;

            if (Properties.Settings.Default.ForceDoubleBuffer)
            {

                this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
                this.UpdateStyles();

            }
            this.OwnerDraw = true;

        }

        protected override void OnDrawColumnHeader(DrawListViewColumnHeaderEventArgs e)
        {
            SolidBrush BackgroundColor = new SolidBrush(Color.DimGray);
            SolidBrush ForegroundColor = new SolidBrush(Color.White);
            e.Graphics.FillRectangle(BackgroundColor, e.Bounds);

            StringFormat sfT = new StringFormat();
            sfT.Alignment = StringAlignment.Center;

            e.Graphics.DrawString(e.Header.Text, e.Font, ForegroundColor, e.Bounds, sfT);

            e.Graphics.FillRectangle(new SolidBrush(Color.Black), new Rectangle(e.Bounds.X + e.Bounds.Width - 1, e.Bounds.Y, 1, e.Bounds.Height));

        }

        protected override void OnDrawItem(DrawListViewItemEventArgs e)
        {
            SolidBrush ForegroundColor = new SolidBrush(Color.White);
            SolidBrush BackgroundColor = new SolidBrush(Color.FromArgb(0, 0, 0, 0));

            StringFormat sfT = new StringFormat();

            // Only draw background if necessary
            if (this.SelectedItems.Contains(e.Item))
            {
                BackgroundColor = new SolidBrush(Color.FromArgb(100, 23, 32, 40));
                e.Graphics.FillRectangle(BackgroundColor, e.Item.GetBounds(ItemBoundsPortion.Label));

            }

            e.Graphics.DrawString(e.Item.Text, e.Item.Font, ForegroundColor, e.Item.Bounds, sfT);
           
        }

        protected override void OnDrawSubItem(DrawListViewSubItemEventArgs e)
        {
            // Don't draw subitem if X if equal to item X
            if (e.SubItem.Bounds.X == e.Item.Bounds.X) { return; }

            SolidBrush ForegroundColor = new SolidBrush(Color.White);
            SolidBrush BackgroundColor = new SolidBrush(this.BackColor);


            StringFormat sfT = new StringFormat();

            // WORKAROUND : Subitem Name being rendered over item name
            e.Graphics.FillRectangle(BackgroundColor, e.SubItem.Bounds);
            e.Graphics.DrawString(e.SubItem.Text, e.SubItem.Font, ForegroundColor, e.SubItem.Bounds, sfT);

        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
        }

        public void LoadTheme()
        {
            if (!ThemeLoader.ThemeLoaded) { return; }
            BackColor = ThemeLoader.GetThemeData("ListView_BackgroundColor");
            ForeColor = ThemeLoader.GetThemeData("ListView_ForegroundColor");

        }

        // Load theme after being added to user layout
        private bool ThemeLoaded = false;
        protected override void OnLayout(LayoutEventArgs e)
        {
            base.OnLayout(e);

            if (!ThemeLoaded)
            {
                ThemeLoaded = true;
                LoadTheme(); 
            }
        }

    }

    class taiyouListBox : ListBox
    {
        public taiyouListBox()
        {
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        }
        public void LoadTheme()
        {
            if (!ThemeLoader.ThemeLoaded) { return; }
            BackColor = ThemeLoader.GetThemeData("ListBox_BackgroundColor");
            ForeColor = ThemeLoader.GetThemeData("ListBox_ForegroundColor");

        }

        // Load theme after being added to user layout
        private bool ThemeLoaded = false;
        protected override void OnLayout(LayoutEventArgs e)
        {
            base.OnLayout(e);

            if (!ThemeLoaded)
            {
                ThemeLoaded = true;
                LoadTheme();
            }
        }

    }


    class taiyouToolStripButton : ToolStripButton
    {
        public void LoadTheme()
        {
            if (!ThemeLoader.ThemeLoaded) { return; }
            BackColor = ThemeLoader.GetThemeData("ToolStrip_Button_BackgroundColor");
            ForeColor = ThemeLoader.GetThemeData("ToolStrip_Button_ForegroundColor");

        }

        // Load theme after being added to user layout
        private bool ThemeLoaded = false;
        protected override void OnLayout(LayoutEventArgs e)
        {
            base.OnLayout(e);

            if (!ThemeLoaded)
            {
                ThemeLoaded = true;
                LoadTheme();
            }
        }

    }

    class taiyouToolStripMenuItem : ToolStripMenuItem
    {
        public void LoadTheme()
        {
            if (!ThemeLoader.ThemeLoaded) { return; }
            BackColor = ThemeLoader.GetThemeData("ToolStrip_MenuItem_BackgroundColor");
            ForeColor = ThemeLoader.GetThemeData("ToolStrip_MenuItem_ForegroundColor");

        }

        // Load theme after being added to user layout
        private bool ThemeLoaded = false;
        protected override void OnLayout(LayoutEventArgs e)
        {
            base.OnLayout(e);

            if (!ThemeLoaded)
            {
                ThemeLoaded = true;
                LoadTheme();
            }
        }

    }

    class taiyouToolStrip : ToolStrip
    {
        public void LoadTheme()
        {
            if (!ThemeLoader.ThemeLoaded) { return; }
            BackColor = ThemeLoader.GetThemeData("ToolStrip_BackgroundColor");
            ForeColor = ThemeLoader.GetThemeData("ToolStrip_ForegroundColor");

        }

        // Load theme after being added to user layout
        private bool ThemeLoaded = false;
        protected override void OnLayout(LayoutEventArgs e)
        {
            base.OnLayout(e);

            if (!ThemeLoaded)
            {
                ThemeLoaded = true;
                LoadTheme();
            }
        }

    }

    class taiyouToolStripDropDownButton : ToolStripDropDownButton
    {

        public void LoadTheme()
        {
            if (!ThemeLoader.ThemeLoaded) { return; }
            BackColor = ThemeLoader.GetThemeData("ToolStrip_DropDownButton_BackgroundColor");
            ForeColor = ThemeLoader.GetThemeData("ToolStrip_DropDownButton_ForegroundColor");
        }

        // Load theme after being added to user layout
        private bool ThemeLoaded = false;
        protected override void OnLayout(LayoutEventArgs e)
        {
            base.OnLayout(e);

            if (!ThemeLoaded)
            {
                ThemeLoaded = true;
                LoadTheme();
            }
        }

    }

    class taiyouStatusStrip : StatusStrip
    {
        public void LoadTheme()
        {
            if (!ThemeLoader.ThemeLoaded) { return; }
            BackColor = ThemeLoader.GetThemeData("ToolStrip_StatusStrip_BackgroundColor");
            ForeColor = ThemeLoader.GetThemeData("ToolStrip_StatusStrip_ForegroundColor");

        }

        // Load theme after being added to user layout
        private bool ThemeLoaded = false;
        protected override void OnLayout(LayoutEventArgs e)
        {
            base.OnLayout(e);

            if (!ThemeLoaded)
            {
                ThemeLoaded = true;
                LoadTheme();
            }
        }

    }

    class taiyouCheckBox : CheckBox
    {
        public void LoadTheme()
        {
            if (!ThemeLoader.ThemeLoaded) { return; }
            BackColor = ThemeLoader.GetThemeData("Checkbox_BackgroundColor");
            ForeColor = ThemeLoader.GetThemeData("Checkbox_ForegroundColor");

        }

        // Load theme after being added to user layout
        private bool ThemeLoaded = false;
        protected override void OnLayout(LayoutEventArgs e)
        {
            base.OnLayout(e);

            if (!ThemeLoaded)
            {
                ThemeLoaded = true;
                LoadTheme();
            }
        }


    }

    class taiyouFlowLayoutPanel : FlowLayoutPanel
    {
        public void LoadTheme()
        {
            if (!ThemeLoader.ThemeLoaded) { return; }
            BackColor = ThemeLoader.GetThemeData("FlowLayoutPanel_BackgroundColor");
            ForeColor = ThemeLoader.GetThemeData("FlowLayoutPanel_ForegroundColor");

        }

        // Load theme after being added to user layout
        private bool ThemeLoaded = false;
        protected override void OnLayout(LayoutEventArgs e)
        {
            base.OnLayout(e);

            if (!ThemeLoaded)
            {
                ThemeLoaded = true;
                LoadTheme();
            }
        }


    }

    class taiyouTextBox : TextBox
    {
        public taiyouTextBox()
        {
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

        }

        public void LoadTheme()
        {
            if (!ThemeLoader.ThemeLoaded) { return; }
            BackColor = ThemeLoader.GetThemeData("TextBox_BackgroundColor");
            ForeColor = ThemeLoader.GetThemeData("TextBox_ForegroundColor");

        }

        // Load theme after being added to user layout
        private bool ThemeLoaded = false;
        protected override void OnLayout(LayoutEventArgs e)
        {
            base.OnLayout(e);

            if (!ThemeLoaded)
            {
                ThemeLoaded = true;
                LoadTheme();
            }
        }



    }

    public class taiyouRichTextBox : RichTextBox
    {
        public taiyouRichTextBox()
        {
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AllowDrop = false;
            this.EnableAutoDragDrop = false;

        }

        public void LoadTheme()
        {
            if (!ThemeLoader.ThemeLoaded) { return; }
            BackColor = ThemeLoader.GetThemeData("RichTextBox_BackgroundColor");
            ForeColor = ThemeLoader.GetThemeData("RichTextBox_ForegroundColor");

        }

        // Load theme after being added to user layout
        private bool ThemeLoaded = false;
        protected override void OnLayout(LayoutEventArgs e)
        {
            base.OnLayout(e);

            if (!ThemeLoaded)
            {
                ThemeLoaded = true;
                LoadTheme();
            }
        }



    }


    public class taiyouUserControl : UserControl
    {
        public TabNotepadForm RootForm;

        public void LoadTheme()
        {
            if (!ThemeLoader.ThemeLoaded) { return; }
            BackColor = ThemeLoader.GetThemeData("Form_BackgroundColor");
            ForeColor = ThemeLoader.GetThemeData("Form_ForegroundColor");
        }


        // Load Theme
        private bool ThemeLoaded = false;
        protected override void OnLayout(LayoutEventArgs e)
        {
            base.OnLayout(e);

            if (!ThemeLoaded)
            {
                ThemeLoaded = true;
                LoadTheme();
            }

        }

    }

    public class taiyouComboBox : ComboBox
    {
        public taiyouComboBox()
        {
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

        }

        public void LoadTheme()
        {
            if (!ThemeLoader.ThemeLoaded) { return; }
            BackColor = ThemeLoader.GetThemeData("TextBox_BackgroundColor");
            ForeColor = ThemeLoader.GetThemeData("TextBox_ForegroundColor");

        }

        // Load theme after being added to user layout
        private bool ThemeLoaded = false;
        protected override void OnLayout(LayoutEventArgs e)
        {
            base.OnLayout(e);

            if (!ThemeLoaded)
            {
                ThemeLoaded = true;
                LoadTheme();
            }
        }


    }

    public class taiyouRadioButton : RadioButton
    {
        public taiyouRadioButton()
        {
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

        }

        public void LoadTheme()
        {
            if (!ThemeLoader.ThemeLoaded) { return; }
            BackColor = ThemeLoader.GetThemeData("RadioButton_BackgroundColor");
            ForeColor = ThemeLoader.GetThemeData("RadioButton_ForegroundColor");

        }

        // Load theme after being added to user layout
        private bool ThemeLoaded = false;
        protected override void OnLayout(LayoutEventArgs e)
        {
            base.OnLayout(e);

            if (!ThemeLoaded)
            {
                ThemeLoaded = true;
                LoadTheme();
            }
        }


    }

    public class taiyouTableLayoutPanel : TableLayoutPanel
    {
        public void LoadTheme()
        {
            if (!ThemeLoader.ThemeLoaded) { return; }
            BackColor = ThemeLoader.GetThemeData("TableLayout_BackgroundColor");
            ForeColor = ThemeLoader.GetThemeData("TableLayout_ForegroundColor");

        }

        // Load theme after being added to user layout
        private bool ThemeLoaded = false;
        protected override void OnLayout(LayoutEventArgs e)
        {
            base.OnLayout(e);

            if (!ThemeLoaded)
            {
                ThemeLoaded = true;
                LoadTheme();
            }
        }

    }

    public class taiyouSplitContainer : SplitContainer
    {
        public void LoadTheme()
        {
            if (!ThemeLoader.ThemeLoaded) { return; }
            BackColor = ThemeLoader.GetThemeData("SplitContainer_BackgroundColor");
            ForeColor = ThemeLoader.GetThemeData("SplitContainer_ForegroundColor");

        }

        // Load theme after being added to user layout
        private bool ThemeLoaded = false;
        protected override void OnLayout(LayoutEventArgs e)
        {
            base.OnLayout(e);

            if (!ThemeLoaded)
            {
                ThemeLoaded = true;
                LoadTheme();
            }
        }
    }

    public class taiyouGroupBox : GroupBox
    {
        public taiyouGroupBox()
        {
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        }

        public void LoadTheme()
        {
            if (!ThemeLoader.ThemeLoaded) { return; }
            BackColor = ThemeLoader.GetThemeData("RadioButton_BackgroundColor");
            ForeColor = ThemeLoader.GetThemeData("RadioButton_ForegroundColor");

        }

        // Load theme after being added to user layout
        private bool ThemeLoaded = false;
        protected override void OnLayout(LayoutEventArgs e)
        {
            base.OnLayout(e);

            if (!ThemeLoaded)
            {
                ThemeLoaded = true;
                LoadTheme();
            }
        }


    }


}
