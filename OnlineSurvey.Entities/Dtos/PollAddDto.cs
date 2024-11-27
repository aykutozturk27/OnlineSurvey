using OnlineSurvey.Core.Entities;
using OnlineSurvey.Entities.Concrete;

namespace OnlineSurvey.Entities.Dtos
{
    public class PollAddDto : IDto
    {
        public string Title { get; set; }
        public int UserId { get; set; }
        public List<Option> Options { get; set; }
    }
}
