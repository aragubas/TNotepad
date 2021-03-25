namespace TNotepad
{
    partial class PinDocumentWizard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PinDocumentWizard));
            this.DocNameThingLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PinDocButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DocNameThingLabel
            // 
            this.DocNameThingLabel.AutoSize = true;
            this.DocNameThingLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.DocNameThingLabel.Location = new System.Drawing.Point(0, 0);
            this.DocNameThingLabel.Name = "DocNameThingLabel";
            this.DocNameThingLabel.Size = new System.Drawing.Size(38, 13);
            this.DocNameThingLabel.TabIndex = 0;
            this.DocNameThingLabel.Text = "Name:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Gray;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(38, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(370, 20);
            this.textBox1.TabIndex = 1;
            // 
            // PinDocButton
            // 
            this.PinDocButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PinDocButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.PinDocButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.PinDocButton.FlatAppearance.BorderSize = 0;
            this.PinDocButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PinDocButton.Location = new System.Drawing.Point(93, 49);
            this.PinDocButton.Name = "PinDocButton";
            this.PinDocButton.Size = new System.Drawing.Size(246, 23);
            this.PinDocButton.TabIndex = 3;
            this.PinDocButton.Text = "Pin Document";
            this.PinDocButton.UseVisualStyleBackColor = false;
            this.PinDocButton.Click += new System.EventHandler(this.PinButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.DocNameThingLabel);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 27);
            this.panel1.TabIndex = 4;
            // 
            // PinDocumentWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(432, 84);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PinDocButton);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PinDocumentWizard";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pin Document";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.PinDocumentWizard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label DocNameThingLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button PinDocButton;
        private System.Windows.Forms.Panel panel1;
    }
}