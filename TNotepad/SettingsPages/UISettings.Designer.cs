/*
   Copyright 2021 Aragubas/Paulo Otávio de Lima

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License. 
  
 */

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
            this.tableLayoutPanel1 = new TaiyouUI.taiyouTableLayoutPanel();
            this.DeFlickerGroupBox = new TaiyouUI.taiyouGroupBox();
            this.DeFlickerCheckBox = new TaiyouUI.taiyouCheckBox();
            this.StretchResizeGroupbox = new TaiyouUI.taiyouGroupBox();
            this.StretchResizeCheckbox = new TaiyouUI.taiyouCheckBox();
            this.SmoothVisualElementsGroupBox = new TaiyouUI.taiyouGroupBox();
            this.SmoothVisualElementsCheckbox = new TaiyouUI.taiyouCheckBox();
            this.WindowShadowGroupBox = new TaiyouUI.taiyouGroupBox();
            this.WindowShadowCheckBox = new TaiyouUI.taiyouCheckBox();
            this.SaveWarningGroupBox = new TaiyouUI.taiyouGroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SaveWarningTextBox = new TaiyouUI.taiyouTextBox();
            this.SaveWarningIntervalInfo = new System.Windows.Forms.Label();
            this.SaveWarningCheckBox = new TaiyouUI.taiyouCheckBox();
            this.OpenLanguageSettingsButton = new TaiyouUI.taiyouButton();
            this.OpenThemeSettingsButton = new TaiyouUI.taiyouButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.DeFlickerGroupBox.SuspendLayout();
            this.StretchResizeGroupbox.SuspendLayout();
            this.SmoothVisualElementsGroupBox.SuspendLayout();
            this.WindowShadowGroupBox.SuspendLayout();
            this.SaveWarningGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.DeFlickerGroupBox, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.StretchResizeGroupbox, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.SmoothVisualElementsGroupBox, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.WindowShadowGroupBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.SaveWarningGroupBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.OpenLanguageSettingsButton, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.OpenThemeSettingsButton, 0, 8);
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(45, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(535, 337);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // DeFlickerGroupBox
            // 
            this.DeFlickerGroupBox.Controls.Add(this.DeFlickerCheckBox);
            this.DeFlickerGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeFlickerGroupBox.Location = new System.Drawing.Point(3, 211);
            this.DeFlickerGroupBox.Name = "DeFlickerGroupBox";
            this.DeFlickerGroupBox.Size = new System.Drawing.Size(526, 45);
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
            this.DeFlickerCheckBox.Size = new System.Drawing.Size(520, 26);
            this.DeFlickerCheckBox.TabIndex = 5;
            this.DeFlickerCheckBox.Text = "Remove flickering by force-enabling Double Buffer on controls";
            this.DeFlickerCheckBox.UseVisualStyleBackColor = true;
            // 
            // StretchResizeGroupbox
            // 
            this.StretchResizeGroupbox.Controls.Add(this.StretchResizeCheckbox);
            this.StretchResizeGroupbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StretchResizeGroupbox.Location = new System.Drawing.Point(3, 168);
            this.StretchResizeGroupbox.Name = "StretchResizeGroupbox";
            this.StretchResizeGroupbox.Size = new System.Drawing.Size(526, 37);
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
            this.StretchResizeCheckbox.Size = new System.Drawing.Size(520, 18);
            this.StretchResizeCheckbox.TabIndex = 0;
            this.StretchResizeCheckbox.Text = "Stretch window when resizing";
            this.StretchResizeCheckbox.UseVisualStyleBackColor = true;
            // 
            // SmoothVisualElementsGroupBox
            // 
            this.SmoothVisualElementsGroupBox.Controls.Add(this.SmoothVisualElementsCheckbox);
            this.SmoothVisualElementsGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SmoothVisualElementsGroupBox.Location = new System.Drawing.Point(3, 125);
            this.SmoothVisualElementsGroupBox.Name = "SmoothVisualElementsGroupBox";
            this.SmoothVisualElementsGroupBox.Size = new System.Drawing.Size(526, 37);
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
            this.SmoothVisualElementsCheckbox.Size = new System.Drawing.Size(520, 18);
            this.SmoothVisualElementsCheckbox.TabIndex = 0;
            this.SmoothVisualElementsCheckbox.Text = "Apply antialiasing to certain custom-rendered elements";
            this.SmoothVisualElementsCheckbox.UseVisualStyleBackColor = true;
            // 
            // WindowShadowGroupBox
            // 
            this.WindowShadowGroupBox.Controls.Add(this.WindowShadowCheckBox);
            this.WindowShadowGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WindowShadowGroupBox.Location = new System.Drawing.Point(3, 81);
            this.WindowShadowGroupBox.Name = "WindowShadowGroupBox";
            this.WindowShadowGroupBox.Size = new System.Drawing.Size(526, 38);
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
            this.WindowShadowCheckBox.Size = new System.Drawing.Size(520, 19);
            this.WindowShadowCheckBox.TabIndex = 5;
            this.WindowShadowCheckBox.Text = "Draw a shadow behind the main window";
            this.WindowShadowCheckBox.UseVisualStyleBackColor = true;
            // 
            // SaveWarningGroupBox
            // 
            this.SaveWarningGroupBox.Controls.Add(this.panel1);
            this.SaveWarningGroupBox.Controls.Add(this.SaveWarningCheckBox);
            this.SaveWarningGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveWarningGroupBox.Location = new System.Drawing.Point(3, 3);
            this.SaveWarningGroupBox.Name = "SaveWarningGroupBox";
            this.SaveWarningGroupBox.Size = new System.Drawing.Size(526, 72);
            this.SaveWarningGroupBox.TabIndex = 1;
            this.SaveWarningGroupBox.TabStop = false;
            this.SaveWarningGroupBox.Text = "Save Warning";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.SaveWarningTextBox);
            this.panel1.Controls.Add(this.SaveWarningIntervalInfo);
            this.panel1.Location = new System.Drawing.Point(3, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 20);
            this.panel1.TabIndex = 4;
            // 
            // SaveWarningTextBox
            // 
            this.SaveWarningTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SaveWarningTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveWarningTextBox.Location = new System.Drawing.Point(112, 0);
            this.SaveWarningTextBox.Name = "SaveWarningTextBox";
            this.SaveWarningTextBox.Size = new System.Drawing.Size(408, 20);
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
            // SaveWarningCheckBox
            // 
            this.SaveWarningCheckBox.AutoSize = true;
            this.SaveWarningCheckBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.SaveWarningCheckBox.Location = new System.Drawing.Point(3, 16);
            this.SaveWarningCheckBox.Name = "SaveWarningCheckBox";
            this.SaveWarningCheckBox.Size = new System.Drawing.Size(520, 32);
            this.SaveWarningCheckBox.TabIndex = 0;
            this.SaveWarningCheckBox.Text = "Show the time a document has been\r\nnot saved on status bar";
            this.SaveWarningCheckBox.UseVisualStyleBackColor = true;
            // 
            // OpenLanguageSettingsButton
            // 
            this.OpenLanguageSettingsButton.AutoSize = true;
            this.OpenLanguageSettingsButton.FlatAppearance.BorderSize = 0;
            this.OpenLanguageSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenLanguageSettingsButton.Location = new System.Drawing.Point(3, 262);
            this.OpenLanguageSettingsButton.Name = "OpenLanguageSettingsButton";
            this.OpenLanguageSettingsButton.Size = new System.Drawing.Size(526, 32);
            this.OpenLanguageSettingsButton.TabIndex = 9;
            this.OpenLanguageSettingsButton.Text = "Open Language Settings";
            this.OpenLanguageSettingsButton.UseVisualStyleBackColor = false;
            this.OpenLanguageSettingsButton.Click += new System.EventHandler(this.OpenLanguageSettingsButton_Click);
            // 
            // OpenThemeSettingsButton
            // 
            this.OpenThemeSettingsButton.FlatAppearance.BorderSize = 0;
            this.OpenThemeSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenThemeSettingsButton.Location = new System.Drawing.Point(3, 300);
            this.OpenThemeSettingsButton.Name = "OpenThemeSettingsButton";
            this.OpenThemeSettingsButton.Size = new System.Drawing.Size(526, 32);
            this.OpenThemeSettingsButton.TabIndex = 11;
            this.OpenThemeSettingsButton.Text = "Open Theme Settings";
            this.OpenThemeSettingsButton.UseVisualStyleBackColor = false;
            this.OpenThemeSettingsButton.Click += new System.EventHandler(this.OpenThemeSettingsButton_Click);
            // 
            // UISettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Arial", 8.25F);
            this.Name = "UISettings";
            this.Size = new System.Drawing.Size(624, 493);
            this.Load += new System.EventHandler(this.UISettingscs_Load);
            this.SizeChanged += new System.EventHandler(this.UISettings_SizeChanged);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.DeFlickerGroupBox.ResumeLayout(false);
            this.DeFlickerGroupBox.PerformLayout();
            this.StretchResizeGroupbox.ResumeLayout(false);
            this.StretchResizeGroupbox.PerformLayout();
            this.SmoothVisualElementsGroupBox.ResumeLayout(false);
            this.SmoothVisualElementsGroupBox.PerformLayout();
            this.WindowShadowGroupBox.ResumeLayout(false);
            this.WindowShadowGroupBox.PerformLayout();
            this.SaveWarningGroupBox.ResumeLayout(false);
            this.SaveWarningGroupBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private taiyouTableLayoutPanel tableLayoutPanel1;
        private taiyouGroupBox DeFlickerGroupBox;
        private taiyouCheckBox DeFlickerCheckBox;
        private taiyouGroupBox StretchResizeGroupbox;
        private taiyouCheckBox StretchResizeCheckbox;
        private taiyouGroupBox SmoothVisualElementsGroupBox;
        private taiyouCheckBox SmoothVisualElementsCheckbox;
        private taiyouGroupBox WindowShadowGroupBox;
        private taiyouCheckBox WindowShadowCheckBox;
        private taiyouGroupBox SaveWarningGroupBox;
        private System.Windows.Forms.Panel panel1;
        private taiyouTextBox SaveWarningTextBox;
        private System.Windows.Forms.Label SaveWarningIntervalInfo;
        private taiyouCheckBox SaveWarningCheckBox;
        private taiyouButton OpenLanguageSettingsButton;
        private taiyouButton OpenThemeSettingsButton;
    }
}
