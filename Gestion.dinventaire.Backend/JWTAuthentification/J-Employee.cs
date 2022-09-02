using Gestion.dinventaire.Backend.Models;

namespace Gestion.dinventaire.Backend.JWTAuthentification
{
    public class J_Employee
    {
        public string? username { get; set; } = string.Empty;
        public string? email { get; set; }=string.Empty;
        public string? password { get; set; }=string.Empty;
        public bool IsActif { get; set; }

        
    }
}
