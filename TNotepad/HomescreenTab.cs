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

namespace TNotepad
{
    public partial class HomescreenTab : UserControl
    {
        MainForm RootControl;


        public HomescreenTab(MainForm pRootControl)
        {
            InitializeComponent();

            RootControl = pRootControl;

            Dock = DockStyle.Fill;
            ReloadPinnedDocuments();
            LoadLangStrings();

        }

        private void HomescreenTab_Load(object sender, EventArgs e)
        {

        }

        public void LoadLangStrings()
        {
            ReloadPinDocListButton.Text = Lang.GetLangData("PinnedDocuments_ReloadListButton");
            SaveChangesButton.Text = Lang.GetLangData("PinnedDocuments_SaveChangesButton");
            RollbackChanges.Text = Lang.GetLangData("PinnedDocuments_RollbackChangesButton");
            OpenPinDocButton.Text = Lang.GetLangData("PinnedDocuments_OpenPinDocButton");
            EditPinDocButton.Text = Lang.GetLangData("PinnedDocuments_EditPinDocButton");
            DeletePinDocButton.Text = Lang.GetLangData("PinnedDocuments_RemovePinDocButton");
            PinnedDocsTitle.Text = Lang.GetLangData("PinnedDocuments_PinDocsTitle");

            PinDocsView.Columns[0].Text = Lang.GetLangData("PinnedDocuments_ListViewCollumsText_PinName");
            PinDocsView.Columns[1].Text = Lang.GetLangData("PinnedDocuments_ListViewCollumsText_FilePath");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void ReloadPinnedDocuments()
        {
            PinDocsView.Items.Clear();
            try
            {
                if (Properties.Settings.Default.PinnedDocuments == null)
                {
                    NoDocumentsPinned();
                    return;
                }
                int PinDocsCount = Properties.Settings.Default.PinnedDocuments.Count;
                if (PinDocsCount < 1)
                {
                    NoDocumentsPinned();
                    return;
                }


                int Index = -1;
                foreach (var item in Properties.Settings.Default.PinnedDocuments)
                {
                    Index += 1;
                    string ItemName = "";
                    string ItemPath = "";

                    string[] SplitAction = item.Split(';');

                    foreach (var SubSplit in SplitAction)
                    {
                        string[] EventSplit = SubSplit.Split('|');

                        switch (EventSplit[0])
                        {
                            case "name":
                                ItemName = EventSplit[1];
                                break;

                            case "path":
                                ItemPath = EventSplit[1];
                                break;

                        }

                    }

                    string ItemFinal = "Name: " + ItemName + " at (" + ItemPath + ")";
                    ListViewItem Ceira = new ListViewItem();

                    Ceira.Text = ItemName;
                    Ceira.Tag = ItemPath + "|" + Index;
                    Ceira.SubItems.Add(ItemPath);
                    PinDocsView.Items.Add(Ceira);

                    // Re-Enable Panel1 if disabled
                    splitContainer1.Panel1.Enabled = true;
                    TipPinLabel.Text = Lang.GetLangData("PinnedDocuments_TipPinLabelText");

                }

            } 
            catch (Exception ex)
            {
                NoDocumentsPinned();
            }

        }

        private void NoDocumentsPinned()
        {
            TipPinLabel.Text = Lang.GetLangData("PinnedDocuments_TipPinLabel_NoPinnedDocuments");

        }

        private void OpenPinDocButton_Click(object sender, EventArgs e)
        {
            if (PinDocsView.SelectedItems.Count > 1)
            {
                if (MessageBox.Show(Lang.GetLangData("PinnedDocuments_OpenMultipleDocuments_Text"), Lang.GetLangData("PinnedDocuments_OpenMultipleDocuments_Title"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }

            }
            foreach (ListViewItem Selected in PinDocsView.SelectedItems)
            {
                RootControl.CreateNewTabWithOpenDocument(Selected.Tag.ToString().Split('|')[0]);

            }

        }

        private void PinDocsView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ReloadPinDocListButton_Click(object sender, EventArgs e)
        {
            ReloadPinnedDocuments();
        }

        private void EditPinDocButton_Click(object sender, EventArgs e)
        {
            if (PinDocsView.SelectedItems.Count > 1)
            {
                MessageBox.Show(Lang.GetLangData("PinnedDocuments_EditMultiplePins_Text"), Lang.GetLangData("PinnedDocuments_EditMultiplePins_Title"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }


        }

        private void DeletePinDocButton_Click(object sender, EventArgs e)
        {
            // Return if nothing was selected
            if (PinDocsView.SelectedItems.Count < 1) { return; }

            // Ask for file removal
            if (PinDocsView.SelectedItems.Count >= 2)
            {
                // Ask for multiple file removal
                if (MessageBox.Show(Lang.GetLangData("PinnedDocuments_DeleteMultiplePinsDialogBox_Text"), Lang.GetLangData("PinnedDocuments_DeleteMultiplePinsDialogBox_Title"), MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                {
                    return;
                }

            }
            else
            {
                // Ask for single file removal
                if (MessageBox.Show(Lang.GetLangData("PinnedDocuments_DeleteSinglePinDialogBox_Text").Replace("$1", PinDocsView.SelectedItems[0].Text), Lang.GetLangData("PinnedDocuments_DeleteSinglePinDialogBox_Title"), MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                {
                    return;
                }

            }

            // Create a reference to OldList
            System.Collections.Specialized.StringCollection OldList = Properties.Settings.Default.PinnedDocuments;
            int IndexOffset = -1;
            foreach (ListViewItem Selected in PinDocsView.SelectedItems)
            { 
                int ItemIndex = Convert.ToInt32(Selected.Tag.ToString().Split('|')[1]);

                if (IndexOffset > 1)
                {
                    ItemIndex -= IndexOffset;
                }

                IndexOffset += 1;
                try
                {
                    int WaxIndex = -1;
                    int FoundIndex = -1;

                    Console.WriteLine("Searching for item...");
                    foreach (var item in OldList)
                    {
                        if (FoundIndex != -1)
                        {
                            break;
                        }
                        WaxIndex += 1;
                        string[] SplitAction = item.Split(';');

                        foreach (var SubSplit in SplitAction)
                        {
                            string[] EventSplit = SubSplit.Split('|');

                            switch (EventSplit[0])
                            {
                                case "path":
                                    if (EventSplit[1] == Selected.Tag.ToString().Split('|')[0])
                                    {
                                        Console.WriteLine("Found at index " + FoundIndex);
                                        FoundIndex = WaxIndex;
                                    }
                                    break;
                            }
                        }
                    }
                    Console.WriteLine("Trying to remove...");
                    OldList.RemoveAt(FoundIndex);
                    Console.WriteLine("Sucefully removed.");

                }
                catch (ArgumentOutOfRangeException) { Console.WriteLine("Error while removing last item."); continue; }

            }

            ReloadPinnedDocuments();


        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Lang.GetLangData("PinnedDocuments_SaveChangesDialogBox_Text"), Lang.GetLangData("PinnedDocuments_SaveChangesDialogBox_Title"), MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            {
                return;
            }

            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();
            ReloadPinnedDocuments();

        }

        private void RollbackChanges_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Lang.GetLangData("PinnedDocuments_RollbackChangesDialogBox_Text"), Lang.GetLangData("PinnedDocuments_RollbackChangesDialogBox_Title"), MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            {
                return;
            }

            Properties.Settings.Default.Reload();
            ReloadPinnedDocuments();
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            Refresh();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
