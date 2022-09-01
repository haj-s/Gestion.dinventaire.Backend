

namespace Gestion.dinventaire.Backend.Models
{
    public class Computer
    {
        public int id { get; set; }
        public string? type { get; set; }
        public string? reference { get; set; }
        public string? image { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public ICollection<Employee>? employees { get; set; }

    }
}
