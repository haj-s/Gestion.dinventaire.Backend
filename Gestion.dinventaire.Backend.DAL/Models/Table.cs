namespace Gestion.dinventaire.Backend.Models
{
    public class Table
    {
        public int Id { get; set; }
        public string? type { get; set; }
        public string? reference { get; set; }
        public string? image { get; set; }
        public string? description { get; set; }
        public DateTime dateDebut { get; set; }
        public DateTime dateFin { get; set; }

    }
}
