using Newtonsoft.Json.Linq;
using static Microsoft.VisualStudio.Services.Graph.GraphResourceIds;

namespace Gestion.dinventaire.Backend.JWTAuthentification
{
    public interface IJWTManagerRepository
    {
        Token Authenticate(Role_user users);
    }
}
