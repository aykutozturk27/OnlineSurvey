using OnlineSurvey.Core.Utilities.Results.Abstract;
using OnlineSurvey.Entities.Dtos;

namespace OnlineSurvey.Business.Abstract
{
    public interface IOptionService
    {
        IDataResult<List<OptionListDto>> GetAll();
        IResult Add(OptionAddDto optionAddDto);
        IResult Update(OptionUpdateDto optionUpdateDto);
    }
}
