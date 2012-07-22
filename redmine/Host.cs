// -----------------------------------------------------------------------
// <copyright file="Host.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace voice2redmine.redmine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Redmine.Net.Api.Types;
    using System.Collections.Specialized;
    using Redmine.Net.Api;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class Host
    {
        public static Dictionary<string, int> GetProjects()
        {
            RedmineManager manager = new RedmineManager(Configuration.RedmineHost,
                Configuration.RedmineUser, Configuration.RedminePassword);
            Dictionary<string, int> Projects = new Dictionary<string, int>();

            foreach (Project proj in manager.GetObjectList<Project>(new NameValueCollection()))
            {
                Projects.Add(proj.Name, proj.Id);
            }
            return Projects;
         }

        public static Dictionary<string, int> GetTrackers()
        {
            RedmineManager manager = new RedmineManager(Configuration.RedmineHost,
                Configuration.RedmineUser, Configuration.RedminePassword);
            Dictionary<string, int> Trackers = new Dictionary<string, int>();

            foreach (Tracker track in manager.GetObjectList<Tracker>(new NameValueCollection()))
            {
                Trackers.Add(track.Name, track.Id);
            }
            return Trackers;
        }
    }
}
