using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitPlugin
{
    public class InitPlugin
    {

        public void Initialize(dynamic PluginAPI)
        {
            Console.WriteLine("TabNotepad Init Plugin v1.0");

            PluginAPI.SettingsUpdate();

            
        }
    }
}
