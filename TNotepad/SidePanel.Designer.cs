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
            this.AboutButton = new TaiyouUI.taiyouButton();
            this.SettingsButton = new TaiyouUI.taiyouButton();
            this.OpenFileButton = new TaiyouUI.taiyouButton();
            this.NewTabButton = new TaiyouUI.taiyouButton();
            this.ProgramNameLabel = new System.Windows.Forms.Label();
            this.HideShowButton = new TaiyouUI.taiyouButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.QuickSettings = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
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
            this.panel2.Size = new System.Drawing.Size(84, 332);
            this.panel2.TabIndex = 0;
            // 
            // AboutButton
            // 
            this.AboutButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AboutButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AboutButton.FlatAppearance.BorderSize = 0;
            this.AboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutButton.Location = new System.Drawing.Point(0, 81);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(84, 25);
            this.AboutButton.TabIndex = 0;
            this.AboutButton.TabStop = false;
            this.AboutButton.Text = "About";
            this.AboutButton.UseVisualStyleBackColor = false;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingsButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SettingsButton.FlatAppearance.BorderSize = 0;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Location = new System.Drawing.Point(0, 56);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(84, 25);
            this.SettingsButton.TabIndex = 0;
            this.SettingsButton.TabStop = false;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = false;
            this.SettingsButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.OpenFileButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.OpenFileButton.FlatAppearance.BorderSize = 0;
            this.OpenFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenFileButton.Location = new System.Drawing.Point(0, 29);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(84, 27);
            this.OpenFileButton.TabIndex = 0;
            this.OpenFileButton.TabStop = false;
            this.OpenFileButton.Text = "Open File";
            this.OpenFileButton.UseVisualStyleBackColor = false;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // NewTabButton
            // 
            this.NewTabButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.NewTabButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.NewTabButton.FlatAppearance.BorderSize = 0;
            this.NewTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewTabButton.Location = new System.Drawing.Point(0, 0);
            this.NewTabButton.Name = "NewTabButton";
            this.NewTabButton.Size = new System.Drawing.Size(84, 29);
            this.NewTabButton.TabIndex = 0;
            this.NewTabButton.TabStop = false;
            this.NewTabButton.Text = "New Tab";
            this.NewTabButton.UseVisualStyleBackColor = false;
            this.NewTabButton.Click += new System.EventHandler(this.NewTabButton_Click);
            // 
            // ProgramNameLabel
            // 
            this.ProgramNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgramNameLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgramNameLabel.Location = new System.Drawing.Point(3, 0);
            this.ProgramNameLabel.Name = "ProgramNameLabel";
            this.ProgramNameLabel.Size = new System.Drawing.Size(118, 51);
            this.ProgramNameLabel.TabIndex = 0;
            this.ProgramNameLabel.Text = "TabNotepad";
            this.ProgramNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HideShowButton
            // 
            this.HideShowButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HideShowButton.FlatAppearance.BorderSize = 0;
            this.HideShowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HideShowButton.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HideShowButton.Location = new System.Drawing.Point(96, 48);
            this.HideShowButton.Name = "HideShowButton";
            this.HideShowButton.Size = new System.Drawing.Size(25, 25);
            this.HideShowButton.TabIndex = 0;
            this.HideShowButton.TabStop = false;
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
            this.QuickSettings.Location = new System.Drawing.Point(96, 79);
            this.QuickSettings.Name = "QuickSettings";
            this.QuickSettings.Size = new System.Drawing.Size(25, 302);
            this.QuickSettings.TabIndex = 0;
            this.QuickSettings.Visible = false;
            // 
            // SidePanel
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.QuickSettings);
            this.Controls.Add(this.HideShowButton);
            this.Controls.Add(this.ProgramNameLabel);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SidePanel";
            this.Size = new System.Drawing.Size(124, 384);
            this.Load += new System.EventHandler(this.SidePanel_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.SidePanel_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.SidePanel_DragEnter);
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.SidePanel_DragOver);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private taiyouButton OpenFileButton;
        private taiyouButton NewTabButton;
        private System.Windows.Forms.Label ProgramNameLabel;
        private taiyouButton HideShowButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private taiyouButton SettingsButton;
        private taiyouButton AboutButton;
        private System.Windows.Forms.Panel QuickSettings;
    }
}
