using Gestion.dinventaire.Backend.Models;
using Gestion.Inventaire.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion.dinventaire.Backend.DAL.Mappers
{
    public static class ComputerMapper
    {
        public static Computer ToModel(this ComputerEntity Entity)
        {
            Computer computer = new(

                 id: Entity?.id ?? 0,
                 reference: Entity?.reference ?? string.Empty,
                 type: Entity?.type ?? string.Empty,
                 model:Entity?.model ?? string.Empty,
                 image: Entity?.type ?? string.Empty,
                 dateDebut: Entity?.DateDebut ?? DateTime.MinValue,
                 dateFin: Entity?.DateFin ?? DateTime.MinValue
                 );


            return computer;

        }




        public static ComputerEntity ToEntity(this Computer Model)
        {
            return new ComputerEntity()
            {
                id = Model?.id ?? 0,
                reference = Model?.reference ?? string.Empty,
                model=Model?.model,
                type = Model?.type,
                image = Model?.image ?? string.Empty,
                DateFin = Model?.DateFin ?? DateTime.MinValue,
                DateDebut = Model?.DateDebut ?? DateTime.MinValue

            };

        }
    }
}

