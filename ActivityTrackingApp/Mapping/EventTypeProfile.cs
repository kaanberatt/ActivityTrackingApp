using ActivityTrackingApp.Entities.Concrete;
using ActivityTrackingApp.Entities.Dtos;
using AutoMapper;

namespace ActivityTrackingApp.API.Mapping
{
    public class EventTypeProfile : Profile
    {
		public EventTypeProfile()
		{
            CreateMap<EventTypeDto, EventType>();
            CreateMap<EventType, EventTypeDto>();
        }    
	}
}
