namespace TNotepad
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SidePanelView = new System.Windows.Forms.Panel();
            this.TitlebarPanel = new System.Windows.Forms.Panel();
            this.FormMaximizeButton = new System.Windows.Forms.Button();
            this.FormCloseButton = new System.Windows.Forms.Button();
            this.FormTitlebar = new TNotepad.MoveWindowLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Tabs = new TNotepad.ApplicationTabs();
            this.TitlebarPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SidePanelView
            // 
            this.SidePanelView.AllowDrop = true;
            this.SidePanelView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SidePanelView.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanelView.Location = new System.Drawing.Point(0, 0);
            this.SidePanelView.Name = "SidePanelView";
            this.SidePanelView.Size = new System.Drawing.Size(131, 448);
            this.SidePanelView.TabIndex = 2;
            // 
            // TitlebarPanel
            // 
            this.TitlebarPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitlebarPanel.Controls.Add(this.FormMaximizeButton);
            this.TitlebarPanel.Controls.Add(this.FormCloseButton);
            this.TitlebarPanel.Controls.Add(this.FormTitlebar);
            this.TitlebarPanel.Location = new System.Drawing.Point(24, 0);
            this.TitlebarPanel.Name = "TitlebarPanel";
            this.TitlebarPanel.Size = new System.Drawing.Size(817, 25);
            this.TitlebarPanel.TabIndex = 3;
            // 
            // FormMaximizeButton
            // 
            this.FormMaximizeButton.BackColor = System.Drawing.Color.DimGray;
            this.FormMaximizeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.FormMaximizeButton.FlatAppearance.BorderSize = 0;
            this.FormMaximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FormMaximizeButton.ForeColor = System.Drawing.Color.White;
            this.FormMaximizeButton.Location = new System.Drawing.Point(767, 0);
            this.FormMaximizeButton.Name = "FormMaximizeButton";
            this.FormMaximizeButton.Size = new System.Drawing.Size(25, 25);
            this.FormMaximizeButton.TabIndex = 1;
            this.FormMaximizeButton.Text = "/\\";
            this.FormMaximizeButton.UseVisualStyleBackColor = false;
            this.FormMaximizeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormCloseButton
            // 
            this.FormCloseButton.BackColor = System.Drawing.Color.DarkRed;
            this.FormCloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.FormCloseButton.FlatAppearance.BorderSize = 0;
            this.FormCloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.FormCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FormCloseButton.ForeColor = System.Drawing.Color.White;
            this.FormCloseButton.Location = new System.Drawing.Point(792, 0);
            this.FormCloseButton.Name = "FormCloseButton";
            this.FormCloseButton.Size = new System.Drawing.Size(25, 25);
            this.FormCloseButton.TabIndex = 0;
            this.FormCloseButton.Text = "X";
            this.FormCloseButton.UseVisualStyleBackColor = false;
            this.FormCloseButton.Click += new System.EventHandler(this.FormCloseButton_Click);
            // 
            // FormTitlebar
            // 
            this.FormTitlebar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormTitlebar.Font = new System.Drawing.Font("Arial", 10F);
            this.FormTitlebar.ForeColor = System.Drawing.Color.White;
            this.FormTitlebar.Location = new System.Drawing.Point(0, 0);
            this.FormTitlebar.Name = "FormTitlebar";
            this.FormTitlebar.Size = new System.Drawing.Size(817, 25);
            this.FormTitlebar.TabIndex = 2;
            this.FormTitlebar.Text = "TabNotepad";
            this.FormTitlebar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FormTitlebar.MouseLeave += new System.EventHandler(this.FormTitlebar_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.Tabs);
            this.panel1.Controls.Add(this.SidePanelView);
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 448);
            this.panel1.TabIndex = 4;
            // 
            // Tabs
            // 
            this.Tabs.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.Tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tabs.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.Tabs.Location = new System.Drawing.Point(131, 0);
            this.Tabs.Name = "Tabs";
            this.Tabs.Padding = new System.Drawing.Point(0, 0);
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(710, 448);
            this.Tabs.TabIndex = 1;
            this.Tabs.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.Tabs_DrawItem);
            this.Tabs.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Tabs_MouseUp);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(841, 473);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TitlebarPanel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(841, 422);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TabNotepad";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeBegin += new System.EventHandler(this.Form1_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.TitlebarPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ApplicationTabs Tabs;
        private System.Windows.Forms.Panel SidePanelView;
        private System.Windows.Forms.Panel TitlebarPanel;
        private System.Windows.Forms.Button FormCloseButton;
        private System.Windows.Forms.Button FormMaximizeButton;
        private MoveWindowLabel FormTitlebar;
        private System.Windows.Forms.Panel panel1;
    }
}

