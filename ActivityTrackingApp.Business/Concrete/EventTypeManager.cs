using ActivityTrackingApp.Business.Abstract;
using ActivityTrackingApp.Entities.Concrete;
using ActivityTrackingApp.Core.Utilities.Result;

namespace ActivityTrackingApp.Business.Concrete;

public class EventTypeManager : IEventTypeService
{
    public Task<IDataResult<EventType>> AddAsync(EventType eventType)
    {
        throw new NotImplementedException();
    }
}
