using Gestion.dinventaire.Backend.DAL.Enteties;
using Gestion.dinventaire.Backend.DAL.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion.dinventaire.Backend.DAL.Repositories
{
    public abstract class BaseRepository<T> : IRepository<T>
        where T : class
    {
        protected readonly APIContext _db;
        public BaseRepository(APIContext context)
        {
            _db = context;
        }

        public abstract T GetOne(int id);
        public abstract IEnumerable<T> GetOne2(int id);
        public abstract IEnumerable<T> GetAll();

        public abstract bool Add(T Model);

        public abstract bool Update(T Model);

        public abstract bool Delete(int id);
    }
    
}
