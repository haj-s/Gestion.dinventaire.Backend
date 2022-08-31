namespace Gestion.dinventaire.Backend.Models
{
    public class Table:Equipement_materielles_physique
    {
        public int Id { get; set; }
        public string? image { get; set; }
        public string? description { get; set; }
        public DateTime dateDebut { get; set; }
        public DateTime dateFin { get; set; }

    }
}
