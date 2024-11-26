using OnlineSurvey.Business.Constants;
using OnlineSurvey.Entities.Dtos;
using FluentValidation;

namespace OnlineSurvey.Business.ValidationRules.FluentValidation
{
    public class UserRegisterValidator : AbstractValidator<UserForRegisterDto>
    {
        public UserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(Messages.NameIsNotEmpty);
            RuleFor(x => x.SurName).NotEmpty().WithMessage(Messages.SurnameIsNotEmpty);
            RuleFor(x => x.Email).NotEmpty().WithMessage(Messages.EmailIsNotEmpty);
            RuleFor(x => x.Password).NotEmpty().WithMessage(Messages.PasswordIsNotEmpty);
        }
    }
}
