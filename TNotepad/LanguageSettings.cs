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
using TaiyouUI;

namespace TNotepad
{
    public partial class LanguageSettings : taiyouUserControl
    {
        Size OriginalSize;
        public LanguageSettings()
        {
            InitializeComponent();

            LoadAvaliableLanguages();
            LoadLang();

            CurrentLanguageTextBox.Text = Properties.Settings.Default.CurrentLanguage;

            OriginalSize = Size;
        }


        private void ExitButton_Click(object sender, EventArgs e)
        {
            RootForm.Close();
        }

        private void LanguageSettings_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            RootForm.Size = OriginalSize;
            RootForm.Text = Lang.GetLangData("LanguageSettings_WindowTitle");
            RootForm.MinimizeableForm = false;
            RootForm.ResizeableForm = false;
            // Set Icon
            RootForm.Icon = Properties.Resources.Icon;

            RootForm.FormCloseButton.Click += FormCloseButton_Click;

        }

        void FormCloseButton_Click(object sender, EventArgs e)
        {
            RootForm.Close();
        }

        public void LoadLang()
        {
            // Buttons
            ConfirmButton.Text = Lang.GetLangData("LanguageSettings_ConfirmButton");
            ExitButton.Text = Lang.GetLangData("LanguageSettings_ExitButton");

            // Labels
            AvaliableLanguageFilesInfoLabel.Text = Lang.GetLangData("LanguageSettings_AvaliableLanguageFiles");
            CurrentLanguageInfoLabel.Text = Lang.GetLangData("LanguageSettings_CurrentLanguageLabel");
        }

        public void LoadAvaliableLanguages()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(Program.ExecutablePath + "\\lang"); ;
            FileInfo[] files = directoryInfo.GetFiles("*.txt");

            foreach(var file in files)
            {
                string LangName = file.Name.Replace(".txt", "");
                AvaliableLanguagesListBox.Items.Add(LangName);
            }
        }

        private void AvaliableLanguagesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentLanguageTextBox.Text = AvaliableLanguagesListBox.Items[AvaliableLanguagesListBox.SelectedIndex].ToString();
        }

        BackgroundWorker bgWork;
        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (CurrentLanguageTextBox.Text == "")
            {
                ExitButton.PerformClick();
            }

            bgWork = new BackgroundWorker();
            bgWork.WorkerReportsProgress = true;
            bgWork.DoWork += bgWork_DoWork;

            Properties.Settings.Default.CurrentLanguage = CurrentLanguageTextBox.Text;
            Properties.Settings.Default.Save();

            Utils.CreateWindow(new BackgroundWorkerDialog(new List<BackgroundWorker>() { bgWork }), ShowAsDialog: true);


            LoadLang();
            this.Refresh();
            MessageBox.Show(Lang.GetLangData("LanguageChangeMessageBox_Text"), Lang.GetLangData("LanguageChangeMessageBox_Title"));

            RootForm.Close();
        }

        void bgWork_DoWork(object sender, DoWorkEventArgs e)
        {
            Lang.LoadDictData(bgWork);

        }
    }
}
