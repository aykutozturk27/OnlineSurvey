using OnlineSurvey.Core.Entities;
using OnlineSurvey.Entities.Concrete;

namespace OnlineSurvey.Entities.Dtos
{
    public class OptionListDto : IDto
    {
        public List<Option> Options { get; set; }
    }
}
