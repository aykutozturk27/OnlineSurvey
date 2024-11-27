using OnlineSurvey.Core.Entities;

namespace OnlineSurvey.Entities.Dtos
{
    public class PollAddDto : IDto
    {
        public string Title { get; set; }
        public int UserId { get; set; }
    }
}
