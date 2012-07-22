// -----------------------------------------------------------------------
// <copyright file="IssueCreating.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace voice2redmine.redmine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Redmine.Net.Api;
    using Redmine.Net.Api.Types;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class rIssue
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int TrackerId { get; set; }
        public int ProjectId { get; set; }

        public bool Create()
        {
            try
            {
                RedmineManager manager = new RedmineManager(Configuration.RedmineHost,
                    Configuration.RedmineUser, Configuration.RedminePassword);

                //Create a issue.
                var newIssue = new Issue
                {
                    Subject = Title,
                    Description = Description,
                    Project = new IdentifiableName() { Id = ProjectId },
                    Tracker = new IdentifiableName() { Id = TrackerId }
                };

                User thisuser = (from u in manager.GetObjectList<User>(new System.Collections.Specialized.NameValueCollection())
                                 where u.Login == Configuration.RedmineUser
                                 select u).FirstOrDefault();
                if (thisuser != null)
                    newIssue.AssignedTo = new IdentifiableName() { Id = thisuser.Id };

                manager.CreateObject(newIssue);
            }
            catch { return false; }
            return true;
        }
    }
}
