using AutoMapper;
using OnlineSurvey.Entities.Concrete;
using OnlineSurvey.Entities.Dtos;

namespace OnlineSurvey.Business.Mappings.AutoMapper.Profiles
{
    public class OptionProfile : Profile
    {
        public OptionProfile() {
            CreateMap<List<Option>, OptionListDto>().ReverseMap();
        }
    }
}
