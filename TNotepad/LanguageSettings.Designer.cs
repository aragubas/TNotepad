﻿
namespace TNotepad
{
    partial class LanguageSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LanguageSettings));
            this.CurrentLanguageInfoLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CurrentLanguageTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.AvaliableLanguagesListBox = new System.Windows.Forms.ListBox();
            this.AvaliableLanguageFilesInfoLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CurrentLanguageInfoLabel
            // 
            this.CurrentLanguageInfoLabel.AutoSize = true;
            this.CurrentLanguageInfoLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.CurrentLanguageInfoLabel.Location = new System.Drawing.Point(0, 0);
            this.CurrentLanguageInfoLabel.Name = "CurrentLanguageInfoLabel";
            this.CurrentLanguageInfoLabel.Size = new System.Drawing.Size(115, 17);
            this.CurrentLanguageInfoLabel.TabIndex = 0;
            this.CurrentLanguageInfoLabel.Text = "Current Language:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.CurrentLanguageTextBox);
            this.panel1.Controls.Add(this.CurrentLanguageInfoLabel);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 32);
            this.panel1.TabIndex = 1;
            // 
            // CurrentLanguageTextBox
            // 
            this.CurrentLanguageTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.CurrentLanguageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CurrentLanguageTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CurrentLanguageTextBox.ForeColor = System.Drawing.Color.White;
            this.CurrentLanguageTextBox.Location = new System.Drawing.Point(115, 0);
            this.CurrentLanguageTextBox.Name = "CurrentLanguageTextBox";
            this.CurrentLanguageTextBox.Size = new System.Drawing.Size(367, 25);
            this.CurrentLanguageTextBox.TabIndex = 1;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ConfirmButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ConfirmButton.FlatAppearance.BorderSize = 0;
            this.ConfirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmButton.Location = new System.Drawing.Point(12, 264);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(75, 32);
            this.ConfirmButton.TabIndex = 2;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = false;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // AvaliableLanguagesListBox
            // 
            this.AvaliableLanguagesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AvaliableLanguagesListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.AvaliableLanguagesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AvaliableLanguagesListBox.ForeColor = System.Drawing.Color.White;
            this.AvaliableLanguagesListBox.FormattingEnabled = true;
            this.AvaliableLanguagesListBox.ItemHeight = 17;
            this.AvaliableLanguagesListBox.Location = new System.Drawing.Point(12, 67);
            this.AvaliableLanguagesListBox.Name = "AvaliableLanguagesListBox";
            this.AvaliableLanguagesListBox.Size = new System.Drawing.Size(482, 189);
            this.AvaliableLanguagesListBox.TabIndex = 3;
            this.AvaliableLanguagesListBox.SelectedIndexChanged += new System.EventHandler(this.AvaliableLanguagesListBox_SelectedIndexChanged);
            // 
            // AvaliableLanguageFilesInfoLabel
            // 
            this.AvaliableLanguageFilesInfoLabel.AutoSize = true;
            this.AvaliableLanguageFilesInfoLabel.Location = new System.Drawing.Point(9, 47);
            this.AvaliableLanguageFilesInfoLabel.Name = "AvaliableLanguageFilesInfoLabel";
            this.AvaliableLanguageFilesInfoLabel.Size = new System.Drawing.Size(157, 17);
            this.AvaliableLanguageFilesInfoLabel.TabIndex = 4;
            this.AvaliableLanguageFilesInfoLabel.Text = "Avaliable Languages files:";
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Location = new System.Drawing.Point(419, 264);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 32);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // LanguageSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(506, 308);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.AvaliableLanguageFilesInfoLabel);
            this.Controls.Add(this.AvaliableLanguagesListBox);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LanguageSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Language Settings";
            this.Load += new System.EventHandler(this.LanguageSettings_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CurrentLanguageInfoLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox CurrentLanguageTextBox;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.ListBox AvaliableLanguagesListBox;
        private System.Windows.Forms.Label AvaliableLanguageFilesInfoLabel;
        private System.Windows.Forms.Button ExitButton;
    }
}