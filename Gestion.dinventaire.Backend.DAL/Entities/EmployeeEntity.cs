

using Microsoft.AspNetCore.Identity;

namespace Gestion.dinventaire.Backend.Models
{
    public class EmployeeEntity:IdentityUser<int>
    {
        //public int id { get; set; }
        public string? lastName{ get; set; }
        public string? firstName { get; set; }
        //public string? Email { get; set; }
        public string? password { get; set; }
        public bool IsActif { get; set; }

        public ClavierEntity? clavier { get; set; }
        public ChaiseBurautiqueEntity? chais { get; set; }
        public ComputerEntity? computer { get; set; }
        public TableEntity? table { get; set; }
        //public Equipement_materielle_electronique? equipement_Materielle_Electronique { get; set; }
        //public Equipement_materielle_physique? equipement_Materielle_Physique { get; set; }







    }
}
