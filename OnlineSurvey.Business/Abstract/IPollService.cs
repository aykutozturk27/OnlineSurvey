using OnlineSurvey.Core.Utilities.Results.Abstract;
using OnlineSurvey.Entities.Dtos;

namespace OnlineSurvey.Business.Abstract
{
    public interface IPollService
    {
        IDataResult<PollListDto> GetAll();
        IDataResult<PollDetailDto> GetById(int pollId);
        IResult Add(PollAddDto pollDto);
    }
}
