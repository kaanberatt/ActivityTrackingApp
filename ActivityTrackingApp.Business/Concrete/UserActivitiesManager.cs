using ActivityTrackingApp.Business.Abstract;
using ActivityTrackingApp.Entities.Concrete;
using ActivityTrackingApp.Core.Utilities.Result;

namespace ActivityTrackingApp.Business.Concrete;

public class UserActivitiesManager : IUserActivitiesService
{
    public Task<IDataResult<UserActivities>> AddAsync(UserActivities userActivities)
    {
        throw new NotImplementedException();
    }
}
