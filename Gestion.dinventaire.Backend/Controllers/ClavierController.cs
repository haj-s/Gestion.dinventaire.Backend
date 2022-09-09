using Gestion.dinventaire.Backend.DAL.Enteties;
using Gestion.dinventaire.Backend.DAL.Repositories;
using Gestion.Inventaire.Model.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.ObjectModel;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Gestion.dinventaire.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClavierController : ControllerBase
    {
        private readonly APIContext _aPIContext;
        private readonly ClavierRepository _clavierRepository;
        public ClavierController(APIContext aPIContext, ClavierRepository clavierRepository)
            
        {
            _aPIContext = aPIContext; ;
            _clavierRepository = clavierRepository;
        }

        // GET: api/<ClavierController>
        [HttpGet]
        public IEnumerable<Clavier> Get()
        {
            return new ObservableCollection<Clavier>(_clavierRepository.GetAll()).ToList();
        }

        // GET api/<ClavierController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ClavierController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ClavierController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ClavierController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
