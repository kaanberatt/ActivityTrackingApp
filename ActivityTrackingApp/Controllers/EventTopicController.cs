using ActivityTrackingApp.Business.Abstract;
using ActivityTrackingApp.Core.Utilities.Result;
using ActivityTrackingApp.Entities.Concrete;
using ActivityTrackingApp.Entities.Dtos;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace ActivityTrackingApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class EventTopicController : ControllerBase
    {
        private IEventTopicService _eventTopicService;
        private readonly IMapper _mapper;

        public EventTopicController(IEventTopicService eventTopicService, IMapper mapper)
        {
            _eventTopicService = eventTopicService;
            _mapper = mapper;
        }
        [HttpPost("")]
        public async Task<IActionResult> AddEventTopic(EventTopicDto eventTopicDto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var _mappedEvent = _mapper.Map<EventTopicDto, EventTopic>(eventTopicDto, new EventTopic());
                    var addedEventTopic = await _eventTopicService.AddAsync(_mappedEvent);
                    if (addedEventTopic.isSuccess)
                    {
                        return Ok(addedEventTopic);
                    }
                    return Ok(addedEventTopic);
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
}
