using TaiyouUI;

namespace TNotepad
{
    partial class TabSwitcher
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
            this.WindowTitle = new MoveWindowLabel();
            this.TabList = new taiyouListBox();
            this.CloseTabButton = new taiyouButton();
            this.HowToSwitchInfoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WindowTitle
            // 
            this.WindowTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.WindowTitle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.WindowTitle.Location = new System.Drawing.Point(0, 0);
            this.WindowTitle.Name = "WindowTitle";
            this.WindowTitle.Size = new System.Drawing.Size(432, 25);
            this.WindowTitle.TabIndex = 0;
            this.WindowTitle.Text = "Tab Switcher";
            this.WindowTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.WindowTitle.Click += new System.EventHandler(this.WindowTitle_Click);
            // 
            // TabList
            // 
            this.TabList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TabList.FormattingEnabled = true;
            this.TabList.Location = new System.Drawing.Point(127, 28);
            this.TabList.Name = "TabList";
            this.TabList.Size = new System.Drawing.Size(305, 249);
            this.TabList.TabIndex = 1;
            this.TabList.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TabList_KeyUp);
            this.TabList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TabList_MouseDoubleClick);
            // 
            // CloseTabButton
            // 
            this.CloseTabButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CloseTabButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CloseTabButton.FlatAppearance.BorderSize = 0;
            this.CloseTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseTabButton.Location = new System.Drawing.Point(3, 242);
            this.CloseTabButton.Name = "CloseTabButton";
            this.CloseTabButton.Size = new System.Drawing.Size(115, 35);
            this.CloseTabButton.TabIndex = 2;
            this.CloseTabButton.Text = "Close";
            this.CloseTabButton.UseVisualStyleBackColor = false;
            this.CloseTabButton.Click += new System.EventHandler(this.CloseTabButton_Click);
            // 
            // HowToSwitchInfoLabel
            // 
            this.HowToSwitchInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.HowToSwitchInfoLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HowToSwitchInfoLabel.Location = new System.Drawing.Point(3, 28);
            this.HowToSwitchInfoLabel.Name = "HowToSwitchInfoLabel";
            this.HowToSwitchInfoLabel.Size = new System.Drawing.Size(115, 211);
            this.HowToSwitchInfoLabel.TabIndex = 2;
            this.HowToSwitchInfoLabel.Text = "Press \"enter\" or \"space\" to switch\r\nPress \"escape\" to exit.";
            this.HowToSwitchInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TabSwitcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.HowToSwitchInfoLabel);
            this.Controls.Add(this.CloseTabButton);
            this.Controls.Add(this.TabList);
            this.Controls.Add(this.WindowTitle);
            this.Name = "TabSwitcher";
            this.Size = new System.Drawing.Size(432, 288);
            this.Load += new System.EventHandler(this.TabSwitcher_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TabSwitcher_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private MoveWindowLabel WindowTitle;
        private taiyouListBox TabList;
        private taiyouButton CloseTabButton;
        private System.Windows.Forms.Label HowToSwitchInfoLabel;
    }
}
