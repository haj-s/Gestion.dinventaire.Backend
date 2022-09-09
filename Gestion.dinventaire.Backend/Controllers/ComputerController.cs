using Gestion.dinventaire.Backend.DAL.Enteties;
using Gestion.dinventaire.Backend.DAL.Repositories;
using Gestion.dinventaire.Backend.Models;
using Gestion.Inventaire.Model.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.ObjectModel;
using System.Security.Claims;

namespace Gestion.dinventaire.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComputerController : ControllerBase
    {
        
        private readonly ComputerRepository _ComputerRepository;
        private readonly APIContext _context;
        private string? _jWTEmail = string.Empty;

        public ComputerController(ComputerRepository computerRepository, APIContext aPIContext)
        {
            _context = aPIContext;
            _ComputerRepository = computerRepository;
        }

        [HttpGet]

        public IEnumerable<Computer> GetAll()
        {
            return new ObservableCollection<Computer>(_ComputerRepository.GetAll()).ToList();
        }
        // GET: api/<MedecinsController>
        [HttpGet]

        //public IEnumerable<Computer> GetPage([FromQuery] int limit = 20, [FromQuery] int offset = 0)
        //{
        //    ComputerEntity c = new();
        //    if (HttpContext.User.Identity is ClaimsIdentity identity)
        //    {
        //        _jWTEmail = identity?.FindFirst(ClaimTypes.Name)?.Value;
        //        c = (ComputerEntity)_context.employees.Include(x => x.urole).ToList().Where(x => x.Email == _jWTEmail);
        //    };
        //    return new ObservableCollection<Chaise>(_ComputerRepository.GetAll(limit, offset)).ToList().Where(x => x.id == c.Id);
        //}

        // GET api/<CoursController>/5
        [HttpGet("{id}")]

        public IEnumerable<Computer> GetOne(int id)
        {
            ComputerEntity p = new();
            //if (HttpContext.User.Identity is ClaimsIdentity identity)
            //{
            //    _jWTEmail = identity?.FindFirst(ClaimTypes.Name)?.Value;
            //    p = (ComputerEntity)_context.Users.Include(x => x.urole).ToList().Where(x => x.Email == _jWTEmail);
            //};
            IEnumerable<Computer> aa = _ComputerRepository.GetOne2(id);
            foreach (var item in aa) { };
            return aa.AsEnumerable().Where(x => x.id == p.id);
        }

        // POST api/<CoursController>
        [HttpPost]

        public void Post([FromBody] J_Computer newComputer)
        {
            //ComputerEntity p = new();
            //if (HttpContext.User.Identity is ClaimsIdentity identity)
            //{
            //    _jWTEmail = identity?.FindFirst(ClaimTypes.Name)?.Value;
            //    p = (ComputerEntity)_context.Users.Include(x => x.urole).ToList().Where(x => x.Email == _jWTEmail);
            //};
            Computer computer = new(
                        newComputer.id,
                         newComputer.reference,
                         newComputer.model,
                         newComputer.image,
                         newComputer.type,
                         newComputer.dateDebut,
                         newComputer.dateFin
                        )
            {
                id = 0
            };
            _ComputerRepository.Add(computer);
        }

        // PUT api/<CoursController>/5
        [HttpPut("{id}")]

        public void Put(long id, [FromBody] J_Computer majComputer)
        {
            //ChaiseBurautiqueEntity p = new();
            //if (HttpContext.User.Identity is ClaimsIdentity identity)
            //{
            //    _jWTEmail = identity?.FindFirst(ClaimTypes.Name)?.Value;
            //    p = (ChaiseBurautiqueEntity)_context.Users.Include(x => x.urole).ToList().Where(x => x.Email == _jWTEmail);
            //};
            Computer computer = new(
                        majComputer.id,
                         majComputer.reference,
                         majComputer.model,
                         majComputer.image,
                         majComputer.type,
                         majComputer.dateDebut,
                         majComputer.dateFin
                        )
            {
            };
            _ComputerRepository.Add(computer);
        }

        // DELETE api/<CoursController>/5
        [HttpDelete("{id}")]
        //[Authorization("Admin", "Praticien")]
        public void Delete(int id)
        {
            //ChaiseBurautiqueEntity p = new();
            //if (HttpContext.User.Identity is ClaimsIdentity identity)
            //{
            //    _jWTEmail = identity?.FindFirst(ClaimTypes.Name)?.Value;
            //    p = (ChaiseBurautiqueEntity)_context.Users.Include(x => x.urole).ToList().Where(x => x.Email == _jWTEmail);
            //};
            Computer ar = _ComputerRepository.GetOne(id);
            //if (ar.id == p.id) _ComputerRepository.Delete(id);
            _ComputerRepository.Delete(id);
        }
    }
}
