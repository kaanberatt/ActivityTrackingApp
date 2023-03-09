using ActivityTrackingApp.Entities.Concrete;
using ActivityTrackingApp.Entities.Dtos;
using AutoMapper;

namespace ActivityTrackingApp.API.Mapping
{
    public class UserActivitiesProfile : Profile
    {
        public UserActivitiesProfile()
        {
            CreateMap<UserActivities, UserActivityDto>();
            CreateMap<UserActivityDto, UserActivities>();
        }
    }
}
