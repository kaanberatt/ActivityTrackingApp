using ActivityTrackingApp.Business.Abstract;
using ActivityTrackingApp.Business.Constants;
using ActivityTrackingApp.Core.Helper;
using ActivityTrackingApp.DataAccess.Abstract;
using ActivityTrackingApp.Entities.Concrete;
using ActivityTrackingApp.Core.Utilities.Result;
using ActivityTrackingApp.Entities.Enums;
using FluentValidation;

namespace ActivityTrackingApp.Business.Concrete;

public class AppUserManager : IAppUserService
{
    private readonly IAppUserDAL _appUserDal;
    private readonly IValidator<AppUser> _appUserValidator;

    public AppUserManager(IAppUserDAL appUserDal, IValidator<AppUser> appUserValidator)
    {
        _appUserDal = appUserDal;
        _appUserValidator = appUserValidator;
    }

    public async Task<IDataResult<AppUser>> AddAsync(AppUser appUser)
    {
        try
        {
            appUser.IsActived = true;
            appUser.Role = RoleEnums.User.ToString();
            var control = _appUserValidator.Validate(appUser);
            if (control.IsValid)
            {
                await _appUserDal.AddAsync(appUser);
                return new SuccessDataResult<AppUser>(appUser, Messages.AddMessage);
            }
            return new ErrorDataResult<AppUser>(appUser, Messages.ErrorMessage);
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
    public async Task<IDataResult<int>> GetUserIdByEmailAsync(string appUserEmail)
    {
        try
        {
            var row = await _appUserDal.GetFirstOrDefaultAsync(x => x.Email == appUserEmail);
            if (row != null)
            {
                return new SuccessDataResult<int>(row.Id);
            }
            return new ErrorDataResult<int>(Messages.NoRecordMessage);
        }
        catch (Exception ex)
        {
            return new ErrorDataResult<int>(ex.Message);
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
    public async Task<IDataResult<List<AppUser>>> GetListAsync()
    {
        var result = (await _appUserDal.GetListAsync(x => x.Role == RoleEnums.User.ToString())).ToList();
        return new SuccessDataResult<List<AppUser>>(result);
    }
}
