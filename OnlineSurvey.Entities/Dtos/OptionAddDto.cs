using OnlineSurvey.Core.Entities;

namespace OnlineSurvey.Entities.Dtos
{
    public class OptionAddDto : IDto
    {
        public int PollId { get; set; }
        public string OptionText { get; set; }
        public int VoteCount { get; set; }
    }
}
