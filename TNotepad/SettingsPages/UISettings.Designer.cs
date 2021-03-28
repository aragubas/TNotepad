namespace TNotepad.SettingsPages
{
    partial class UISettings
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
            this.SaveWarningGroupBox = new System.Windows.Forms.GroupBox();
            this.SaveWarningCheckBox = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SaveWarningTextBox = new System.Windows.Forms.TextBox();
            this.SaveWarningIntervalInfo = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.LanguageSettingGroupBox = new System.Windows.Forms.GroupBox();
            this.OpenLanguageSettingsButton = new System.Windows.Forms.Button();
            this.LanguageSettingsInfoLabel = new System.Windows.Forms.Label();
            this.WindowShadowGroupBox = new System.Windows.Forms.GroupBox();
            this.WindowShadowCheckBox = new System.Windows.Forms.CheckBox();
            this.SaveWarningGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.LanguageSettingGroupBox.SuspendLayout();
            this.WindowShadowGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveWarningGroupBox
            // 
            this.SaveWarningGroupBox.Controls.Add(this.SaveWarningCheckBox);
            this.SaveWarningGroupBox.Controls.Add(this.panel1);
            this.SaveWarningGroupBox.ForeColor = System.Drawing.Color.White;
            this.SaveWarningGroupBox.Location = new System.Drawing.Point(3, 3);
            this.SaveWarningGroupBox.Name = "SaveWarningGroupBox";
            this.SaveWarningGroupBox.Size = new System.Drawing.Size(300, 91);
            this.SaveWarningGroupBox.TabIndex = 1;
            this.SaveWarningGroupBox.TabStop = false;
            this.SaveWarningGroupBox.Text = "Save Warning";
            // 
            // SaveWarningCheckBox
            // 
            this.SaveWarningCheckBox.AutoSize = true;
            this.SaveWarningCheckBox.Location = new System.Drawing.Point(24, 26);
            this.SaveWarningCheckBox.Name = "SaveWarningCheckBox";
            this.SaveWarningCheckBox.Size = new System.Drawing.Size(202, 32);
            this.SaveWarningCheckBox.TabIndex = 0;
            this.SaveWarningCheckBox.Text = "Show the time a document has been\r\nnot saved on status bar";
            this.SaveWarningCheckBox.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SaveWarningTextBox);
            this.panel1.Controls.Add(this.SaveWarningIntervalInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 20);
            this.panel1.TabIndex = 4;
            // 
            // SaveWarningTextBox
            // 
            this.SaveWarningTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.SaveWarningTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SaveWarningTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveWarningTextBox.ForeColor = System.Drawing.Color.White;
            this.SaveWarningTextBox.Location = new System.Drawing.Point(112, 0);
            this.SaveWarningTextBox.Name = "SaveWarningTextBox";
            this.SaveWarningTextBox.Size = new System.Drawing.Size(182, 20);
            this.SaveWarningTextBox.TabIndex = 1;
            // 
            // SaveWarningIntervalInfo
            // 
            this.SaveWarningIntervalInfo.AutoSize = true;
            this.SaveWarningIntervalInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.SaveWarningIntervalInfo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveWarningIntervalInfo.Location = new System.Drawing.Point(0, 0);
            this.SaveWarningIntervalInfo.Name = "SaveWarningIntervalInfo";
            this.SaveWarningIntervalInfo.Size = new System.Drawing.Size(112, 14);
            this.SaveWarningIntervalInfo.TabIndex = 2;
            this.SaveWarningIntervalInfo.Text = "Interval (miliseconds):";
            this.SaveWarningIntervalInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.SaveWarningGroupBox);
            this.flowLayoutPanel1.Controls.Add(this.LanguageSettingGroupBox);
            this.flowLayoutPanel1.Controls.Add(this.WindowShadowGroupBox);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(492, 340);
            this.flowLayoutPanel1.TabIndex = 3;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // LanguageSettingGroupBox
            // 
            this.LanguageSettingGroupBox.Controls.Add(this.OpenLanguageSettingsButton);
            this.LanguageSettingGroupBox.Controls.Add(this.LanguageSettingsInfoLabel);
            this.LanguageSettingGroupBox.ForeColor = System.Drawing.Color.White;
            this.LanguageSettingGroupBox.Location = new System.Drawing.Point(3, 100);
            this.LanguageSettingGroupBox.Name = "LanguageSettingGroupBox";
            this.LanguageSettingGroupBox.Size = new System.Drawing.Size(297, 114);
            this.LanguageSettingGroupBox.TabIndex = 3;
            this.LanguageSettingGroupBox.TabStop = false;
            this.LanguageSettingGroupBox.Text = "Language";
            // 
            // OpenLanguageSettingsButton
            // 
            this.OpenLanguageSettingsButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.OpenLanguageSettingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.OpenLanguageSettingsButton.FlatAppearance.BorderSize = 0;
            this.OpenLanguageSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenLanguageSettingsButton.Location = new System.Drawing.Point(53, 59);
            this.OpenLanguageSettingsButton.Name = "OpenLanguageSettingsButton";
            this.OpenLanguageSettingsButton.Size = new System.Drawing.Size(190, 23);
            this.OpenLanguageSettingsButton.TabIndex = 4;
            this.OpenLanguageSettingsButton.Text = "Open Language Settings";
            this.OpenLanguageSettingsButton.UseVisualStyleBackColor = false;
            this.OpenLanguageSettingsButton.Click += new System.EventHandler(this.OpenLanguageSettingsButton_Click);
            // 
            // LanguageSettingsInfoLabel
            // 
            this.LanguageSettingsInfoLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LanguageSettingsInfoLabel.Location = new System.Drawing.Point(3, 16);
            this.LanguageSettingsInfoLabel.Name = "LanguageSettingsInfoLabel";
            this.LanguageSettingsInfoLabel.Size = new System.Drawing.Size(291, 20);
            this.LanguageSettingsInfoLabel.TabIndex = 4;
            this.LanguageSettingsInfoLabel.Text = "Language Settings is at another window.";
            this.LanguageSettingsInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WindowShadowGroupBox
            // 
            this.WindowShadowGroupBox.Controls.Add(this.WindowShadowCheckBox);
            this.WindowShadowGroupBox.ForeColor = System.Drawing.Color.White;
            this.WindowShadowGroupBox.Location = new System.Drawing.Point(3, 220);
            this.WindowShadowGroupBox.Name = "WindowShadowGroupBox";
            this.WindowShadowGroupBox.Size = new System.Drawing.Size(297, 114);
            this.WindowShadowGroupBox.TabIndex = 4;
            this.WindowShadowGroupBox.TabStop = false;
            this.WindowShadowGroupBox.Text = "Window Shadow";
            // 
            // WindowShadowCheckBox
            // 
            this.WindowShadowCheckBox.Location = new System.Drawing.Point(47, 38);
            this.WindowShadowCheckBox.Name = "WindowShadowCheckBox";
            this.WindowShadowCheckBox.Size = new System.Drawing.Size(202, 39);
            this.WindowShadowCheckBox.TabIndex = 5;
            this.WindowShadowCheckBox.Text = "Enabled";
            this.WindowShadowCheckBox.UseVisualStyleBackColor = true;
            this.WindowShadowCheckBox.CheckedChanged += new System.EventHandler(this.WindowShadowCheckButton_CheckedChanged);
            // 
            // UISettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Arial", 8.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "UISettings";
            this.Size = new System.Drawing.Size(492, 340);
            this.Load += new System.EventHandler(this.UISettingscs_Load);
            this.SaveWarningGroupBox.ResumeLayout(false);
            this.SaveWarningGroupBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.LanguageSettingGroupBox.ResumeLayout(false);
            this.WindowShadowGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SaveWarningGroupBox;
        private System.Windows.Forms.Label SaveWarningIntervalInfo;
        private System.Windows.Forms.TextBox SaveWarningTextBox;
        private System.Windows.Forms.CheckBox SaveWarningCheckBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox LanguageSettingGroupBox;
        private System.Windows.Forms.Button OpenLanguageSettingsButton;
        private System.Windows.Forms.Label LanguageSettingsInfoLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox WindowShadowGroupBox;
        private System.Windows.Forms.CheckBox WindowShadowCheckBox;
    }
}
