using ActivityTrackingApp.Entities.Concrete;
using BungalowVip.Core.Utilities.Result;

namespace ActivityTrackingApp.Business.Abstract;
public interface IUserActivities
{
    Task<IDataResult<UserActivities>> AddAsync(UserActivities userActivities);
}
