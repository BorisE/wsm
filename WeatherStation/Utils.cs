using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Deployment;
using System.Deployment.Application;
using System.Reflection;

namespace WeatherStation
{
    class Utils
    {

        public static void CreateShortcut(string name)
        {
            ApplicationDeployment ad = ApplicationDeployment.CurrentDeployment;

            if (ad.IsFirstRun)
            {
                Assembly assembly = Assembly.GetEntryAssembly();
                string company = string.Empty;
                string description = string.Empty;

                // Company name
                if (Attribute.IsDefined(assembly, typeof(AssemblyCompanyAttribute)))
                {
                    AssemblyCompanyAttribute ascompany = (AssemblyCompanyAttribute)Attribute.GetCustomAttribute(assembly, typeof(AssemblyCompanyAttribute));
                    company = ascompany.Company;
                }

                // Description
                if (Attribute.IsDefined(assembly, typeof(AssemblyDescriptionAttribute)))
                {
                    AssemblyDescriptionAttribute asdescription = (AssemblyDescriptionAttribute)Attribute.GetCustomAttribute(assembly, typeof(AssemblyDescriptionAttribute));
                    description = asdescription.Description;
                }
                
                if (!string.IsNullOrEmpty(company))
                {
                    string desktopPath = string.Empty;
                    desktopPath = string.Concat(Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                                    "\\",
                                    description,
                                    ".appref-ms");

                    string shortcutName = string.Empty;
                    shortcutName = string.Concat(
                                     Environment.GetFolderPath(Environment.SpecialFolder.Programs),
                                     "\\",
                                     company,
                                     "\\",
                                     description,
                                     ".appref-ms");

                    System.IO.File.Copy(shortcutName, desktopPath, true);
                }
            }
        }
    }
}
