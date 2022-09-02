namespace Gestion.Inventaire.Model.Models
{
    public interface IChaise
    {
        DateTime dateDebut { get; set; }
        DateTime dateFin { get; set; }
        ICollection<Employee>? employees { get; set; }
        int id { get; set; }
        string? image { get; set; }
        string? reference { get; set; }
        string? type { get; set; }
    }
}