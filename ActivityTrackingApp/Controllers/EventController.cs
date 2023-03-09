using ActivityTrackingApp.Business.Abstract;
using ActivityTrackingApp.Entities.Concrete;
using ActivityTrackingApp.Entities.Dtos;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ActivityTrackingApp.API.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class EventController : ControllerBase
{
    private readonly IEventService _eventService;
    private readonly IEventTopicService _eventTopicService;
    private readonly IEventTypeService _eventTypeService;
    public readonly IMapper _mapper;

    public EventController(IEventService eventService, IMapper mapper, IEventTopicService eventTopicService, IEventTypeService eventTypeService)
    {
        _eventService = eventService;
        _mapper = mapper;
        _eventTopicService = eventTopicService;
        _eventTypeService = eventTypeService;
    }
    [HttpPost("")]
    public async Task<IActionResult> AddEventAsync(EventDto eventDto)
    {
        try
        {
            if (ModelState.IsValid)
            {
                var controlEventTypeId = _eventTypeService.DataVerificationAsync(eventDto.EventTypeId);
                if (!controlEventTypeId.Result.isSuccess)
                {
                    return Ok(controlEventTypeId.Result.Message);
                }
                var _mappedEvent = _mapper.Map<EventDto, Event>(eventDto, new Event());
                var addedevent = await _eventService.AddAsync(_mappedEvent);
                if (addedevent.isSuccess)
                {
                    return Ok(addedevent.Message);
                }
                return BadRequest(addedevent.Message);
            }
            else
            {
                var errors = ModelState.SelectMany(x => x.Value.Errors.Select(z => z.ErrorMessage));
                return BadRequest(errors);
            }
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
