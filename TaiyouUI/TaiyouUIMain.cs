using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaiyouUI
{
    public static class Properties
    {
        public static bool UseForcedDoubleBuffer;
        public static bool StrechWindowContentsWhenResizing;
        public static bool WindowShadow;

    }

    public class taiyouButton : Button
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

    public class taiyouListView : ListView
    {
        public taiyouListView()
        {
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OwnerDraw = true;

            if (Properties.UseForcedDoubleBuffer)
            {
                this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
                this.UpdateStyles();

            }
            this.OwnerDraw = true;

        }

        protected override void OnDrawColumnHeader(DrawListViewColumnHeaderEventArgs e)
        {
            SolidBrush BackgroundColor = new SolidBrush(ThemeLoader.GetThemeData("ListView_Header_BackgroundColor"));
            SolidBrush ForegroundColor = new SolidBrush(ThemeLoader.GetThemeData("ListView_Header_ForegroundColor"));
            // Draw Header Background
            e.Graphics.FillRectangle(BackgroundColor, e.Bounds);


            StringFormat sfT = new StringFormat();
            // Set Text to Center
            sfT.Alignment = StringAlignment.Center;
            sfT.LineAlignment = StringAlignment.Center;

            // Draw Header Text
            e.Graphics.DrawString(e.Header.Text, e.Font, ForegroundColor, e.Bounds, sfT);

            // Draw Separation Line
            e.Graphics.FillRectangle(new SolidBrush(ThemeLoader.GetThemeData("ListView_Header_SpliterColor")), new Rectangle(e.Bounds.X + e.Bounds.Width - 1, e.Bounds.Y, 1, e.Bounds.Height));

        }

        protected override void OnDrawItem(DrawListViewItemEventArgs e)
        {
            SolidBrush ForegroundColor = new SolidBrush(ForeColor);
            SolidBrush BackgroundColor = new SolidBrush(BackColor);

            // Only draw background if necessary
            if (this.SelectedItems.Contains(e.Item))
            {
                BackgroundColor = new SolidBrush(ThemeLoader.GetThemeData("ListView_SelectedItemBackgroundColor"));
                e.Graphics.FillRectangle(BackgroundColor, e.Item.GetBounds(ItemBoundsPortion.Label));

            }

            e.Graphics.DrawString(e.Item.Text, e.Item.Font, ForegroundColor, e.Item.Bounds);

        }

        protected override void OnDrawSubItem(DrawListViewSubItemEventArgs e)
        {
            // Don't draw subitem if X if equal to item X
            if (e.SubItem.Bounds.X == e.Item.Bounds.X) { return; }

            SolidBrush ForegroundColor = new SolidBrush(ForeColor);
            SolidBrush BackgroundColor = new SolidBrush(BackColor);

            // WORKAROUND : Subitem Name being rendered over item name
            e.Graphics.FillRectangle(BackgroundColor, e.SubItem.Bounds);
            e.Graphics.DrawString(e.SubItem.Text, e.SubItem.Font, ForegroundColor, e.SubItem.Bounds);

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

    public class taiyouListBox : ListBox
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


    public class taiyouToolStripButton : ToolStripButton
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

    public class taiyouToolStripMenuItem : ToolStripMenuItem
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

    public class taiyouToolStrip : ToolStrip
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

    public class taiyouToolStripDropDownButton : ToolStripDropDownButton
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

    public class taiyouStatusStrip : StatusStrip
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

    public class taiyouCheckBox : CheckBox
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

    public class taiyouFlowLayoutPanel : FlowLayoutPanel
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

    public class taiyouTextBox : TextBox
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

        // FIXME : Not Working
        /// <summary>
        /// NOT WORKING : Goto a specific line
        /// </summary>
        /// <param name="LineNumber">0 based location of line</param>
        public void GotoLine(int LineNumber)
        {
            int Index = GetFirstCharIndexFromLine(LineNumber - 1);
            Select(LineNumber, 0);
        }

        /// <summary>
        /// Get the current selected column
        /// </summary>
        /// <returns>int</returns>
        public int SelectedColumn()
        {
            int index = SelectionStart;
            int line = GetLineFromCharIndex(index);

            int firstChar = GetFirstCharIndexFromLine(line);
            return index - firstChar + 1;
        }

        /// <summary>
        /// Get the current selected line number
        /// </summary>
        /// <returns>int</returns>
        public int SelectedLine()
        {
            try
            {
                return GetLineFromCharIndex(SelectionStart) + 1 / Lines.Length;
            }
            catch (DivideByZeroException) { return 1; }

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
