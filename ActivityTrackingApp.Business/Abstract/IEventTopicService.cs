using ActivityTrackingApp.Entities.Concrete;
using ActivityTrackingApp.Core.Utilities.Result;

namespace ActivityTrackingApp.Business.Abstract;
public interface IEventTopicService
{
    Task<IDataResult<EventTopic>> AddAsync(EventTopic eventTopic);
    Task<IResult> DataVerification(int id);
}
