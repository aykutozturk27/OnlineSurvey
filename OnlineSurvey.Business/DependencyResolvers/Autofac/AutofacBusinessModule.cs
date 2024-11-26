using Autofac;
using Microsoft.AspNetCore.Http;
using OnlineSurvey.Business.Abstract;
using OnlineSurvey.Business.Concrete.Managers;
using OnlineSurvey.DataAccess.Abstract;
using OnlineSurvey.DataAccess.Concrete.EntityFramework;

namespace OnlineSurvey.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<OptionManager>().As<IOptionService>();
            builder.RegisterType<EfOptionDal>().As<IOptionDal>();

            builder.RegisterType<PollManager>().As<IPollService>();
            builder.RegisterType<EfPollDal>().As<IPollDal>();

            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();

            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();

            builder.RegisterType<HttpContextAccessor>().As<IHttpContextAccessor>();
        }
    }
}
