using Microsoft.AspNet.Identity.EntityFramework;

namespace Gestion.dinventaire.Backend.Models
{
    public class J_Employee:IdentityUser
    {
        public string? LastName { get; set; } = string.Empty;
        public string? FirstName { get; set; } = string.Empty;
        public string? email { get; set; } = string.Empty;
        public string? password { get; set; } = string.Empty;
        public bool IsActif { get; set; }


    }
}
