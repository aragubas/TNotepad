namespace TNotepad
{
    partial class SidePanel
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.AboutButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.NewTabButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.HideShowButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.HideShowAnimation = new System.Windows.Forms.Timer(this.components);
            this.QuickSettings = new System.Windows.Forms.Panel();
            this.SettingsMiniButton = new System.Windows.Forms.PictureBox();
            this.CloseMiniButton = new System.Windows.Forms.PictureBox();
            this.OpenFileMiniButton = new System.Windows.Forms.PictureBox();
            this.NewFileMiniButton = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.QuickSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsMiniButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseMiniButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenFileMiniButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewFileMiniButton)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.AboutButton);
            this.panel2.Controls.Add(this.SettingsButton);
            this.panel2.Controls.Add(this.OpenFileButton);
            this.panel2.Controls.Add(this.NewTabButton);
            this.panel2.Location = new System.Drawing.Point(6, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(82, 330);
            this.panel2.TabIndex = 1;
            // 
            // AboutButton
            // 
            this.AboutButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AboutButton.Location = new System.Drawing.Point(0, 81);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(82, 25);
            this.AboutButton.TabIndex = 4;
            this.AboutButton.Text = "About";
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingsButton.Location = new System.Drawing.Point(0, 56);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(82, 25);
            this.SettingsButton.TabIndex = 3;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.OpenFileButton.Location = new System.Drawing.Point(0, 29);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(82, 27);
            this.OpenFileButton.TabIndex = 1;
            this.OpenFileButton.Text = "Open File";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // NewTabButton
            // 
            this.NewTabButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.NewTabButton.Location = new System.Drawing.Point(0, 0);
            this.NewTabButton.Name = "NewTabButton";
            this.NewTabButton.Size = new System.Drawing.Size(82, 29);
            this.NewTabButton.TabIndex = 0;
            this.NewTabButton.Text = "New Tab";
            this.NewTabButton.UseVisualStyleBackColor = true;
            this.NewTabButton.Click += new System.EventHandler(this.NewTabButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "TabNotepad";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HideShowButton
            // 
            this.HideShowButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HideShowButton.FlatAppearance.BorderSize = 0;
            this.HideShowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HideShowButton.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HideShowButton.Location = new System.Drawing.Point(94, 48);
            this.HideShowButton.Name = "HideShowButton";
            this.HideShowButton.Size = new System.Drawing.Size(25, 25);
            this.HideShowButton.TabIndex = 2;
            this.HideShowButton.Text = "<";
            this.HideShowButton.UseVisualStyleBackColor = true;
            this.HideShowButton.Click += new System.EventHandler(this.HideShowButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "untitled.txt";
            this.openFileDialog1.Filter = "Text Files|*.txt|Any File|*.*";
            this.openFileDialog1.Title = "Open File";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // HideShowAnimation
            // 
            this.HideShowAnimation.Interval = 1;
            this.HideShowAnimation.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // QuickSettings
            // 
            this.QuickSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QuickSettings.Controls.Add(this.SettingsMiniButton);
            this.QuickSettings.Controls.Add(this.CloseMiniButton);
            this.QuickSettings.Controls.Add(this.OpenFileMiniButton);
            this.QuickSettings.Controls.Add(this.NewFileMiniButton);
            this.QuickSettings.Location = new System.Drawing.Point(94, 79);
            this.QuickSettings.Name = "QuickSettings";
            this.QuickSettings.Size = new System.Drawing.Size(25, 300);
            this.QuickSettings.TabIndex = 3;
            this.QuickSettings.Visible = false;
            // 
            // SettingsMiniButton
            // 
            this.SettingsMiniButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingsMiniButton.Image = global::TNotepad.Properties.Resources.SettingsMini;
            this.SettingsMiniButton.Location = new System.Drawing.Point(0, 90);
            this.SettingsMiniButton.Name = "SettingsMiniButton";
            this.SettingsMiniButton.Size = new System.Drawing.Size(25, 30);
            this.SettingsMiniButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SettingsMiniButton.TabIndex = 2;
            this.SettingsMiniButton.TabStop = false;
            this.SettingsMiniButton.Click += new System.EventHandler(this.SettingsMiniButton_Click);
            this.SettingsMiniButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SettingsMiniButton_MouseDown);
            this.SettingsMiniButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SettingsMiniButton_MouseUp);
            // 
            // CloseMiniButton
            // 
            this.CloseMiniButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CloseMiniButton.Image = global::TNotepad.Properties.Resources.CloseTabMini;
            this.CloseMiniButton.Location = new System.Drawing.Point(0, 60);
            this.CloseMiniButton.Name = "CloseMiniButton";
            this.CloseMiniButton.Size = new System.Drawing.Size(25, 30);
            this.CloseMiniButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseMiniButton.TabIndex = 3;
            this.CloseMiniButton.TabStop = false;
            this.CloseMiniButton.Click += new System.EventHandler(this.CloseMiniButton_Click);
            this.CloseMiniButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CloseMiniButton_MouseDown);
            this.CloseMiniButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CloseMiniButton_MouseUp);
            // 
            // OpenFileMiniButton
            // 
            this.OpenFileMiniButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.OpenFileMiniButton.Image = global::TNotepad.Properties.Resources.Open_FileMini;
            this.OpenFileMiniButton.Location = new System.Drawing.Point(0, 30);
            this.OpenFileMiniButton.Name = "OpenFileMiniButton";
            this.OpenFileMiniButton.Size = new System.Drawing.Size(25, 30);
            this.OpenFileMiniButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OpenFileMiniButton.TabIndex = 1;
            this.OpenFileMiniButton.TabStop = false;
            this.OpenFileMiniButton.Click += new System.EventHandler(this.OpenFileMiniButton_Click);
            this.OpenFileMiniButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OpenFileMiniButton_MouseDown);
            this.OpenFileMiniButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OpenFileMiniButton_MouseUp);
            // 
            // NewFileMiniButton
            // 
            this.NewFileMiniButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.NewFileMiniButton.Image = global::TNotepad.Properties.Resources.NewFileMini;
            this.NewFileMiniButton.Location = new System.Drawing.Point(0, 0);
            this.NewFileMiniButton.Name = "NewFileMiniButton";
            this.NewFileMiniButton.Size = new System.Drawing.Size(25, 30);
            this.NewFileMiniButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NewFileMiniButton.TabIndex = 0;
            this.NewFileMiniButton.TabStop = false;
            this.NewFileMiniButton.Click += new System.EventHandler(this.NewFileMiniButton_Click);
            this.NewFileMiniButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NewFileMiniButton_MouseDown);
            this.NewFileMiniButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NewFileMiniButton_MouseUp);
            // 
            // SidePanel
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.QuickSettings);
            this.Controls.Add(this.HideShowButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SidePanel";
            this.Size = new System.Drawing.Size(122, 382);
            this.Load += new System.EventHandler(this.SidePanel_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.SidePanel_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.SidePanel_DragEnter);
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.SidePanel_DragOver);
            this.panel2.ResumeLayout(false);
            this.QuickSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SettingsMiniButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseMiniButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenFileMiniButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewFileMiniButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.Button NewTabButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button HideShowButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer HideShowAnimation;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.Panel QuickSettings;
        private System.Windows.Forms.PictureBox NewFileMiniButton;
        private System.Windows.Forms.PictureBox SettingsMiniButton;
        private System.Windows.Forms.PictureBox OpenFileMiniButton;
        private System.Windows.Forms.PictureBox CloseMiniButton;
    }
}
