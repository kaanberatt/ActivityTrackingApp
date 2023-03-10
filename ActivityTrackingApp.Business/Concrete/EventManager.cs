using ActivityTrackingApp.Business.Abstract;
using ActivityTrackingApp.Entities.Concrete;
using ActivityTrackingApp.Core.Utilities.Result;
using ActivityTrackingApp.DataAccess.Abstract;
using ActivityTrackingApp.Business.Constants;
using FluentValidation;
using ActivityTrackingApp.DataAccess.Concrete;
using System.Collections.Generic;

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

    public async Task<IDataResult<Event>> GetByIdAsync(int id)
    {
        try
        {
            var row = await _eventDAL.GetFirstOrDefaultAsync(x => x.Id == id);
            if (row != null)
            {
                return new SuccessDataResult<Event>(row);
            }
            return new ErrorDataResult<Event>(row);
        }
        catch (Exception ex)
        {
            return new ErrorDataResult<Event>(ex.Message);
        }
    }

    public async Task<IDataResult<List<Event>>> GetListAsync()
    {
        try
        {
            var list = (await _eventDAL.GetListAsync(null,null,x=>x.EventType)).ToList();
            return new SuccessDataResult<List<Event>>(list);
        }
        catch (Exception ex)
        {
            return new SuccessDataResult<List<Event>>(new List<Event>() , ex.Message);

        }

    }
}
