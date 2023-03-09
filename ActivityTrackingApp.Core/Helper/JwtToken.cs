using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ActivityTrackingApp.Core.Helper;

public class JwtToken
{
    public static JwtSecurityToken GetToken(List<Claim> authClaims)
    {
        var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("3KBsVR697nrsqxfvvjlZDw=="));
        var token = new JwtSecurityToken
        (
            issuer: "https://localhost:7044/",
            audience: "https://localhost:7044/",
            expires: DateTime.Now.AddHours(24),
            claims: authClaims,
            signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
        );
        return token;
    }
}
