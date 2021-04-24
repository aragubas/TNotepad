using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using TaiyouUI;

namespace TNotepad
{ 
    public class PluginAPI
    {

        public PluginAPI()
        {

        }

        public void SettingsUpdate()
        {
            Utils.ApplyTaiyouUISettings();
        }

        public void HelloWorld()
        {
            Console.WriteLine("Hello World Test! from TabNotepad version {" + Utils.GetVersionWithBuild() + "}");

        }

    }

    public static class PluginManager
    {
        public static string PluginPath;

        public static void LoadPlugins(BackgroundWorker bgWorker = null)
        {
            PluginPath = Environment.CurrentDirectory + "\\plugins\\";
            Console.WriteLine("PluginLoader : Plugin Path is {" + PluginPath + "}");
            DirectoryInfo fileInfo = new DirectoryInfo(PluginPath);
            FileInfo[] Files = fileInfo.GetFiles();

            int Wax = -1;
            foreach (FileInfo file in Files)
            {
                Wax += 1;
                if (file.Extension != ".dll")
                {
                    if (bgWorker != null)
                    {
                        var progress = (int)Math.Ceiling(((float)Wax / Files.Length) * 100);
                        bgWorker.ReportProgress(progress);
                    }

                    continue;
                }

                var DLL = Assembly.LoadFile(file.FullName);
                Console.WriteLine("PluginLoader : Found plugin {" + file.Name + "}");
                foreach (Type type in DLL.GetExportedTypes())
                {
                    dynamic C = Activator.CreateInstance(type);
                    C.Initialize(Utils.InstanceAPI);
                    Console.WriteLine("PluginLoader : Plugin initialized sucefully");
                }

                if (bgWorker != null)
                {
                    var progress = (int)Math.Ceiling(((float)Wax / Files.Length) * 100);
                    bgWorker.ReportProgress(progress);
                }

                

            }

        }
    }
}
