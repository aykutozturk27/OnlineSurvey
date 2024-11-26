using AutoMapper;
using OnlineSurvey.Entities.Concrete;
using OnlineSurvey.Entities.Dtos;

namespace OnlineSurvey.Business.Mappings.AutoMapper.Profiles
{
    public class PollProfile : Profile
    {
        public PollProfile()
        {
            CreateMap<Poll, PollDto>().ReverseMap();
        }
    }
}
