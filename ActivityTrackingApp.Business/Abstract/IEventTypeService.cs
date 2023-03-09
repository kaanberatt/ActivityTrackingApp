using ActivityTrackingApp.Entities.Concrete;
using ActivityTrackingApp.Core.Utilities.Result;

namespace ActivityTrackingApp.Business.Abstract;
public interface IEventTypeService
{
    Task<IDataResult<EventType>> AddAsync(EventType eventType);
    Task<IResult> DataVerificationAsync(int id);

}
