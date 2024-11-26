using OnlineSurvey.Core.Entities;

namespace OnlineSurvey.Entities.Dtos
{
    public class OptionUpdateDto : IDto
    {
        public int Id { get; set; }
        public int PollId { get; set; }
        public string OptionText { get; set; }
        public int VoteCount { get; set; }
    }
}
