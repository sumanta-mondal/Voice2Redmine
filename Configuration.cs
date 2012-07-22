// -----------------------------------------------------------------------
// <copyright file="Configuration.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace voice2redmine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public static class Configuration
    {
        public static string RedmineHost { get; set; }
        public static string RedmineUser { get; set; }
        public static string RedminePassword { get; set; }

        public static void FILL()
        {
            RedmineHost = System.Configuration.ConfigurationManager.AppSettings["redmineHost"];
            RedmineUser = System.Configuration.ConfigurationManager.AppSettings["redmineUser"];
            RedminePassword = System.Configuration.ConfigurationManager.AppSettings["redmineUserPassword"];
            //RedmineHost = "http://192.168.56.2:8080/redmine";
        }
    }
}
