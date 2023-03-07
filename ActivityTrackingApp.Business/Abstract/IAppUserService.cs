using ActivityTrackingApp.Entities.Concrete;
using ActivityTrackingApp.Core.Utilities.Result;

namespace ActivityTrackingApp.Business.Abstract;
public interface IAppUserService
{
    Task<IDataResult<AppUser>> AddAsync(AppUser appUser);
    Task<IDataResult<AppUser>> SignInAsync(string email, string password);
    Task<IDataResult<AppUser>> GetUserByEmailAsync(string appUserEmail);

}
