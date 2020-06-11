using System.Collections.Generic;
using IssueTracker.Models;

namespace IssueTracker.Data
{
    public class MockIssueTrackerRepo : IIssueTrackerRepo
    {
        public IEnumerable<Issue> GetAllIssues()
        {
            var issues = new List<Issue>
            {
                new Issue{Id=0, Title="First Issue", Desc="This is a test issue", Status="no action needed"},
                new Issue{Id=1, Title="Second Issue", Desc="This is a test issue", Status="no action needed"},
                new Issue{Id=2, Title="Third Issue", Desc="This is a test issue", Status="no action needed"}
            };

            return issues;
        }

        public Issue GetIssueById(int id)
        {
            return new Issue{Id=0, Title="First Issue", Desc="This is a test issue", Status="no action needed"};
        }
    }
}