namespace Gestion.dinventaire.Backend.Models
{
    public class Computer
    {
        public int Id { get; set; }
        public string? type { get; set; }
        public string? reference { get; set; }
        public string? image { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        
    }
}
