﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WeatherStation.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("COM5")]
        public string comport {
            get {
                return ((string)(this["comport"]));
            }
            set {
                this["comport"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool resetArduino {
            get {
                return ((bool)(this["resetArduino"]));
            }
            set {
                this["resetArduino"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool logFileFlag {
            get {
                return ((bool)(this["logFileFlag"]));
            }
            set {
                this["logFileFlag"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string logFileLocation {
            get {
                return ((string)(this["logFileLocation"]));
            }
            set {
                this["logFileLocation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool CSVFileFlag {
            get {
                return ((bool)(this["CSVFileFlag"]));
            }
            set {
                this["CSVFileFlag"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string CSVFileLocation {
            get {
                return ((string)(this["CSVFileLocation"]));
            }
            set {
                this["CSVFileLocation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool BoltwoodFileFlag {
            get {
                return ((bool)(this["BoltwoodFileFlag"]));
            }
            set {
                this["BoltwoodFileFlag"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string BoltwoodFileLocation {
            get {
                return ((string)(this["BoltwoodFileLocation"]));
            }
            set {
                this["BoltwoodFileLocation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool WebDataFlag {
            get {
                return ((bool)(this["WebDataFlag"]));
            }
            set {
                this["WebDataFlag"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://astromania.info/checkconn/putweatherdata2a.php")]
        public string WebDataURL {
            get {
                return ((string)(this["WebDataURL"]));
            }
            set {
                this["WebDataURL"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10000")]
        public string RefreshInterval {
            get {
                return ((string)(this["RefreshInterval"]));
            }
            set {
                this["RefreshInterval"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("4320")]
        public string MaxPoints {
            get {
                return ((string)(this["MaxPoints"]));
            }
            set {
                this["MaxPoints"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("12")]
        public string Clearsky {
            get {
                return ((string)(this["Clearsky"]));
            }
            set {
                this["Clearsky"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("8")]
        public string Cloudysky {
            get {
                return ((string)(this["Cloudysky"]));
            }
            set {
                this["Cloudysky"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1010")]
        public string WetLimit {
            get {
                return ((string)(this["WetLimit"]));
            }
            set {
                this["WetLimit"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("980")]
        public string RainLimit {
            get {
                return ((string)(this["RainLimit"]));
            }
            set {
                this["RainLimit"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("-7")]
        public string K1 {
            get {
                return ((string)(this["K1"]));
            }
            set {
                this["K1"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("110")]
        public string K2 {
            get {
                return ((string)(this["K2"]));
            }
            set {
                this["K2"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("46")]
        public string K3 {
            get {
                return ((string)(this["K3"]));
            }
            set {
                this["K3"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("88")]
        public string K4 {
            get {
                return ((string)(this["K4"]));
            }
            set {
                this["K4"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("88")]
        public string K5 {
            get {
                return ((string)(this["K5"]));
            }
            set {
                this["K5"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("42")]
        public string K6 {
            get {
                return ((string)(this["K6"]));
            }
            set {
                this["K6"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("25")]
        public string K7 {
            get {
                return ((string)(this["K7"]));
            }
            set {
                this["K7"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ComWatchdog {
            get {
                return ((bool)(this["ComWatchdog"]));
            }
            set {
                this["ComWatchdog"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool SendToNarodmon {
            get {
                return ((bool)(this["SendToNarodmon"]));
            }
            set {
                this["SendToNarodmon"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("00-00-00-00-00-00")]
        public string Narodmon_MAC {
            get {
                return ((string)(this["Narodmon_MAC"]));
            }
            set {
                this["Narodmon_MAC"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Temp1")]
        public string BaseTempSensor {
            get {
                return ((string)(this["BaseTempSensor"]));
            }
            set {
                this["BaseTempSensor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string SensorName {
            get {
                return ((string)(this["SensorName"]));
            }
            set {
                this["SensorName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string SensorEnabled {
            get {
                return ((string)(this["SensorEnabled"]));
            }
            set {
                this["SensorEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string SensorType {
            get {
                return ((string)(this["SensorType"]));
            }
            set {
                this["SensorType"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string SensorSendToWeb {
            get {
                return ((string)(this["SensorSendToWeb"]));
            }
            set {
                this["SensorSendToWeb"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string SensorSendToNarodmon {
            get {
                return ((string)(this["SensorSendToNarodmon"]));
            }
            set {
                this["SensorSendToNarodmon"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string SensorArduinoName {
            get {
                return ((string)(this["SensorArduinoName"]));
            }
            set {
                this["SensorArduinoName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string SensorWebCustomName {
            get {
                return ((string)(this["SensorWebCustomName"]));
            }
            set {
                this["SensorWebCustomName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string SerialLogFileLocation {
            get {
                return ((string)(this["SerialLogFileLocation"]));
            }
            set {
                this["SerialLogFileLocation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool SerialLogFileFlag {
            get {
                return ((bool)(this["SerialLogFileFlag"]));
            }
            set {
                this["SerialLogFileFlag"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1 - Common messages")]
        public string LogLevel {
            get {
                return ((string)(this["LogLevel"]));
            }
            set {
                this["LogLevel"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string SensorFieldName {
            get {
                return ((string)(this["SensorFieldName"]));
            }
            set {
                this["SensorFieldName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("30")]
        public string HeatingMaxTemp {
            get {
                return ((string)(this["HeatingMaxTemp"]));
            }
            set {
                this["HeatingMaxTemp"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("300")]
        public string HeatingMaxDuration {
            get {
                return ((string)(this["HeatingMaxDuration"]));
            }
            set {
                this["HeatingMaxDuration"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1010")]
        public string HeatingWetThreshold {
            get {
                return ((string)(this["HeatingWetThreshold"]));
            }
            set {
                this["HeatingWetThreshold"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("13")]
        public string HeatingCSThresholdMin {
            get {
                return ((string)(this["HeatingCSThresholdMin"]));
            }
            set {
                this["HeatingCSThresholdMin"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public string WetSensorsMode {
            get {
                return ((string)(this["WetSensorsMode"]));
            }
            set {
                this["WetSensorsMode"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1800")]
        public string HeatingPauseTime {
            get {
                return ((string)(this["HeatingPauseTime"]));
            }
            set {
                this["HeatingPauseTime"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("17")]
        public string HeatingCSThresholdMax {
            get {
                return ((string)(this["HeatingCSThresholdMax"]));
            }
            set {
                this["HeatingCSThresholdMax"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public string HeatingCS_MinDelta {
            get {
                return ((string)(this["HeatingCS_MinDelta"]));
            }
            set {
                this["HeatingCS_MinDelta"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2")]
        public string HeatingCS_MaxDelta {
            get {
                return ((string)(this["HeatingCS_MaxDelta"]));
            }
            set {
                this["HeatingCS_MaxDelta"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool MinModeEnabled {
            get {
                return ((bool)(this["MinModeEnabled"]));
            }
            set {
                this["MinModeEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool MinimizeToSystemTray {
            get {
                return ((bool)(this["MinimizeToSystemTray"]));
            }
            set {
                this["MinimizeToSystemTray"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ShowDebugPannels {
            get {
                return ((bool)(this["ShowDebugPannels"]));
            }
            set {
                this["ShowDebugPannels"] = value;
            }
        }
    }
}
