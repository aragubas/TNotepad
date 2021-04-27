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

namespace TNotepad
{
    partial class SettingsTab
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
            this.SideOptionsPanel = new System.Windows.Forms.Panel();
            this.OptionsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.UISettingsPanelButton = new taiyouButton();
            this.TextEditorSettingsPanelButton = new taiyouButton();
            this.ApplyChangesButton = new taiyouButton();
            this.SideOptionsPanel.SuspendLayout();
            this.OptionsFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SideOptionsPanel
            // 
            this.SideOptionsPanel.Controls.Add(this.OptionsFlowLayoutPanel);
            this.SideOptionsPanel.Controls.Add(this.ApplyChangesButton);
            this.SideOptionsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideOptionsPanel.Location = new System.Drawing.Point(0, 0);
            this.SideOptionsPanel.Name = "SideOptionsPanel";
            this.SideOptionsPanel.Size = new System.Drawing.Size(114, 414);
            this.SideOptionsPanel.TabIndex = 2;
            // 
            // OptionsFlowLayoutPanel
            // 
            this.OptionsFlowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OptionsFlowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OptionsFlowLayoutPanel.Controls.Add(this.UISettingsPanelButton);
            this.OptionsFlowLayoutPanel.Controls.Add(this.TextEditorSettingsPanelButton);
            this.OptionsFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.OptionsFlowLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.OptionsFlowLayoutPanel.Name = "OptionsFlowLayoutPanel";
            this.OptionsFlowLayoutPanel.Size = new System.Drawing.Size(106, 377);
            this.OptionsFlowLayoutPanel.TabIndex = 2;
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsPanel.Location = new System.Drawing.Point(114, 0);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(459, 414);
            this.SettingsPanel.TabIndex = 3;
            // 
            // UISettingsPanelButton
            // 
            this.UISettingsPanelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.UISettingsPanelButton.FlatAppearance.BorderSize = 0;
            this.UISettingsPanelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UISettingsPanelButton.ForeColor = System.Drawing.Color.White;
            this.UISettingsPanelButton.Location = new System.Drawing.Point(3, 3);
            this.UISettingsPanelButton.Name = "UISettingsPanelButton";
            this.UISettingsPanelButton.Size = new System.Drawing.Size(90, 23);
            this.UISettingsPanelButton.TabIndex = 0;
            this.UISettingsPanelButton.Text = "UI";
            this.UISettingsPanelButton.UseVisualStyleBackColor = false;
            this.UISettingsPanelButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextEditorSettingsPanelButton
            // 
            this.TextEditorSettingsPanelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.TextEditorSettingsPanelButton.FlatAppearance.BorderSize = 0;
            this.TextEditorSettingsPanelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TextEditorSettingsPanelButton.ForeColor = System.Drawing.Color.White;
            this.TextEditorSettingsPanelButton.Location = new System.Drawing.Point(3, 32);
            this.TextEditorSettingsPanelButton.Name = "TextEditorSettingsPanelButton";
            this.TextEditorSettingsPanelButton.Size = new System.Drawing.Size(90, 23);
            this.TextEditorSettingsPanelButton.TabIndex = 1;
            this.TextEditorSettingsPanelButton.Text = "Text Editor";
            this.TextEditorSettingsPanelButton.UseVisualStyleBackColor = false;
            this.TextEditorSettingsPanelButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // ApplyChangesButton
            // 
            this.ApplyChangesButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ApplyChangesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ApplyChangesButton.FlatAppearance.BorderSize = 0;
            this.ApplyChangesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApplyChangesButton.ForeColor = System.Drawing.Color.White;
            this.ApplyChangesButton.Location = new System.Drawing.Point(3, 386);
            this.ApplyChangesButton.Name = "ApplyChangesButton";
            this.ApplyChangesButton.Size = new System.Drawing.Size(108, 25);
            this.ApplyChangesButton.TabIndex = 1;
            this.ApplyChangesButton.Text = "Apply";
            this.ApplyChangesButton.UseVisualStyleBackColor = false;
            this.ApplyChangesButton.Click += new System.EventHandler(this.ApplyChangesButton_Click);
            // 
            // SettingsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SettingsPanel);
            this.Controls.Add(this.SideOptionsPanel);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SettingsTab";
            this.Size = new System.Drawing.Size(573, 414);
            this.Load += new System.EventHandler(this.SettingsTab_Load);
            this.SideOptionsPanel.ResumeLayout(false);
            this.OptionsFlowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private taiyouButton ApplyChangesButton;
        private System.Windows.Forms.Panel SideOptionsPanel;
        private System.Windows.Forms.Panel SettingsPanel;
        private System.Windows.Forms.FlowLayoutPanel OptionsFlowLayoutPanel;
        private taiyouButton UISettingsPanelButton;
        private taiyouButton TextEditorSettingsPanelButton;
    }
}
