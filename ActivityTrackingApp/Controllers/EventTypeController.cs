using ActivityTrackingApp.Business.Abstract;
using ActivityTrackingApp.Entities.Concrete;
using ActivityTrackingApp.Entities.Dtos;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace ActivityTrackingApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class EventTypeController : ControllerBase
    {
        private readonly IEventTypeService _eventTypeService;
        private readonly IMapper _mapper;
        public EventTypeController(IEventTypeService eventTypeService, IMapper mapper)
        {
            _eventTypeService = eventTypeService;
            _mapper = mapper;
        }

        [HttpPost("")]
        public async Task<IActionResult> AddEventType(EventTypeDto eventTypeDto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var _mappedEventType = _mapper.Map<EventTypeDto, EventType>(eventTypeDto , new EventType());
                    var addedEventType = await _eventTypeService.AddAsync(_mappedEventType);
                    if (addedEventType.isSuccess)
                    {
                        return Ok(addedEventType);
                    }
                    return Ok(addedEventType);
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
    }
}
