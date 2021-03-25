using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TNotepad
{
    public partial class BackgroundWorkerDialog : Form
    {
        List<BackgroundWorker> Workers = new List<BackgroundWorker>();
        BackgroundWorker LastTask = null;
        bool ProgressChnagedEventHandlerSet = false;
        int CurrentWorking = 0;

        public BackgroundWorkerDialog(List<BackgroundWorker> pWorkers)
        {
            InitializeComponent();

            Workers = pWorkers;
        }

        private void BackgroundWorkerDialog_Load(object sender, EventArgs e)
        {
            Text = Lang.GetLangData("BackgroundWorker_WindowTitle");
            CurrentInfoLabel.Text = Lang.GetLangData("BackgroundWorker_CurrentLabel");

            FileRemaning.Maximum = Workers.Count;

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
                    Close();
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
