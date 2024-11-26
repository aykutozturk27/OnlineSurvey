using OnlineSurvey.Business.Abstract;
using OnlineSurvey.Business.Constants;
using OnlineSurvey.Core.Utilities.Results.Abstract;
using OnlineSurvey.Core.Utilities.Results.Concrete;
using OnlineSurvey.DataAccess.Abstract;
using OnlineSurvey.Entities.Concrete;
using OnlineSurvey.Entities.Dtos;

namespace OnlineSurvey.Business.Concrete.Managers
{
    public class OptionManager : IOptionService
    {
        private readonly IOptionDal _optionDal;

        public OptionManager(IOptionDal optionDal)
        {
            _optionDal = optionDal;
        }

        public IResult Update(OptionUpdateDto optionDto)
        {
            var option = _optionDal.Get(x => x.Id == optionDto.Id);

            var updateOption = new Option
            {
                Id = optionDto.Id,
                OptionText = optionDto.OptionText,
                VoteCount = optionDto.VoteCount++,
                PollId = optionDto.PollId
            };

            var updatedOption = _optionDal.Update(updateOption);
            if (updatedOption == null)
                return new ErrorResult(option.OptionText + Messages.ErrorWhileNamedOptionUpdated);

            return new SuccessResult(option.OptionText + Messages.NamedOptionUpdated);
        }
    }
}
