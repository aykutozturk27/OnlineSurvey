using OnlineSurvey.Core.Entities;

namespace OnlineSurvey.Entities.Concrete
{
    /// <summary>
    /// Seçenek tablosu
    /// </summary>
    public class Option : BaseEntity
    {
        public int PollId { get; set; }
        public string OptionText { get; set; }
        public int VoteCount { get; set; }

        public Poll Poll { get; set; }
    }
}
