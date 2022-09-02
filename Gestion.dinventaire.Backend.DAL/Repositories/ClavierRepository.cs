using Gestion.dinventaire.Backend.DAL.Enteties;
using Gestion.dinventaire.Backend.DAL.Mappers;
using Gestion.dinventaire.Backend.DAL.Repositories.Interface;
using Gestion.dinventaire.Backend.Models;
using Gestion.Inventaire.Model.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion.dinventaire.Backend.DAL.Repositories
{
    public class ClavierRepository : BaseRepository<Clavier>,IClavierRepository 
    {
        public ClavierRepository(APIContext context) : base(context)
        {
        }

        public override bool Add(Clavier Model)
        {
            ClavierEntity toInsert = Model.ToEntity();
            _db.claviers.Add(toInsert);
            try
            {
                _db.SaveChanges();
                return true;
            }
            catch (DbUpdateException)
            {
                _db.claviers.Remove(toInsert);
                return false;
            }
        }

        public override bool Delete(int id)
        {
            try
            {
                _db.claviers.Remove(_db.claviers.Find(id)!);
                _db.SaveChanges();
                return true;
            }
            catch (DbUpdateException)
            {
                return false;
            }
        }

        public override IEnumerable<Clavier> GetAll()
        {
            return _db.claviers.Select(m => m.ToModel());
        }

        public override Clavier GetOne(int id)
        {
            return _db.claviers.Find(id)!.ToModel();
        }

        public override IEnumerable<Clavier> GetOne2(int id)
        {
            yield return _db.claviers.Find(id)!.ToModel();
        }

        public override bool Update(Clavier Model)
        {
           ClavierEntity toUpdate = _db.claviers.Find(Model.id)!;

            toUpdate.id = int.Parse(Model.id.ToString());
            _db.claviers.Remove(_db.claviers.Find(Model.id)!);
            toUpdate = Model.ToEntity();
            _db.claviers.Add(toUpdate);
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

    

