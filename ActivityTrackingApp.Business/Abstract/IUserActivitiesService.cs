using ActivityTrackingApp.Entities.Concrete;
using ActivityTrackingApp.Core.Utilities.Result;

namespace ActivityTrackingApp.Business.Abstract;
public interface IUserActivitiesService
{
    Task<IDataResult<UserActivities>> AddAsync(UserActivities userActivities);
    Task<IDataResult<UserActivities>> UpdateAsync(UserActivities userActivities);
    Task<IDataResult<UserActivities>> GetActivityByIdAsync(int activityId);
}
