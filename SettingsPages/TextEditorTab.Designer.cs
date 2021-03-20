
namespace TNotepad.SettingsPages
{
    partial class TextEditorTab
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.WordWrapGroupBox = new System.Windows.Forms.GroupBox();
            this.WordWrapToggleButton = new System.Windows.Forms.Button();
            this.WordWrap_Enable = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1.SuspendLayout();
            this.WordWrapGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.flowLayoutPanel1.Controls.Add(this.WordWrapGroupBox);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(482, 378);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // WordWrapGroupBox
            // 
            this.WordWrapGroupBox.Controls.Add(this.WordWrapToggleButton);
            this.WordWrapGroupBox.Controls.Add(this.WordWrap_Enable);
            this.WordWrapGroupBox.ForeColor = System.Drawing.Color.White;
            this.WordWrapGroupBox.Location = new System.Drawing.Point(3, 3);
            this.WordWrapGroupBox.Name = "WordWrapGroupBox";
            this.WordWrapGroupBox.Size = new System.Drawing.Size(155, 67);
            this.WordWrapGroupBox.TabIndex = 1;
            this.WordWrapGroupBox.TabStop = false;
            this.WordWrapGroupBox.Text = "Word Wrap";
            // 
            // WordWrapToggleButton
            // 
            this.WordWrapToggleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.WordWrapToggleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WordWrapToggleButton.FlatAppearance.BorderSize = 0;
            this.WordWrapToggleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WordWrapToggleButton.Location = new System.Drawing.Point(3, 41);
            this.WordWrapToggleButton.Name = "WordWrapToggleButton";
            this.WordWrapToggleButton.Size = new System.Drawing.Size(149, 23);
            this.WordWrapToggleButton.TabIndex = 2;
            this.WordWrapToggleButton.Text = "Toggle";
            this.WordWrapToggleButton.UseVisualStyleBackColor = false;
            this.WordWrapToggleButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // WordWrap_Enable
            // 
            this.WordWrap_Enable.AutoCheck = false;
            this.WordWrap_Enable.Dock = System.Windows.Forms.DockStyle.Top;
            this.WordWrap_Enable.Enabled = false;
            this.WordWrap_Enable.Location = new System.Drawing.Point(3, 16);
            this.WordWrap_Enable.Name = "WordWrap_Enable";
            this.WordWrap_Enable.Size = new System.Drawing.Size(149, 25);
            this.WordWrap_Enable.TabIndex = 2;
            this.WordWrap_Enable.Text = "Enabled";
            this.WordWrap_Enable.UseVisualStyleBackColor = true;
            // 
            // TextEditorTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "TextEditorTab";
            this.Size = new System.Drawing.Size(482, 378);
            this.Load += new System.EventHandler(this.TextEditorTab_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.WordWrapGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox WordWrapGroupBox;
        private System.Windows.Forms.RadioButton WordWrap_Enable;
        private System.Windows.Forms.Button WordWrapToggleButton;
    }
}
