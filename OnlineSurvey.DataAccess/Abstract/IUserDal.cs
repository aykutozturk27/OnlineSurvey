using OnlineSurvey.Core.DataAccess;
using OnlineSurvey.Entities.Concrete;

namespace OnlineSurvey.DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        List<OperationClaim> GetClaims(User user);
    }
}
