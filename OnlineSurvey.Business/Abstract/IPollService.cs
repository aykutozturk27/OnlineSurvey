using OnlineSurvey.Core.Utilities.Results.Abstract;
using OnlineSurvey.Entities.Dtos;

namespace OnlineSurvey.Business.Abstract
{
    public interface IPollService
    {
        IDataResult<PollDto> GetById(int pollId);
        IResult Add(PollDto pollDto);
    }
}
