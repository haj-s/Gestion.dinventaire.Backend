﻿using Gestion.dinventaire.Backend.DAL.Enteties;
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
    public class ComputerRepository : BaseRepository<Computer>, IComputerRepository
    {
        public ComputerRepository(APIContext context) : base(context)
        {
        }

        public override bool Add(Computer Model)
        {
            ComputerEntity toInsert = Model.ToEntity();
            _db.Computers.Add(toInsert);
            try
            {
                _db.SaveChanges();
                return true;
            }
            catch (DbUpdateException)
            {
                _db.Computers.Remove(toInsert);
                return false;
            }
        }

        public override bool Delete(int id)
        {
            try
            {
                _db.Computers.Remove(_db.Computers.Find(id)!);
                _db.SaveChanges();
                return true;
            }
            catch (DbUpdateException)
            {
                return false;
            }
        }

        public override IEnumerable<Computer> GetAll()
        {
            return _db.Computers.Select(m => m.ToModel());
        }

        public override Computer GetOne(int id)
        {
             return _db.Computers.Find(id)!.ToModel();
        }

        public override IEnumerable<Computer> GetOne2(int id)
        {
            yield return _db.Computers.Find(id)!.ToModel();
        }

        public override bool Update(Computer Model)
        {
            ComputerEntity toUpdate = _db.Computers.Find(Model.id)!;

            toUpdate.id = int.Parse(Model.id.ToString());
            _db.Computers.Remove(_db.Computers.Find(Model.id)!);
            toUpdate = Model.ToEntity();
            _db.Computers.Add(toUpdate);
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

