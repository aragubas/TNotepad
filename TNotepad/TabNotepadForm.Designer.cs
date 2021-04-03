﻿namespace TNotepad
{
    partial class TabNotepadForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabNotepadForm));
            this.TitlebarPanel = new System.Windows.Forms.Panel();
            this.FormMaximizeButton = new System.Windows.Forms.Button();
            this.FormCloseButton = new System.Windows.Forms.Button();
            this.FormControls = new System.Windows.Forms.Panel();
            this.WindowButtonsPanel = new System.Windows.Forms.Panel();
            this.FormTitlebar = new TNotepad.MoveWindowLabel();
            this.TitlebarPanel.SuspendLayout();
            this.WindowButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitlebarPanel
            // 
            this.TitlebarPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitlebarPanel.Controls.Add(this.WindowButtonsPanel);
            this.TitlebarPanel.Controls.Add(this.FormTitlebar);
            this.TitlebarPanel.Location = new System.Drawing.Point(24, 0);
            this.TitlebarPanel.Name = "TitlebarPanel";
            this.TitlebarPanel.Size = new System.Drawing.Size(639, 27);
            this.TitlebarPanel.TabIndex = 5;
            // 
            // FormMaximizeButton
            // 
            this.FormMaximizeButton.BackColor = System.Drawing.Color.Gray;
            this.FormMaximizeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.FormMaximizeButton.FlatAppearance.BorderSize = 0;
            this.FormMaximizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.FormMaximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FormMaximizeButton.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.FormMaximizeButton.ForeColor = System.Drawing.Color.White;
            this.FormMaximizeButton.Location = new System.Drawing.Point(42, 0);
            this.FormMaximizeButton.Name = "FormMaximizeButton";
            this.FormMaximizeButton.Size = new System.Drawing.Size(25, 20);
            this.FormMaximizeButton.TabIndex = 1;
            this.FormMaximizeButton.Text = "/\\";
            this.FormMaximizeButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.FormMaximizeButton.UseVisualStyleBackColor = false;
            this.FormMaximizeButton.Click += new System.EventHandler(this.FormMaximizeButton_Click);
            // 
            // FormCloseButton
            // 
            this.FormCloseButton.BackColor = System.Drawing.Color.DarkGray;
            this.FormCloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.FormCloseButton.FlatAppearance.BorderSize = 0;
            this.FormCloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.FormCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FormCloseButton.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.FormCloseButton.ForeColor = System.Drawing.Color.White;
            this.FormCloseButton.Location = new System.Drawing.Point(67, 0);
            this.FormCloseButton.Name = "FormCloseButton";
            this.FormCloseButton.Size = new System.Drawing.Size(44, 20);
            this.FormCloseButton.TabIndex = 0;
            this.FormCloseButton.Text = "X";
            this.FormCloseButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.FormCloseButton.UseVisualStyleBackColor = false;
            this.FormCloseButton.Click += new System.EventHandler(this.FormCloseButton_Click);
            // 
            // FormControls
            // 
            this.FormControls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FormControls.ForeColor = System.Drawing.Color.White;
            this.FormControls.Location = new System.Drawing.Point(0, 27);
            this.FormControls.Name = "FormControls";
            this.FormControls.Size = new System.Drawing.Size(663, 396);
            this.FormControls.TabIndex = 6;
            // 
            // WindowButtonsPanel
            // 
            this.WindowButtonsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WindowButtonsPanel.Controls.Add(this.FormMaximizeButton);
            this.WindowButtonsPanel.Controls.Add(this.FormCloseButton);
            this.WindowButtonsPanel.Location = new System.Drawing.Point(524, 0);
            this.WindowButtonsPanel.Name = "WindowButtonsPanel";
            this.WindowButtonsPanel.Size = new System.Drawing.Size(111, 20);
            this.WindowButtonsPanel.TabIndex = 3;
            // 
            // FormTitlebar
            // 
            this.FormTitlebar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormTitlebar.Font = new System.Drawing.Font("Arial", 10F);
            this.FormTitlebar.ForeColor = System.Drawing.Color.White;
            this.FormTitlebar.Location = new System.Drawing.Point(0, 0);
            this.FormTitlebar.Name = "FormTitlebar";
            this.FormTitlebar.Size = new System.Drawing.Size(639, 27);
            this.FormTitlebar.TabIndex = 2;
            this.FormTitlebar.Text = "TabNotepad";
            this.FormTitlebar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FormTitlebar.MouseLeave += new System.EventHandler(this.FormTitlebar_MouseLeave);
            // 
            // TabNotepadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(663, 423);
            this.Controls.Add(this.TitlebarPanel);
            this.Controls.Add(this.FormControls);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 8.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TabNotepadForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Untitled TabNotepad Form";
            this.Load += new System.EventHandler(this.TabNotepadForm_Load);
            this.ResizeBegin += new System.EventHandler(this.TabNotepadForm_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.TabNotepadForm_ResizeEnd);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.TabNotepadForm_Paint);
            this.TitlebarPanel.ResumeLayout(false);
            this.WindowButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel TitlebarPanel;
        public System.Windows.Forms.Button FormMaximizeButton;
        public System.Windows.Forms.Button FormCloseButton;
        public MoveWindowLabel FormTitlebar;
        public System.Windows.Forms.Panel FormControls;
        private System.Windows.Forms.Panel WindowButtonsPanel;

    }
}