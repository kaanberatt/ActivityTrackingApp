using ActivityTrackingApp.Business.Abstract;
using ActivityTrackingApp.Core.Helper;
using ActivityTrackingApp.Entities.Concrete;
using ActivityTrackingApp.Entities.Dtos;
using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace ActivityTrackingApp.API.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class UserAccountController : ControllerBase
{
    private readonly IAppUserService _appUserService;
    public readonly IMapper _mapper;
    private readonly IValidator<AppUserDto> _appUserDtoValidator;


    public UserAccountController(IAppUserService appUserService, IMapper mapper, IValidator<AppUserDto> appUserDtoValidator)
    {
        _appUserService = appUserService;
        _mapper = mapper;
        _appUserDtoValidator = appUserDtoValidator;
    }

    [HttpPost("")]
    public async Task<IActionResult> CreateUser([FromBody] AppUserDto appUserDto)
    {
        try
        {
            var errorList = new List<string>();
            var control = _appUserDtoValidator.Validate(appUserDto);
            if (control.IsValid)
            {

                var appUserControl = await _appUserService.GetUserByEmailAsync(appUserDto.Email);
                if (appUserControl.isSuccess)
                {
                    return Ok("Email already in use.");
                }
                HashingHelper.CreatePasswordHash(appUserDto.Password, out var passwordHash, out var passwordSalt);
                var _mappedAppUser = _mapper.Map<AppUserDto, AppUser>(appUserDto, new AppUser());
                _mappedAppUser.PasswordHash = passwordHash;
                _mappedAppUser.PasswordSalt = passwordSalt;

                var _appUser = await _appUserService.AddAsync(_mappedAppUser);
                if (_appUser.isSuccess)
                {
                    return Ok (_appUser.Message);
                }
            }
            else
            {
                foreach (var failure in control.Errors)
                {
                    errorList.Add(failure.ErrorMessage);   
                }
            }
            return Ok(errorList);
        }
        catch (Exception ex)
        {
            return Ok(ex.Message);
        }
    }
    [HttpPost("")]
    public async Task<IActionResult> CreateToken([FromBody] AppUserSignInDto signInDto)
    {
        try
        {
            if (ModelState.IsValid)
            {
                var _userControl = await _appUserService.SignInAsync(signInDto.Email, signInDto.Password);
                if (_userControl.isSuccess)
                {
                    var authClaims = new List<Claim>
                    {
                    new Claim(ClaimTypes.Email, _userControl.Data.Email),
                    new Claim(ClaimTypes.Role, _userControl.Data.Role),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    };

                    var token = JwtToken.GetToken(authClaims);

                    return Ok(new
                    {
                        token = new JwtSecurityTokenHandler().WriteToken(token),
                        expiration = token.ValidTo
                    });
                }
                else
                {
                    return Unauthorized(_userControl.Message);
                }
            }
            var errors = ModelState.SelectMany(x => x.Value.Errors.Select(z => z.ErrorMessage));
            return Ok(errors);
        }
        catch (Exception ex)
        {
            return Ok(ex.Message);
        }
    }
    [Authorize(Roles = "User")]
    [HttpGet("")]
    public IActionResult UserAuthorizationTest()
    {
        return Ok("User Authentication is successful!");
    }
}
