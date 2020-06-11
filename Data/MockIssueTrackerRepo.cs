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
                new Issue{Id=0, title="First Issue", desc="This is a test issue", status="no action needed"},
                new Issue{Id=0, title="Second Issue", desc="This is a test issue", status="no action needed"},
                new Issue{Id=0, title="Third Issue", desc="This is a test issue", status="no action needed"}
            };

            return issues;
        }

        public Issue GetIssueById(int id)
        {
            return new Issue{Id=0, title="First Issue", desc="This is a test issue", status="no action needed"};
        }
    }
}