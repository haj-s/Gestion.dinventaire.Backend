namespace Gestion.dinventaire.Backend.Models
{
    public class Clavier: Equipement_materielle_electronique
    {
        public int Id { get; set; }
        public string? type { get; set; }
        public string? reference { get; set; }
        public string? image { get; set; }
        public string? model { get; set; }
        public DateTime dateDebut { get; set; }
        public DateTime dateFin { get; set; }


    }
}
