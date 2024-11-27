using OnlineSurvey.Core.Entities;
using OnlineSurvey.Entities.Concrete;

namespace OnlineSurvey.Entities.Dtos
{
    public class PollResultDto : IDto
    {
        public string Title { get; set; }
        public string UserName { get; set; }
        public List<Option> Options { get; set; }
    }
}
