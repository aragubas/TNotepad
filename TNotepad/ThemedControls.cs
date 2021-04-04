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
            this.FlatAppearance.BorderSize = 0;

        }

        public void LoadTheme()
        {
            BackColor = ThemeLoader.GetThemeData("Button_BackgroundColor");
            ForeColor = ThemeLoader.GetThemeData("Button_ForegroundColor");

        }

    }

    class taiyouListView : ListView
    {
        public void LoadTheme()
        {
            if (!ThemeLoader.ThemeLoaded) { return; }
            BackColor = ThemeLoader.GetThemeData("ListView_BackgroundColor");
            ForeColor = ThemeLoader.GetThemeData("ListView_ForegroundColor");
            
        }

    }

    class taiyouListBox : ListBox
    {
        public void LoadTheme()
        {
            if (!ThemeLoader.ThemeLoaded) { return; }
            BackColor = ThemeLoader.GetThemeData("ListBox_BackgroundColor");
            ForeColor = ThemeLoader.GetThemeData("ListBox_ForegroundColor");

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

    }

    class taiyouToolStripMenuItem : ToolStripMenuItem
    {
        public void LoadTheme()
        {
            if (!ThemeLoader.ThemeLoaded) { return; }
            BackColor = ThemeLoader.GetThemeData("ToolStrip_MenuItem_BackgroundColor");
            ForeColor = ThemeLoader.GetThemeData("ToolStrip_MenuItem_ForegroundColor");

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

    }

    class taiyouToolStripDropDownButton : ToolStripDropDownButton
    {

        public void LoadTheme()
        {
            if (!ThemeLoader.ThemeLoaded) { return; }
            BackColor = ThemeLoader.GetThemeData("ToolStrip_DropDownButton_BackgroundColor");
            ForeColor = ThemeLoader.GetThemeData("ToolStrip_DropDownButton_ForegroundColor");
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

    }

    class taiyouCheckBox : CheckBox
    {
        public void LoadTheme()
        {
            if (!ThemeLoader.ThemeLoaded) { return; }
            BackColor = ThemeLoader.GetThemeData("Checkbox_BackgroundColor");
            ForeColor = ThemeLoader.GetThemeData("Checkbox_ForegroundColor");

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


    }

    class taiyouRichTextBox : RichTextBox
    {
        public taiyouRichTextBox()
        {
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

        }

        public void LoadTheme()
        {
            if (!ThemeLoader.ThemeLoaded) { return; }
            BackColor = ThemeLoader.GetThemeData("RichTextBox_BackgroundColor");
            ForeColor = ThemeLoader.GetThemeData("RichTextBox_ForegroundColor");

        }


    }


    public class taiyouUserControl : UserControl
    {
        public TabNotepadForm RootForm;

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

    }

}
