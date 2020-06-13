using System.Collections.Generic;
using IssueTracker.Data;
using IssueTracker.Models;
using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers
{
    [Route("api/issues")]
    [ApiController]
    public class IssuesController : ControllerBase
    {
        private readonly IIssueTrackerRepo _repository;

        public IssuesController(IIssueTrackerRepo repository)
        {
          _repository = repository;  
        }

        //private readonly MockIssueTrackerRepo _repository = new MockIssueTrackerRepo();
        //GET api/issues
        [HttpGet]
        public ActionResult <IEnumerable<Issue>> GetIssues()
        {
            var issueItems = _repository.GetAllIssues();

            return Ok(issueItems);
        }          
        //GET api/issues/{id}
         [HttpGet("{id}")]
        public ActionResult <Issue> GetIssueById(int id)
        {
            var issueItem = _repository.GetIssueById(id);
            return Ok(issueItem);
        }

    }
}