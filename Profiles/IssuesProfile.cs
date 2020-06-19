using AutoMapper;
using IssueTracker.Dtos;
using IssueTracker.Models;

namespace IssueTracker.Profiles
{
    public class IssuesProfile : Profile
    {
        public IssuesProfile()
        {
            CreateMap<Issue, IssueReadDto>();
        }
    }
}