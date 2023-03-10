using ActivityTrackingApp.Business.Abstract;
using ActivityTrackingApp.Entities.Concrete;
using ActivityTrackingApp.Entities.Dtos;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace ActivityTrackingApp.API.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]

public class EventController : ControllerBase
{
    private readonly IEventService _eventService;
    private readonly IEventTypeService _eventTypeService;
    public readonly IMapper _mapper;

    public EventController(IEventService eventService, IMapper mapper,  IEventTypeService eventTypeService)
    {
        _eventService = eventService;
        _mapper = mapper;
        _eventTypeService = eventTypeService;
    }
    [HttpPost("")]
    public async Task<IActionResult> AddEvent(EventDto eventDto)
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
                    return Ok(addedevent);
                }
                return BadRequest(addedevent);
            }
            else
            {
                var errors = ModelState.SelectMany(x => x.Value.Errors.Select(z => z.ErrorMessage));
                return Ok(errors);
            }
        }
        catch (Exception ex)
        {
            return Ok(ex.Message);
        }
    }
    [HttpGet]
    public async Task<IActionResult> GetEventList()
    {
        var eventList = await _eventService.GetListAsync();
        return Ok(eventList);
    }
}
