using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaiyouUI;
using TaiyouUtils;
using IWshRuntimeLibrary;

namespace Installer
{
    public partial class InstallerPage1 : taiyouUserControl
    {
        Size OriginalSize;
        
        
        public InstallerPage1()
        {
            InitializeComponent();
            OriginalSize = Size;
        }

        public void LoadLang()
        {
            RootForm.Text = TaiyouUtils.Lang.Get("WindowTitle");
            TitleLabel.Text = TaiyouUtils.Lang.Get("MainPage_TitleLabel");

        }


        private void InstallerPage1_Load(object sender, EventArgs e)
        {
            // Set MainForm Properties
            RootForm.FormCloseButton.Click += FormCloseButton_Click;
            RootForm.Size = OriginalSize;
            RootForm.ResizeableForm = false;
            RootForm.Icon = Properties.Resources.app_icon;

            // Set Dockstyle
            Dock = DockStyle.Fill;
            
            // Set InstallExtraPageSize
            InstallExtraPage.Width = Width;
            InstallExtraPage.Height = Height;
            InstallExtraPage.Location = new Point(0, Height);

            // Do first installation step
            NextStep();

        }

        public void ShowInstallExtraPage(taiyouUserControl ThingControls)
        {
            AnimationState = 0;
            InstallExtraPage.Controls.Clear();
            InstallExtraPage.Controls.Add(ThingControls);
            InstallExtraPage.Visible = true;
            InstallExtraPageAnimator.Start();

        }

        public void HideInstallExtraPage()
        {
            AnimationState = 1;
            InstallExtraPage.Visible = true;
            InstallExtraPageAnimator.Start();

        }

        void FormCloseButton_Click(object sender, EventArgs e)
        { 
            Environment.Exit(0);
        }

        int AnimationState = 0;
        int AnimationMultiplier = 1;

        public void StartInstalation()
        {
            TitleLabel.Text = TaiyouUtils.Lang.Get("MainPage_InstallingTitle");

        }

        private void LanguageWaxAnimator_Tick(object sender, EventArgs e)
        {
            if (AnimationState == 0) // Show Animation
            {
                AnimationMultiplier += 6;
                InstallExtraPage.Location = new Point(0, InstallExtraPage.Location.Y - AnimationMultiplier);

                // Hide controls when its not needed
                if (InstallExtraPage.Location.Y <= MainLogo.Location.Y)
                {
                    MainLogo.Visible = false;
                    progressBar1.Visible = false;
                }

                if (InstallExtraPage.Location.Y <= 0)
                {
                    AnimationMultiplier = 1;
                    InstallExtraPage.Location = new Point(0, 0);
                    AnimationState = 1;
                    InstallExtraPageAnimator.Stop();
                    return;
                }

            }
            else if (AnimationState == 1) // Hide Animation
            {
                AnimationMultiplier += 8;
                InstallExtraPage.Location = new Point(0, InstallExtraPage.Location.Y + AnimationMultiplier);

                // Show controls when its needed
                if (InstallExtraPage.Location.Y >= MainLogo.Location.Y)
                {
                    MainLogo.Visible = true;
                    progressBar1.Visible = true;
                }


                if (InstallExtraPage.Location.Y >= Height)
                {
                    AnimationMultiplier = 1;
                    InstallExtraPage.Location = new Point(0, Height);
                    AnimationState = 0;
                    InstallExtraPage.Visible = false;
                    InstallExtraPageAnimator.Stop();
                    InstallExtraPage.Controls.Clear();
                    return;
                }

            }

        }

        private void Instalation_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;

        }

        int CurrentStep = -1;
        private void NextStep()
        {
            CurrentStep += 1;

            switch (CurrentStep)
            {
                case 0:
                    // Show language selection
                    ShowInstallExtraPage(new LanguageSelection(this));
                    break;

                case 1:
                    // Show about screen
                    ShowInstallExtraPage(new AboutInstall(this));
                    break;
                
                case 2:
                    // Start Instalation
                    Instalation.RunWorkerAsync();
                    TitleLabel.Text = Lang.Get("MainPage_InstallingTitle");
                    Console.WriteLine("Instalation started");
                    break;


            }
        }

        public void NextInstallStep()
        {
            HideInstallExtraPage();
            NextStepDelay.Start();
        }

        private void NextStepDelay_Tick(object sender, EventArgs e)
        {
            NextStep();
            NextStepDelay.Stop();
        }

        string TaiyouSoftwarePath;
        string TaiyouSoftwareInstalationRegistryPath;
        public string TNotepadInstallPath;
        public string PathToChargerPlugEventExecutable;
        string LanguageForceName;

        private void SetUpInstallPath()
        {
            TaiyouSoftwarePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\TaiyouSoftware";
            TaiyouSoftwareInstalationRegistryPath = TaiyouSoftwarePath + "\\InstalledSoftware\\";
            TNotepadInstallPath = TaiyouSoftwarePath + "\\TNotepad\\";
            LanguageForceName = TaiyouUtils.Lang.Get("LanguageLink");
            PathToChargerPlugEventExecutable = TNotepadInstallPath + Properties.Resources.ExecutableName;

            // Register instalation for future Taiyou Software Manager
            Directory.CreateDirectory(TaiyouSoftwarePath);
            Directory.CreateDirectory(TaiyouSoftwareInstalationRegistryPath);
            Directory.CreateDirectory(TNotepadInstallPath);


        }

        private void RegisterTaiyouInstalation()
        {
            // Write Install Info File
            System.IO.File.WriteAllText(TaiyouSoftwareInstalationRegistryPath + "TNotepad", Properties.Resources.TNotepad);


        }

        private void UnpackInstallPackpage()
        {
            // Copy instalation packpage to temporary folder
            string InstallPackpagePath = Program.TempDirToWorkWith + "InstalationPackpage.zip";
            System.IO.File.WriteAllBytes(InstallPackpagePath, Properties.Resources.InstalationPackpage);

            // Extract Zip File
            try
            {
                ZipFile.ExtractToDirectory(InstallPackpagePath, TNotepadInstallPath);

            }
            catch (System.IO.IOException)
            {
                this.Invoke(new Action(() => SetStatusText(TaiyouUtils.Lang.Get("InstallStatus_FileAlreadyExists"))));
                Directory.Delete(TNotepadInstallPath, true);

                ZipFile.ExtractToDirectory(InstallPackpagePath, TNotepadInstallPath);

            }

        }

        private void SetDefaultLanguage()
        {
            System.IO.File.WriteAllText(TNotepadInstallPath + "\\force-lang.command", LanguageForceName);
            
        }

        private void CreateDesktopShortcut()
        {
            TaiyouUtils.Utils.CreateDesktopShortcut(TNotepadInstallPath + "\\" + Properties.Resources.ExecutableName, TNotepadInstallPath, "TabNotepad by Aragubas", "TabNotepad", TNotepadInstallPath + "\\icon.ico");
        }

        private void SetStatusText(string Text)
        {
            StatusLabel.Text = Text;
        }

        private void Instalation_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                // Set up install path
                this.Invoke(new Action(() => SetStatusText(TaiyouUtils.Lang.Get("InstallStatus_SetUpInstallPath"))));
                SetUpInstallPath();

                // Register Instalation
                this.Invoke(new Action(() => SetStatusText(TaiyouUtils.Lang.Get("InstallStatus_RegisterInstalation"))));
                RegisterTaiyouInstalation();

                // Unpack Installer Packpage
                this.Invoke(new Action(() => SetStatusText(TaiyouUtils.Lang.Get("InstallStatus_UnpackInstallerPackpage"))));
                UnpackInstallPackpage();

                // Set Default Language
                this.Invoke(new Action(() => SetStatusText(TaiyouUtils.Lang.Get("InstallStatus_SetCorrectLanguage"))));
                SetDefaultLanguage();

                // Create Desktop Shortcut
                this.Invoke(new Action(() => SetStatusText(TaiyouUtils.Lang.Get("InstallStatus_CreateDesktopShortcut"))));
                CreateDesktopShortcut();

            } catch (Exception ex)
            {
                // Finish Instalation with error
                Instalation.ReportProgress(100);
                this.Invoke(new Action(() => SetStatusText(TaiyouUtils.Lang.Get("InstallStatus_InstalationError"))));
                this.Invoke(new Action(() => ShowInstallExtraPage(new InstalationComplete(this, true, ex))));
                return;
            }


            // Finish Instalation
            Instalation.ReportProgress(100);
            this.Invoke(new Action(() => SetStatusText(TaiyouUtils.Lang.Get("InstallStatus_InstalationFinished"))));
            this.Invoke(new Action(() => ShowInstallExtraPage(new InstalationComplete(this))));
        }


    }
}
