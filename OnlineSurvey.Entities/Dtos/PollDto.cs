using OnlineSurvey.Core.Entities;

namespace OnlineSurvey.Entities.Dtos
{
    public class PollDto : IDto
    {
        public string Title { get; set; }
        public int UserId { get; set; }
        public List<string> Options { get; set; }
    }
}
