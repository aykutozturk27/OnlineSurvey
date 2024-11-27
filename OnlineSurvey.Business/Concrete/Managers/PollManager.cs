using AutoMapper;
using Microsoft.AspNetCore.Http;
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
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IUserDal _userDal;

        public PollManager(IPollDal pollDal, IMapper mapper, IHttpContextAccessor httpContextAccessor, IUserDal userDal)
        {
            _pollDal = pollDal;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
            _userDal = userDal;
        }

        public IResult Add(PollAddDto pollAddDto)
        {
            var createdUserId = _userDal.Get(x => x.Email == _httpContextAccessor.HttpContext.User.Identity.Name).Id;

            if (pollAddDto.Options.Count < 2)
                return new ErrorResult(Messages.PollMustHaveAtLeastTwoOptions);

            var poll = _mapper.Map<Poll>(pollAddDto);

            var newPoll = new Poll
            {
                Title = pollAddDto.Title,
                UserId = createdUserId,
                Options = pollAddDto.Options
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

        public IDataResult<PollDetailDto> GetById(int pollId)
        {
            var mappedPoll = _pollDal.GetPollDetail(pollId);
            return new SuccessDataResult<PollDetailDto>(mappedPoll, Messages.PollListed);
        }
    }
}
