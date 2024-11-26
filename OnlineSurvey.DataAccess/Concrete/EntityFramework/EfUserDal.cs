using OnlineSurvey.Core.DataAccess.EntityFramework;
using OnlineSurvey.DataAccess.Abstract;
using OnlineSurvey.DataAccess.Concrete.EntityFramework.Contexts;
using OnlineSurvey.Entities.Concrete;

namespace OnlineSurvey.DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, OnlineSurveyContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new OnlineSurveyContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                                 on operationClaim.Id equals userOperationClaim.OperationClaimId
                             where userOperationClaim.UserId == user.Id
                             select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };

                return result.ToList();
            }
        }
    }
}
