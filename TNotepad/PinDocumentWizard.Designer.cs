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
            this.DocNameThingLabel = new System.Windows.Forms.Label();
            this.DocPinNameTextbox = new TNotepad.taiyouTextBox();
            this.PinDocButton = new TNotepad.taiyouButton();
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
            // DocPinNameTextbox
            // 
            this.DocPinNameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DocPinNameTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DocPinNameTextbox.ForeColor = System.Drawing.Color.White;
            this.DocPinNameTextbox.Location = new System.Drawing.Point(38, 0);
            this.DocPinNameTextbox.Name = "DocPinNameTextbox";
            this.DocPinNameTextbox.Size = new System.Drawing.Size(370, 20);
            this.DocPinNameTextbox.TabIndex = 1;
            this.DocPinNameTextbox.TextChanged += new System.EventHandler(this.DocPinNameTextbox_TextChanged);
            // 
            // PinDocButton
            // 
            this.PinDocButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.panel1.Controls.Add(this.DocPinNameTextbox);
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
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PinDocButton);
            this.Name = "PinDocumentWizard";
            this.Size = new System.Drawing.Size(432, 84);
            this.Load += new System.EventHandler(this.PinDocumentWizard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label DocNameThingLabel;
        private taiyouTextBox DocPinNameTextbox;
        private taiyouButton PinDocButton;
        private System.Windows.Forms.Panel panel1;
    }
}