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
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using TaiyouUI;

namespace TNotepad
{
    public partial class ThemeSettings : taiyouUserControl
    {
        Size OriginalSize;
        public ThemeSettings()
        {
            InitializeComponent();

            OriginalSize = Size;
        }

        private void ThemeSettings_Load(object sender, EventArgs e)
        {
            LoadLang();
            LoadThemes();

            this.Dock = DockStyle.Fill;
            RootForm.Size = OriginalSize;
            RootForm.Text = Lang.GetLangData("ThemeSettings_WindowTitle");
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

        public void LoadThemes()
        {
            SelectedThemeTextBox.Text = Properties.Settings.Default.CurrentTheme;

            DirectoryInfo dirInfo = new DirectoryInfo(Program.ExecutablePath + "\\themes\\");

            foreach (var file in dirInfo.GetFiles("*.txt", SearchOption.TopDirectoryOnly))
            {
                string ThemeName = file.Name.Replace(".txt", "");
                Console.WriteLine("Found Theme : '" + ThemeName + "'");

                AvaliableThemesListBox.Items.Add(ThemeName);

            }

        }

        public void LoadLang()
        {
            RootForm.Text = Lang.GetLangData("ThemeSettings_WindowTitle");
            SelectedThemeInfoLabel.Text = Lang.GetLangData("ThemeSettings_SelectedThemeInfoLabel");
            AvaliableThemesListBox.Text = Lang.GetLangData("ThemeSettings_SelectThemeButton");
            AvaliableThemeFilesInfoLabel.Text = Lang.GetLangData("ThemeSettings_AvalibleThemesFileInfoLabel");
            ExitButton.Text = Lang.GetLangData("ThemeSettings_ExitButton");

        }

        BackgroundWorker bgWork;
        private void SelectThemeButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.CurrentTheme = SelectedThemeTextBox.Text;
            Properties.Settings.Default.Save();
            
            // Create background worker
            BackgroundWorker Ceira = new BackgroundWorker();
            Ceira.WorkerReportsProgress = true;
            bgWork = Ceira;
            Ceira.DoWork += Ceira_DoWork;
            
            Utils.CreateWindow(new BackgroundWorkerDialog(new List<BackgroundWorker>() { Ceira }), ShowAsDialog:true);

            MessageBox.Show(Lang.GetLangData("ThemeSettings_ThemeApplyMessage"), Lang.GetLangData("ThemeSettings_ThemeApplyMessage_Title"), MessageBoxButtons.OK, MessageBoxIcon.Information);

            RootForm.Close();
        }

        void Ceira_DoWork(object sender, DoWorkEventArgs e)
        {
            ThemeLoader.LoadDictData(Program.ExecutablePath + "\\themes\\" + Properties.Settings.Default.CurrentTheme + ".txt", bgWork);
        }

        private void AvaliableThemesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AvaliableThemesListBox.SelectedIndex == -1) { return; }
            SelectedThemeTextBox.Text = AvaliableThemesListBox.Items[AvaliableThemesListBox.SelectedIndex].ToString();

        }

        private void TopThingsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        { 
            RootForm.Close();
        }
    }
}
