using ActivityTrackingApp.Business.Abstract;
using ActivityTrackingApp.Core.Helper;
using ActivityTrackingApp.Entities.Concrete;
using ActivityTrackingApp.Entities.Dtos;
using ActivityTrackingApp.Entities.Enums;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ActivityTrackingApp.API.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class UserAccountController : ControllerBase
{
    private readonly IAppUserService _appUserService;
    public readonly IMapper _mapper;

    public UserAccountController(IAppUserService appUserService, IMapper mapper)
    {
        _appUserService = appUserService;
        _mapper = mapper;
    }

    [HttpPost("")]
    public async Task<IActionResult> CreateUser([FromBody] AppUserDto appUserDto)
    {
        try
        {
            if (ModelState.IsValid)
            {
                var appUserControl = await _appUserService.GetUserByEmailAsync(appUserDto.Email);
                if (appUserControl.Success)
                {
                    return BadRequest("Email already in use.");
                }
                HashingHelper.CreatePasswordHash(appUserDto.Password, out var passwordHash, out var passwordSalt);
                var _mappedAppUser = _mapper.Map<AppUserDto, AppUser>(appUserDto, new AppUser());
                _mappedAppUser.PasswordHash = passwordHash;
                _mappedAppUser.PasswordSalt = passwordSalt;

                var _appUser = await _appUserService.AddAsync(_mappedAppUser);
                if (_appUser.Success)
                {
                    return Ok(_appUser);
                }
            }

            return BadRequest("Model State is not valid");
        }
        catch (System.Exception ex)
        {
            return BadRequest(ex.InnerException.Message);
        }
    }
}
