using ActivityTrackingApp.Business.Abstract;
using ActivityTrackingApp.Entities.Concrete;
using ActivityTrackingApp.Core.Utilities.Result;
using ActivityTrackingApp.DataAccess.Abstract;
using ActivityTrackingApp.Business.Constants;
using FluentValidation;

namespace ActivityTrackingApp.Business.Concrete;

public class EventTopicManager : IEventTopicService
{
    private IEventTopicDAL _eventTopicDAL;
    private readonly IValidator<EventTopic> _eventValidator;

    public EventTopicManager(IEventTopicDAL eventTopicDAL, IValidator<EventTopic> eventValidator)
    {
        _eventTopicDAL = eventTopicDAL;
        _eventValidator = eventValidator;
    }

    public async Task<IDataResult<EventTopic>> AddAsync(EventTopic eventTopic)
    {
        try
        {
            eventTopic.createdDate = DateTime.Now;
            var control = _eventValidator.Validate(eventTopic);
            if (control.IsValid)
            {
                await _eventTopicDAL.AddAsync(eventTopic);
                return new SuccessDataResult<EventTopic>(eventTopic, Messages.AddMessage);
            }
            return new ErrorDataResult<EventTopic>(eventTopic, Messages.ModelErrorMessage);

        }
        catch (Exception ex)
        {
            return new ErrorDataResult<EventTopic>(eventTopic, Messages.ModelErrorMessage);

        }
    }
}
