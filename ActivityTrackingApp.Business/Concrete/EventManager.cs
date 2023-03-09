using ActivityTrackingApp.Business.Abstract;
using ActivityTrackingApp.Entities.Concrete;
using ActivityTrackingApp.Core.Utilities.Result;
using ActivityTrackingApp.DataAccess.Abstract;
using ActivityTrackingApp.Business.Constants;
using FluentValidation;
using ActivityTrackingApp.Entities.EntityValidator;

namespace ActivityTrackingApp.Business.Concrete;

public class EventManager : IEventService
{
    private readonly IEventDAL _eventDAL;
    private readonly IValidator<Event> _eventValidator;
    public EventManager(IEventDAL eventDAL, IValidator<Event> eventValidator)
    {
        _eventDAL = eventDAL;
        _eventValidator = eventValidator;
    }

    public async Task<IDataResult<Event>> AddAsync(Event model)
    {
        try
        {
            model.createdDate = DateTime.Now;
            var control = _eventValidator.Validate(model);
            if (control.IsValid)
            {
                await _eventDAL.AddAsync(model);
                return new SuccessDataResult<Event>(model, Messages.AddMessage);
            }
            return new ErrorDataResult<Event>(model, Messages.ModelErrorMessage);
        }
        catch (Exception ex)
        {
            return new ErrorDataResult<Event>(model,ex.Message);
        }
       
    }
}
