using OnlineSurvey.Core.Entities;
using OnlineSurvey.Entities.Concrete;

namespace OnlineSurvey.Entities.Dtos
{
    public class PollListDto : IDto
    {
        public List<Poll> Polls { get; set; }
    }
}
