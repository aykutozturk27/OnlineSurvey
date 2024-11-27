using AutoMapper;
using OnlineSurvey.Entities.Concrete;
using OnlineSurvey.Entities.Dtos;

namespace OnlineSurvey.Business.Mappings.AutoMapper.Profiles
{
    public class PollProfile : Profile
    {
        public PollProfile()
        {
            CreateMap<List<Poll>, PollListDto>()
                .ForMember(x => x.Polls, y => y.MapFrom(z => z.ToList()))
                .ReverseMap();
            CreateMap<Poll, PollDetailDto>().ReverseMap();
            CreateMap<Poll, PollAddDto>().ReverseMap();
        }
    }
}
