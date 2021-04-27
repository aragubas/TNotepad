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
    public partial class MainForm : taiyouUserControl
    {
        public MainForm()
        {
            InitializeComponent();

            this.Dock = DockStyle.Fill;

            AttachSidePanel();
            //CreateHometab();
            CreateNewTab();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RootForm.FormCloseButton.Click += FormCloseButton_Click;

            // Set minimun size to the previous version window size.
            RootForm.MinimumSize = new Size(840, 470);
            RootForm.Size = new Size(840, 470);

            // Enable Tab Switcher Shortcut
            RootForm.KeyPreview = true;
            RootForm.KeyDown += RootForm_KeyDown;

            Utils.MainFormInstance = this;

            Tabs.CreateNewTabEvent += Tabs_CreateNewTabEvent;

            // handle open with
            if (Utils.OpenTabStartupArg)
            {
                Utils.OpenTabStartupArg = false;
                CreateNewTabWithOpenDocument(Utils.OpenTabStartupArg_FileName);
            }
        }

        void Tabs_CreateNewTabEvent()
        {
            CreateNewTab();
        }

        void FormControls_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            // Open Shortcut
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.Tab)
            {
                OpenTabSwitcher();
            }
        }

        public void OpenTabSwitcher()
        {
            TabSwitcher tabSw = new TabSwitcher(Tabs);
            Utils.CreateWindow(tabSw, "Tab Switcher", true);

        }

        void RootForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Open Shortcut
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.Tab)
            {
                OpenTabSwitcher();
            }

        }

        void FormCloseButton_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.SaveChangesWhenExiting)
            {
                Properties.Settings.Default.Save();
            }

            Environment.Exit(0);
               
        }

        public void CloseSelectedTab()
        {
            // Create new tab if there is no one left
            if (!Tabs.SelectedTab.Tag.ToString().Contains("PERSISTENT"))
            {  
                Tabs.ClosePageAt(Tabs.SelectedIndex);
            }

        }


        public void CreateHometab()
        {
            // Create Tab object
            TabPage newTab = new TabPage();
            newTab.Controls.Add(new HomescreenTab(this));
            newTab.Text = Lang.GetLangData("PinnedDocuments_TabTitle");
            newTab.Padding = new Padding(0, 0, 0, 0);
            newTab.Tag = "PERSISTENT";

            Tabs.TabPages.Add(newTab);

            // Set selected tab to the newly created one
            Tabs.SelectedIndex = Tabs.TabPages.IndexOf(newTab);

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
        }

        public void CreateSettingsTab()
        {
            // Create Tab object
            TabPage newTab = new TabPage();
            newTab.Text = Lang.GetLangData("Generic_Settings");
            newTab.Controls.Add(new SettingsTab(RootForm, newTab));
            newTab.Padding = new Padding(0, 0, 0, 0);
            newTab.Tag = "GENERIC";

            Tabs.TabPages.Add(newTab);

            // Set selected tab to the newly created one
            Tabs.SelectedIndex = Tabs.TabPages.IndexOf(newTab);
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
            newTab.Tag = "TEXT_EDITOR";

            Tabs.TabPages.Add(newTab);

            // Set selected tab to the newly created one
            Tabs.SelectedIndex = Tabs.TabPages.IndexOf(newTab);
        }

        public void AttachSidePanel()
        {
            SidePanelView.Controls.Clear();

            SidePanel panelSide = new SidePanel(this, SidePanelView);

            SidePanelView.Controls.Add(panelSide);

        }

    }
}
