﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TNotepad
{
    public partial class InitialDBLoad : Form
    {
        public InitialDBLoad()
        {
            InitializeComponent();
        }

        private void InitialDBLoad_Load(object sender, EventArgs e)
        {
            BGWorker.RunWorkerAsync();
        }

        private void BGWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            label1.Text = "Progress: " + e.ProgressPercentage + "%";
            label1.Refresh();
        }

        public void ChangeReportText(string NewReportText)
        {
            CurrentlyLoading.Invoke((MethodInvoker)delegate {
                CurrentlyLoading.Text = NewReportText;
            });
        }

        private void BGWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            ChangeReportText("Language Files 1/2");
            Lang.LoadDictData(BGWorker);

            BGWorker.ReportProgress(0);
            ChangeReportText("Theme Files 2/2");
            ThemeLoader.LoadDictData(BGWorker);



        }

        private void BGWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ChangeReportText("Loading Complete");
            Utils.CreateMainForm();
            Close();

        }

        private void CurrentVersionLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
