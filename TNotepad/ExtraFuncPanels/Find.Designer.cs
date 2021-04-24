using TaiyouUI;

namespace TNotepad.ExtraFuncPanels
{

    partial class Find
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
            this.textBox1 = new TaiyouUI.taiyouTextBox();
            this.FindButton = new TaiyouUI.taiyouButton();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(398, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // FindButton
            // 
            this.FindButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FindButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindButton.Location = new System.Drawing.Point(404, 0);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(82, 24);
            this.FindButton.TabIndex = 1;
            this.FindButton.Text = "Find";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // Find
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.FindButton);
            this.Name = "Find";
            this.Size = new System.Drawing.Size(486, 27);
            this.Load += new System.EventHandler(this.Find_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Find_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private taiyouTextBox textBox1;
        private taiyouButton FindButton;
    }
}
