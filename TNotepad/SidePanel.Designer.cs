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
            this.panel2 = new System.Windows.Forms.Panel();
            this.AboutButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.NewTabButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.HideShowButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.QuickSettings = new System.Windows.Forms.Panel();
            this.SettingsMiniButton = new System.Windows.Forms.Button();
            this.OpenFileMiniButton = new System.Windows.Forms.Button();
            this.CloseTabMiniButton = new System.Windows.Forms.Button();
            this.NewFileMiniButton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.QuickSettings.SuspendLayout();
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
            this.AboutButton.BackColor = System.Drawing.Color.Gray;
            this.AboutButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AboutButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutButton.ForeColor = System.Drawing.Color.White;
            this.AboutButton.Location = new System.Drawing.Point(0, 81);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(82, 25);
            this.AboutButton.TabIndex = 4;
            this.AboutButton.Text = "About";
            this.AboutButton.UseVisualStyleBackColor = false;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackColor = System.Drawing.Color.Gray;
            this.SettingsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingsButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.ForeColor = System.Drawing.Color.White;
            this.SettingsButton.Location = new System.Drawing.Point(0, 56);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(82, 25);
            this.SettingsButton.TabIndex = 3;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = false;
            this.SettingsButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.BackColor = System.Drawing.Color.Gray;
            this.OpenFileButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.OpenFileButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.OpenFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenFileButton.ForeColor = System.Drawing.Color.White;
            this.OpenFileButton.Location = new System.Drawing.Point(0, 29);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(82, 27);
            this.OpenFileButton.TabIndex = 1;
            this.OpenFileButton.Text = "Open File";
            this.OpenFileButton.UseVisualStyleBackColor = false;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // NewTabButton
            // 
            this.NewTabButton.BackColor = System.Drawing.Color.Gray;
            this.NewTabButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.NewTabButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.NewTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewTabButton.ForeColor = System.Drawing.Color.White;
            this.NewTabButton.Location = new System.Drawing.Point(0, 0);
            this.NewTabButton.Name = "NewTabButton";
            this.NewTabButton.Size = new System.Drawing.Size(82, 29);
            this.NewTabButton.TabIndex = 0;
            this.NewTabButton.Text = "New Tab";
            this.NewTabButton.UseVisualStyleBackColor = false;
            this.NewTabButton.Click += new System.EventHandler(this.NewTabButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
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
            this.HideShowButton.ForeColor = System.Drawing.Color.White;
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
            // QuickSettings
            // 
            this.QuickSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QuickSettings.Controls.Add(this.SettingsMiniButton);
            this.QuickSettings.Controls.Add(this.OpenFileMiniButton);
            this.QuickSettings.Controls.Add(this.CloseTabMiniButton);
            this.QuickSettings.Controls.Add(this.NewFileMiniButton);
            this.QuickSettings.Location = new System.Drawing.Point(94, 79);
            this.QuickSettings.Name = "QuickSettings";
            this.QuickSettings.Size = new System.Drawing.Size(25, 300);
            this.QuickSettings.TabIndex = 3;
            this.QuickSettings.Visible = false;
            // 
            // SettingsMiniButton
            // 
            this.SettingsMiniButton.BackgroundImage = global::TNotepad.Properties.Resources.SettingsMini;
            this.SettingsMiniButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SettingsMiniButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingsMiniButton.FlatAppearance.BorderSize = 0;
            this.SettingsMiniButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.SettingsMiniButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsMiniButton.Location = new System.Drawing.Point(0, 81);
            this.SettingsMiniButton.Name = "SettingsMiniButton";
            this.SettingsMiniButton.Size = new System.Drawing.Size(25, 27);
            this.SettingsMiniButton.TabIndex = 3;
            this.SettingsMiniButton.UseVisualStyleBackColor = true;
            this.SettingsMiniButton.Click += new System.EventHandler(this.SettingsMiniButton_Click);
            // 
            // OpenFileMiniButton
            // 
            this.OpenFileMiniButton.BackgroundImage = global::TNotepad.Properties.Resources.OpenFileMini;
            this.OpenFileMiniButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.OpenFileMiniButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.OpenFileMiniButton.FlatAppearance.BorderSize = 0;
            this.OpenFileMiniButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.OpenFileMiniButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenFileMiniButton.Location = new System.Drawing.Point(0, 54);
            this.OpenFileMiniButton.Name = "OpenFileMiniButton";
            this.OpenFileMiniButton.Size = new System.Drawing.Size(25, 27);
            this.OpenFileMiniButton.TabIndex = 2;
            this.OpenFileMiniButton.UseVisualStyleBackColor = true;
            this.OpenFileMiniButton.Click += new System.EventHandler(this.OpenFileMiniButton_Click);
            // 
            // CloseTabMiniButton
            // 
            this.CloseTabMiniButton.BackgroundImage = global::TNotepad.Properties.Resources.CloseTabMini;
            this.CloseTabMiniButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CloseTabMiniButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CloseTabMiniButton.FlatAppearance.BorderSize = 0;
            this.CloseTabMiniButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.CloseTabMiniButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseTabMiniButton.Location = new System.Drawing.Point(0, 27);
            this.CloseTabMiniButton.Name = "CloseTabMiniButton";
            this.CloseTabMiniButton.Size = new System.Drawing.Size(25, 27);
            this.CloseTabMiniButton.TabIndex = 1;
            this.CloseTabMiniButton.UseVisualStyleBackColor = true;
            this.CloseTabMiniButton.Click += new System.EventHandler(this.CloseTabMiniButton_Click);
            // 
            // NewFileMiniButton
            // 
            this.NewFileMiniButton.BackgroundImage = global::TNotepad.Properties.Resources.NewFileMini;
            this.NewFileMiniButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.NewFileMiniButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.NewFileMiniButton.FlatAppearance.BorderSize = 0;
            this.NewFileMiniButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.NewFileMiniButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewFileMiniButton.Location = new System.Drawing.Point(0, 0);
            this.NewFileMiniButton.Name = "NewFileMiniButton";
            this.NewFileMiniButton.Size = new System.Drawing.Size(25, 27);
            this.NewFileMiniButton.TabIndex = 0;
            this.NewFileMiniButton.UseVisualStyleBackColor = true;
            this.NewFileMiniButton.Click += new System.EventHandler(this.NewFileMiniButton_Click);
            // 
            // SidePanel
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.Panel QuickSettings;
        private System.Windows.Forms.Button NewFileMiniButton;
        private System.Windows.Forms.Button CloseTabMiniButton;
        private System.Windows.Forms.Button OpenFileMiniButton;
        private System.Windows.Forms.Button SettingsMiniButton;
    }
}
