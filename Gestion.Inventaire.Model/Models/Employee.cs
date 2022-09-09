using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity;

namespace Gestion.Inventaire.Model.Models
{
    public class Employee:IdentityUser<int>
    {
        public Employee(string FirstName, string LastName, string Email, string Password, bool isActif)  
        {
            firstName= FirstName;
            lastName= LastName;
            email = Email;
            password = Password;
            IsActif = isActif;

        }

        //public int id { get; set; }
        public string? firstName { get; set; }
        public string? lastName { get; set; }
        public string? email { get; set; }
        public string? password { get; set; }
        public bool? IsActif { get; set; }

        public Clavier? clavier { get; set; }
        public Chaise? chais { get; set; }
        public Computer? computer { get; set; }
        public Table? table { get; set; }
    }
}
