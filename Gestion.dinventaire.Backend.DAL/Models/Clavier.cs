

namespace Gestion.dinventaire.Backend.Models
{
    public class Clavier
    {
        public int id { get; set; }
        public string? type { get; set; }
        public string? reference { get; set; }
        public string? image { get; set; }
        public string? model { get; set; }
        public DateTime dateDebut { get; set; }
        public DateTime dateFin { get; set; }
        public ICollection<Employee>? employees { get; set; }




    }
}
