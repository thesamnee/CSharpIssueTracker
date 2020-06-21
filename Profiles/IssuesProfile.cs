using AutoMapper;
using IssueTracker.Dtos;
using IssueTracker.Models;

namespace IssueTracker.Profiles
{
    public class IssuesProfile : Profile
    {
        public IssuesProfile()
        {
            //Source -> Destination
            CreateMap<Issue, IssueReadDto>();
            CreateMap<IssueCreateDto, Issue>();
        }
    }
}