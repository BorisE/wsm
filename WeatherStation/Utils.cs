using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Deployment;
using System.Deployment.Application;
using System.Reflection;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;
using System.Diagnostics;
using System.Web;
using System.Collections.Specialized;

namespace WeatherStation
{
    class AuxilaryProc
    {
        /// <summary>
        /// Create .lnk to ClickOnce shortcut with autostart parameters
        /// </summary>
        public static void CreateAutoStartLink()
        {
            Logging.Log("CreateAutoStartLink enter");
            
            try
            {
                ApplicationDeployment ad = ApplicationDeployment.CurrentDeployment;

                if (ad.IsFirstRun)
                {
                    Logging.Log("Creating autostart link file");

                    Assembly assembly = Assembly.GetEntryAssembly();

                    string company = string.Empty;
                    string description = string.Empty;
                    string productname = string.Empty;
                    string StartMenuShortcutName = string.Empty;

                    // Get company name
                    if (Attribute.IsDefined(assembly, typeof(AssemblyCompanyAttribute)))
                    {
                        AssemblyCompanyAttribute ascompany = (AssemblyCompanyAttribute)Attribute.GetCustomAttribute(assembly, typeof(AssemblyCompanyAttribute));
                        company = ascompany.Company;
                    }

                    // Get shortcut description
                    if (Attribute.IsDefined(assembly, typeof(AssemblyDescriptionAttribute)))
                    {
                        AssemblyDescriptionAttribute asdescription = (AssemblyDescriptionAttribute)Attribute.GetCustomAttribute(assembly, typeof(AssemblyDescriptionAttribute));
                        description = asdescription.Description;
                    }

                    // Get shortcut product name
                    if (Attribute.IsDefined(assembly, typeof(AssemblyProductAttribute)))
                    {
                        AssemblyProductAttribute asproduct = (AssemblyProductAttribute)Attribute.GetCustomAttribute(assembly, typeof(AssemblyProductAttribute));
                        productname = asproduct.Product;
                    }
                    Logging.Log(company + " | " + description + " | " + productname);

                    // Concat clickonce shortcut full path
                    if (!string.IsNullOrEmpty(company))
                    {
                        StartMenuShortcutName = string.Concat(
                                            Environment.GetFolderPath(Environment.SpecialFolder.Programs),
                                            "\\",
                                            company,
                                            "\\",
                                            productname,
                                            ".appref-ms");
                    }


                    //if everything is ok - create shortcut
                    if (!string.IsNullOrEmpty(StartMenuShortcutName))
                    {
                        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                        Utils.CreateLink("WeatherStation Monitor autostart", desktopPath, StartMenuShortcutName, "-start");
                    }
                    else
                    {
                        Logging.Log("Couldn't locate ClickOnce shortcut in start menu");
                    }
                }
            }
            catch (Exception ex)
            {
                StackTrace st = new StackTrace(ex, true);
                StackFrame[] frames = st.GetFrames();
                string messstr = "";

                // Iterate over the frames extracting the information you need
                foreach (StackFrame frame in frames)
                {
                    messstr += String.Format("{0}:{1}({2},{3})", frame.GetFileName(), frame.GetMethod().Name, frame.GetFileLineNumber(), frame.GetFileColumnNumber());
                }

                string FullMessage = "Error in creating Autostart link. ";
                FullMessage += "IOException source: " + ex.Data + " | " + ex.Message + " | " + messstr;

                Logging.Log(FullMessage);
            }

            Logging.Log("CreateAutoStartLink exit", 3);
        }


        /// <summary>
        /// Import settings from previously compiled versions
        /// </summary>
        public static void UpgradeSettings()
        {
            Logging.Log("UpgradeSettings enter",3);
            //Import settings from previously compiled versions
            if (Properties.Settings.Default.UpgradeRequired)
            {
                Logging.Log("Settings were copied from previous compile");
                Properties.Settings.Default.Upgrade();
                Properties.Settings.Default.UpgradeRequired = false;
            }
            
            Logging.Log("UpgradeSettings exit", 3);
        }


        /// <summary>
        /// Test and Parse command line arguments, including usual coomand line and ClickOnce URI parameters passing
        /// </summary>
        /// <param name="outAutoStart">(out) Returns autostart parameter</param>
        /// <param name="outComport">(out) Returns comport name</param>
        public static void CheckStartParams(out bool outAutoStart, out string outComport)
        {
            bool autostart = false;
            string Comport = string.Empty;

            //1. USUAL COMMAND LINE ARGUMENTS
            string[] args = Environment.GetCommandLineArgs();
            for (int i = 1; i < args.Length; i++)
            {
                if (args[i].IndexOf("start") >= 0)
                {
                    //AUTOSTART MONITORING
                    autostart = true;
                }
                else if (args[i].ToLower().Substring(0, 3) == "com")
                {
                    //RESET COM PORT NAME
                    Comport = args[i].ToLower();
                }
            }

            //2. ClickOnce parameters pass algorithm
            try
            {
                string cmdLine = AppDomain.CurrentDomain.SetupInformation.ActivationArguments.ActivationData[0];
                
                if (cmdLine != "")
                {
                    ////// for debug
                    //MessageBox.Show(cmdLine);
                    /////////
                    NameValueCollection nvc = HttpUtility.ParseQueryString(cmdLine);
                    string[] theKeys = nvc.AllKeys;

                    // if cmdline wasn't in GetQuery format, then force it to be one string delimetered by space
                    if (theKeys.Count() == 1 && string.IsNullOrEmpty(theKeys[0]))
                    {
                        theKeys = cmdLine.Split(' ');
                    }

                    foreach (string theKey in theKeys)
                    {
                        if (theKey.IndexOf("start") >= 0)
                        {
                            //AUTOSTART MONITORING
                            autostart = true;
                        }
                        else if (theKey.ToLower().Substring(0, 3) == "com")
                        {
                            //RESET COM PORT NAME
                            Comport = theKey.ToLower();
                        }
                    }
                }
            }
            catch { }

            outAutoStart = autostart;
            outComport = Comport;
        }
    }

/**************************************************************************************************************************************************
 * Module with program independent utils
 * 
 * 
 ***************************************************************************************************************************************************/
    class Utils
    {
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        /// <summary>
        /// Send current process window to foreground using WinAPI functions
        /// </summary>
        public static void SetCurrentWindowToForeground()
        {
            Process current = Process.GetCurrentProcess();
            foreach (Process process in Process.GetProcessesByName(current.ProcessName))
            {
                if (process.Id != current.Id)
                {
                    SetForegroundWindow(process.MainWindowHandle);
                    break;
                }
            }
        }
        
        /// <summary>
        /// Create windows .lnk file (shortcut)
        /// </summary>
        /// <param name="LinkName">The result name of the shortcut</param>
        /// <param name="LinkPath">Path where to place shortcut</param>
        /// <param name="ProgramFullPath">Full path to program</param>
        /// <param name="argm">Command line arguments to pass to program</param>
        static public void CreateLink(string LinkName, string LinkPath, string ProgramFullPath, string argm)
        {
            IShellLink link = (IShellLink)new ShellLink();

            // setup shortcut information
            link.SetDescription(LinkName);
            link.SetPath(ProgramFullPath);

            if (!string.IsNullOrEmpty(argm))
            {
                link.SetArguments(argm);
            }

            // save it
            IPersistFile file = (IPersistFile)link;
            file.Save(Path.Combine(LinkPath, LinkName + ".lnk"), false);
        }

        /// <summary>
        /// Create URL shortcut of current run program
        /// </summary>
        /// <param name="linkName">The name of the shortcut</param>
        /// <param name="linkPath">Path where to place the shortcut</param>
        public static void CreateURLShortcut(string linkName, string linkPath)
        {
            using (StreamWriter writer = new StreamWriter(linkPath + "\\" + linkName + ".url"))
            {
                string app = System.Reflection.Assembly.GetExecutingAssembly().Location;
                writer.WriteLine("[InternetShortcut]");
                writer.WriteLine("URL=file:///" + app);
                writer.WriteLine("IconIndex=0");

                string icon = app.Replace('\\', '/');
                writer.WriteLine("IconFile=" + icon);

                writer.Flush();
            }
        }
    
        /// <summary>
        /// Create ClickOnce Shortcut of the current program on desktop
        /// </summary>
        /// <param name="name"></param>
        public static void CreateClickOnceShortcut(string name)
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

    [ComImport]
    [Guid("00021401-0000-0000-C000-000000000046")]
    internal class ShellLink
    {
    }

    [ComImport]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [Guid("000214F9-0000-0000-C000-000000000046")]
    internal interface IShellLink
    {
        void GetPath([Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszFile, int cchMaxPath, out IntPtr pfd, int fFlags);
        void GetIDList(out IntPtr ppidl);
        void SetIDList(IntPtr pidl);
        void GetDescription([Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszName, int cchMaxName);
        void SetDescription([MarshalAs(UnmanagedType.LPWStr)] string pszName);
        void GetWorkingDirectory([Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszDir, int cchMaxPath);
        void SetWorkingDirectory([MarshalAs(UnmanagedType.LPWStr)] string pszDir);
        void GetArguments([Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszArgs, int cchMaxPath);
        void SetArguments([MarshalAs(UnmanagedType.LPWStr)] string pszArgs);
        void GetHotkey(out short pwHotkey);
        void SetHotkey(short wHotkey);
        void GetShowCmd(out int piShowCmd);
        void SetShowCmd(int iShowCmd);
        void GetIconLocation([Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszIconPath, int cchIconPath, out int piIcon);
        void SetIconLocation([MarshalAs(UnmanagedType.LPWStr)] string pszIconPath, int iIcon);
        void SetRelativePath([MarshalAs(UnmanagedType.LPWStr)] string pszPathRel, int dwReserved);
        void Resolve(IntPtr hwnd, int fFlags);
        void SetPath([MarshalAs(UnmanagedType.LPWStr)] string pszFile);
    }

}
