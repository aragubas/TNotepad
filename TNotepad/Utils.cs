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
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TNotepad
{
    static class Utils
    {

        static DateTime BuildDate = new DateTime(2000, 1, 1);

        public static string GetVersion()
        {
            var version = Assembly.GetExecutingAssembly().GetName().Version.Major + "." + Assembly.GetExecutingAssembly().GetName().Version.Minor;


            return version.ToString();
        }
        public static string GetVersionWithBuild()
        {
            var version = Assembly.GetExecutingAssembly().GetName().Version;

            return version.ToString();
        }

        public static string GetBuildDate()
        {
            var version = Assembly.GetExecutingAssembly().GetName().Version;

            var buildDate = BuildDate.AddDays(version.Build).AddSeconds(version.Revision * 2);

            return buildDate.ToString();

        }

        public static void CreateMainForm()
        {
            TabNotepadForm ParentForm = new TabNotepadForm();
            MainForm ParentControls = new MainForm(ParentForm);

            // Add controls to the form
            ParentForm.FormControls.Controls.Add(ParentControls);

            ParentForm.Text = "TNotepad v" + GetVersion();
            ParentForm.Show();

        }

        public static string GetBuildNumber()
        {
            var version = Assembly.GetExecutingAssembly().GetName().Version.Revision;

            return version.ToString();

        }

        public static Encoding EncodingNameToEncodingObject(string EncodingName="")
        {
            string CurrentValue = "";

            if (EncodingName == "") { CurrentValue = Properties.Settings.Default.DefaultEncoding; } else { CurrentValue = EncodingName; }

            switch (CurrentValue.ToUpper())
            {
                case "UTF-8":
                    return Encoding.UTF8;

                case "UTF-7":
                    return Encoding.UTF7;

                case "UNICODE":
                    return Encoding.Unicode;

                case "UTF-32":
                    return Encoding.UTF32;

                case "ASCII":
                    return Encoding.ASCII;

                default:
                    Console.WriteLine("Invalid value for encoding : " + CurrentValue);
                    return Encoding.UTF8;
            }

        }
        public static string GetCurrentEncodingName(Encoding CurrentValue)
        {
            if (CurrentValue == Encoding.UTF8)
            {
                return "UTF-8";

            }
            if (CurrentValue == Encoding.UTF7)
            {
                return "UTF-7";

            }
            if (CurrentValue == Encoding.UTF32)
            {
                return "UTF-32";

            }
            if (CurrentValue == Encoding.Unicode)
            {
                return "UNICODE";

            }
            if (CurrentValue == Encoding.ASCII)
            {
                return "ASCII";

            }

            return "INVALID_ENCODING";

        }


    }
}
