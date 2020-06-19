using System.Collections.Generic;
using IssueTracker.Models;

namespace IssueTracker.Data
{
    public interface  IIssueTrackerRepo 
    {
        bool SaveChanges();
        IEnumerable<Issue> GetAllIssues();
        Issue GetIssueById(int id);
        void CreateIssue(Issue iss);
    }
}