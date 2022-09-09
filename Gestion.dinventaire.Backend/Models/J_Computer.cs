namespace Gestion.dinventaire.Backend.Models
{
    public class J_Computer
    {
        public int id { get; set; } = int.MinValue;
        public string? reference { get; set; } = string.Empty;
        public string model { get; set; } = string.Empty;
        public string? type { get; set; } = string.Empty;
        public string? image { get; set; } = string.Empty;
        public DateTime dateDebut { get; set; } = DateTime.MinValue;
        public DateTime dateFin { get; set; } = DateTime.MinValue;
        public ICollection<EmployeeEntity>? employees { get; set; }
    }
}
