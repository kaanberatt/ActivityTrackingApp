using ActivityTrackingApp.Business.Abstract;
using ActivityTrackingApp.Business.Concrete;
using ActivityTrackingApp.DataAccess.Abstract;
using ActivityTrackingApp.DataAccess.Concrete;
using Autofac;


namespace ActivityTrackingApp.Business.DependencyResolvers.Autofac;
public class AutofacBusinessModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        #region App User
        builder.RegisterType<AppUserManager>().As<IAppUserService>();
        builder.RegisterType<EfAppUserDAL>().As<IAppUserDAL>();
        #endregion

        #region User Activities
        builder.RegisterType<UserActivitiesManager>().As<IUserActivitiesService>();
        builder.RegisterType<EfUserActivitiesDAL>().As<IUserActivitiesDAL>();
        #endregion
        
        #region Event
        builder.RegisterType<EventManager>().As<IEventService>();
        builder.RegisterType<EfEventDAL>().As<IEventDAL>();
        #endregion

    }
}