using Gestion.dinventaire.Backend.DAL.Enteties;
using Gestion.dinventaire.Backend.DAL.Repositories;
using Gestion.dinventaire.Backend.Models;
using Gestion.Inventaire.Model.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.ObjectModel;
using System.Security.Claims;
using XAct.Security;

namespace Gestion.dinventaire.Backend.Controllers
{
    [Authorization]
    [Route("api/[controller]")]
    [ApiController]
    public class ChaiseController : ControllerBase
    {
        
        private readonly ChaiseRepository _ChaiseRepository;
        private readonly APIContext _context;
        //private string? _jWTEmail = string.Empty;

        public ChaiseController(ChaiseRepository chaiseRepository, APIContext aPIContext)
        {
            _context = aPIContext;  
            _ChaiseRepository= chaiseRepository;    
        }

        [HttpGet]
        
        public IEnumerable<Chaise> GetAll()
        {
            return new ObservableCollection<Chaise>(_ChaiseRepository.GetAll()).ToList();
        }
        // GET: api/<MedecinsController>
        [HttpGet]
   
        //public IEnumerable<Chaise> GetPage([FromQuery] int limit = 20, [FromQuery] int offset = 0)
        //{
            //ChaiseBurautiqueEntity c = new();
            //if (HttpContext.User.Identity is ClaimsIdentity identity)
            //{
            //    _jWTEmail = identity?.FindFirst(ClaimTypes.Name)?.Value;
            //    c = (ChaiseBurautiqueEntity)_context.employees.Include(x => x.).ToList().Where(x => x.Email == _jWTEmail);
            //};
        //    return new ObservableCollection<Chaise>(_ChaiseRepository.GetAll(limit, offset)).ToList();
        //}

        // GET api/<CoursController>/5
        [HttpGet("{id}")]
        
        public IEnumerable<Chaise> GetOne(int id)
        {
            //ChaiseBurautiqueEntity p = new();
            //if (HttpContext.User.Identity is ClaimsIdentity identity)
            //{
            //    _jWTEmail = identity?.FindFirst(ClaimTypes.Name)?.Value;
            //    p = (ChaiseBurautiqueEntity)_context.Users.Include(x => x.urole).ToList().Where(x => x.Email == _jWTEmail);
            //};
            IEnumerable<Chaise> aa = _ChaiseRepository.GetOne2(id);
            //foreach (var item in aa) { };
            return aa;
            /*.AsEnumerable().Where(x => x.id==id == p.id)*/
        }

        // POST api/<CoursController>
        [HttpPost]
       
        public void Post([FromBody] J_Chaise newChaise)
        {
            //ChaiseBurautiqueEntity p = new();
            //if (HttpContext.User.Identity is ClaimsIdentity identity)
            //{
            //    _jWTEmail = identity?.FindFirst(ClaimTypes.Name)?.Value;
            //    p = (ChaiseBurautiqueEntity)_context.Users.Include(x => x.urole).ToList().Where(x => x.Email == _jWTEmail);
            //};
            Chaise chaise = new(
                newChaise.id,
                         newChaise.reference,
                         newChaise.model,
                         newChaise.image,
                         newChaise.type,
                         newChaise.dateDebut,
                         newChaise.dateFin

                        )
            {
                id = 0
            };
            _ChaiseRepository.Add(chaise);
        }

        // PUT api/<CoursController>/5
        [HttpPut("{id}")]

        public void Put(long id, [FromBody] J_Chaise majChaise)
        {
            //EmployeeEntity p = new();
            //  if (HttpContext.User.Identity is ClaimsIdentity identity)
            //  {
            //      _jWTEmail = identity?.FindFirst(ClaimTypes.Name)?.Value;
            //      p = (EmployeeEntity)_context.Users.Include(x => x.urole).ToList().Where(x => x.Email == _jWTEmail);
            //  };
            Chaise chaise = new(
                         majChaise.id,
                         majChaise.reference,
                         majChaise.model,
                         majChaise.image,
                         majChaise.type,
                         majChaise.dateDebut,
                         majChaise.dateFin
                         
                       )
            {
                id=0
            };
            _ChaiseRepository.Update(chaise);
        }

        // DELETE api/<CoursController>/5
        [HttpDelete("{id}")]
        //[Authorization("Admin", "Praticien")]
        public void Delete(int id)
        {
           //ChaiseBurautiqueEntity p = new();
           // if (HttpContext.User.Identity is ClaimsIdentity identity)
           // {
           //     _jWTEmail = identity?.FindFirst(ClaimTypes.Name)?.Value;
           //     p = (ChaiseBurautiqueEntity)_context.Users.Include(x => x.urole).ToList().Where(x => x.Email == _jWTEmail);
           // };
            Chaise ar = _ChaiseRepository.GetOne(id);
            //if (ar.id == p.id) _ChaiseRepository.Delete(id);
            _ChaiseRepository.Delete(id);
        }
    }
}
