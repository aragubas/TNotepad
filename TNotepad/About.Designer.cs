using TaiyouUI;

namespace TNotepad
{
    partial class About
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
            this.InfosLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LicenseView = new taiyouRichTextBox();
            this.ExitButton = new taiyouButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // InfosLabel
            // 
            this.InfosLabel.AutoSize = true;
            this.InfosLabel.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfosLabel.Location = new System.Drawing.Point(12, 129);
            this.InfosLabel.Name = "InfosLabel";
            this.InfosLabel.Size = new System.Drawing.Size(90, 13);
            this.InfosLabel.TabIndex = 0;
            this.InfosLabel.Text = "2021 - Aragubas\r\n";
            this.InfosLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TNotepad.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LicenseView
            // 
            this.LicenseView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LicenseView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LicenseView.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LicenseView.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LicenseView.Location = new System.Drawing.Point(285, 12);
            this.LicenseView.Name = "LicenseView";
            this.LicenseView.ReadOnly = true;
            this.LicenseView.Size = new System.Drawing.Size(365, 304);
            this.LicenseView.TabIndex = 2;
            this.LicenseView.Text = "Loading apache license...";
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Location = new System.Drawing.Point(12, 287);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 29);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.LicenseView);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.InfosLabel);
            this.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "About";
            this.Size = new System.Drawing.Size(662, 328);
            this.Load += new System.EventHandler(this.About_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InfosLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private taiyouRichTextBox LicenseView;
        private taiyouButton ExitButton;
    }
}