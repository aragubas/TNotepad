namespace TNotepad.ExtraFuncPanels
{
    partial class GotoLine
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
            this.LineThingTextbox = new TaiyouUI.taiyouTextBox();
            this.GoButton = new TaiyouUI.taiyouButton();
            this.SuspendLayout();
            // 
            // LineThingTextbox
            // 
            this.LineThingTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LineThingTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LineThingTextbox.Location = new System.Drawing.Point(0, 0);
            this.LineThingTextbox.Name = "LineThingTextbox";
            this.LineThingTextbox.Size = new System.Drawing.Size(268, 20);
            this.LineThingTextbox.TabIndex = 0;
            this.LineThingTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LineThingTextbox_KeyDown);
            // 
            // GoButton
            // 
            this.GoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GoButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.GoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoButton.Location = new System.Drawing.Point(274, 1);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(93, 29);
            this.GoButton.TabIndex = 1;
            this.GoButton.Text = "Goto Line";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            this.GoButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GoButton_KeyDown);
            // 
            // GotoLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GoButton);
            this.Controls.Add(this.LineThingTextbox);
            this.Name = "GotoLine";
            this.Size = new System.Drawing.Size(368, 39);
            this.Load += new System.EventHandler(this.GotoLine_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TaiyouUI.taiyouTextBox LineThingTextbox;
        private TaiyouUI.taiyouButton GoButton;
    }
}
