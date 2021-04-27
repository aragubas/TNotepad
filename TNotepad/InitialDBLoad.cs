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

using System;
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
            Console.WriteLine("Loading Databases...");
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
            ChangeReportText("Language Files 1/3");
            Lang.LoadDictData(BGWorker);

            BGWorker.ReportProgress(0);
            ChangeReportText("Theme Files 2/3");
            TaiyouUI.ThemeLoader.LoadDictData(Environment.CurrentDirectory + "\\themes\\" + Properties.Settings.Default.CurrentTheme + ".txt", BGWorker);

            BGWorker.ReportProgress(0);
            ChangeReportText("Create PluginAPI Instance 3/3");
            Utils.InstanceAPI = new PluginAPI();
            


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
