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
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace TNotepad
{
    public static class Lang
    {
        //static List<String> Language_StringData = new List<string>();
        public static Dictionary<string, string> LangData = new Dictionary<string, string>();
        public static string CurrentLangFile = "";

        public static string GetLangData(string Key)
        {
            if (!LangData.ContainsKey(Key))
            {
                throw new KeyNotFoundException("Cannot find key '" + Key + "' at language '" + Properties.Settings.Default.CurrentLanguage + "'");
            }

            return LangData[Key];
        }

        public static void LoadDictData(BackgroundWorker bgWorker = null)
        {
            LangData.Clear();
            CurrentLangFile = Program.ExecutablePath + "\\lang\\" + Properties.Settings.Default.CurrentLanguage + ".txt";

            //DicData should be located at (./lang_bank/en-us)
            if (!File.Exists(Lang.CurrentLangFile))
            {
                Console.WriteLine("Cannot locate language file.");
                Console.WriteLine(Lang.CurrentLangFile);
                throw new FileNotFoundException("Cannot locate language file.");
            }

            string[] FileRead = File.ReadAllLines(CurrentLangFile);


            int Wax = -1;
            foreach (string Line in FileRead)
            {
                Wax++;
                if (Line.StartsWith("#"))
                {
                    continue;
                }
                if (Line.Length < 10) { continue; }
                string[] LineSplit = Line.Split(';');
                string Key = "";
                string Data = "";

                foreach (string LineSplitData in LineSplit)
                {
                    if (Key == "")
                    {
                        Key = LineSplitData;
                        continue;
                    }
                    Data = LineSplitData.Replace("%n", "\n");
                }


                try
                {
                    LangData.Add(Key, Data);

                }
                catch (ArgumentException) { Console.WriteLine("Duplicate entry found, ignoring..."); continue; }
                Console.WriteLine("LangLoader: Added '" + Key + "' with value '" + Data + "'");

                if (bgWorker != null)
                {
                    var progress = (int)Math.Ceiling(((float)Wax / FileRead.Length) * 100);
                    bgWorker.ReportProgress(progress);
                }

            }

        }

    }
}
