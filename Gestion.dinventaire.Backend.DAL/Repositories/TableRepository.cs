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
    public class TableRepository : BaseRepository<Table>,ITableRepositrory
    {
        public TableRepository(APIContext context) : base(context)
        {
        }

        public override bool Add(Table Model)
        {
           TableEntity toInsert = Model.ToEntity();
            _db.Tables.Add(toInsert);
            try
            {
                _db.SaveChanges();
                return true;
            }
            catch (DbUpdateException)
            {
                _db.Tables.Remove(toInsert);
                return false;
            }
        }

        public override bool Delete(int id)
        {
            try
            {
                _db.Tables.Remove(_db.Tables.Find(id)!);
                _db.SaveChanges();
                return true;
            }
            catch (DbUpdateException)
            {
                return false;
            }
        }

        public override IEnumerable<Table> GetAll()
        {
            return _db.Tables.Select(m => m.ToModel());
        }

        public override Table GetOne(int id)
        {
            return _db.Tables.Find(id)!.ToModel();
        }

        public override IEnumerable<Table> GetOne2(int id)
        {
            yield return _db.Tables.Find(id)!.ToModel();
        }

        public override bool Update(Table Model)
        {
            TableEntity toUpdate = _db.Tables.Find(Model.id)!;

            toUpdate.id = int.Parse(Model.id.ToString());
            _db.Tables.Remove(_db.Tables.Find(Model.id)!);
            toUpdate = Model.ToEntity();
            _db.Tables.Add(toUpdate);
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

