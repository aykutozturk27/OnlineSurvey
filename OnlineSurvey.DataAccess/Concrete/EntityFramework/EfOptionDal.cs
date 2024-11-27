using OnlineSurvey.Core.DataAccess.EntityFramework;
using OnlineSurvey.DataAccess.Abstract;
using OnlineSurvey.DataAccess.Concrete.EntityFramework.Contexts;
using OnlineSurvey.Entities.Concrete;
using OnlineSurvey.Entities.Dtos;

namespace OnlineSurvey.DataAccess.Concrete.EntityFramework
{
    public class EfOptionDal : EfEntityRepositoryBase<Option, OnlineSurveyContext>, IOptionDal
    {
        public List<OptionListDto> GetOptionList()
        {
            using (var context = new OnlineSurveyContext())
            {
                var result = from o in context.Options
                             join p in context.Polls
                             on o.PollId equals p.Id
                             select new OptionListDto
                             {
                                 OptionText = o.OptionText,
                                 VoteCount = o.VoteCount,
                                 PollId = p.Id,
                                 PollName = p.Title
                             };

                return result.ToList();
            }
        }
    }
}
