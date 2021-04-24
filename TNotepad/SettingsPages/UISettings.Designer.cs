using TaiyouUI;

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
            this.flowLayoutPanel1 = new taiyouFlowLayoutPanel();
            this.SaveWarningGroupBox = new taiyouGroupBox();
            this.SaveWarningCheckBox = new taiyouCheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SaveWarningTextBox = new taiyouTextBox();
            this.SaveWarningIntervalInfo = new System.Windows.Forms.Label();
            this.LanguageSettingGroupBox = new taiyouGroupBox();
            this.OpenLanguageSettingsButton = new taiyouButton();
            this.LanguageSettingsInfoLabel = new System.Windows.Forms.Label();
            this.WindowShadowGroupBox = new taiyouGroupBox();
            this.WindowShadowCheckBox = new taiyouCheckBox();
            this.SmoothVisualElementsGroupBox = new taiyouGroupBox();
            this.SmoothVisualElementsCheckbox = new taiyouCheckBox();
            this.StretchResizeGroupbox = new taiyouGroupBox();
            this.StretchResizeCheckbox = new taiyouCheckBox();
            this.ThemeSettingsGroupBox = new taiyouGroupBox();
            this.OpenThemeSettingsButton = new taiyouButton();
            this.ThemeSettingsInfoLabel = new System.Windows.Forms.Label();
            this.DeFlickerGroupBox = new taiyouGroupBox();
            this.DeFlickerCheckBox = new taiyouCheckBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.SaveWarningGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.LanguageSettingGroupBox.SuspendLayout();
            this.WindowShadowGroupBox.SuspendLayout();
            this.SmoothVisualElementsGroupBox.SuspendLayout();
            this.StretchResizeGroupbox.SuspendLayout();
            this.ThemeSettingsGroupBox.SuspendLayout();
            this.DeFlickerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.SaveWarningGroupBox);
            this.flowLayoutPanel1.Controls.Add(this.LanguageSettingGroupBox);
            this.flowLayoutPanel1.Controls.Add(this.WindowShadowGroupBox);
            this.flowLayoutPanel1.Controls.Add(this.SmoothVisualElementsGroupBox);
            this.flowLayoutPanel1.Controls.Add(this.StretchResizeGroupbox);
            this.flowLayoutPanel1.Controls.Add(this.ThemeSettingsGroupBox);
            this.flowLayoutPanel1.Controls.Add(this.DeFlickerGroupBox);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(733, 397);
            this.flowLayoutPanel1.TabIndex = 3;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // SaveWarningGroupBox
            // 
            this.SaveWarningGroupBox.AutoSize = true;
            this.SaveWarningGroupBox.Controls.Add(this.SaveWarningCheckBox);
            this.SaveWarningGroupBox.Controls.Add(this.panel1);
            this.SaveWarningGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveWarningGroupBox.Location = new System.Drawing.Point(3, 3);
            this.SaveWarningGroupBox.Name = "SaveWarningGroupBox";
            this.SaveWarningGroupBox.Size = new System.Drawing.Size(208, 71);
            this.SaveWarningGroupBox.TabIndex = 1;
            this.SaveWarningGroupBox.TabStop = false;
            this.SaveWarningGroupBox.Text = "Save Warning";
            // 
            // SaveWarningCheckBox
            // 
            this.SaveWarningCheckBox.AutoSize = true;
            this.SaveWarningCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveWarningCheckBox.Location = new System.Drawing.Point(3, 16);
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
            this.panel1.Location = new System.Drawing.Point(3, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 20);
            this.panel1.TabIndex = 4;
            // 
            // SaveWarningTextBox
            // 
            this.SaveWarningTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SaveWarningTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveWarningTextBox.Location = new System.Drawing.Point(112, 0);
            this.SaveWarningTextBox.Name = "SaveWarningTextBox";
            this.SaveWarningTextBox.Size = new System.Drawing.Size(90, 20);
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
            // LanguageSettingGroupBox
            // 
            this.LanguageSettingGroupBox.Controls.Add(this.OpenLanguageSettingsButton);
            this.LanguageSettingGroupBox.Controls.Add(this.LanguageSettingsInfoLabel);
            this.LanguageSettingGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LanguageSettingGroupBox.Location = new System.Drawing.Point(3, 80);
            this.LanguageSettingGroupBox.Name = "LanguageSettingGroupBox";
            this.LanguageSettingGroupBox.Size = new System.Drawing.Size(244, 85);
            this.LanguageSettingGroupBox.TabIndex = 3;
            this.LanguageSettingGroupBox.TabStop = false;
            this.LanguageSettingGroupBox.Text = "Language";
            // 
            // OpenLanguageSettingsButton
            // 
            this.OpenLanguageSettingsButton.FlatAppearance.BorderSize = 0;
            this.OpenLanguageSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenLanguageSettingsButton.Location = new System.Drawing.Point(27, 47);
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
            this.LanguageSettingsInfoLabel.Size = new System.Drawing.Size(238, 20);
            this.LanguageSettingsInfoLabel.TabIndex = 4;
            this.LanguageSettingsInfoLabel.Text = "Language Settings is at another window.";
            this.LanguageSettingsInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WindowShadowGroupBox
            // 
            this.WindowShadowGroupBox.AutoSize = true;
            this.WindowShadowGroupBox.Controls.Add(this.WindowShadowCheckBox);
            this.WindowShadowGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WindowShadowGroupBox.Location = new System.Drawing.Point(3, 171);
            this.WindowShadowGroupBox.Name = "WindowShadowGroupBox";
            this.WindowShadowGroupBox.Size = new System.Drawing.Size(232, 37);
            this.WindowShadowGroupBox.TabIndex = 4;
            this.WindowShadowGroupBox.TabStop = false;
            this.WindowShadowGroupBox.Text = "Window Shadow";
            // 
            // WindowShadowCheckBox
            // 
            this.WindowShadowCheckBox.AutoSize = true;
            this.WindowShadowCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WindowShadowCheckBox.Location = new System.Drawing.Point(3, 16);
            this.WindowShadowCheckBox.Name = "WindowShadowCheckBox";
            this.WindowShadowCheckBox.Size = new System.Drawing.Size(226, 18);
            this.WindowShadowCheckBox.TabIndex = 5;
            this.WindowShadowCheckBox.Text = "Draw a shadow behind the main window";
            this.WindowShadowCheckBox.UseVisualStyleBackColor = true;
            this.WindowShadowCheckBox.CheckedChanged += new System.EventHandler(this.WindowShadowCheckButton_CheckedChanged);
            // 
            // SmoothVisualElementsGroupBox
            // 
            this.SmoothVisualElementsGroupBox.AutoSize = true;
            this.SmoothVisualElementsGroupBox.Controls.Add(this.SmoothVisualElementsCheckbox);
            this.SmoothVisualElementsGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SmoothVisualElementsGroupBox.Location = new System.Drawing.Point(3, 214);
            this.SmoothVisualElementsGroupBox.Name = "SmoothVisualElementsGroupBox";
            this.SmoothVisualElementsGroupBox.Size = new System.Drawing.Size(296, 37);
            this.SmoothVisualElementsGroupBox.TabIndex = 5;
            this.SmoothVisualElementsGroupBox.TabStop = false;
            this.SmoothVisualElementsGroupBox.Text = "Smooth visual elements";
            // 
            // SmoothVisualElementsCheckbox
            // 
            this.SmoothVisualElementsCheckbox.AutoSize = true;
            this.SmoothVisualElementsCheckbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SmoothVisualElementsCheckbox.Location = new System.Drawing.Point(3, 16);
            this.SmoothVisualElementsCheckbox.Name = "SmoothVisualElementsCheckbox";
            this.SmoothVisualElementsCheckbox.Size = new System.Drawing.Size(290, 18);
            this.SmoothVisualElementsCheckbox.TabIndex = 0;
            this.SmoothVisualElementsCheckbox.Text = "Apply antialiasing to certain custom-rendered elements";
            this.SmoothVisualElementsCheckbox.UseVisualStyleBackColor = true;
            // 
            // StretchResizeGroupbox
            // 
            this.StretchResizeGroupbox.AutoSize = true;
            this.StretchResizeGroupbox.Controls.Add(this.StretchResizeCheckbox);
            this.StretchResizeGroupbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StretchResizeGroupbox.Location = new System.Drawing.Point(3, 257);
            this.StretchResizeGroupbox.Name = "StretchResizeGroupbox";
            this.StretchResizeGroupbox.Size = new System.Drawing.Size(182, 37);
            this.StretchResizeGroupbox.TabIndex = 6;
            this.StretchResizeGroupbox.TabStop = false;
            this.StretchResizeGroupbox.Text = "Stretch when resing";
            // 
            // StretchResizeCheckbox
            // 
            this.StretchResizeCheckbox.AutoSize = true;
            this.StretchResizeCheckbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StretchResizeCheckbox.Location = new System.Drawing.Point(3, 16);
            this.StretchResizeCheckbox.Name = "StretchResizeCheckbox";
            this.StretchResizeCheckbox.Size = new System.Drawing.Size(176, 18);
            this.StretchResizeCheckbox.TabIndex = 0;
            this.StretchResizeCheckbox.Text = "Stretch window when resizing";
            this.StretchResizeCheckbox.UseVisualStyleBackColor = true;
            // 
            // ThemeSettingsGroupBox
            // 
            this.ThemeSettingsGroupBox.Controls.Add(this.OpenThemeSettingsButton);
            this.ThemeSettingsGroupBox.Controls.Add(this.ThemeSettingsInfoLabel);
            this.ThemeSettingsGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThemeSettingsGroupBox.Location = new System.Drawing.Point(3, 300);
            this.ThemeSettingsGroupBox.Name = "ThemeSettingsGroupBox";
            this.ThemeSettingsGroupBox.Size = new System.Drawing.Size(244, 85);
            this.ThemeSettingsGroupBox.TabIndex = 7;
            this.ThemeSettingsGroupBox.TabStop = false;
            this.ThemeSettingsGroupBox.Text = "Theme Chooser";
            // 
            // OpenThemeSettingsButton
            // 
            this.OpenThemeSettingsButton.FlatAppearance.BorderSize = 0;
            this.OpenThemeSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenThemeSettingsButton.Location = new System.Drawing.Point(27, 47);
            this.OpenThemeSettingsButton.Name = "OpenThemeSettingsButton";
            this.OpenThemeSettingsButton.Size = new System.Drawing.Size(190, 23);
            this.OpenThemeSettingsButton.TabIndex = 4;
            this.OpenThemeSettingsButton.Text = "Open Theme Settings";
            this.OpenThemeSettingsButton.UseVisualStyleBackColor = false;
            this.OpenThemeSettingsButton.Click += new System.EventHandler(this.OpenThemeSettingsButton_Click);
            // 
            // ThemeSettingsInfoLabel
            // 
            this.ThemeSettingsInfoLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ThemeSettingsInfoLabel.Location = new System.Drawing.Point(3, 16);
            this.ThemeSettingsInfoLabel.Name = "ThemeSettingsInfoLabel";
            this.ThemeSettingsInfoLabel.Size = new System.Drawing.Size(238, 20);
            this.ThemeSettingsInfoLabel.TabIndex = 4;
            this.ThemeSettingsInfoLabel.Text = "Language Settings is at another window.";
            this.ThemeSettingsInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeFlickerGroupBox
            // 
            this.DeFlickerGroupBox.AutoSize = true;
            this.DeFlickerGroupBox.Controls.Add(this.DeFlickerCheckBox);
            this.DeFlickerGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeFlickerGroupBox.Location = new System.Drawing.Point(305, 3);
            this.DeFlickerGroupBox.Name = "DeFlickerGroupBox";
            this.DeFlickerGroupBox.Size = new System.Drawing.Size(332, 37);
            this.DeFlickerGroupBox.TabIndex = 8;
            this.DeFlickerGroupBox.TabStop = false;
            this.DeFlickerGroupBox.Text = "Window De-Flicker";
            // 
            // DeFlickerCheckBox
            // 
            this.DeFlickerCheckBox.AutoSize = true;
            this.DeFlickerCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeFlickerCheckBox.Location = new System.Drawing.Point(3, 16);
            this.DeFlickerCheckBox.Name = "DeFlickerCheckBox";
            this.DeFlickerCheckBox.Size = new System.Drawing.Size(326, 18);
            this.DeFlickerCheckBox.TabIndex = 5;
            this.DeFlickerCheckBox.Text = "Remove flickering by force-enabling Double Buffer on controls";
            this.DeFlickerCheckBox.UseVisualStyleBackColor = true;
            // 
            // UISettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Arial", 8.25F);
            this.Name = "UISettings";
            this.Size = new System.Drawing.Size(733, 397);
            this.Load += new System.EventHandler(this.UISettingscs_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.SaveWarningGroupBox.ResumeLayout(false);
            this.SaveWarningGroupBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.LanguageSettingGroupBox.ResumeLayout(false);
            this.WindowShadowGroupBox.ResumeLayout(false);
            this.WindowShadowGroupBox.PerformLayout();
            this.SmoothVisualElementsGroupBox.ResumeLayout(false);
            this.SmoothVisualElementsGroupBox.PerformLayout();
            this.StretchResizeGroupbox.ResumeLayout(false);
            this.StretchResizeGroupbox.PerformLayout();
            this.ThemeSettingsGroupBox.ResumeLayout(false);
            this.DeFlickerGroupBox.ResumeLayout(false);
            this.DeFlickerGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private taiyouGroupBox SaveWarningGroupBox;
        private System.Windows.Forms.Label SaveWarningIntervalInfo;
        private taiyouTextBox SaveWarningTextBox;
        private taiyouCheckBox SaveWarningCheckBox;
        private taiyouFlowLayoutPanel flowLayoutPanel1;
        private taiyouGroupBox LanguageSettingGroupBox;
        private taiyouButton OpenLanguageSettingsButton;
        private System.Windows.Forms.Label LanguageSettingsInfoLabel;
        private System.Windows.Forms.Panel panel1;
        private taiyouGroupBox WindowShadowGroupBox;
        private taiyouCheckBox WindowShadowCheckBox;
        private taiyouGroupBox SmoothVisualElementsGroupBox;
        private taiyouCheckBox SmoothVisualElementsCheckbox;
        private taiyouGroupBox StretchResizeGroupbox;
        private taiyouCheckBox StretchResizeCheckbox;
        private taiyouGroupBox ThemeSettingsGroupBox;
        private taiyouButton OpenThemeSettingsButton;
        private System.Windows.Forms.Label ThemeSettingsInfoLabel;
        private taiyouGroupBox DeFlickerGroupBox;
        private taiyouCheckBox DeFlickerCheckBox;
    }
}
