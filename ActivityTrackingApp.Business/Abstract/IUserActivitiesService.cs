using ActivityTrackingApp.Entities.Concrete;
using BungalowVip.Core.Utilities.Result;

namespace ActivityTrackingApp.Business.Abstract;
public interface IUserActivitiesService
{
    Task<IDataResult<UserActivities>> AddAsync(UserActivities userActivities);
}
