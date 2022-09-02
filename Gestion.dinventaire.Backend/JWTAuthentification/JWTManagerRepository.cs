using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json.Linq;
using static Microsoft.VisualStudio.Services.Graph.GraphResourceIds;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Gestion.dinventaire.Backend.JWTAuthentification
{
    public class JWTManagerRepository
    {
        public JWTManagerRepository()
        {

        }
        public Token Authenticate(Role_user users)
        {

            JwtSecurityTokenHandler tokenHandler = new();
            //var tokenKey = Encoding.UTF8.GetBytes(iconfiguration["JWT:Key"]);
            byte[] tokenKey = Encoding.UTF8.GetBytes(Environment.GetEnvironmentVariable("SECRETJWT", EnvironmentVariableTarget.Machine) ?? string.Empty);

            SecurityToken token = new JwtSecurityToken(null, null, new Claim[]
                       {
                          new Claim(ClaimTypes.Name, users.Email??String.Empty),
                          new Claim(ClaimTypes.Role, users.Role??String.Empty)
                       }, DateTime.Now, DateTime.Now.AddDays(1), new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature));
            return new Token { token = tokenHandler.WriteToken(token) };

        }
    }
}

