using ActivityTrackingApp.Entities.Concrete;
using ActivityTrackingApp.Entities.Dtos;
using AutoMapper;

namespace ActivityTrackingApp.API.Mapping
{
    public class EventTopicProfile : Profile
    {
		public EventTopicProfile()
		{
            CreateMap<EventTopicDto, EventTopic>();
            CreateMap<EventTopic, EventTopicDto>();
        }    
	}
}
