using ActivityTrackingApp.Entities.Concrete;
using BungalowVip.Core.Utilities.Result;

namespace ActivityTrackingApp.Business.Abstract;
public interface IAppUserService
{
    Task<IDataResult<AppUser>> AddAsync(AppUser appUser);
}
