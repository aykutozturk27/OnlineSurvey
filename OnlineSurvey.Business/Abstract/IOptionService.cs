using OnlineSurvey.Core.Utilities.Results.Abstract;
using OnlineSurvey.Entities.Dtos;

namespace OnlineSurvey.Business.Abstract
{
    public interface IOptionService
    {
        IResult Update(OptionUpdateDto optionDto);
    }
}
