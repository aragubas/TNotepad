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

namespace TNotepad
{
    public partial class PinDocumentWizard : Form
    {
        TextEditingTab RootControl;
        string DocFileName;

        public PinDocumentWizard(TextEditingTab pRootControl)
        {
            InitializeComponent();
            RootControl = pRootControl;
        }

        public void LoadLang()
        {
            // Window Title
            Text = Lang.GetLangData("PinDocument_WindowTitle");

            // Pin name Label
            DocNameThingLabel.Text = Lang.GetLangData("PinDocument_PinNameLabel");

            // Save pin button
            PinDocButton.Text = Lang.GetLangData("PinDocument_PinDocButton");

        }
        private void PinDocumentWizard_Load(object sender, EventArgs e)
        {
            DocFileName = RootControl.LastFileName;
            LoadLang();

        }

        private void PinButton_Click(object sender, EventArgs e)
        {
            // Check if finename don't contain any invalid character
            if (textBox1.Text.Contains(":"))
            {
                MessageBox.Show("Title cannot contain ':' character.", "Invalid Character", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            // DocString data to be stored
            string DocString = "name|" + textBox1.Text + ";path|" + DocFileName;

            // Define the list if it has not been defined before
            try
            {
                if (Properties.Settings.Default.PinnedDocuments.Count == 0)
                {

                }

            }catch(NullReferenceException ex)
            {
                // Define the list
                Properties.Settings.Default.PinnedDocuments = new System.Collections.Specialized.StringCollection();
            }

            // Don't allow duplicate pins
            foreach (var item in Properties.Settings.Default.PinnedDocuments)
            {
                string[] SplitAction = item.Split(';');

                foreach (var SubSplit in SplitAction)
                {
                    string[] EventSplit = SubSplit.Split('|');

                    switch (EventSplit[0])
                    {
                        case "name":
                            if (EventSplit[1] == textBox1.Text)
                            {
                                MessageBox.Show(Lang.GetLangData("PinDocument_SameDocumentTitleAlreadyPinned_Text"), Lang.GetLangData("PinDocument_DuplicateDocumentPin_Title"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                Close();
                                return;
                            }
                            break;

                        case "path":
                            if (EventSplit[1] == DocFileName)
                            {
                                MessageBox.Show(Lang.GetLangData("PinDocument_SameDocumentAlreadyPinned_Text"), Lang.GetLangData("PinDocument_DuplicateDocumentPin_Title"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                Close();
                                return;
                            }
                            break;

                    }
                }
            }
            
            // Save the item to list
            Properties.Settings.Default.PinnedDocuments.Add(DocString);
            Properties.Settings.Default.Save();
            MessageBox.Show(Lang.GetLangData("PinDocument_DocumentSucefullyPinned_Text"), Lang.GetLangData("PinDocument_DocumentSucefullyPinned_Title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
