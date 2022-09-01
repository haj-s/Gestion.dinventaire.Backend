

namespace Gestion.dinventaire.Backend.Models
{
    public class Employee
    {
        public int id { get; set; }
        public string?  username { get; set; }
        public string? email { get; set; }
        public string? password { get; set; }
        public bool IsActif { get; set; }

        public Clavier? clavier { get; set; }
        public ChaiseBurautique? chais { get; set; }
        public Computer? computer { get; set; }
        public Table? table { get; set; }
        //public Equipement_materielle_electronique? equipement_Materielle_Electronique { get; set; }
        //public Equipement_materielle_physique? equipement_Materielle_Physique { get; set; }







    }
}
