using ActivityTrackingApp.Business.Abstract;
using ActivityTrackingApp.Business.Constants;
using ActivityTrackingApp.Core.Helper;
using ActivityTrackingApp.DataAccess.Abstract;
using ActivityTrackingApp.Entities.Concrete;
using ActivityTrackingApp.Core.Utilities.Result;

namespace ActivityTrackingApp.Business.Concrete;

public class AppUserManager : IAppUserService
{
    private readonly IAppUserDAL _appUserDal;

    public AppUserManager(IAppUserDAL appUserDal)
    {
        _appUserDal = appUserDal;
    }

    public async Task<IDataResult<AppUser>> AddAsync(AppUser appUser)
    {
        try
        {
            await _appUserDal.AddAsync(appUser);
            return new SuccessDataResult<AppUser>(appUser, Messages.AddMessage);
        }
        catch (Exception ex)
        {
            return new ErrorDataResult<AppUser>(appUser, ex.Message);
        }

    }

    public async Task<IDataResult<AppUser>> GetUserByEmailAsync(string appUserEmail)
    {
        try
        {
            var row = await _appUserDal.GetFirstOrDefaultAsync(x => x.Email == appUserEmail);
            if (row != null)
            {
                return new SuccessDataResult<AppUser>(row);
            }
            return new ErrorDataResult<AppUser>(Messages.NoRecordMessage);
        }
        catch (Exception ex)
        {
            return new ErrorDataResult<AppUser>(ex.Message);
        }
       
    }

    public async Task<IDataResult<AppUser>> SignInAsync(string email, string password)
    {
        try
        {
            var row = await _appUserDal.GetFirstOrDefaultAsync(x => x.Email == email.Trim());
            if (row != null)
            {
                var isPasswordValid = HashingHelper.VerifyPasswordHash(password, row.PasswordHash, row.PasswordSalt);
                if (isPasswordValid)
                    return new SuccessDataResult<AppUser>(row, Messages.SuccesfulLogin);
            }
            return new ErrorDataResult<AppUser>(new AppUser(), Messages.UserNotFound);
        }
        catch (Exception ex)
        {
            return new ErrorDataResult<AppUser>(ex.Message);
        }
        
    }
}
