using OnlineSurvey.Core.Entities;

namespace OnlineSurvey.Entities.Concrete
{
    public class User : BaseEntity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string FullName => FirstName + " " + LastName;
        public string Email { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public bool Status { get; set; }
        public ICollection<Poll> Polls { get; set; }
        public virtual ICollection<UserOperationClaim>? UserOperationClaims { get; set; }

        public User()
        {
            UserOperationClaims = new HashSet<UserOperationClaim>();
        }
    }
}
