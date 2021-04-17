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
            this.Toolbar = new TNotepad.taiyouToolStrip();
            this.NewPage = new TNotepad.taiyouToolStripButton();
            this.OpenFileButton = new TNotepad.taiyouToolStripButton();
            this.ExtraMenu = new TNotepad.taiyouToolStripDropDownButton();
            this.encodingToolStripMenuItem = new TNotepad.taiyouToolStripMenuItem();
            this.runToolStripMenuItem = new TNotepad.taiyouToolStripMenuItem();
            this.settingsToolStripMenuItem = new TNotepad.taiyouToolStripMenuItem();
            this.pinDocumentToolStripMenuItem = new TNotepad.taiyouToolStripMenuItem();
            this.savePathToolStripMenuItem = new TNotepad.taiyouToolStripMenuItem();
            this.quickFindToolStripMenuItem = new TNotepad.taiyouToolStripMenuItem();
            this.SaveButton = new TNotepad.taiyouToolStripButton();
            this.SaveAsButton = new TNotepad.taiyouToolStripButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.StatusBar = new TNotepad.taiyouStatusStrip();
            this.SaveStatusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.EncodingInfoLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.LineInfoLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ColumnInfoLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.LastSavedTimer = new System.Windows.Forms.Timer(this.components);
            this.ExtraFuncPanel = new System.Windows.Forms.Panel();
            this.Updater = new System.Windows.Forms.Timer(this.components);
            this.TextEditorContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new TNotepad.taiyouToolStripMenuItem();
            this.cutToolStripMenuItem = new TNotepad.taiyouToolStripMenuItem();
            this.PasteToolStripMenuItem = new TNotepad.taiyouToolStripMenuItem();
            this.TextEditingThing = new TNotepad.taiyouRichTextBox();
            this.Toolbar.SuspendLayout();
            this.StatusBar.SuspendLayout();
            this.TextEditorContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Toolbar
            // 
            this.Toolbar.AllowItemReorder = true;
            this.Toolbar.GripMargin = new System.Windows.Forms.Padding(0);
            this.Toolbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.Toolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewPage,
            this.OpenFileButton,
            this.ExtraMenu,
            this.SaveButton,
            this.SaveAsButton});
            this.Toolbar.Location = new System.Drawing.Point(0, 35);
            this.Toolbar.Name = "Toolbar";
            this.Toolbar.Padding = new System.Windows.Forms.Padding(0);
            this.Toolbar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.Toolbar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Toolbar.Size = new System.Drawing.Size(710, 25);
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
            // quickFindToolStripMenuItem
            // 
            this.quickFindToolStripMenuItem.Name = "quickFindToolStripMenuItem";
            this.quickFindToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.quickFindToolStripMenuItem.Text = "Quick Find";
            this.quickFindToolStripMenuItem.Click += new System.EventHandler(this.quickFindToolStripMenuItem_Click);
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
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "untitled.txt";
            this.saveFileDialog1.Filter = "Text Files|*.txt|Any File|*.*";
            this.saveFileDialog1.Title = "Save Document as...";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // StatusBar
            // 
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveStatusText,
            this.EncodingInfoLabel,
            this.LineInfoLabel,
            this.ColumnInfoLabel});
            this.StatusBar.Location = new System.Drawing.Point(0, 263);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(710, 22);
            this.StatusBar.TabIndex = 2;
            this.StatusBar.Text = "Status Bar";
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
            // LineInfoLabel
            // 
            this.LineInfoLabel.Name = "LineInfoLabel";
            this.LineInfoLabel.Size = new System.Drawing.Size(49, 17);
            this.LineInfoLabel.Text = "Line 0/0";
            // 
            // ColumnInfoLabel
            // 
            this.ColumnInfoLabel.Name = "ColumnInfoLabel";
            this.ColumnInfoLabel.Size = new System.Drawing.Size(59, 17);
            this.ColumnInfoLabel.Text = "Column 0";
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
            this.ExtraFuncPanel.Size = new System.Drawing.Size(710, 35);
            this.ExtraFuncPanel.TabIndex = 3;
            this.ExtraFuncPanel.Visible = false;
            // 
            // Updater
            // 
            this.Updater.Enabled = true;
            this.Updater.Interval = 10;
            this.Updater.Tick += new System.EventHandler(this.Updater_Tick);
            // 
            // TextEditorContextMenu
            // 
            this.TextEditorContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.PasteToolStripMenuItem});
            this.TextEditorContextMenu.Name = "TextEditorContextMenu";
            this.TextEditorContextMenu.ShowImageMargin = false;
            this.TextEditorContextMenu.Size = new System.Drawing.Size(78, 70);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(77, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(77, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // PasteToolStripMenuItem
            // 
            this.PasteToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem";
            this.PasteToolStripMenuItem.Size = new System.Drawing.Size(77, 22);
            this.PasteToolStripMenuItem.Text = "Paste";
            this.PasteToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PasteToolStripMenuItem.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            // 
            // TextEditingThing
            // 
            this.TextEditingThing.AcceptsTab = true;
            this.TextEditingThing.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextEditingThing.ContextMenuStrip = this.TextEditorContextMenu;
            this.TextEditingThing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextEditingThing.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextEditingThing.HideSelection = false;
            this.TextEditingThing.Location = new System.Drawing.Point(0, 60);
            this.TextEditingThing.Name = "TextEditingThing";
            this.TextEditingThing.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.TextEditingThing.ShowSelectionMargin = true;
            this.TextEditingThing.Size = new System.Drawing.Size(710, 203);
            this.TextEditingThing.TabIndex = 1;
            this.TextEditingThing.Text = "";
            this.TextEditingThing.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Text_KeyDown);
            this.TextEditingThing.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextEditingThing_KeyUp);
            // 
            // TextEditingTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TextEditingThing);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.Toolbar);
            this.Controls.Add(this.ExtraFuncPanel);
            this.DoubleBuffered = true;
            this.Name = "TextEditingTab";
            this.Size = new System.Drawing.Size(710, 285);
            this.Load += new System.EventHandler(this.TextEditingTab_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextEditingTab_KeyDown);
            this.Toolbar.ResumeLayout(false);
            this.Toolbar.PerformLayout();
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.TextEditorContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private taiyouToolStrip Toolbar;
        private taiyouToolStripButton NewPage;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private taiyouStatusStrip StatusBar;
        private System.Windows.Forms.ToolStripStatusLabel SaveStatusText;
        private taiyouToolStripButton OpenFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer LastSavedTimer;
        private taiyouToolStripDropDownButton ExtraMenu;
        private taiyouToolStripMenuItem encodingToolStripMenuItem;
        private taiyouToolStripMenuItem runToolStripMenuItem;
        private taiyouToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel EncodingInfoLabel;
        private taiyouToolStripMenuItem pinDocumentToolStripMenuItem;
        private taiyouToolStripButton SaveButton;
        private taiyouToolStripButton SaveAsButton;
        private taiyouToolStripMenuItem savePathToolStripMenuItem;
        public System.Windows.Forms.Panel ExtraFuncPanel;
        private taiyouToolStripMenuItem quickFindToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel LineInfoLabel;
        private System.Windows.Forms.Timer Updater;
        private System.Windows.Forms.ToolStripStatusLabel ColumnInfoLabel;
        public taiyouRichTextBox TextEditingThing;
        private System.Windows.Forms.ContextMenuStrip TextEditorContextMenu;
        private taiyouToolStripMenuItem copyToolStripMenuItem;
        private taiyouToolStripMenuItem PasteToolStripMenuItem;
        private taiyouToolStripMenuItem cutToolStripMenuItem;
    }
}
