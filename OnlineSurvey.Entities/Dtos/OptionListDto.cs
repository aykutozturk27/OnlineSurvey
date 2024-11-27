using OnlineSurvey.Core.Entities;

namespace OnlineSurvey.Entities.Dtos
{
    public class OptionListDto : IDto
    {
        public string OptionText { get; set; }
        public int VoteCount { get; set; }
        public int PollId { get; set; }
        public string PollName { get; set; }
    }
}
