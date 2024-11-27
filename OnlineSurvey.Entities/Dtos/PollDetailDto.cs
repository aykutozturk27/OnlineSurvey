using OnlineSurvey.Core.Entities;

namespace OnlineSurvey.Entities.Dtos
{
    public class PollDetailDto : IDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string UserName { get; set; }
    }
}
