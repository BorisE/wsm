﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeatherStation
{
    public class CommandInterpretator
    {
        public Dictionary<string, Func<string>> Commands = new Dictionary<string, Func<string>>();

        public CommandInterpretator()
        {
            //Commands = PassedCommands;
        }

        /// <summary>
        /// Method which doesn't return command output 
        /// </summary>
        /// <param name="CommandString">command</param>
        /// <returns>false if command doesn't exist</returns>
        public bool ParseSingleCommand(string CommandString)
        {
            bool ret = true;
            if (!Commands.ContainsKey(CommandString))
            {
                Logging.AddLog("Команды [" + CommandString + "] не существует", 0, Highlight.Error);
                ret = false;
            }
            string cmd_output = Commands[CommandString]();
            return ret;
        }

        /// <summary>
        /// Method override which returns command output 
        /// </summary>
        /// <param name="CommandString">command</param>
        /// <param name="cmd_output">command output</param>
        /// <returns>false if command doesn't exist</returns>
        public bool ParseSingleCommand(string CommandString, out string cmd_output)
        {
            bool ret = true;
            if (!Commands.ContainsKey(CommandString))
            {
                Logging.AddLog("Команды [" + CommandString + "] не существует", 0, Highlight.Error);
                cmd_output = "";
                ret = false;
            }
            else
            {
                cmd_output = Commands[CommandString]();
            }
            return ret;
        }


        public string ListCommands()
        {
            string st = "";

            foreach (KeyValuePair<string, Func<string>> entry in Commands)
            {
                st += entry.Key + ";";
            }

            return st;
        }
    }
}
