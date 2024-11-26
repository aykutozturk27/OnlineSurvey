using OnlineSurvey.Core.Entities;

namespace OnlineSurvey.Entities.Concrete
{
    public class OperationClaim : BaseEntity
    {
        public string Name { get; set; }

        public IList<UserOperationClaim> UserOperationClaims { get; set; }
    }
}
