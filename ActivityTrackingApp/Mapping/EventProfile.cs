using ActivityTrackingApp.Entities.Concrete;
using ActivityTrackingApp.Entities.Dtos;
using AutoMapper;

namespace ActivityTrackingApp.API.Mapping
{
    public class EventProfile : Profile
{
    public EventProfile()
    {
        CreateMap<EventDto, Event>();
        CreateMap<Event, EventDto>();
    }
}
}
