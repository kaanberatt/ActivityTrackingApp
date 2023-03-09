using ActivityTrackingApp.Business.Abstract;
using ActivityTrackingApp.Business.Constants;
using ActivityTrackingApp.Entities.Concrete;
using ActivityTrackingApp.Entities.Dtos;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ActivityTrackingApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    [Authorize(Roles = "User")]
    public class ActivityController : ControllerBase
    {
        private readonly IUserActivitiesService _userActivitiesService;
        private readonly IAppUserService _appUserService;
        private IMapper _mapper;
        public ActivityController(IUserActivitiesService userActivitiesService, IAppUserService appUserService, IMapper mapper)
        {
            _userActivitiesService = userActivitiesService;
            _appUserService = appUserService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> StartActivity(UserActivityDto userActivityDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    var errors = ModelState.SelectMany(x => x.Value.Errors.Select(z => z.ErrorMessage));
                    return Ok(errors);
                }
                var userId = GetAuthenticatedUserId();
                var _mappedActivity = _mapper.Map<UserActivityDto, UserActivities>(userActivityDto, new UserActivities());
                _mappedActivity.AppUserId = userId;
                _mappedActivity.StartDate = DateTime.Now;
                var startedActivity = await _userActivitiesService.AddAsync(_mappedActivity);
                if (startedActivity.isSuccess)
                {
                    return Ok(startedActivity);
                }
                else
                {
                    return Ok(startedActivity.Message);
                }

            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }
        }
        [HttpPost]
        public async Task<IActionResult> FinishActivity(int activityId)
        {
            try
            {
                if (activityId == null)
                {
                    return Ok("Please enter the activityId");
                }
                var activity = _userActivitiesService.GetActivityByIdAsync(activityId);
                if (activity.Result.Data == null )
                {
                    return Ok(Messages.NoRecordMessage);
                }
                else if (activity.Result.Data.FinishDate.Day != 1)
                {
                    return Ok("Bu Aktivite zaten tamamlanmıştır");
                }
                activity.Result.Data.FinishDate = DateTime.Now;
                var result = await _userActivitiesService.UpdateAsync(activity.Result.Data);
                if (result.isSuccess)
                {
                    return Ok(result);
                }
                return Ok(result);

            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }
        }
        private int GetAuthenticatedUserId()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            var claims = identity.Claims.ToList();
            var userEmail = claims.FirstOrDefault(c => c.Type.Contains("emailaddress"))?.Value;
            // claimsler üzerinden giriş yapan kullanıcın email adresi alınıyor.
            int authenticatedUserId = _appUserService.GetUserIdByEmailAsync(userEmail).Result.Data;
            // Email adresi gönderilerek User'ın Id değeri alınıyor.
            return authenticatedUserId;
        }
    }
}
