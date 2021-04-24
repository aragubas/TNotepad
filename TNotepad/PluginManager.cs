using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace TNotepad
{
    public static class PluginManager
    {
        public static string PluginPath;

        public static void LoadPlugins(BackgroundWorker bgWork = null)
        {
            PluginPath = Environment.CurrentDirectory + "\\plugins\\";
            Console.WriteLine("PluginLoader : Plugin Path is {" + PluginPath + "}");
            DirectoryInfo fileInfo = new DirectoryInfo(PluginPath);

            foreach (FileInfo file in fileInfo.GetFiles())
            {
                if (file.Extension != ".dll") { continue; }

                var DLL = Assembly.LoadFile(file.FullName);
                Console.WriteLine("PluginLoader : Found plugin {" + file.Name + "}");
                foreach (Type type in DLL.GetExportedTypes())
                {
                    dynamic C = Activator.CreateInstance(type);
                    C.Initialize();
                    Console.WriteLine("PluginLoader : Plugin initialized sucefully");
                }
                

            }

        }
    }
}
