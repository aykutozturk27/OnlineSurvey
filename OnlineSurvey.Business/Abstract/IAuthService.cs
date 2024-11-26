using OnlineSurvey.Core.Utilities.Results.Abstract;
using OnlineSurvey.Core.Utilities.Security.JWT;
using OnlineSurvey.Entities.Concrete;
using OnlineSurvey.Entities.Dtos;

namespace OnlineSurvey.Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password);
        IDataResult<User> Login(UserForLoginDto userForLoginDto);
        IResult UserExists(string email);
        IDataResult<AccessToken> CreateAccessToken(User user);
    }
}
