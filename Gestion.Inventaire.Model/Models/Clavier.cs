using Gestion.Inventaire.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion.Inventaire.Model.Models
{
   public class Clavier:IClavier
    {
        public Clavier(int id, string? type, string? reference, string? image, string? model, DateTime dateDebut, DateTime dateFin)
        {
            this.id = id;
            this.type = type;
            this.reference = reference;
            this.image = image;
            this.model = model;
            this.dateDebut = dateDebut;
            this.dateFin = dateFin;
         
        }

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
