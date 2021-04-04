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
            this.AvaliableThemesListBox = new TNotepad.taiyouListBox();
            this.TopThingsPanel = new System.Windows.Forms.Panel();
            this.SelectedThemeTextBox = new TNotepad.taiyouTextBox();
            this.SelectedThemeInfoLabel = new System.Windows.Forms.Label();
            this.SelectThemeButton = new TNotepad.taiyouButton();
            this.TopThingsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AvaliableThemesListBox
            // 
            this.AvaliableThemesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AvaliableThemesListBox.FormattingEnabled = true;
            this.AvaliableThemesListBox.Location = new System.Drawing.Point(6, 36);
            this.AvaliableThemesListBox.Name = "AvaliableThemesListBox";
            this.AvaliableThemesListBox.Size = new System.Drawing.Size(420, 225);
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
            this.TopThingsPanel.Size = new System.Drawing.Size(423, 27);
            this.TopThingsPanel.TabIndex = 1;
            // 
            // SelectedThemeTextBox
            // 
            this.SelectedThemeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SelectedThemeTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.SelectedThemeTextBox.Location = new System.Drawing.Point(103, 0);
            this.SelectedThemeTextBox.Name = "SelectedThemeTextBox";
            this.SelectedThemeTextBox.Size = new System.Drawing.Size(320, 20);
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
            this.SelectThemeButton.Location = new System.Drawing.Point(6, 270);
            this.SelectThemeButton.Name = "SelectThemeButton";
            this.SelectThemeButton.Size = new System.Drawing.Size(420, 23);
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
            this.Size = new System.Drawing.Size(429, 301);
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
