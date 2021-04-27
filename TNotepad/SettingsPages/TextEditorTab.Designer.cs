using TaiyouUI;

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
            this.flowLayoutPanel1 = new TaiyouUI.taiyouFlowLayoutPanel();
            this.WordWrapGroupBox = new TaiyouUI.taiyouGroupBox();
            this.WordWrapCheckbox = new TaiyouUI.taiyouCheckBox();
            this.FontSettingGroupBox = new TaiyouUI.taiyouGroupBox();
            this.FontSettingPreview = new System.Windows.Forms.Label();
            this.FontSettingChangeFontButton = new TaiyouUI.taiyouButton();
            this.TextEditorFont = new System.Windows.Forms.FontDialog();
            this.flowLayoutPanel1.SuspendLayout();
            this.WordWrapGroupBox.SuspendLayout();
            this.FontSettingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.WordWrapGroupBox);
            this.flowLayoutPanel1.Controls.Add(this.FontSettingGroupBox);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
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
            // FontSettingGroupBox
            // 
            this.FontSettingGroupBox.Controls.Add(this.FontSettingPreview);
            this.FontSettingGroupBox.Controls.Add(this.FontSettingChangeFontButton);
            this.FontSettingGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FontSettingGroupBox.Location = new System.Drawing.Point(3, 65);
            this.FontSettingGroupBox.Name = "FontSettingGroupBox";
            this.FontSettingGroupBox.Size = new System.Drawing.Size(240, 100);
            this.FontSettingGroupBox.TabIndex = 2;
            this.FontSettingGroupBox.TabStop = false;
            this.FontSettingGroupBox.Text = "Font";
            // 
            // FontSettingPreview
            // 
            this.FontSettingPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FontSettingPreview.Location = new System.Drawing.Point(3, 16);
            this.FontSettingPreview.Name = "FontSettingPreview";
            this.FontSettingPreview.Size = new System.Drawing.Size(234, 54);
            this.FontSettingPreview.TabIndex = 0;
            this.FontSettingPreview.Text = "This is a font preview";
            this.FontSettingPreview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FontSettingChangeFontButton
            // 
            this.FontSettingChangeFontButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FontSettingChangeFontButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.FontSettingChangeFontButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FontSettingChangeFontButton.Location = new System.Drawing.Point(3, 70);
            this.FontSettingChangeFontButton.Name = "FontSettingChangeFontButton";
            this.FontSettingChangeFontButton.Size = new System.Drawing.Size(234, 27);
            this.FontSettingChangeFontButton.TabIndex = 1;
            this.FontSettingChangeFontButton.Text = "Change current font";
            this.FontSettingChangeFontButton.UseVisualStyleBackColor = true;
            this.FontSettingChangeFontButton.Click += new System.EventHandler(this.FontSettingChangeFontButton_Click);
            // 
            // TextEditorFont
            // 
            this.TextEditorFont.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextEditorFont.ShowApply = true;
            this.TextEditorFont.ShowEffects = false;
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
            this.FontSettingGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private taiyouFlowLayoutPanel flowLayoutPanel1;
        private taiyouGroupBox WordWrapGroupBox;
        private taiyouCheckBox WordWrapCheckbox;
        private taiyouGroupBox FontSettingGroupBox;
        private System.Windows.Forms.Label FontSettingPreview;
        private taiyouButton FontSettingChangeFontButton;
        private System.Windows.Forms.FontDialog TextEditorFont;
    }
}
