/*
   Copyright 2021 Aragubas/Paulo Otávio de Lima

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License. 
  
 */


namespace TNotepad
{
    partial class BackgroundWorkerDialog
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
            this.components = new System.ComponentModel.Container();
            this.CurrentProgress = new System.Windows.Forms.ProgressBar();
            this.WorkingProgress = new System.Windows.Forms.Label();
            this.BackgroundWorking = new System.Windows.Forms.Timer(this.components);
            this.FileRemaning = new System.Windows.Forms.ProgressBar();
            this.CurrentInfoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CurrentProgress
            // 
            this.CurrentProgress.Location = new System.Drawing.Point(12, 25);
            this.CurrentProgress.Name = "CurrentProgress";
            this.CurrentProgress.Size = new System.Drawing.Size(383, 23);
            this.CurrentProgress.Step = 1;
            this.CurrentProgress.TabIndex = 1;
            // 
            // WorkingProgress
            // 
            this.WorkingProgress.AutoSize = true;
            this.WorkingProgress.Location = new System.Drawing.Point(12, 65);
            this.WorkingProgress.Name = "WorkingProgress";
            this.WorkingProgress.Size = new System.Drawing.Size(24, 13);
            this.WorkingProgress.TabIndex = 2;
            this.WorkingProgress.Text = "0/0";
            // 
            // BackgroundWorking
            // 
            this.BackgroundWorking.Enabled = true;
            this.BackgroundWorking.Tick += new System.EventHandler(this.BackgroundWorking_Tick);
            // 
            // FileRemaning
            // 
            this.FileRemaning.Location = new System.Drawing.Point(12, 81);
            this.FileRemaning.Name = "FileRemaning";
            this.FileRemaning.Size = new System.Drawing.Size(381, 23);
            this.FileRemaning.TabIndex = 3;
            // 
            // CurrentInfoLabel
            // 
            this.CurrentInfoLabel.AutoSize = true;
            this.CurrentInfoLabel.Location = new System.Drawing.Point(12, 9);
            this.CurrentInfoLabel.Name = "CurrentInfoLabel";
            this.CurrentInfoLabel.Size = new System.Drawing.Size(41, 13);
            this.CurrentInfoLabel.TabIndex = 4;
            this.CurrentInfoLabel.Text = "Current\r\n";
            // 
            // BackgroundWorkerDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CurrentInfoLabel);
            this.Controls.Add(this.WorkingProgress);
            this.Controls.Add(this.FileRemaning);
            this.Controls.Add(this.CurrentProgress);
            this.Name = "BackgroundWorkerDialog";
            this.Size = new System.Drawing.Size(407, 155);
            this.Load += new System.EventHandler(this.BackgroundWorkerDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar CurrentProgress;
        private System.Windows.Forms.Label WorkingProgress;
        private System.Windows.Forms.Timer BackgroundWorking;
        private System.Windows.Forms.ProgressBar FileRemaning;
        private System.Windows.Forms.Label CurrentInfoLabel;
    }
}