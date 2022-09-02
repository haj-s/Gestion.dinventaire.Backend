using Gestion.dinventaire.Backend.DAL.Enteties;
using Gestion.dinventaire.Backend.DAL.Mappers;
using Gestion.dinventaire.Backend.Models;
using Gestion.Inventaire.Model.Models;
using Microsoft.EntityFrameworkCore;

namespace Gestion.dinventaire.Backend.DAL.Repositories
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(APIContext context) : base(context)
        {

        }

        public override bool Add(Employee Model)
        {
            EmployeeEntity toInsert = Model.ToEntity();
            _db.Employees.Add(toInsert);
            try
            {
                _db.SaveChanges();
                return true;
            }
            catch (DbUpdateException)
            {
                _db.Employees.Remove(toInsert);
                return false;
            }
        }

        public override bool Delete(int id)
        {
            try
            {
                _db.Employees.Remove(_db.Employees.Find(id)!);
                _db.SaveChanges();
                return true;
            }
            catch (DbUpdateException)
            {
                return false;
            }
        }

        public override IEnumerable<Employee> GetAll()
        {
            return _db.Employees.Select(m => m.ToModel());
        }

        public override Employee GetOne(int id)
        {
            return _db.Employees.Find(id)!.ToModel();
        }

        public override IEnumerable<Employee> GetOne2(int id)
        {
            yield return _db.Employees.Find(id)!.ToModel();
        }

        public override bool Update(Employee Model)
        {
            EmployeeEntity toUpdate = _db.Employees.Find(Model.Id)!;
         
            toUpdate.Id = int.Parse(Model.Id.ToString());
            _db.Employees.Remove(_db.Employees.Find(Model.Id)!);
            toUpdate = Model.ToEntity();
            _db.Employees.Add(toUpdate);
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

   




