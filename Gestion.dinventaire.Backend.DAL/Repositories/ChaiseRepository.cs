using Gestion.dinventaire.Backend.DAL.Enteties;
using Gestion.dinventaire.Backend.DAL.Mappers;
using Gestion.dinventaire.Backend.Models;
using Gestion.Inventaire.Model.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion.dinventaire.Backend.DAL.Repositories
{
    public class ChaiseRepository : BaseRepository<Chaise>
    {
        public ChaiseRepository(APIContext context) : base(context)
        {
        }

        public override bool Add(Chaise Model)
        {
            ChaiseBurautiqueEntity BurautiqueEntity = Model.ToEntity();
            _db.ChaiseBurautiques.Add(BurautiqueEntity);
            try
            {
                _db.SaveChanges();
                return true;
            }
            catch (DbUpdateException)
            {
                _db.ChaiseBurautiques.Remove(BurautiqueEntity);     
                 return false;
            }
        }


        public override bool Delete(int id)
        {
            try
            {
                _db.ChaiseBurautiques.Remove(_db.ChaiseBurautiques.Find(id)!);
                _db.SaveChanges();
                return true;
            }
            catch (DbUpdateException)
            {
                return false;
            }
        }

        public override IEnumerable<Chaise> GetAll()
        {
            return _db.ChaiseBurautiques.Select(m => m.ToModel());
        }

        public override Chaise GetOne(int id)
        {
            return _db.ChaiseBurautiques.Find(id)!.ToModel();
        }

        public override IEnumerable<Chaise> GetOne2(int id)
        {
            yield return _db.ChaiseBurautiques.Find(id)!.ToModel();
        }

        public override bool Update(Chaise Model)
        {
            ChaiseBurautiqueEntity toUpdate = _db.ChaiseBurautiques.Find(Model.id)!;

            toUpdate.id = int.Parse(Model.id.ToString());
            _db.ChaiseBurautiques.Remove(_db.ChaiseBurautiques.Find(Model.id)!);
            toUpdate = Model.ToEntity();
            _db.ChaiseBurautiques.Add(toUpdate);
            try
            {
                _db.SaveChanges();
                return true;
            }
            catch (DbUpdateException)
            {
                return false;
            }
        }
    }
}

    
    
    

