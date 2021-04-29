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
    partial class ThemeSettings
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
            this.AvaliableThemesListBox = new TaiyouUI.taiyouListBox();
            this.TopThingsPanel = new System.Windows.Forms.Panel();
            this.SelectedThemeTextBox = new TaiyouUI.taiyouTextBox();
            this.SelectedThemeInfoLabel = new System.Windows.Forms.Label();
            this.SelectThemeButton = new TaiyouUI.taiyouButton();
            this.TopThingsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AvaliableThemesListBox
            // 
            this.AvaliableThemesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AvaliableThemesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AvaliableThemesListBox.FormattingEnabled = true;
            this.AvaliableThemesListBox.Location = new System.Drawing.Point(6, 36);
            this.AvaliableThemesListBox.Name = "AvaliableThemesListBox";
            this.AvaliableThemesListBox.Size = new System.Drawing.Size(392, 184);
            this.AvaliableThemesListBox.TabIndex = 0;
            this.AvaliableThemesListBox.SelectedIndexChanged += new System.EventHandler(this.AvaliableThemesListBox_SelectedIndexChanged);
            // 
            // TopThingsPanel
            // 
            this.TopThingsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TopThingsPanel.Controls.Add(this.SelectedThemeTextBox);
            this.TopThingsPanel.Controls.Add(this.SelectedThemeInfoLabel);
            this.TopThingsPanel.Location = new System.Drawing.Point(3, 3);
            this.TopThingsPanel.Name = "TopThingsPanel";
            this.TopThingsPanel.Size = new System.Drawing.Size(395, 27);
            this.TopThingsPanel.TabIndex = 1;
            this.TopThingsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TopThingsPanel_Paint);
            // 
            // SelectedThemeTextBox
            // 
            this.SelectedThemeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SelectedThemeTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.SelectedThemeTextBox.Location = new System.Drawing.Point(103, 0);
            this.SelectedThemeTextBox.Name = "SelectedThemeTextBox";
            this.SelectedThemeTextBox.Size = new System.Drawing.Size(292, 20);
            this.SelectedThemeTextBox.TabIndex = 1;
            // 
            // SelectedThemeInfoLabel
            // 
            this.SelectedThemeInfoLabel.AutoSize = true;
            this.SelectedThemeInfoLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SelectedThemeInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedThemeInfoLabel.Location = new System.Drawing.Point(0, 0);
            this.SelectedThemeInfoLabel.Name = "SelectedThemeInfoLabel";
            this.SelectedThemeInfoLabel.Size = new System.Drawing.Size(103, 17);
            this.SelectedThemeInfoLabel.TabIndex = 0;
            this.SelectedThemeInfoLabel.Text = "Current Theme";
            // 
            // SelectThemeButton
            // 
            this.SelectThemeButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectThemeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectThemeButton.Location = new System.Drawing.Point(6, 232);
            this.SelectThemeButton.Name = "SelectThemeButton";
            this.SelectThemeButton.Size = new System.Drawing.Size(392, 23);
            this.SelectThemeButton.TabIndex = 2;
            this.SelectThemeButton.Text = "Select Theme";
            this.SelectThemeButton.UseVisualStyleBackColor = true;
            this.SelectThemeButton.Click += new System.EventHandler(this.SelectThemeButton_Click);
            // 
            // ThemeSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SelectThemeButton);
            this.Controls.Add(this.TopThingsPanel);
            this.Controls.Add(this.AvaliableThemesListBox);
            this.Name = "ThemeSettings";
            this.Size = new System.Drawing.Size(401, 263);
            this.Load += new System.EventHandler(this.ThemeSettings_Load);
            this.TopThingsPanel.ResumeLayout(false);
            this.TopThingsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private taiyouListBox AvaliableThemesListBox;
        private System.Windows.Forms.Panel TopThingsPanel;
        private System.Windows.Forms.Label SelectedThemeInfoLabel;
        private taiyouTextBox SelectedThemeTextBox;
        private taiyouButton SelectThemeButton;
    }
}
