using IssueTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace IssueTracker.Data
{
    public class IssueTrackerContext : DbContext
    {
        public IssueTrackerContext(DbContextOptions<IssueTrackerContext> opt) : base(opt)
        {
            
        }

        public DbSet<Issue> Issues { get; set; }

    }
}