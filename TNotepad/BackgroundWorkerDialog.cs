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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaiyouUI;

namespace TNotepad
{
    public partial class BackgroundWorkerDialog : taiyouUserControl
    {
        List<BackgroundWorker> Workers = new List<BackgroundWorker>();
        BackgroundWorker LastTask = null;
        bool ProgressChnagedEventHandlerSet = false;
        int CurrentWorking = 0;
        Size originalSize;

        public BackgroundWorkerDialog(List<BackgroundWorker> pWorkers)
        {
            InitializeComponent();

            originalSize = Size;

            // Set Icon
            RootForm.Icon = Properties.Resources.Icon;

            Workers = pWorkers;
        }

        private void BackgroundWorkerDialog_Load(object sender, EventArgs e)
        {
            CurrentInfoLabel.Text = Lang.GetLangData("BackgroundWorker_CurrentLabel");

            FileRemaning.Maximum = Workers.Count;

            Dock = DockStyle.Fill;
            RootForm.ResizeableForm = false;
            RootForm.MinimizeableForm = false;
            RootForm.CloseableForm = false;
            RootForm.Text = Lang.GetLangData("BackgroundWorker_WindowTitle");
            RootForm.Size = originalSize;

        }

        public void BackgroundWorkerProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            CurrentProgress.Value = e.ProgressPercentage;

        }

        private void BackgroundWorking_Tick(object sender, EventArgs e)
        {
            WorkingProgress.Text = Workers.Count + Lang.GetLangData("BackgroundWorker_WorksLeftLabel");
            FileRemaning.Value = CurrentWorking;

            // Last task is still running
            if (LastTask != null)
            {
                if (LastTask.IsBusy)
                {
                    if (!ProgressChnagedEventHandlerSet)
                    {
                        ProgressChnagedEventHandlerSet = true;
                        LastTask.ProgressChanged += BackgroundWorkerProgressChanged;
                        CurrentWorking += 1;

                    }

                    //BackgroundWorkingInfo.Text = 
                }
                else
                {
                    Console.WriteLine("Last task has been finished");
                    LastTask = null;
                    CurrentProgress.Value = 0;
                }

            }
            else
            {
                Console.WriteLine("Next Task");
                ProgressChnagedEventHandlerSet = false;

                // Done!
                if (Workers.Count == 0)
                {
                    RootForm.Close();
                    return;
                }

                // Get last item
                LastTask = Workers[Workers.Count - 1];
                Workers.Remove(LastTask);
                LastTask.RunWorkerAsync();

            }




        }

    }
}
