using Autofac;
using FluentValidation;
using OnlineSurvey.Business.ValidationRules.FluentValidation;
using OnlineSurvey.Entities.Dtos;

namespace OnlineSurvey.Business.DependencyResolvers.Autofac
{
    public class AutofacValidationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UserLoginValidator>().As<IValidator<UserForLoginDto>>();
            builder.RegisterType<UserRegisterValidator>().As<IValidator<UserForRegisterDto>>();
        }
    }
}
