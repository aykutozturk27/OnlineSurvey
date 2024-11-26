using OnlineSurvey.Core.Entities;

namespace OnlineSurvey.Entities.Concrete
{
    /// <summary>
    /// Anket tablosu
    /// </summary>
    public class Poll : BaseEntity
    {
        public string Title { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public ICollection<Option> Options { get; set; }
    }
}
