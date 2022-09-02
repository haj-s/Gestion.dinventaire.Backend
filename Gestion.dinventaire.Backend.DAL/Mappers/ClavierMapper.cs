using Gestion.dinventaire.Backend.Models;
using Gestion.Inventaire.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion.dinventaire.Backend.DAL.Mappers
{
    public static class ClavierMapper
    {
        public static Clavier ToModel(this ClavierEntity? Entity)
        {
            Clavier clavier = new
            (
                 id: Entity?.id ?? 0,
                 reference: Entity?.reference,
                 type: Entity?.type ?? string.Empty,
                 model: Entity?.model ?? string.Empty,
                 image: Entity?.type ?? string.Empty,
                 dateDebut: Entity?.dateDebut ?? DateTime.MinValue,
                 dateFin: Entity?.dateFin ?? DateTime.MinValue
             );


            return clavier;

        }




        public static ClavierEntity ToEntity(this Clavier Model)
        {
            return new ClavierEntity()
            {
                id = Model?.id ?? 0,
                reference = Model?.reference ?? string.Empty,
                model = Model?.model,
                type = Model?.type,
                image = Model?.image ?? string.Empty,
                dateFin = Model?.dateFin ?? DateTime.MinValue,
                dateDebut = Model?.dateDebut ?? DateTime.MinValue

            };

        }
    }
}

