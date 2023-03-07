using ActivityTrackingApp.Business.Abstract;
using ActivityTrackingApp.Entities.Concrete;
using ActivityTrackingApp.Core.Utilities.Result;

namespace ActivityTrackingApp.Business.Concrete;

public class EventTopicManager : IEventTopicService
{
    public Task<IDataResult<EventTopic>> AddAsync(EventTopic eventTopic)
    {
        throw new NotImplementedException();
    }
}
