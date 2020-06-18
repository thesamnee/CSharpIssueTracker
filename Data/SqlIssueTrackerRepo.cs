using System.Collections.Generic;
using System.Linq;
using IssueTracker.Models;

namespace IssueTracker.Data
{
    public class SqlIssueTrackerRepo : IIssueTrackerRepo
    {
        private readonly IssueTrackerContext _context;

        public SqlIssueTrackerRepo(IssueTrackerContext context)
        {
            _context = context;
        }
        public IEnumerable<Issue> GetAllIssues()
        {
            return _context.Issues.ToList();
        }

        public Issue GetIssueById(int id)
        {
            return _context.Issues.FirstOrDefault(p => p.Id == id);
        }
    }
}