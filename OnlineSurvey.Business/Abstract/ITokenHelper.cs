using OnlineSurvey.Core.Utilities.Security.JWT;
using OnlineSurvey.Entities.Concrete;

namespace OnlineSurvey.Business.Abstract
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
