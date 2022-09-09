using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion.Inventaire.Model.Models
{
    public class Chaise : IChaise
    {
        public Chaise(int id, string Reference, string model, string type, string image, DateTime dateDebut, DateTime dateFin )
        {
            this.id = id;
            this.reference = Reference;
            this.model = model;
            this.type = type;
            this.image = image;
            this.dateDebut = dateDebut;
            this.dateFin = dateFin;
          
        }

        public int id { get; set; }
        public string? reference { get; set; }
        public string? model { get; set; }
        public string? type { get; set; }
        public string? image { get; set; }
        public DateTime dateDebut { get; set; }
        public DateTime dateFin { get; set; }
        public ICollection<Employee>? employees { get; set; }
    }
}
