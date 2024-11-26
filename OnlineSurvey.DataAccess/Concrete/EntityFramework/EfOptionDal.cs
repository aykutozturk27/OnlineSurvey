using OnlineSurvey.Core.DataAccess.EntityFramework;
using OnlineSurvey.DataAccess.Abstract;
using OnlineSurvey.DataAccess.Concrete.EntityFramework.Contexts;
using OnlineSurvey.Entities.Concrete;

namespace OnlineSurvey.DataAccess.Concrete.EntityFramework
{
    public class EfOptionDal : EfEntityRepositoryBase<Option, OnlineSurveyContext>, IOptionDal
    {
    }
}
