using ActivityTrackingApp.Business.Abstract;
using ActivityTrackingApp.Entities.Concrete;
using ActivityTrackingApp.Core.Utilities.Result;
using ActivityTrackingApp.DataAccess.Abstract;
using FluentValidation;
using ActivityTrackingApp.Business.Constants;
using ActivityTrackingApp.DataAccess.Concrete;
using ActivityTrackingApp.Entities.EntityValidator;

namespace ActivityTrackingApp.Business.Concrete;

public class UserActivitiesManager : IUserActivitiesService
{
    private readonly IUserActivitiesDAL _userActivitiesDAL;
    private readonly IValidator<UserActivities> _validator;

    public UserActivitiesManager(IUserActivitiesDAL userActivitiesDAL, IValidator<UserActivities> validator)
    {
        _userActivitiesDAL = userActivitiesDAL;
        _validator = validator;
    }

    public async Task<IDataResult<UserActivities>> AddAsync(UserActivities userActivities)
    {
        try
        {
            userActivities.createdDate = DateTime.Now;
            var control = _validator.Validate(userActivities);
            if (control.IsValid)
            {
                await _userActivitiesDAL.AddAsync(userActivities);
                return new SuccessDataResult<UserActivities>(userActivities, Messages.AddMessage);
            }
            return new ErrorDataResult<UserActivities>(userActivities, Messages.ModelErrorMessage);
        }
        catch (Exception ex)
        {
            return new ErrorDataResult<UserActivities>(userActivities, ex.Message);
        }
    }

    public async Task<IDataResult<UserActivities>> GetActivityByIdAsync(int activityId)
    {
        try
        {
            var row = await _userActivitiesDAL.GetFirstOrDefaultAsync(x => x.Id == activityId);
            if (row != null)
            {
                return new SuccessDataResult<UserActivities>(row);
            }
            return new ErrorDataResult<UserActivities>(row);
        }
        catch (Exception ex)
        {
            return new ErrorDataResult<UserActivities>(ex.Message);
        }
    }

    public async Task<IDataResult<UserActivities>> UpdateAsync(UserActivities userActivities)
    {
        try
        {
            userActivities.updatedDate = DateTime.Now;
            var control = _validator.Validate(userActivities);
            if (control.IsValid)
            {
                await _userActivitiesDAL.UpdateAsync(userActivities);
                return new SuccessDataResult<UserActivities>(userActivities, Messages.UpdateMessage);
            }
            return new ErrorDataResult<UserActivities>(userActivities, Messages.ModelErrorMessage);
        }
        catch (Exception ex)
        {
            return new ErrorDataResult<UserActivities>(ex.Message);

        }

    }
}
