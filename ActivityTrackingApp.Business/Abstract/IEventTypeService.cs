using ActivityTrackingApp.Entities.Concrete;
using BungalowVip.Core.Utilities.Result;

namespace ActivityTrackingApp.Business.Abstract;
public interface IEventTypeService
{
    Task<IDataResult<EventType>> AddAsync(EventType eventType);
}
