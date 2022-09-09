using Gestion.dinventaire.Backend.DAL.Enteties;
using Gestion.dinventaire.Backend.DAL.Repositories;
using Gestion.dinventaire.Backend.JWTAuthentification;
using Gestion.dinventaire.Backend.Models;
using Gestion.Inventaire.Model.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using XAct.Security;

namespace Gestion.dinventaire.Backend.Controllers
{
    [Authorization]
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class EmployeeController : ControllerBase
    {

        private readonly IJWTManagerRepository _jWTManager;
        private readonly EmployeeRepository _employeeRepository;
        //private readonly SignInManager<EmployeeEntity> _signInManager;
        //private readonly UserManager<EmployeeEntity> _userManager;
        private readonly APIContext _context;

        public EmployeeController(IJWTManagerRepository jWTManager,
                                        EmployeeRepository employeeRepository,
                                        //SignInManager<EmployeeEntity> signInManager,
                                        //UserManager<EmployeeEntity> userManager,
                                        APIContext context
                )
        {
            _jWTManager = jWTManager;
            _employeeRepository = employeeRepository;
            //_signInManager = signInManager;
            //_userManager = userManager;
            _context = context;
        }

        // GET: api/<PersonnesController>
        [HttpGet]
        //[Authorization("Admin")]
        public IEnumerable<EmployeeEntity> GetAll()
        {
            //return _context.Users.Include(x => x.urole).ToList() ;
            return _context.Employees.ToList();

        }

        // GET api/<PersonnesController>/5
        [HttpGet]
        //[Authorization("Admin", "Etudiant")]
        public IEnumerable<Employee>? GetOne([FromQuery] int id)
        {
            IEnumerable<Employee> aa = _employeeRepository.GetOne2(id);
            if (aa != null)
            {
                foreach (var item in aa) { _ = item; };
                return aa.AsEnumerable();
            }
            return null;
        }


    }
}
