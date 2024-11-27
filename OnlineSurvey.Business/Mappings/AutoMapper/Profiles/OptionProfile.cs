using AutoMapper;
using OnlineSurvey.Entities.Concrete;
using OnlineSurvey.Entities.Dtos;

namespace OnlineSurvey.Business.Mappings.AutoMapper.Profiles
{
    public class OptionProfile : Profile
    {
        public OptionProfile() {
            CreateMap<List<Option>, OptionListDto>()
                .ForMember(x => x.Options, y => y.MapFrom(z => z.ToList()))
                .ReverseMap();
        }
    }
}
