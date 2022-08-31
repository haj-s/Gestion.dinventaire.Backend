namespace Gestion.dinventaire.Backend.Models
{
    public class Computer:Equipement_materielle_electronique
    {
        public int Id { get; set; }
        public string? type { get; set; }
        public string? reference { get; set; }
        public string? image { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        
    }
}
