using AutoMapper;
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
        private readonly IMapper _mapper;

        public OptionManager(IOptionDal optionDal, IMapper mapper)
        {
            _optionDal = optionDal;
            _mapper = mapper;
        }

        public IResult Add(OptionAddDto optionAddDto)
        {
            var newOption = new Option
            {
                OptionText = optionAddDto.OptionText,
                VoteCount = optionAddDto.VoteCount++,
                PollId = optionAddDto.PollId
            };

            var addedOption = _optionDal.Add(newOption);
            if (addedOption == null)
                return new ErrorResult(addedOption.OptionText + Messages.ErrorWhileNamedOptionAdded);

            return new SuccessResult(addedOption.OptionText + Messages.NamedOptionAdded);
        }

        public IDataResult<List<OptionListDto>> GetAll()
        {
            var optionList = _optionDal.GetOptionList();
            return new SuccessDataResult<List<OptionListDto>>(optionList, Messages.OptionsListed);
        }

        public IResult Update(OptionUpdateDto optionUpdateDto)
        {
            var option = _optionDal.Get(x => x.Id == optionUpdateDto.Id);

            var updateOption = new Option
            {
                Id = optionUpdateDto.Id,
                OptionText = optionUpdateDto.OptionText,
                VoteCount = optionUpdateDto.VoteCount++,
                PollId = optionUpdateDto.PollId
            };

            var updatedOption = _optionDal.Update(updateOption);
            if (updatedOption == null)
                return new ErrorResult(option.OptionText + Messages.ErrorWhileNamedOptionUpdated);

            return new SuccessResult(option.OptionText + Messages.NamedOptionUpdated);
        }
    }
}
