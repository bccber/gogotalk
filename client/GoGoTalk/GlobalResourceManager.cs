using GoGoTalk.Models;
using System;
using System.Configuration;

namespace GoGoTalk
{
    public static class GlobalResourceManager
    {
        public readonly static String AppPath = AppDomain.CurrentDomain.BaseDirectory;
        public readonly static String ServerIP = ConfigurationManager.AppSettings["ServerIP"];
        public readonly static Int32 ServerPort = Int32.Parse(ConfigurationManager.AppSettings["ServerPort"]);

        public static User CurrentUser { get; set; }
    }
}
