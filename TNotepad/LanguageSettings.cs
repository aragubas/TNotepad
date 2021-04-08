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
            DirectoryInfo directoryInfo = new DirectoryInfo(Environment.CurrentDirectory + "\\lang"); ;
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

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (CurrentLanguageTextBox.Text == "")
            {
                ExitButton.PerformClick();
            }

            Properties.Settings.Default.CurrentLanguage = CurrentLanguageTextBox.Text;
            Properties.Settings.Default.Save();
            Lang.LoadDictData();
            LoadLang();
            this.Refresh();
            MessageBox.Show(Lang.GetLangData("LanguageChangeMessageBox_Text"), Lang.GetLangData("LanguageChangeMessageBox_Title"));
            RootForm.Close();
        }
    }
}
