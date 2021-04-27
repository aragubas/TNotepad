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

namespace TNotepad
{
    partial class MainForm
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
            this.SidePanelView = new System.Windows.Forms.Panel();
            this.Tabs = new TNotepad.ApplicationTabs();
            this.SuspendLayout();
            // 
            // SidePanelView
            // 
            this.SidePanelView.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanelView.Location = new System.Drawing.Point(0, 0);
            this.SidePanelView.Name = "SidePanelView";
            this.SidePanelView.Size = new System.Drawing.Size(132, 443);
            this.SidePanelView.TabIndex = 0;
            // 
            // Tabs
            // 
            this.Tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tabs.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.Tabs.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Tabs.Location = new System.Drawing.Point(132, 0);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(533, 443);
            this.Tabs.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Tabs);
            this.Controls.Add(this.SidePanelView);
            this.Font = new System.Drawing.Font("Arial", 8.25F);
            this.Name = "MainForm";
            this.Size = new System.Drawing.Size(665, 443);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SidePanelView;
        private ApplicationTabs Tabs;
    }
}
