using Gestion.dinventaire.Backend.Models;
using Gestion.Inventaire.Model.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion.dinventaire.Backend.DAL.Mappers
{
    public static class ChaiseMapper
    {
        public static Chaise ToModel(this ChaiseBurautiqueEntity? Entity)
        {
            Chaise chaise =new(

                 id: Entity?.id ?? 0,
                 Reference: Entity?.reference ?? string.Empty,
                 model: Entity?.model ?? string.Empty,
                 type: Entity?.type ?? string.Empty,
                 image: Entity?.type ?? string.Empty,
                 dateDebut: Entity?.dateDebut ?? DateTime.MinValue,
                 dateFin: Entity?.dateFin ?? DateTime.MinValue
                 ) ;

          
            return chaise;

        }




        public static ChaiseBurautiqueEntity ToEntity(this Chaise Model)
        {
            return new ChaiseBurautiqueEntity()
            {
                id= Model?.id ?? 0,
                reference= Model?.reference ?? string.Empty, 
                model=Model?.model ?? string.Empty, 
                type=Model?.type,
                image=Model?.image ?? string.Empty, 
                dateFin=Model?.dateFin ?? DateTime.MinValue,    
                dateDebut=Model?.dateDebut ?? DateTime.MinValue

            };

        }
    }
}
