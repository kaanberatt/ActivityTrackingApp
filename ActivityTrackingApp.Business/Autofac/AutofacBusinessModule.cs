using ActivityTrackingApp.Business.Abstract;
using ActivityTrackingApp.Business.Concrete;
using ActivityTrackingApp.DataAccess.Abstract;
using ActivityTrackingApp.DataAccess.Concrete;
using ActivityTrackingApp.Entities.Concrete;
using ActivityTrackingApp.Entities.Dtos;
using ActivityTrackingApp.Entities.DtosValidator;
using ActivityTrackingApp.Entities.EntityValidator;
using Autofac;
using FluentValidation;

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

        #region EventTopic
        builder.RegisterType<EventTopicManager>().As<IEventTopicService>();
        builder.RegisterType<EfEventTopicDAL>().As<IEventTopicDAL>();
        #endregion

        #region Event Type
        builder.RegisterType<EventTypeManager>().As<IEventTypeService>();
        builder.RegisterType<EfEventTypeDAL>().As<IEventTypeDAL>();
        #endregion

        #region Validators for entities
        builder.RegisterType<AppUserValidator>().As<IValidator<AppUser>>();
        builder.RegisterType<EventValidator>().As<IValidator<Event>>();
        builder.RegisterType<EventTopicValidator>().As<IValidator<EventTopic>>();
        builder.RegisterType<EventTypeValidator>().As<IValidator<EventType>>();
        builder.RegisterType<UserActivitiesValidator>().As<IValidator<UserActivities>>();
        #endregion



        builder.RegisterType<AppUserDtoValidator>().As<IValidator<AppUserDto>>();

    }
}