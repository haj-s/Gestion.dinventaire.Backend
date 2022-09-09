using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json.Linq;
using static Microsoft.VisualStudio.Services.Graph.GraphResourceIds;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Gestion.dinventaire.Backend.Models;

namespace Gestion.dinventaire.Backend.JWTAuthentification
{
    public class JWTManagerRepository:IJWTManagerRepository
    {
        public JWTManagerRepository()
        {

        }
        public Token Authenticate(J_Users users)
        {

            JwtSecurityTokenHandler tokenHandler = new();
            //var tokenKey = Encoding.UTF8.GetBytes(iconfiguration["JWT:Key"]);
            byte[] tokenKey = Encoding.UTF8.GetBytes(Environment.GetEnvironmentVariable("", EnvironmentVariableTarget.Machine) ?? string.Empty);

            SecurityToken token = new JwtSecurityToken(null, null, new Claim[]
                       {
                          new Claim(ClaimTypes.Name, users.email??String.Empty),
                          new Claim(ClaimTypes.Role, users.Role??String.Empty)
                       }, DateTime.Now, DateTime.Now.AddDays(1), new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature));
            return new Token { token = tokenHandler.WriteToken(token) };

        }
    }
}

