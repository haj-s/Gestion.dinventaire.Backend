using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion.Inventaire.Model.Models
{
    public class Table
    {
        public Table(int id, string? type, string? reference, string? model, string? image, DateTime dateDebut, DateTime dateFin)
        {
            this.id = id;
            this.type = type;
            this.reference = reference;
            this.model = model;
            this.image = image;
            
            this.dateDebut = dateDebut;
            this.dateFin = dateFin;
            this.employees = employees;
        }

        public int id { get; set; }
        public string? type { get; set; }
        public string? reference { get; set; }
        public string? model { get; set; }
        public string? image { get; set; }
      
        public DateTime dateDebut { get; set; }
        public DateTime dateFin { get; set; }

        public ICollection<Employee>? employees { get; set; }
    }
}
