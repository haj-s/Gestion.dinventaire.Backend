namespace Gestion.dinventaire.Backend.Models
{
    public class ChaiseBurautique:Equipement_materielles_physique
    {
        public int Id { get; set; }
        public string? reference { get; set; }
        public string? type { get; set; }
        public string? image { get; set; }
        public DateTime dateDebut { get; set; }
        public DateTime dateFin { get; set; }
    }
}
