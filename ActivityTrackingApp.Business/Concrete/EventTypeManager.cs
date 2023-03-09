using ActivityTrackingApp.Business.Abstract;
using ActivityTrackingApp.Entities.Concrete;
using ActivityTrackingApp.Core.Utilities.Result;
using ActivityTrackingApp.DataAccess.Abstract;
using ActivityTrackingApp.Business.Constants;
using ActivityTrackingApp.DataAccess.Concrete;

namespace ActivityTrackingApp.Business.Concrete;

public class EventTypeManager : IEventTypeService
{
    private readonly IEventTypeDAL _eventTypeDAL;

    public EventTypeManager(IEventTypeDAL eventTypeDAL)
    {
        _eventTypeDAL = eventTypeDAL;
    }

    public Task<IDataResult<EventType>> AddAsync(EventType eventType)
    {
        throw new NotImplementedException();
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
