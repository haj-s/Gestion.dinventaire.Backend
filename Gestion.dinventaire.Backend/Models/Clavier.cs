namespace Gestion.dinventaire.Backend.Models
{
    public class Clavier: Equipement_materielle_electronique
    {
        public int Id { get; set; }
        public string? reference { get; set; }
        public string? marque { get; set; }
        public string? model { get; set; }
        

    }
}
