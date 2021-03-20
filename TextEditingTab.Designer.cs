namespace TNotepad
{
    partial class TextEditingTab
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextEditingTab));
            this.Toolbar = new System.Windows.Forms.ToolStrip();
            this.NewPage = new System.Windows.Forms.ToolStripButton();
            this.OpenFileButton = new System.Windows.Forms.ToolStripButton();
            this.ExtraMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.encodingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pinDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveButton = new System.Windows.Forms.ToolStripButton();
            this.SaveAsButton = new System.Windows.Forms.ToolStripButton();
            this.TextEditingThing = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.SaveStatusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.EncodingInfoLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.LastSavedTimer = new System.Windows.Forms.Timer(this.components);
            this.ExtraFuncPanel = new System.Windows.Forms.Panel();
            this.quickFindToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Toolbar.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Toolbar
            // 
            this.Toolbar.AllowItemReorder = true;
            this.Toolbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.Toolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewPage,
            this.OpenFileButton,
            this.ExtraMenu,
            this.SaveButton,
            this.SaveAsButton});
            this.Toolbar.Location = new System.Drawing.Point(0, 29);
            this.Toolbar.Name = "Toolbar";
            this.Toolbar.Size = new System.Drawing.Size(760, 25);
            this.Toolbar.TabIndex = 0;
            this.Toolbar.Text = "Toolbar";
            // 
            // NewPage
            // 
            this.NewPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.NewPage.Image = ((System.Drawing.Image)(resources.GetObject("NewPage.Image")));
            this.NewPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewPage.Name = "NewPage";
            this.NewPage.Size = new System.Drawing.Size(35, 22);
            this.NewPage.Text = "New";
            this.NewPage.Click += new System.EventHandler(this.NewPage_Click);
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.OpenFileButton.Image = ((System.Drawing.Image)(resources.GetObject("OpenFileButton.Image")));
            this.OpenFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(61, 22);
            this.OpenFileButton.Text = "Open File";
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // ExtraMenu
            // 
            this.ExtraMenu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ExtraMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ExtraMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encodingToolStripMenuItem,
            this.runToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.pinDocumentToolStripMenuItem,
            this.savePathToolStripMenuItem,
            this.quickFindToolStripMenuItem});
            this.ExtraMenu.Image = ((System.Drawing.Image)(resources.GetObject("ExtraMenu.Image")));
            this.ExtraMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExtraMenu.Name = "ExtraMenu";
            this.ExtraMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ExtraMenu.Size = new System.Drawing.Size(46, 22);
            this.ExtraMenu.Text = "Extra";
            // 
            // encodingToolStripMenuItem
            // 
            this.encodingToolStripMenuItem.Name = "encodingToolStripMenuItem";
            this.encodingToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.encodingToolStripMenuItem.Text = "Encoding";
            this.encodingToolStripMenuItem.Click += new System.EventHandler(this.encodingToolStripMenuItem_Click);
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.runToolStripMenuItem.Text = "Run";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // pinDocumentToolStripMenuItem
            // 
            this.pinDocumentToolStripMenuItem.Enabled = false;
            this.pinDocumentToolStripMenuItem.Name = "pinDocumentToolStripMenuItem";
            this.pinDocumentToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.pinDocumentToolStripMenuItem.Text = "Pin Document";
            this.pinDocumentToolStripMenuItem.Click += new System.EventHandler(this.pinDocumentToolStripMenuItem_Click);
            // 
            // savePathToolStripMenuItem
            // 
            this.savePathToolStripMenuItem.Name = "savePathToolStripMenuItem";
            this.savePathToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.savePathToolStripMenuItem.Text = "Save Path";
            this.savePathToolStripMenuItem.Click += new System.EventHandler(this.savePathToolStripMenuItem_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
            this.SaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(35, 22);
            this.SaveButton.Text = "Save";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click_1);
            // 
            // SaveAsButton
            // 
            this.SaveAsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SaveAsButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveAsButton.Image")));
            this.SaveAsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveAsButton.Name = "SaveAsButton";
            this.SaveAsButton.Size = new System.Drawing.Size(60, 22);
            this.SaveAsButton.Text = "Save As...";
            this.SaveAsButton.Click += new System.EventHandler(this.SaveAsButton_Click);
            // 
            // TextEditingThing
            // 
            this.TextEditingThing.AcceptsTab = true;
            this.TextEditingThing.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextEditingThing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextEditingThing.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextEditingThing.Location = new System.Drawing.Point(0, 54);
            this.TextEditingThing.Name = "TextEditingThing";
            this.TextEditingThing.ShowSelectionMargin = true;
            this.TextEditingThing.Size = new System.Drawing.Size(760, 274);
            this.TextEditingThing.TabIndex = 1;
            this.TextEditingThing.Text = "";
            this.TextEditingThing.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Text_KeyDown);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "untitled.txt";
            this.saveFileDialog1.Filter = "Text Files|*.txt|Any File|*.*";
            this.saveFileDialog1.Title = "Save Document as...";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveStatusText,
            this.EncodingInfoLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 328);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(760, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "Status Bar";
            // 
            // SaveStatusText
            // 
            this.SaveStatusText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SaveStatusText.Name = "SaveStatusText";
            this.SaveStatusText.Size = new System.Drawing.Size(52, 17);
            this.SaveStatusText.Text = "Unsaved";
            this.SaveStatusText.ToolTipText = "Time Format:\r\nHours:Minutes:Secounds";
            this.SaveStatusText.Click += new System.EventHandler(this.SaveStatusText_Click);
            // 
            // EncodingInfoLabel
            // 
            this.EncodingInfoLabel.Name = "EncodingInfoLabel";
            this.EncodingInfoLabel.Size = new System.Drawing.Size(99, 17);
            this.EncodingInfoLabel.Text = "Encoding not set.";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "untitled.txt";
            this.openFileDialog1.Filter = "Text Files|*.txt|Any File|*.*";
            this.openFileDialog1.Title = "Open File";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // LastSavedTimer
            // 
            this.LastSavedTimer.Enabled = true;
            this.LastSavedTimer.Interval = 1000;
            this.LastSavedTimer.Tick += new System.EventHandler(this.LastSavedTimer_Tick);
            // 
            // ExtraFuncPanel
            // 
            this.ExtraFuncPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ExtraFuncPanel.Location = new System.Drawing.Point(0, 0);
            this.ExtraFuncPanel.Name = "ExtraFuncPanel";
            this.ExtraFuncPanel.Size = new System.Drawing.Size(760, 29);
            this.ExtraFuncPanel.TabIndex = 3;
            this.ExtraFuncPanel.Visible = false;
            // 
            // quickFindToolStripMenuItem
            // 
            this.quickFindToolStripMenuItem.Name = "quickFindToolStripMenuItem";
            this.quickFindToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quickFindToolStripMenuItem.Text = "Quick Find";
            this.quickFindToolStripMenuItem.Click += new System.EventHandler(this.quickFindToolStripMenuItem_Click);
            // 
            // TextEditingTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.TextEditingThing);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Toolbar);
            this.Controls.Add(this.ExtraFuncPanel);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "TextEditingTab";
            this.Size = new System.Drawing.Size(760, 350);
            this.Load += new System.EventHandler(this.TextEditingTab_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextEditingTab_KeyDown);
            this.Toolbar.ResumeLayout(false);
            this.Toolbar.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip Toolbar;
        public System.Windows.Forms.RichTextBox TextEditingThing;
        private System.Windows.Forms.ToolStripButton NewPage;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel SaveStatusText;
        private System.Windows.Forms.ToolStripButton OpenFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer LastSavedTimer;
        private System.Windows.Forms.ToolStripDropDownButton ExtraMenu;
        private System.Windows.Forms.ToolStripMenuItem encodingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel EncodingInfoLabel;
        private System.Windows.Forms.ToolStripMenuItem pinDocumentToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton SaveButton;
        private System.Windows.Forms.ToolStripButton SaveAsButton;
        private System.Windows.Forms.ToolStripMenuItem savePathToolStripMenuItem;
        public System.Windows.Forms.Panel ExtraFuncPanel;
        private System.Windows.Forms.ToolStripMenuItem quickFindToolStripMenuItem;
    }
}
