namespace TNotepad
{
    partial class HomescreenTab
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new taiyouSplitContainer();
            this.tableLayoutPanel1 = new taiyouTableLayoutPanel();
            this.OpenPinDocButton = new TNotepad.taiyouButton();
            this.EditPinDocButton = new TNotepad.taiyouButton();
            this.DeletePinDocButton = new TNotepad.taiyouButton();
            this.PinDocsView = new TNotepad.taiyouListView();
            this.PinName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FilePath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PinnedDocsTitle = new System.Windows.Forms.Label();
            this.RollbackChanges = new TNotepad.taiyouButton();
            this.SaveChangesButton = new TNotepad.taiyouButton();
            this.TipPinLabel = new System.Windows.Forms.Label();
            this.ReloadPinDocListButton = new TNotepad.taiyouButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 351);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel1.Controls.Add(this.PinDocsView);
            this.splitContainer1.Panel1.Controls.Add(this.PinnedDocsTitle);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.RollbackChanges);
            this.splitContainer1.Panel2.Controls.Add(this.SaveChangesButton);
            this.splitContainer1.Panel2.Controls.Add(this.TipPinLabel);
            this.splitContainer1.Panel2.Controls.Add(this.ReloadPinDocListButton);
            this.splitContainer1.Size = new System.Drawing.Size(728, 351);
            this.splitContainer1.SplitterDistance = 505;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 4;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 213F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanel1.Controls.Add(this.OpenPinDocButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.EditPinDocButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.DeletePinDocButton, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 317);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(505, 34);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // OpenPinDocButton
            // 
            this.OpenPinDocButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OpenPinDocButton.FlatAppearance.BorderSize = 0;
            this.OpenPinDocButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenPinDocButton.Location = new System.Drawing.Point(3, 3);
            this.OpenPinDocButton.Name = "OpenPinDocButton";
            this.OpenPinDocButton.Size = new System.Drawing.Size(178, 28);
            this.OpenPinDocButton.TabIndex = 0;
            this.OpenPinDocButton.Text = "Open";
            this.OpenPinDocButton.UseVisualStyleBackColor = false;
            this.OpenPinDocButton.Click += new System.EventHandler(this.OpenPinDocButton_Click);
            // 
            // EditPinDocButton
            // 
            this.EditPinDocButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditPinDocButton.FlatAppearance.BorderSize = 0;
            this.EditPinDocButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditPinDocButton.Location = new System.Drawing.Point(187, 3);
            this.EditPinDocButton.Name = "EditPinDocButton";
            this.EditPinDocButton.Size = new System.Drawing.Size(207, 28);
            this.EditPinDocButton.TabIndex = 1;
            this.EditPinDocButton.Text = "Edit";
            this.EditPinDocButton.UseVisualStyleBackColor = false;
            this.EditPinDocButton.Click += new System.EventHandler(this.EditPinDocButton_Click);
            // 
            // DeletePinDocButton
            // 
            this.DeletePinDocButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeletePinDocButton.FlatAppearance.BorderSize = 0;
            this.DeletePinDocButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeletePinDocButton.Location = new System.Drawing.Point(400, 3);
            this.DeletePinDocButton.Name = "DeletePinDocButton";
            this.DeletePinDocButton.Size = new System.Drawing.Size(102, 28);
            this.DeletePinDocButton.TabIndex = 2;
            this.DeletePinDocButton.Text = "Remove";
            this.DeletePinDocButton.UseVisualStyleBackColor = false;
            this.DeletePinDocButton.Click += new System.EventHandler(this.DeletePinDocButton_Click);
            // 
            // PinDocsView
            // 
            this.PinDocsView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.PinDocsView.BackgroundImageTiled = true;
            this.PinDocsView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PinDocsView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PinName,
            this.FilePath});
            this.PinDocsView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PinDocsView.HideSelection = false;
            this.PinDocsView.Location = new System.Drawing.Point(0, 30);
            this.PinDocsView.Name = "PinDocsView";
            this.PinDocsView.Size = new System.Drawing.Size(505, 321);
            this.PinDocsView.TabIndex = 4;
            this.PinDocsView.UseCompatibleStateImageBehavior = false;
            this.PinDocsView.View = System.Windows.Forms.View.Details;
            this.PinDocsView.SelectedIndexChanged += new System.EventHandler(this.PinDocsView_SelectedIndexChanged);
            // 
            // PinName
            // 
            this.PinName.Text = "Pin Name";
            this.PinName.Width = 100;
            // 
            // FilePath
            // 
            this.FilePath.Text = "File Path";
            this.FilePath.Width = 349;
            // 
            // PinnedDocsTitle
            // 
            this.PinnedDocsTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PinnedDocsTitle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PinnedDocsTitle.Location = new System.Drawing.Point(0, 0);
            this.PinnedDocsTitle.Name = "PinnedDocsTitle";
            this.PinnedDocsTitle.Size = new System.Drawing.Size(505, 30);
            this.PinnedDocsTitle.TabIndex = 0;
            this.PinnedDocsTitle.Text = "Pinned Documents";
            this.PinnedDocsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PinnedDocsTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // RollbackChanges
            // 
            this.RollbackChanges.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RollbackChanges.FlatAppearance.BorderSize = 0;
            this.RollbackChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RollbackChanges.Location = new System.Drawing.Point(7, 100);
            this.RollbackChanges.Name = "RollbackChanges";
            this.RollbackChanges.Size = new System.Drawing.Size(201, 23);
            this.RollbackChanges.TabIndex = 5;
            this.RollbackChanges.Text = "Rollback Changes";
            this.RollbackChanges.UseVisualStyleBackColor = false;
            this.RollbackChanges.Click += new System.EventHandler(this.RollbackChanges_Click);
            // 
            // SaveChangesButton
            // 
            this.SaveChangesButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveChangesButton.FlatAppearance.BorderSize = 0;
            this.SaveChangesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveChangesButton.Location = new System.Drawing.Point(6, 71);
            this.SaveChangesButton.Name = "SaveChangesButton";
            this.SaveChangesButton.Size = new System.Drawing.Size(201, 23);
            this.SaveChangesButton.TabIndex = 4;
            this.SaveChangesButton.Text = "Save Changes";
            this.SaveChangesButton.UseVisualStyleBackColor = false;
            this.SaveChangesButton.Click += new System.EventHandler(this.SaveChangesButton_Click);
            // 
            // TipPinLabel
            // 
            this.TipPinLabel.AutoSize = true;
            this.TipPinLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipPinLabel.Location = new System.Drawing.Point(3, 7);
            this.TipPinLabel.Name = "TipPinLabel";
            this.TipPinLabel.Size = new System.Drawing.Size(163, 32);
            this.TipPinLabel.TabIndex = 3;
            this.TipPinLabel.Text = "You can pin a document at\r\nExtras -> Pin Document\r\n";
            // 
            // ReloadPinDocListButton
            // 
            this.ReloadPinDocListButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReloadPinDocListButton.FlatAppearance.BorderSize = 0;
            this.ReloadPinDocListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReloadPinDocListButton.Location = new System.Drawing.Point(6, 42);
            this.ReloadPinDocListButton.Name = "ReloadPinDocListButton";
            this.ReloadPinDocListButton.Size = new System.Drawing.Size(201, 23);
            this.ReloadPinDocListButton.TabIndex = 3;
            this.ReloadPinDocListButton.Text = "Refresh List";
            this.ReloadPinDocListButton.UseVisualStyleBackColor = false;
            this.ReloadPinDocListButton.Click += new System.EventHandler(this.ReloadPinDocListButton_Click);
            // 
            // HomescreenTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "HomescreenTab";
            this.Size = new System.Drawing.Size(728, 351);
            this.Load += new System.EventHandler(this.HomescreenTab_Load);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label PinnedDocsTitle;
        private taiyouTableLayoutPanel tableLayoutPanel1;
        private taiyouButton OpenPinDocButton;
        private taiyouButton EditPinDocButton;
        private taiyouButton DeletePinDocButton;
        private System.Windows.Forms.Label TipPinLabel;
        private taiyouListView PinDocsView;
        private System.Windows.Forms.ColumnHeader PinName;
        private System.Windows.Forms.ColumnHeader FilePath;
        private taiyouSplitContainer splitContainer1;
        private taiyouButton ReloadPinDocListButton;
        private taiyouButton SaveChangesButton;
        private taiyouButton RollbackChanges;

    }
}
