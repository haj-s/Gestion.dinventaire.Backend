﻿using Gestion.dinventaire.Backend.DAL.Enteties;
using Gestion.dinventaire.Backend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion.dinventaire.Backend.DAL.Repositories
{
    public class EmployeeRepository : BaseRepository<Employee>
    {
        public override bool Add(Employee Model)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Employee> GetAll()
        {
            throw new NotImplementedException();
        }

        public override Employee GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Employee> GetOne2(int id)
        {
            throw new NotImplementedException();
        }

        public override bool Update(Employee Model)
        {
            throw new NotImplementedException();
        }
    }
}
