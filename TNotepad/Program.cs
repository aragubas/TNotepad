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
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TNotepad
{
    static class Program
    {
        public static string ExecutablePath;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] Args)
        {
            // Set executable path
            ExecutablePath = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);

            // Write Build number to file
            File.WriteAllText(ExecutablePath + "\\build_info.txt", Utils.GetVersionWithBuild(), new System.Text.UTF8Encoding());
            
            // Enable visual styles
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Console.WriteLine("Listening to startup arguments...");
            foreach (string argument in Args)
            {
                Console.WriteLine(argument);
                if (File.Exists(argument))
                {
                    Utils.OpenTabStartupArg = true;
                    Utils.OpenTabStartupArg_FileName = argument;
                }
            }

            Console.WriteLine("Install Path is: " + ExecutablePath);

            // Start InitialDB Load
            InitialDBLoad Ceira = new InitialDBLoad();
            Ceira.Show();

            Application.Run();
        }
    }
}
