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
    partial class EncodingSelector
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EncodingInfoLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new TaiyouUI.taiyouComboBox();
            this.button1 = new TaiyouUI.taiyouButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SetAsDefaultEncodingCheckbox = new TaiyouUI.taiyouCheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EncodingInfoLabel
            // 
            this.EncodingInfoLabel.AutoSize = true;
            this.EncodingInfoLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.EncodingInfoLabel.Location = new System.Drawing.Point(0, 0);
            this.EncodingInfoLabel.Name = "EncodingInfoLabel";
            this.EncodingInfoLabel.Size = new System.Drawing.Size(65, 15);
            this.EncodingInfoLabel.TabIndex = 0;
            this.EncodingInfoLabel.Text = "Encoding: ";
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "UTF-7",
            "UTF-8",
            "UTF-32",
            "UNICODE",
            "ASCII"});
            this.comboBox1.Location = new System.Drawing.Point(65, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(318, 23);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(149, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Save and Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.EncodingInfoLabel);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 27);
            this.panel1.TabIndex = 4;
            // 
            // SetAsDefaultEncodingCheckbox
            // 
            this.SetAsDefaultEncodingCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SetAsDefaultEncodingCheckbox.Location = new System.Drawing.Point(12, 52);
            this.SetAsDefaultEncodingCheckbox.Name = "SetAsDefaultEncodingCheckbox";
            this.SetAsDefaultEncodingCheckbox.Size = new System.Drawing.Size(383, 40);
            this.SetAsDefaultEncodingCheckbox.TabIndex = 5;
            this.SetAsDefaultEncodingCheckbox.Text = "Set selected encoding as default for new documents";
            this.SetAsDefaultEncodingCheckbox.UseVisualStyleBackColor = true;
            // 
            // EncodingSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SetAsDefaultEncodingCheckbox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "EncodingSelector";
            this.Size = new System.Drawing.Size(407, 142);
            this.Load += new System.EventHandler(this.EncodingSelector_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label EncodingInfoLabel;
        private taiyouComboBox comboBox1;
        private taiyouButton button1;
        private System.Windows.Forms.Panel panel1;
        private taiyouCheckBox SetAsDefaultEncodingCheckbox;
    }
}