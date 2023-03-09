using ActivityTrackingApp.Business.Abstract;
using ActivityTrackingApp.Entities.Concrete;
using ActivityTrackingApp.Core.Utilities.Result;
using ActivityTrackingApp.DataAccess.Abstract;
using ActivityTrackingApp.Business.Constants;
using ActivityTrackingApp.DataAccess.Concrete;
using ActivityTrackingApp.Entities.EntityValidator;
using FluentValidation;

namespace ActivityTrackingApp.Business.Concrete;

public class EventTypeManager : IEventTypeService
{
    private readonly IEventTypeDAL _eventTypeDAL;
    private readonly IValidator<EventType> _validator;
    public EventTypeManager(IEventTypeDAL eventTypeDAL, IValidator<EventType> validator)
    {
        _eventTypeDAL = eventTypeDAL;
        _validator = validator;
    }

    public async Task<IDataResult<EventType>> AddAsync(EventType eventType)
    {
        try
        {
            eventType.createdDate = DateTime.Now;
            var control = _validator.Validate(eventType);
            if (control.IsValid)
            {
                await _eventTypeDAL.AddAsync(eventType);
                return new SuccessDataResult<EventType>(eventType, Messages.AddMessage);
            }
            return new ErrorDataResult<EventType>(eventType, Messages.ModelErrorMessage);

        }
        catch (Exception ex)
        {
            return new ErrorDataResult<EventType>(eventType, ex.Message);

        }
    }

    public async Task<IResult> DataVerificationAsync(int id)
    {
        try
        {
            var data = await _eventTypeDAL.GetFirstOrDefaultAsync(x => x.Id == id);
            if (data != null)
            {
                return new SuccessResult(Messages.VerificationTrue);
            }
            return new ErrorResult(Messages.VerificationFalse + ". Please change Event Type Id");
        }
        catch (Exception ex)
        {
            return new ErrorResult(ex.Message);
        }
    }
}
