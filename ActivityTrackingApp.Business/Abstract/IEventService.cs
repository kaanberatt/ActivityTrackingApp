using ActivityTrackingApp.Entities.Concrete;
using BungalowVip.Core.Utilities.Result;

namespace ActivityTrackingApp.Business.Abstract;
public interface IEventService
{
    Task<IDataResult<Event>> AddAsync(Event model);
}
