using OnlineSurvey.Core.DataAccess.EntityFramework;
using OnlineSurvey.DataAccess.Abstract;
using OnlineSurvey.DataAccess.Concrete.EntityFramework.Contexts;
using OnlineSurvey.Entities.Concrete;
using OnlineSurvey.Entities.Dtos;

namespace OnlineSurvey.DataAccess.Concrete.EntityFramework
{
    public class EfPollDal : EfEntityRepositoryBase<Poll, OnlineSurveyContext>, IPollDal
    {
        public PollDetailDto GetPollDetail(int pollId)
        {
            using (var context = new OnlineSurveyContext())
            {
                var result = from p in context.Polls
                             join u in context.Users
                             on p.UserId equals u.Id
                             where p.Id == pollId
                             select new PollDetailDto
                             {
                                 Id = p.Id,
                                 Title = p.Title,
                                 UserName = u.FullName
                             };

                return result.FirstOrDefault();
            }
        }
    }
}
