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

        public IResult Add(PollDto pollDto)
        {
            if (pollDto.Options.Count < 2)
                return new ErrorResult(Messages.PollMustHaveAtLeastTwoOptions);

            var poll = _mapper.Map<Poll>(pollDto);

            var newPoll = new Poll
            {
                Title = pollDto.Title,
                UserId = pollDto.UserId
            };

            var addedPoll = _pollDal.Add(newPoll);
            if (addedPoll == null)
                return new ErrorResult(addedPoll.Title + Messages.ErrorWhileNamedPollAdded);

            return new SuccessResult(addedPoll.Title + Messages.NamedPollAdded);
        }

        public IDataResult<PollDto> GetById(int pollId)
        {
            var poll = _pollDal.Get(x => x.Id == pollId);
            var mappedPoll = _mapper.Map<PollDto>(poll);
            return new SuccessDataResult<PollDto>(mappedPoll, Messages.PollListed);
        }
    }
}
