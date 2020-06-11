using System.Collections.Generic;
using IssueTracker.Models;

namespace IssueTracker.Data
{
    public interface  IIssueTrackerRepo 
    {
        IEnumerable<Issue> GetAllIssues();
        Issue GetIssueById(int id);
    }
}