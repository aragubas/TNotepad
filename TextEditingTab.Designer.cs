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
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showCurrentPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.encodingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pinDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Text = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.SaveStatusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.EncodingInfoLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.LastSavedTimer = new System.Windows.Forms.Timer(this.components);
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
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2});
            this.Toolbar.Location = new System.Drawing.Point(0, 0);
            this.Toolbar.Name = "Toolbar";
            this.Toolbar.Size = new System.Drawing.Size(558, 25);
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
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.showCurrentPathToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(44, 22);
            this.toolStripDropDownButton1.Text = "Save";
            this.toolStripDropDownButton1.ToolTipText = "Save Actions";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.saveToolStripMenuItem.Text = "Save with current path";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // showCurrentPathToolStripMenuItem
            // 
            this.showCurrentPathToolStripMenuItem.Name = "showCurrentPathToolStripMenuItem";
            this.showCurrentPathToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.showCurrentPathToolStripMenuItem.Text = "Show current path";
            this.showCurrentPathToolStripMenuItem.Click += new System.EventHandler(this.showCurrentPathToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encodingToolStripMenuItem,
            this.runToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.pinDocumentToolStripMenuItem});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(46, 22);
            this.toolStripDropDownButton2.Text = "Extra";
            // 
            // encodingToolStripMenuItem
            // 
            this.encodingToolStripMenuItem.Name = "encodingToolStripMenuItem";
            this.encodingToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.encodingToolStripMenuItem.Text = "Encoding";
            this.encodingToolStripMenuItem.Click += new System.EventHandler(this.encodingToolStripMenuItem_Click);
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.runToolStripMenuItem.Text = "Run";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // pinDocumentToolStripMenuItem
            // 
            this.pinDocumentToolStripMenuItem.Enabled = false;
            this.pinDocumentToolStripMenuItem.Name = "pinDocumentToolStripMenuItem";
            this.pinDocumentToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pinDocumentToolStripMenuItem.Text = "Pin Document";
            this.pinDocumentToolStripMenuItem.Click += new System.EventHandler(this.pinDocumentToolStripMenuItem_Click);
            // 
            // Text
            // 
            this.Text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Text.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text.Location = new System.Drawing.Point(0, 25);
            this.Text.Name = "Text";
            this.Text.Size = new System.Drawing.Size(558, 324);
            this.Text.TabIndex = 1;
            this.Text.Text = "";
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 349);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(558, 22);
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
            // TextEditingTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.Text);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Toolbar);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "TextEditingTab";
            this.Size = new System.Drawing.Size(558, 371);
            this.Load += new System.EventHandler(this.TextEditingTab_Load);
            this.Toolbar.ResumeLayout(false);
            this.Toolbar.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip Toolbar;
        private System.Windows.Forms.RichTextBox Text;
        private System.Windows.Forms.ToolStripButton NewPage;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel SaveStatusText;
        private System.Windows.Forms.ToolStripButton OpenFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer LastSavedTimer;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showCurrentPathToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem encodingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel EncodingInfoLabel;
        private System.Windows.Forms.ToolStripMenuItem pinDocumentToolStripMenuItem;

    }
}
