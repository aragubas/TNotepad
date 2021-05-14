using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaiyouUI;
using TaiyouUtils;
using System.Diagnostics;
using System.IO;

namespace Installer
{
    public partial class InstalationComplete : taiyouUserControl
    {
        InstallerPage1 RootPage;
        bool InstalationError;
        Exception Exc;

        public InstalationComplete(InstallerPage1 pRootPage, bool pInstalationError=false, Exception pExc=null)
        {
            InitializeComponent();

            RootPage = pRootPage;
            InstalationError = pInstalationError;
            Exc = pExc;
        }

        private void InstalationComplete_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
            LoadLang();

            if (InstalationError)
            {
                MainLogo.Image = Properties.Resources.FatalError;

                TitleLabel.Text = TaiyouUtils.Lang.Get("InstalationError_Title");
                InstallCompleteLabel.Text = TaiyouUtils.Lang.Get("InstalationError_DescriptionText").Replace("$1", Exc.Message);
                FinishButton.Text = TaiyouUtils.Lang.Get("InstalationError_FinishButton");

            }
        }

        public void LoadLang()
        {
            TitleLabel.Text = TaiyouUtils.Lang.Get("InstalationComplete_Title");
            InstallCompleteLabel.Text = TaiyouUtils.Lang.Get("InstalationComplete_DescriptionText");
            FinishButton.Text = TaiyouUtils.Lang.Get("InstalationComplete_FinishButton");

        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            // Delete the temporary directory
            Directory.Delete(Program.TempDirToWorkWith, true);
            
            // Start newly installed program only if instalation didn't errored out
            if (!InstalationError) { Process.Start(RootPage.PathToChargerPlugEventExecutable); }
            

            Environment.Exit(0);
        }
    }
}
