using Gestion.dinventaire.Backend.Models;
using Microsoft.AspNet.Identity;
using Microsoft.VisualStudio.Services.Users;
using Newtonsoft.Json.Linq;
using static Microsoft.VisualStudio.Services.Graph.GraphResourceIds;

namespace Gestion.dinventaire.Backend.JWTAuthentification
{
    public interface IJWTManagerRepository
    {
        Token Authenticate(J_Users users);
    }
}
