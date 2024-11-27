using Microsoft.EntityFrameworkCore;
using OnlineSurvey.Core.DataAccess.EntityFramework;
using OnlineSurvey.DataAccess.Abstract;
using OnlineSurvey.DataAccess.Concrete.EntityFramework.Contexts;
using OnlineSurvey.Entities.Concrete;
using OnlineSurvey.Entities.Dtos;

namespace OnlineSurvey.DataAccess.Concrete.EntityFramework
{
    public class EfPollDal : EfEntityRepositoryBase<Poll, OnlineSurveyContext>, IPollDal
    {
        public PollResultDto GetPollResult(int pollId)
        {
            using (var context = new OnlineSurveyContext())
            {
                var tableResult = from p in context.Polls
                             join u in context.Users
                             on p.UserId equals u.Id
                             where p.Id == pollId
                             select new PollResultDto
                             {
                                 Title = p.Title,
                                 UserName = u.FullName,
                             };

                var result = tableResult.Include(x => x.Options).FirstOrDefault();
                return result;
            }
        }
    }
}
