using ActivityTrackingApp.Entities.Concrete;
using BungalowVip.Core.Utilities.Result;

namespace ActivityTrackingApp.Business.Abstract;
public interface IEventTopicService
{
    Task<IDataResult<EventTopic>> AddAsync(EventTopic eventTopic);
}
