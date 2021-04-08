
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
            this.flowLayoutPanel1 = new taiyouFlowLayoutPanel();
            this.WordWrapGroupBox = new taiyouGroupBox();
            this.WordWrapCheckbox = new TNotepad.taiyouCheckBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.WordWrapGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.WordWrapGroupBox);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(482, 378);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // WordWrapGroupBox
            // 
            this.WordWrapGroupBox.Controls.Add(this.WordWrapCheckbox);
            this.WordWrapGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WordWrapGroupBox.Location = new System.Drawing.Point(3, 3);
            this.WordWrapGroupBox.Name = "WordWrapGroupBox";
            this.WordWrapGroupBox.Size = new System.Drawing.Size(207, 56);
            this.WordWrapGroupBox.TabIndex = 1;
            this.WordWrapGroupBox.TabStop = false;
            this.WordWrapGroupBox.Text = "Word Wrap";
            // 
            // WordWrapCheckbox
            // 
            this.WordWrapCheckbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WordWrapCheckbox.Location = new System.Drawing.Point(3, 16);
            this.WordWrapCheckbox.Name = "WordWrapCheckbox";
            this.WordWrapCheckbox.Size = new System.Drawing.Size(201, 37);
            this.WordWrapCheckbox.TabIndex = 0;
            this.WordWrapCheckbox.Text = "Enabled";
            this.WordWrapCheckbox.UseVisualStyleBackColor = true;
            // 
            // TextEditorTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "TextEditorTab";
            this.Size = new System.Drawing.Size(482, 378);
            this.Load += new System.EventHandler(this.TextEditorTab_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.WordWrapGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private taiyouFlowLayoutPanel flowLayoutPanel1;
        private taiyouGroupBox WordWrapGroupBox;
        private taiyouCheckBox WordWrapCheckbox;
    }
}
