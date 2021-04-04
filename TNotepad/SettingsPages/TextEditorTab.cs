﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TNotepad.SettingsPages
{
    public partial class TextEditorTab : UserControl
    {
        TabNotepadForm RootControl;

        public TextEditorTab(TabNotepadForm pRootControl)
        {
            InitializeComponent();
            RootControl = pRootControl;

            Dock = DockStyle.Fill;

            LoadValues();
            LoadLangStrings();
            LoadTheme();

        }

        public void LoadTheme()
        {
            // Default Colors
            BackColor = ThemeLoader.GetThemeData("Form_BackgroundColor");
            ForeColor = ThemeLoader.GetThemeData("Form_ForegroundColor");

            // Checkbox
            WordWrapCheckbox.LoadTheme();

            // FlowLayoutPanel
            flowLayoutPanel1.LoadTheme();

            // GroupBox
            WordWrapGroupBox.ForeColor = ForeColor;

        }

        public void LoadLangStrings()
        {
            WordWrapGroupBox.Text = Lang.GetLangData("Settings_TextEditor_WordWrapGroupBoxTitle");
            WordWrapCheckbox.Text = Lang.GetLangData("Settings_TextEditor_WordWrapCheckbox");
        }

        private void TextEditorTab_Load(object sender, EventArgs e)
        {
        }

        public void LoadValues()
        {
            WordWrapCheckbox.Checked = Properties.Settings.Default.WordWrapEnabled;

        }

        public void SaveSettings()
        {
            Properties.Settings.Default.WordWrapEnabled = WordWrapCheckbox.Checked;
            

        }


    }
}
