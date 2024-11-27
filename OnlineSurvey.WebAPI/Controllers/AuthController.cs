using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using OnlineSurvey.Business.Abstract;
using OnlineSurvey.Entities.Dtos;
using System.Security.Claims;

namespace OnlineSurvey.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private IAuthService _authService;
        private IUserService _userService;

        public AuthController(IAuthService authService, IUserService userService)
        {
            _authService = authService;
            _userService = userService;
        }

        [HttpPost("login")]
        public ActionResult Login(UserForLoginDto userForLoginDto)
        {
            var userToLogin = _authService.Login(userForLoginDto);
            if (!userToLogin.Success)
            {
                return BadRequest(userToLogin.Message);
            }

            var result = _authService.CreateAccessToken(userToLogin.Data);
            if (result.Success)
            {
                //var operationClaims = _userService.GetClaims(userToLogin.Data);
                //List<Claim> claims = new List<Claim> {
                //    new Claim(ClaimTypes.Name, userToLogin.Data.FullName),
                //    new Claim(ClaimTypes.PrimarySid, userToLogin.Data.Id.ToString()),
                //    new Claim(ClaimTypes.Email, userToLogin.Data.Email ?? string.Empty),
                //    new Claim(ClaimTypes.GivenName, userToLogin.Data.FirstName ?? string.Empty),
                //    new Claim(ClaimTypes.Surname, userToLogin.Data.LastName ?? string.Empty)
                //};

                //foreach (var operationClaim in operationClaims)
                //{
                //    claims.Add(new Claim(ClaimTypes.Role, operationClaim.Name));
                //}

                //var identity = new ClaimsIdentity(claims,
                //  CookieAuthenticationDefaults.AuthenticationScheme);

                //HttpContext.SignInAsync(
                //  CookieAuthenticationDefaults.AuthenticationScheme,
                //  new ClaimsPrincipal(identity));
                return Ok(result);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("register")]
        public ActionResult Register(UserForRegisterDto userForRegisterDto)
        {
            var userExists = _authService.UserExists(userForRegisterDto.Email);
            if (!userExists.Success)
            {
                return BadRequest(userExists.Message);
            }

            var registerResult = _authService.Register(userForRegisterDto, userForRegisterDto.Password);
            var result = _authService.CreateAccessToken(registerResult.Data);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }
    }
}
