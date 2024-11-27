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
    public class PollManager : IPollService
    {
        private readonly IPollDal _pollDal;
        private readonly IMapper _mapper;

        public PollManager(IPollDal pollDal, IMapper mapper)
        {
            _pollDal = pollDal;
            _mapper = mapper;
        }

        public IResult Add(PollAddDto pollAddDto)
        {
            //if (pollAddDto.Options.Count < 2)
            //    return new ErrorResult(Messages.PollMustHaveAtLeastTwoOptions);

            var poll = _mapper.Map<Poll>(pollAddDto);

            var newPoll = new Poll
            {
                Title = pollAddDto.Title,
                UserId = pollAddDto.UserId,
            };

            var addedPoll = _pollDal.Add(newPoll);
            if (addedPoll == null)
                return new ErrorResult(addedPoll.Title + Messages.ErrorWhileNamedPollAdded);

            return new SuccessResult(addedPoll.Title + Messages.NamedPollAdded);
        }

        public IDataResult<PollListDto> GetAll()
        {
            var pollList = _pollDal.GetList();
            var mappedPollList = _mapper.Map<PollListDto>(pollList);
            return new SuccessDataResult<PollListDto>(mappedPollList, Messages.PollsListed);
        }

        public IDataResult<PollResultDto> GetPollResult(int pollId)
        {
            var mappedPoll = _pollDal.GetPollResult(pollId);
            return new SuccessDataResult<PollResultDto>(mappedPoll, Messages.PollListed);
        }
    }
}
