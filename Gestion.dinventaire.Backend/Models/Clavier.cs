namespace Gestion.dinventaire.Backend.Models
{
    public class Clavier: Equipement_materielle_electronique
    {
        public int id { get; set; }
        public string NumeroSerie { get; set; }
        public string marque { get; set; }
        public string model { get; set; }
        public int MyProperty { get; set; }

    }
}
