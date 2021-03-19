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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TabNotepad v" + Application.ProductVersion);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void About_Load(object sender, EventArgs e)
        {
            LicenseView.Text = Properties.Resources.ApacheLicense;

            InfosLabel.Text += "\n\nBuild Number: " + Utils.GetBuildNumber() + "\n\nBuild Date: " + Utils.GetBuildDate();
        }

        private void BuildInfo_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Build at " + Utils.GetBuildDate() + "\nBuild ID:" + Utils.GetBuildNumber(), "Build Info");
        }
    }
}
