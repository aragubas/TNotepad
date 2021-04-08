using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TNotepad
{
    public partial class MainForm : taiyouUserControl
    {
        TabNotepadForm RootControl;
        public MainForm(TabNotepadForm pRootControl)
        {
            InitializeComponent();

            RootControl = pRootControl;

            this.Dock = DockStyle.Fill;

            AttachSidePanel();
            CreateHometab();

            RootControl.FormCloseButton.Click += FormCloseButton_Click;

            // Set minimun size to the previous version window size.
            RootControl.MinimumSize = new Size(840, 470);
            RootControl.Size = new Size(840, 470);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

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
            newTab.Controls.Add(new SettingsTab(RootControl, newTab));
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

    }
}
