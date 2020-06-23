using System.Collections.Generic;
using AutoMapper;
using IssueTracker.Data;
using IssueTracker.Dtos;
using IssueTracker.Models;
using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers
{
    [Route("api/issues")]
    [ApiController]
    public class IssuesController : ControllerBase
    {
        private readonly IIssueTrackerRepo _repository;
        private readonly IMapper _mapper;

        public IssuesController(IIssueTrackerRepo repository, IMapper mapper)
        {
          _repository = repository;  
          _mapper = mapper;
        }

        //GET api/issues
        [HttpGet]
        public ActionResult <IEnumerable<IssueReadDto>> GetIssues()
        {
            var issueItems = _repository.GetAllIssues();

            return Ok(_mapper.Map<IEnumerable<IssueReadDto>>(issueItems));
        }          
        //GET api/issues/{id}
         [HttpGet("{id}", Name="GetIssueById")]
        public ActionResult <IssueReadDto> GetIssueById(int id)
        {
            var issueItem = _repository.GetIssueById(id);
            if(issueItem != null)
            {
            return Ok(_mapper.Map<IssueReadDto>(issueItem));
            }
            return NotFound();
        }

        //POST api/issues
        [HttpPost]
        public ActionResult <IssueReadDto> CreateIssue(IssueCreateDto issueCreateDto)
        {
            var issueModel = _mapper.Map<Issue>(issueCreateDto);
            _repository.CreateIssue(issueModel);
            _repository.SaveChanges();
            
            var issueReadDto = _mapper.Map<IssueReadDto>(issueModel);


            return CreatedAtRoute(nameof(GetIssueById), new {Id = issueReadDto.Id}, issueReadDto);
        }

        //PUT api/issues/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateIssue(int id, IssueUpdateDto issueUpdateDto)
        {
            var issueModelFromRepo = _repository.GetIssueById(id);
            if(issueModelFromRepo == null)
            {
                return NotFound();
            }

            _mapper.Map(issueUpdateDto, issueModelFromRepo);

            _repository.UpdateIssue(issueModelFromRepo);

            _repository.SaveChanges();

            return NoContent();

        }

    }
}