using OnlineSurvey.Core.DataAccess;
using OnlineSurvey.Entities.Concrete;
using OnlineSurvey.Entities.Dtos;

namespace OnlineSurvey.DataAccess.Abstract
{
    public interface IOptionDal : IEntityRepository<Option>
    {
        List<OptionListDto> GetOptionList();
    }
}
