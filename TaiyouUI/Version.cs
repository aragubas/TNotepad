using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TaiyouUI
{
    public static class Version
    {
        static DateTime BuildDate = new DateTime(2000, 1, 1);

        /// <summary>
        /// Get version without Build Number
        /// </summary>
        /// <returns></returns>
        public static string GetVersion()
        {
            var version = Assembly.GetExecutingAssembly().GetName().Version.Major + "." + Assembly.GetExecutingAssembly().GetName().Version.Minor;


            return version.ToString();
        }

        /// <summary>
        /// Get Version with Build Number
        /// </summary>
        /// <returns></returns>
        public static string GetVersionWithBuild()
        {
            var version = Assembly.GetExecutingAssembly().GetName().Version;

            return version.ToString();
        }

        /// <summary>
        /// Get Build Date of TaiyouUI
        /// </summary>
        /// <returns></returns>
        public static string GetBuildDate()
        {
            var version = Assembly.GetExecutingAssembly().GetName().Version;

            var buildDate = BuildDate.AddDays(version.Build).AddSeconds(version.Revision * 2);

            return buildDate.ToString();

        }

        /// <summary>
        /// Get the BuildNumber of TaiyouUI
        /// </summary>
        /// <returns></returns>
        public static string GetBuildNumber()
        {
            var version = Assembly.GetExecutingAssembly().GetName().Version.Revision;

            return version.ToString();

        }


    }
}
